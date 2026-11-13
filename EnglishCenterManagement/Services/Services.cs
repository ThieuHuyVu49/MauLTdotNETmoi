using EnglishCenterManagement.Data;
using EnglishCenterManagement.Models;
using Microsoft.Data.Sqlite;

namespace EnglishCenterManagement.Services;

using Args = Dictionary<string, object>;

public static class AppSession
{
    public static AppUser User { get; set; }
}

public static class AuthService
{
    private static AppUser Map(SqliteDataReader r) => new()
    {
        Id = r.Long("Id"), Email = r.Str("Email"), FullName = r.Str("FullName"), Phone = r.Str("Phone"), Role = r.Str("Role"),
        TeacherId = r["TeacherId"] is DBNull ? null : r.Long("TeacherId"),
        StudentId = r["StudentId"] is DBNull ? null : r.Long("StudentId")
    };

    public static (string Error, AppUser User) Login(string email, string password, string role)
    {
        if (string.IsNullOrWhiteSpace(email) || string.IsNullOrEmpty(password))
            return ("Vui lòng nhập email và mật khẩu.", null);
        var user = Db.Query("SELECT * FROM Users WHERE lower(Email)=lower(@e) AND PasswordHash=@p", Map,
            new Args { ["@e"] = email.Trim(), ["@p"] = Db.Hash(password) }).FirstOrDefault();
        if (user == null) return ("Email hoặc mật khẩu không đúng.", null);
        if (user.Role != role) return ($"Tài khoản này không thuộc vai trò {RoleName(role)}.", null);
        return (null, user);
    }

    public static string RoleName(string role) => role switch { "admin" => "Quản trị viên", "teacher" => "Giáo viên", _ => "Học viên" };

    public static (string Error, AppUser User) Register(string fullName, string email, string password, string role)
    {
        if (string.IsNullOrWhiteSpace(fullName)) return ("Vui lòng nhập họ và tên.", null);
        if (string.IsNullOrWhiteSpace(email) || !email.Contains('@')) return ("Email không hợp lệ.", null);
        if ((password ?? "").Length < 8) return ("Mật khẩu tối thiểu 8 ký tự.", null);
        if (Db.Count("SELECT COUNT(*) FROM Users WHERE lower(Email)=lower(@e)", new Args { ["@e"] = email.Trim() }) > 0)
            return ("Email đã được sử dụng.", null);

        object teacherId = null, studentId = null;
        if (role == "teacher")
            teacherId = Db.Insert("INSERT INTO Teachers(FullName,Email) VALUES(@n,@e)", new Args { ["@n"] = fullName.Trim(), ["@e"] = email.Trim() });
        if (role == "student")
            studentId = Db.Insert("INSERT INTO Students(Code,FullName,Email) VALUES(@c,@n,@e)",
                new Args { ["@c"] = StudentService.NextCode(), ["@n"] = fullName.Trim(), ["@e"] = email.Trim() });

        long id = Db.Insert("INSERT INTO Users(Email,PasswordHash,FullName,Role,TeacherId,StudentId) VALUES(@e,@p,@n,@r,@t,@s)",
            new Args { ["@e"] = email.Trim(), ["@p"] = Db.Hash(password), ["@n"] = fullName.Trim(), ["@r"] = role, ["@t"] = teacherId, ["@s"] = studentId });
        return (null, Db.Query("SELECT * FROM Users WHERE Id=@id", Map, new Args { ["@id"] = id }).First());
    }

    public static string UpdateProfile(AppUser user, string fullName, string email, string phone)
    {
        if (string.IsNullOrWhiteSpace(fullName)) return "Họ và tên không được để trống.";
        if (string.IsNullOrWhiteSpace(email) || !email.Contains('@')) return "Email không hợp lệ.";
        if (Db.Count("SELECT COUNT(*) FROM Users WHERE lower(Email)=lower(@e) AND Id<>@id", new Args { ["@e"] = email.Trim(), ["@id"] = user.Id }) > 0)
            return "Email đã được tài khoản khác sử dụng.";
        Db.Execute("UPDATE Users SET FullName=@n,Email=@e,Phone=@p WHERE Id=@id",
            new Args { ["@n"] = fullName.Trim(), ["@e"] = email.Trim(), ["@p"] = phone?.Trim(), ["@id"] = user.Id });
        user.FullName = fullName.Trim();
        user.Email = email.Trim();
        user.Phone = phone?.Trim();
        return null;
    }

    public static string ChangePassword(AppUser user, string current, string next, string confirm)
    {
        if (Db.Count("SELECT COUNT(*) FROM Users WHERE Id=@id AND PasswordHash=@p", new Args { ["@id"] = user.Id, ["@p"] = Db.Hash(current ?? "") }) == 0)
            return "Mật khẩu hiện tại không đúng.";
        if ((next ?? "").Length < 8) return "Mật khẩu mới tối thiểu 8 ký tự.";
        if (next != confirm) return "Xác nhận mật khẩu không khớp.";
        Db.Execute("UPDATE Users SET PasswordHash=@p WHERE Id=@id", new Args { ["@p"] = Db.Hash(next), ["@id"] = user.Id });
        return null;
    }
}

public static class SettingService
{
    public static string Get(string key, string fallback = "") =>
        Db.Scalar("SELECT Value FROM Settings WHERE Key=@k", new Args { ["@k"] = key }) as string ?? fallback;

    public static bool GetBool(string key, bool fallback = true) => Get(key, fallback ? "1" : "0") == "1";

    public static void Set(string key, string value) =>
        Db.Execute("INSERT INTO Settings(Key,Value) VALUES(@k,@v) ON CONFLICT(Key) DO UPDATE SET Value=excluded.Value",
            new Args { ["@k"] = key, ["@v"] = value });

    public static void SetBool(string key, bool value) => Set(key, value ? "1" : "0");
}

public static class RoomService
{
    public static List<Room> List() =>
        Db.Query("SELECT * FROM Rooms ORDER BY Name", r => new Room { Id = r.Long("Id"), Name = r.Str("Name"), Capacity = (int)r.Long("Capacity") });
}

public static class CourseService
{
    public static List<Course> List(string search = "", string status = null) =>
        Db.Query(@"SELECT c.*, (SELECT COUNT(*) FROM Classes k WHERE k.CourseId=c.Id AND k.Status='Đang học') AS OpenClasses
                   FROM Courses c
                   WHERE (@q='' OR c.Name LIKE '%'||@q||'%' OR c.Code LIKE '%'||@q||'%')
                     AND (@s IS NULL OR c.Status=@s)
                   ORDER BY c.Id",
            r => new Course
            {
                Id = r.Long("Id"), Code = r.Str("Code"), Name = r.Str("Name"), Weeks = (int)r.Long("Weeks"), Sessions = (int)r.Long("Sessions"),
                Fee = r.Dbl("Fee"), Description = r.Str("Description"), Status = r.Str("Status"), OpenClasses = (int)r.Long("OpenClasses")
            }, new Args { ["@q"] = search?.Trim() ?? "", ["@s"] = status });

    public static string Save(Course c)
    {
        if (string.IsNullOrWhiteSpace(c.Name)) return "Vui lòng nhập tên khóa học.";
        if (string.IsNullOrWhiteSpace(c.Code)) return "Vui lòng nhập mã khóa học.";
        if (c.Fee <= 0) return "Học phí phải lớn hơn 0.";
        if (Db.Count("SELECT COUNT(*) FROM Courses WHERE lower(Code)=lower(@c) AND Id<>@id", new Args { ["@c"] = c.Code.Trim(), ["@id"] = c.Id }) > 0)
            return "Mã khóa học đã tồn tại.";
        var a = new Args
        {
            ["@id"] = c.Id, ["@c"] = c.Code.Trim().ToUpper(), ["@n"] = c.Name.Trim(), ["@w"] = c.Weeks, ["@s"] = c.Sessions,
            ["@f"] = c.Fee, ["@d"] = c.Description, ["@st"] = c.Status
        };
        if (c.Id == 0)
            c.Id = Db.Insert("INSERT INTO Courses(Code,Name,Weeks,Sessions,Fee,Description,Status) VALUES(@c,@n,@w,@s,@f,@d,@st)", a);
        else
            Db.Execute("UPDATE Courses SET Code=@c,Name=@n,Weeks=@w,Sessions=@s,Fee=@f,Description=@d,Status=@st WHERE Id=@id", a);
        return null;
    }

    public static string Delete(long id)
    {
        if (Db.Count("SELECT COUNT(*) FROM Classes WHERE CourseId=@id", new Args { ["@id"] = id }) > 0)
            return "Không thể xóa: khóa học đã có lớp được mở.";
        Db.Execute("DELETE FROM Courses WHERE Id=@id", new Args { ["@id"] = id });
        return null;
    }
}

public static class TeacherService
{
    public static List<Teacher> List(string search = "", string status = null)
    {
        var monday = DashboardService.Monday(DateTime.Today);
        return Db.Query(@"SELECT t.*,
                    (SELECT COUNT(*) FROM Classes k WHERE k.TeacherId=t.Id AND k.Status='Đang học') AS ClassCount,
                    (SELECT COUNT(*) FROM Sessions s WHERE s.TeacherId=t.Id AND s.SessionDate BETWEEN @a AND @b) AS WeekSessions
                  FROM Teachers t
                  WHERE (@q='' OR t.FullName LIKE '%'||@q||'%' OR t.Specialty LIKE '%'||@q||'%')
                    AND (@s IS NULL OR t.Status=@s)
                  ORDER BY t.Id",
            r => new Teacher
            {
                Id = r.Long("Id"), FullName = r.Str("FullName"), Phone = r.Str("Phone"), Email = r.Str("Email"), Specialty = r.Str("Specialty") ?? "",
                Years = (int)r.Long("Years"), Certificates = r.Str("Certificates"), Availability = r.Str("Availability"), Status = r.Str("Status"),
                ClassCount = (int)r.Long("ClassCount"), WeeklySessions = (int)r.Long("WeekSessions")
            }, new Args { ["@q"] = search?.Trim() ?? "", ["@s"] = status, ["@a"] = Fmt.DbDate(monday), ["@b"] = Fmt.DbDate(monday.AddDays(6)) });
    }

    public static Teacher Get(long id) => List().FirstOrDefault(t => t.Id == id);

    public static string Save(Teacher t)
    {
        if (string.IsNullOrWhiteSpace(t.FullName)) return "Vui lòng nhập họ và tên.";
        if (string.IsNullOrWhiteSpace(t.Phone)) return "Vui lòng nhập số điện thoại.";
        if (string.IsNullOrWhiteSpace(t.Email) || !t.Email.Contains('@')) return "Email không hợp lệ.";
        var a = new Args
        {
            ["@id"] = t.Id, ["@n"] = t.FullName.Trim(), ["@p"] = t.Phone.Trim(), ["@e"] = t.Email.Trim(), ["@s"] = t.Specialty, ["@y"] = t.Years,
            ["@c"] = t.Certificates, ["@a"] = t.Availability, ["@st"] = t.Status
        };
        if (t.Id == 0)
            t.Id = Db.Insert("INSERT INTO Teachers(FullName,Phone,Email,Specialty,Years,Certificates,Availability,Status) VALUES(@n,@p,@e,@s,@y,@c,@a,@st)", a);
        else
            Db.Execute("UPDATE Teachers SET FullName=@n,Phone=@p,Email=@e,Specialty=@s,Years=@y,Certificates=@c,Availability=@a,Status=@st WHERE Id=@id", a);
        return null;
    }

    public static string Delete(long id)
    {
        if (Db.Count("SELECT (SELECT COUNT(*) FROM Classes WHERE TeacherId=@id)+(SELECT COUNT(*) FROM Sessions WHERE TeacherId=@id)", new Args { ["@id"] = id }) > 0)
            return "Không thể xóa: giảng viên đang được phân công lớp hoặc lịch dạy.";
        Db.Execute("DELETE FROM Teachers WHERE Id=@id", new Args { ["@id"] = id });
        return null;
    }
}

public static class StudentService
{
    public static string NextCode()
    {
        var year = DateTime.Today.Year;
        var last = Db.Query("SELECT Code FROM Students WHERE Code LIKE @p", r => r.Str("Code"), new Args { ["@p"] = $"HV-{year}-%" })
            .Select(c => int.TryParse(c[^4..], out var n) ? n : 0).DefaultIfEmpty(0).Max();
        if (year == 2025 || last == 0)
            last = Math.Max(last, Db.Query("SELECT Code FROM Students", r => r.Str("Code")).Select(c => int.TryParse(c[^4..], out var n) ? n : 0).DefaultIfEmpty(0).Max());
        return $"HV-{year}-{last + 1:0000}";
    }

    private static Student Map(SqliteDataReader r) => new()
    {
        Id = r.Long("Id"), Code = r.Str("Code"), FullName = r.Str("FullName"), BirthDate = r.Str("BirthDate"), Phone = r.Str("Phone"),
        Email = r.Str("Email"), Address = r.Str("Address"), Status = r.Str("Status"),
        CurrentClass = r.Str("CurrentClass") ?? "Chưa đăng ký"
    };

    public static List<Student> List(string search = "", string status = null)
    {
        var list = Db.Query(@"SELECT s.*,
                    (SELECT k.Name FROM Enrollments e JOIN Classes k ON k.Id=e.ClassId WHERE e.StudentId=s.Id ORDER BY (k.Status='Đang học') DESC, e.Id DESC LIMIT 1) AS CurrentClass
                  FROM Students s
                  WHERE (@q='' OR s.FullName LIKE '%'||@q||'%' OR s.Code LIKE '%'||@q||'%' OR s.Phone LIKE '%'||@q||'%')
                    AND (@s IS NULL OR s.Status=@s)
                  ORDER BY s.Code DESC", Map, new Args { ["@q"] = search?.Trim() ?? "", ["@s"] = status });

        var unpaid = Db.Query(@"SELECT e.StudentId, p.InstallmentNo, p.Amount, e.Installments,
                    (SELECT SUM(Amount) FROM Payments x WHERE x.EnrollmentId=e.Id AND x.PaidDate IS NULL) AS Remain
                  FROM Payments p JOIN Enrollments e ON e.Id=p.EnrollmentId
                  WHERE p.PaidDate IS NULL ORDER BY p.DueDate",
            r => (Student: r.Long("StudentId"), No: (int)r.Long("InstallmentNo"), Amount: r.Dbl("Amount"), Inst: (int)r.Long("Installments"), Remain: r.Dbl("Remain")));
        foreach (var s in list)
        {
            var u = unpaid.FirstOrDefault(x => x.Student == s.Id);
            bool any = Db.Count("SELECT COUNT(*) FROM Enrollments WHERE StudentId=@id", new Args { ["@id"] = s.Id }) > 0;
            s.FeeStatus = !any ? "Chưa đăng ký" : u.Student == 0 ? "Đã thanh toán" : u.Inst > 1 ? $"Kỳ {u.No}: {Fmt.Money(u.Amount)}" : $"Còn {Fmt.Money(u.Remain)}";
        }
        return list;
    }

    public static Student Get(long id) => Db.Query("SELECT s.*, NULL AS CurrentClass FROM Students s WHERE Id=@id", Map, new Args { ["@id"] = id }).FirstOrDefault();

    public static string Save(Student s)
    {
        if (string.IsNullOrWhiteSpace(s.FullName)) return "Vui lòng nhập họ và tên.";
        if (string.IsNullOrWhiteSpace(s.Phone)) return "Vui lòng nhập số điện thoại.";
        if (!string.IsNullOrWhiteSpace(s.Email) && !s.Email.Contains('@')) return "Email không hợp lệ.";
        if (s.Id == 0) s.Code = NextCode();
        var a = new Args
        {
            ["@id"] = s.Id, ["@c"] = s.Code, ["@n"] = s.FullName.Trim(), ["@b"] = s.BirthDate, ["@p"] = s.Phone.Trim(), ["@e"] = s.Email?.Trim(),
            ["@a"] = s.Address?.Trim(), ["@s"] = s.Status
        };
        if (s.Id == 0)
            s.Id = Db.Insert("INSERT INTO Students(Code,FullName,BirthDate,Phone,Email,Address,Status) VALUES(@c,@n,@b,@p,@e,@a,@s)", a);
        else
            Db.Execute("UPDATE Students SET FullName=@n,BirthDate=@b,Phone=@p,Email=@e,Address=@a,Status=@s WHERE Id=@id", a);
        return null;
    }

    public static string Delete(long id)
    {
        if (Db.Count("SELECT COUNT(*) FROM Enrollments WHERE StudentId=@id", new Args { ["@id"] = id }) > 0)
            return "Không thể xóa: học viên đã có phiếu đăng ký.";
        Db.Execute("DELETE FROM Users WHERE StudentId=@id; DELETE FROM Students WHERE Id=@id", new Args { ["@id"] = id });
        return null;
    }
}

public static class ClassService
{
    public static List<ClassInfo> List(string search = "", string status = null, long? teacherId = null, long? studentId = null) =>
        Db.Query(@"SELECT k.*, c.Name AS CourseName, c.Fee, t.FullName AS TeacherName, r.Name AS RoomName,
                    (SELECT COUNT(*) FROM Enrollments e WHERE e.ClassId=k.Id) AS StudentCount,
                    (SELECT group_concat(d, ',') FROM (SELECT DISTINCT ((CAST(strftime('%w', s.SessionDate) AS INTEGER)+6)%7+2) AS d
                         FROM Sessions s WHERE s.ClassId=k.Id ORDER BY d)) AS Days
                  FROM Classes k
                  JOIN Courses c ON c.Id=k.CourseId
                  JOIN Teachers t ON t.Id=k.TeacherId
                  JOIN Rooms r ON r.Id=k.RoomId
                  WHERE (@q='' OR k.Name LIKE '%'||@q||'%' OR c.Name LIKE '%'||@q||'%' OR t.FullName LIKE '%'||@q||'%')
                    AND (@s IS NULL OR k.Status=@s)
                    AND (@t IS NULL OR k.TeacherId=@t)
                    AND (@st IS NULL OR EXISTS(SELECT 1 FROM Enrollments e WHERE e.ClassId=k.Id AND e.StudentId=@st))
                  ORDER BY (k.Status='Đang học') DESC, k.Id",
            r => new ClassInfo
            {
                Id = r.Long("Id"), CourseId = r.Long("CourseId"), CourseName = r.Str("CourseName"), Fee = r.Dbl("Fee"), Name = r.Str("Name"),
                MaxStudents = (int)r.Long("MaxStudents"), TeacherId = r.Long("TeacherId"), TeacherName = r.Str("TeacherName"),
                RoomId = r.Long("RoomId"), RoomName = r.Str("RoomName"), Status = r.Str("Status"),
                StudentCount = (int)r.Long("StudentCount"), Days = r.Str("Days")
            }, new Args { ["@q"] = search?.Trim() ?? "", ["@s"] = status, ["@t"] = teacherId, ["@st"] = studentId });

    public static string Save(ClassInfo c)
    {
        if (c.CourseId == 0) return "Vui lòng chọn khóa học.";
        if (string.IsNullOrWhiteSpace(c.Name)) return "Vui lòng nhập tên lớp.";
        if (c.MaxStudents <= 0) return "Sĩ số tối đa phải lớn hơn 0.";
        if (c.TeacherId == 0 || c.RoomId == 0) return "Vui lòng chọn giảng viên và phòng học.";
        if (Db.Count("SELECT COUNT(*) FROM Classes WHERE lower(Name)=lower(@n) AND Id<>@id", new Args { ["@n"] = c.Name.Trim(), ["@id"] = c.Id }) > 0)
            return "Tên lớp đã tồn tại.";
        if (c.Id != 0 && c.MaxStudents < Db.Count("SELECT COUNT(*) FROM Enrollments WHERE ClassId=@id", new Args { ["@id"] = c.Id }))
            return "Sĩ số tối đa nhỏ hơn số học viên đã đăng ký.";
        var cap = Db.Count("SELECT Capacity FROM Rooms WHERE Id=@r", new Args { ["@r"] = c.RoomId });
        if (c.MaxStudents > cap) return $"Phòng học chỉ chứa tối đa {cap} học viên.";
        var a = new Args
        {
            ["@id"] = c.Id, ["@c"] = c.CourseId, ["@n"] = c.Name.Trim(), ["@m"] = c.MaxStudents, ["@t"] = c.TeacherId, ["@r"] = c.RoomId, ["@s"] = c.Status
        };
        if (c.Id == 0)
            c.Id = Db.Insert("INSERT INTO Classes(CourseId,Name,MaxStudents,TeacherId,RoomId,Status) VALUES(@c,@n,@m,@t,@r,@s)", a);
        else
            Db.Execute("UPDATE Classes SET CourseId=@c,Name=@n,MaxStudents=@m,TeacherId=@t,RoomId=@r,Status=@s WHERE Id=@id", a);
        return null;
    }

    public static string Delete(long id)
    {
        if (Db.Count("SELECT COUNT(*) FROM Enrollments WHERE ClassId=@id", new Args { ["@id"] = id }) > 0)
            return "Không thể xóa: lớp đã có học viên đăng ký.";
        Db.Execute("DELETE FROM Sessions WHERE ClassId=@id; DELETE FROM Classes WHERE Id=@id", new Args { ["@id"] = id });
        return null;
    }
}

public static class ScheduleService
{
    public static readonly string[] Slots = { "08:00 — 09:30", "09:45 — 11:15", "14:00 — 15:30", "18:00 — 19:30", "19:45 — 21:15" };

    private const string Select = @"SELECT s.*, k.Name AS ClassName, r.Name AS RoomName, t.FullName AS TeacherName,
              (SELECT COUNT(*) FROM Sessions x WHERE x.ClassId=s.ClassId AND (x.SessionDate<s.SessionDate OR (x.SessionDate=s.SessionDate AND x.StartTime<=s.StartTime))) AS No,
              EXISTS(SELECT 1 FROM Sessions o WHERE o.Id<>s.Id AND o.SessionDate=s.SessionDate AND o.StartTime<s.EndTime AND s.StartTime<o.EndTime
                     AND (o.RoomId=s.RoomId OR o.TeacherId=s.TeacherId)) AS Conflict
            FROM Sessions s JOIN Classes k ON k.Id=s.ClassId JOIN Rooms r ON r.Id=s.RoomId JOIN Teachers t ON t.Id=s.TeacherId";

    private static SessionInfo Map(SqliteDataReader r) => new()
    {
        Id = r.Long("Id"), ClassId = r.Long("ClassId"), ClassName = r.Str("ClassName"), Date = Fmt.ParseDate(r.Str("SessionDate")),
        Start = r.Str("StartTime"), End = r.Str("EndTime"), RoomId = r.Long("RoomId"), RoomName = r.Str("RoomName"),
        TeacherId = r.Long("TeacherId"), TeacherName = r.Str("TeacherName"), No = (int)r.Long("No"), Conflict = r.Long("Conflict") == 1
    };

    public static List<SessionInfo> Range(DateTime from, DateTime to, long? teacherId = null, long? studentId = null) =>
        Db.Query(Select + @" WHERE s.SessionDate BETWEEN @a AND @b AND (@t IS NULL OR s.TeacherId=@t)
                AND (@st IS NULL OR EXISTS(SELECT 1 FROM Enrollments e WHERE e.ClassId=s.ClassId AND e.StudentId=@st))
                ORDER BY s.SessionDate, s.StartTime", Map,
            new Args { ["@a"] = Fmt.DbDate(from), ["@b"] = Fmt.DbDate(to), ["@t"] = teacherId, ["@st"] = studentId });

    public static List<SessionInfo> OfClass(long classId) =>
        Db.Query(Select + " WHERE s.ClassId=@c ORDER BY s.SessionDate, s.StartTime", Map, new Args { ["@c"] = classId });

    public static List<SessionInfo> Conflicts() =>
        Db.Query(Select + " ORDER BY s.SessionDate, s.StartTime", Map).Where(s => s.Conflict && s.Date >= DateTime.Today.AddDays(-7)).ToList();

    public static string Check(long classId, DateTime date, string start, string end, long roomId, long teacherId, long ignoreId = 0)
    {
        if (string.CompareOrdinal(start, end) >= 0) return "Giờ kết thúc phải sau giờ bắt đầu.";
        if (date.DayOfWeek == DayOfWeek.Sunday) return "Trung tâm không xếp lịch học vào Chủ nhật.";
        var clashes = Db.Query(@"SELECT k.Name AS ClassName, s.StartTime, s.EndTime, s.RoomId, s.TeacherId, r.Name AS RoomName, t.FullName AS TeacherName
                FROM Sessions s JOIN Classes k ON k.Id=s.ClassId JOIN Rooms r ON r.Id=s.RoomId JOIN Teachers t ON t.Id=s.TeacherId
                WHERE s.Id<>@ig AND s.SessionDate=@d AND s.StartTime<@e AND @s<s.EndTime
                  AND (s.RoomId=@r OR s.TeacherId=@t OR s.ClassId=@c)",
            r => (Class: r.Str("ClassName"), Start: r.Str("StartTime"), End: r.Str("EndTime"), Room: r.Long("RoomId"), Teacher: r.Long("TeacherId"),
                RoomName: r.Str("RoomName"), TeacherName: r.Str("TeacherName")),
            new Args { ["@ig"] = ignoreId, ["@d"] = Fmt.DbDate(date), ["@s"] = start, ["@e"] = end, ["@r"] = roomId, ["@t"] = teacherId, ["@c"] = classId });
        if (clashes.Count == 0) return null;
        var c = clashes[0];
        if (c.Room == roomId)
            return $"Trùng phòng: {c.RoomName} đã có lớp {c.Class} ({c.Start}–{c.End}).";
        if (c.Teacher == teacherId)
            return $"Trùng lịch giáo viên: {c.TeacherName} đang dạy lớp {c.Class} ({c.Start}–{c.End}).";
        return $"Lớp đã có buổi học khác trong khung giờ này ({c.Start}–{c.End}).";
    }

    public static string Add(long classId, DateTime date, string slot, long roomId, long teacherId)
    {
        var (start, end) = SplitSlot(slot);
        var err = Check(classId, date, start, end, roomId, teacherId);
        if (err != null) return err;
        Db.Execute("INSERT INTO Sessions(ClassId,SessionDate,StartTime,EndTime,RoomId,TeacherId) VALUES(@c,@d,@s,@e,@r,@t)",
            new Args { ["@c"] = classId, ["@d"] = Fmt.DbDate(date), ["@s"] = start, ["@e"] = end, ["@r"] = roomId, ["@t"] = teacherId });
        return null;
    }

    public static string Delete(long sessionId)
    {
        if (Db.Count("SELECT COUNT(*) FROM Attendance WHERE SessionId=@id", new Args { ["@id"] = sessionId }) > 0)
            return "Không thể xóa: buổi học đã được điểm danh.";
        Db.Execute("DELETE FROM Sessions WHERE Id=@id", new Args { ["@id"] = sessionId });
        return null;
    }

    public static (string Start, string End) SplitSlot(string slot)
    {
        var p = slot.Split('—');
        return (p[0].Trim(), p[1].Trim());
    }
}

public static class EnrollmentService
{
    public const double OldStudentDiscount = 10;
    public const double GroupDiscount = 10;

    public static bool IsOldStudent(long studentId, long excludeClassId = 0) =>
        Db.Count("SELECT COUNT(*) FROM Enrollments WHERE StudentId=@s AND ClassId<>@c", new Args { ["@s"] = studentId, ["@c"] = excludeClassId }) > 0;

    public static (double Percent, double Discount, double Final) Calc(double baseFee, bool oldStudent, bool group)
    {
        double percent = (oldStudent ? OldStudentDiscount : 0) + (group ? GroupDiscount : 0);
        double discount = Math.Round(baseFee * percent / 100);
        return (percent, discount, baseFee - discount);
    }

    public static string PolicyText(bool oldStudent, bool group) =>
        oldStudent && group ? "Học viên cũ −10%, Đăng ký nhóm −10%" : oldStudent ? "Học viên cũ −10%" : group ? "Đăng ký nhóm −10%" : "Không áp dụng";

    public static (string Error, long Id) Enroll(long studentId, long classId, bool oldStudent, bool group, int installments)
    {
        if (studentId == 0 || classId == 0) return ("Vui lòng chọn học viên và lớp.", 0);
        if (installments < 1 || installments > 3) return ("Phương thức thanh toán không hợp lệ.", 0);
        var cls = ClassService.List().FirstOrDefault(c => c.Id == classId);
        if (cls == null) return ("Lớp học không tồn tại.", 0);
        if (cls.Status != "Đang học") return ("Lớp học đã kết thúc hoặc tạm dừng.", 0);
        if (Db.Count("SELECT COUNT(*) FROM Enrollments WHERE StudentId=@s AND ClassId=@c", new Args { ["@s"] = studentId, ["@c"] = classId }) > 0)
            return ("Học viên đã đăng ký lớp này.", 0);
        if (cls.StudentCount >= cls.MaxStudents) return ($"Lớp {cls.Name} đã đủ sĩ số ({cls.MaxStudents}).", 0);
        if (oldStudent && !IsOldStudent(studentId, classId)) return ("Học viên chưa từng học tại trung tâm nên không được ưu đãi học viên cũ.", 0);

        var (percent, _, final) = Calc(cls.Fee, oldStudent, group);
        var today = DateTime.Today;
        long id = Db.Insert("INSERT INTO Enrollments(StudentId,ClassId,EnrollDate,BaseFee,DiscountPercent,FinalFee,Policy,Installments) VALUES(@s,@c,@d,@b,@p,@f,@po,@i)",
            new Args
            {
                ["@s"] = studentId, ["@c"] = classId, ["@d"] = Fmt.DbDate(today), ["@b"] = cls.Fee, ["@p"] = percent, ["@f"] = final,
                ["@po"] = PolicyText(oldStudent, group), ["@i"] = installments
            });
        double each = Math.Round(final / installments);
        for (int k = 1; k <= installments; k++)
        {
            double amount = k == installments ? final - each * (installments - 1) : each;
            Db.Execute("INSERT INTO Payments(EnrollmentId,InstallmentNo,DueDate,Amount) VALUES(@e,@n,@d,@a)",
                new Args { ["@e"] = id, ["@n"] = k, ["@d"] = Fmt.DbDate(today.AddMonths(k - 1)), ["@a"] = amount });
        }
        Db.Execute("INSERT OR IGNORE INTO Scores(EnrollmentId) VALUES(@e)", new Args { ["@e"] = id });
        return (null, id);
    }

    public static List<EnrollmentInfo> List(long? studentId = null, long? enrollmentId = null) =>
        Db.Query(@"SELECT e.*, s.FullName AS StudentName, s.Code AS StudentCode, k.Name AS ClassName, c.Name AS CourseName,
                    (SELECT IFNULL(SUM(Amount),0) FROM Payments p WHERE p.EnrollmentId=e.Id AND p.PaidDate IS NOT NULL) AS Paid
                  FROM Enrollments e JOIN Students s ON s.Id=e.StudentId JOIN Classes k ON k.Id=e.ClassId JOIN Courses c ON c.Id=k.CourseId
                  WHERE (@s IS NULL OR e.StudentId=@s) AND (@e IS NULL OR e.Id=@e)
                  ORDER BY e.Id DESC",
            r => new EnrollmentInfo
            {
                Id = r.Long("Id"), StudentId = r.Long("StudentId"), StudentName = r.Str("StudentName"), StudentCode = r.Str("StudentCode"),
                ClassId = r.Long("ClassId"), ClassName = r.Str("ClassName"), CourseName = r.Str("CourseName"), EnrollDate = Fmt.ParseDate(r.Str("EnrollDate")),
                BaseFee = r.Dbl("BaseFee"), DiscountPercent = r.Dbl("DiscountPercent"), FinalFee = r.Dbl("FinalFee"), Policy = r.Str("Policy"),
                Installments = (int)r.Long("Installments"), Paid = r.Dbl("Paid")
            }, new Args { ["@s"] = studentId, ["@e"] = enrollmentId });

    public static List<PaymentInfo> Payments(long enrollmentId) =>
        Db.Query("SELECT * FROM Payments WHERE EnrollmentId=@e ORDER BY InstallmentNo",
            r => new PaymentInfo
            {
                Id = r.Long("Id"), EnrollmentId = r.Long("EnrollmentId"), InstallmentNo = (int)r.Long("InstallmentNo"), DueDate = Fmt.ParseDate(r.Str("DueDate")),
                Amount = r.Dbl("Amount"), PaidDate = r.Str("PaidDate"), ReceiptNo = r.Str("ReceiptNo")
            }, new Args { ["@e"] = enrollmentId });

    public static (string Error, string ReceiptNo) Pay(long paymentId)
    {
        var p = Db.Query("SELECT EnrollmentId, InstallmentNo, PaidDate FROM Payments WHERE Id=@id",
            r => (E: r.Long("EnrollmentId"), No: (int)r.Long("InstallmentNo"), Paid: r.Str("PaidDate")), new Args { ["@id"] = paymentId }).FirstOrDefault();
        if (p.E == 0) return ("Không tìm thấy kỳ thanh toán.", null);
        if (p.Paid != null) return ("Kỳ này đã được thu.", null);
        if (Db.Count("SELECT COUNT(*) FROM Payments WHERE EnrollmentId=@e AND InstallmentNo<@n AND PaidDate IS NULL", new Args { ["@e"] = p.E, ["@n"] = p.No }) > 0)
            return ("Vui lòng thu các kỳ trước theo thứ tự.", null);
        var receipt = $"PT{DateTime.Now:yyMMddHHmmss}";
        Db.Execute("UPDATE Payments SET PaidDate=@d, ReceiptNo=@r WHERE Id=@id",
            new Args { ["@d"] = Fmt.DbDate(DateTime.Today), ["@r"] = receipt, ["@id"] = paymentId });
        return (null, receipt);
    }

    public static (double Revenue, double LastRevenue, double Debt, long DebtStudents, long InstallmentStudents, long InstallmentsLeft) Stats()
    {
        var today = DateTime.Today;
        var first = new DateTime(today.Year, today.Month, 1);
        var prev = first.AddMonths(-1);
        double rev = Db.Sum("SELECT IFNULL(SUM(Amount),0) FROM Payments WHERE PaidDate BETWEEN @a AND @b",
            new Args { ["@a"] = Fmt.DbDate(first), ["@b"] = Fmt.DbDate(first.AddMonths(1).AddDays(-1)) });
        double last = Db.Sum("SELECT IFNULL(SUM(Amount),0) FROM Payments WHERE PaidDate BETWEEN @a AND @b",
            new Args { ["@a"] = Fmt.DbDate(prev), ["@b"] = Fmt.DbDate(first.AddDays(-1)) });
        double debt = Db.Sum("SELECT IFNULL(SUM(Amount),0) FROM Payments WHERE PaidDate IS NULL");
        long debtStudents = Db.Count("SELECT COUNT(DISTINCT e.StudentId) FROM Payments p JOIN Enrollments e ON e.Id=p.EnrollmentId WHERE p.PaidDate IS NULL");
        long instStudents = Db.Count(@"SELECT COUNT(DISTINCT e.StudentId) FROM Enrollments e WHERE e.Installments>1
                                        AND EXISTS(SELECT 1 FROM Payments p WHERE p.EnrollmentId=e.Id AND p.PaidDate IS NULL)");
        long left = Db.Count("SELECT COUNT(*) FROM Payments p JOIN Enrollments e ON e.Id=p.EnrollmentId WHERE e.Installments>1 AND p.PaidDate IS NULL");
        return (rev, last, debt, debtStudents, instStudents, left);
    }
}

public static class AttendanceService
{
    public static readonly string[] Statuses = { "Có mặt", "Vắng có phép", "Vắng không phép" };
    public const int WarningThreshold = 3;

    public static List<AttendanceRow> Roster(long sessionId)
    {
        var s = Db.Query("SELECT ClassId, SessionDate FROM Sessions WHERE Id=@id", r => (C: r.Long("ClassId"), D: r.Str("SessionDate")),
            new Args { ["@id"] = sessionId }).First();
        return Db.Query(@"SELECT st.Id, st.Code, st.FullName, st.Phone,
                    IFNULL((SELECT a.Status FROM Attendance a WHERE a.SessionId=@sid AND a.StudentId=st.Id),0) AS Status,
                    (SELECT COUNT(*) FROM Sessions x WHERE x.ClassId=@c AND x.SessionDate<=@d) AS Held,
                    (SELECT COUNT(*) FROM Attendance a JOIN Sessions x ON x.Id=a.SessionId
                       WHERE x.ClassId=@c AND a.StudentId=st.Id AND a.Status>0 AND x.SessionDate<=@d) AS Absent
                  FROM Enrollments e JOIN Students st ON st.Id=e.StudentId
                  WHERE e.ClassId=@c ORDER BY st.FullName",
            r => new AttendanceRow
            {
                StudentId = r.Long("Id"), Code = r.Str("Code"), FullName = r.Str("FullName"), Phone = r.Str("Phone"),
                Status = (int)r.Long("Status"), Held = (int)r.Long("Held"), Absent = (int)r.Long("Absent")
            }, new Args { ["@sid"] = sessionId, ["@c"] = s.C, ["@d"] = s.D });
    }

    public static string Save(long sessionId, IEnumerable<AttendanceRow> rows)
    {
        var date = Fmt.ParseDate((string)Db.Scalar("SELECT SessionDate FROM Sessions WHERE Id=@id", new Args { ["@id"] = sessionId }));
        if (date > DateTime.Today) return "Không thể điểm danh cho buổi học chưa diễn ra.";
        using var conn = Db.Open();
        using var tx = conn.BeginTransaction();
        foreach (var row in rows)
        {
            using var cmd = conn.CreateCommand();
            cmd.Transaction = tx;
            cmd.CommandText = "INSERT INTO Attendance(SessionId,StudentId,Status) VALUES(@s,@st,@v) ON CONFLICT(SessionId,StudentId) DO UPDATE SET Status=excluded.Status";
            cmd.Parameters.AddWithValue("@s", sessionId);
            cmd.Parameters.AddWithValue("@st", row.StudentId);
            cmd.Parameters.AddWithValue("@v", row.Status);
            cmd.ExecuteNonQuery();
        }
        tx.Commit();
        return null;
    }

    public static List<WarningRow> Warnings(long? classId = null) =>
        Db.Query(@"SELECT st.Id, st.FullName, st.Phone, k.Name AS ClassName, COUNT(*) AS Absent
                  FROM Attendance a JOIN Sessions x ON x.Id=a.SessionId JOIN Classes k ON k.Id=x.ClassId JOIN Students st ON st.Id=a.StudentId
                  WHERE a.Status>0 AND k.Status='Đang học' AND (@c IS NULL OR k.Id=@c)
                  GROUP BY st.Id, k.Id HAVING COUNT(*)>@n ORDER BY Absent DESC",
            r => new WarningRow { StudentId = r.Long("Id"), FullName = r.Str("FullName"), Phone = r.Str("Phone"), ClassName = r.Str("ClassName"), Absent = (int)r.Long("Absent") },
            new Args { ["@c"] = classId, ["@n"] = WarningThreshold });

    public static long DefaultSession(List<SessionInfo> sessions)
    {
        var past = sessions.Where(s => s.Date <= DateTime.Today).ToList();
        return past.Count > 0 ? past[^1].Id : sessions.FirstOrDefault()?.Id ?? 0;
    }
}

public static class ScoreService
{
    public static List<ScoreRow> Roster(long classId, long? studentId = null) =>
        Db.Query(@"SELECT e.Id AS EnrollmentId, st.Id AS StudentId, st.FullName, k.Name AS ClassName, c.Name AS CourseName, sc.Midterm, sc.Final,
                    (SELECT COUNT(*) FROM Sessions x WHERE x.ClassId=k.Id AND x.SessionDate<=@today) AS Held,
                    (SELECT COUNT(*) FROM Attendance a JOIN Sessions x ON x.Id=a.SessionId WHERE x.ClassId=k.Id AND a.StudentId=st.Id AND a.Status>0) AS Absent
                  FROM Enrollments e JOIN Students st ON st.Id=e.StudentId JOIN Classes k ON k.Id=e.ClassId JOIN Courses c ON c.Id=k.CourseId
                  LEFT JOIN Scores sc ON sc.EnrollmentId=e.Id
                  WHERE e.ClassId=@c AND (@s IS NULL OR e.StudentId=@s) ORDER BY st.FullName",
            r => new ScoreRow
            {
                EnrollmentId = r.Long("EnrollmentId"), StudentId = r.Long("StudentId"), FullName = r.Str("FullName"), ClassName = r.Str("ClassName"),
                CourseName = r.Str("CourseName"), Midterm = r.DblN("Midterm"), Final = r.DblN("Final"), Held = (int)r.Long("Held"), Absent = (int)r.Long("Absent")
            }, new Args { ["@c"] = classId, ["@s"] = studentId, ["@today"] = Fmt.DbDate(DateTime.Today) });

    public static string Save(IEnumerable<ScoreRow> rows)
    {
        foreach (var r in rows)
            if (r.Midterm is < 0 or > 10 || r.Final is < 0 or > 10)
                return $"Điểm của {r.FullName} phải nằm trong khoảng 0 – 10.";
        foreach (var r in rows)
            Db.Execute("INSERT INTO Scores(EnrollmentId,Midterm,Final) VALUES(@e,@m,@f) ON CONFLICT(EnrollmentId) DO UPDATE SET Midterm=excluded.Midterm, Final=excluded.Final",
                new Args { ["@e"] = r.EnrollmentId, ["@m"] = r.Midterm, ["@f"] = r.Final });
        return null;
    }
}

public static class DashboardService
{
    public static DateTime Monday(DateTime d) => d.Date.AddDays(-(((int)d.DayOfWeek + 6) % 7));

    public static long Students() => Db.Count("SELECT COUNT(*) FROM Students");
    public static long NewStudentsThisMonth() => Db.Count("SELECT COUNT(DISTINCT StudentId) FROM Enrollments WHERE EnrollDate>=@a",
        new Args { ["@a"] = Fmt.DbDate(new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1)) });
    public static long ActiveClasses() => Db.Count("SELECT COUNT(*) FROM Classes WHERE Status='Đang học'");
    public static long Teachers() => Db.Count("SELECT COUNT(*) FROM Teachers");
    public static long TeachersWithSessionsThisWeek()
    {
        var m = Monday(DateTime.Today);
        return Db.Count("SELECT COUNT(DISTINCT TeacherId) FROM Sessions WHERE SessionDate BETWEEN @a AND @b",
            new Args { ["@a"] = Fmt.DbDate(m), ["@b"] = Fmt.DbDate(m.AddDays(6)) });
    }

    public static (DateTime From, DateTime To) RangeOf(int index)
    {
        var today = DateTime.Today;
        return index switch
        {
            1 => (new DateTime(today.Year, today.Month, 1), new DateTime(today.Year, today.Month, 1).AddMonths(1).AddDays(-1)),
            2 => (new DateTime(today.Year, (today.Month - 1) / 3 * 3 + 1, 1), new DateTime(today.Year, (today.Month - 1) / 3 * 3 + 1, 1).AddMonths(3).AddDays(-1)),
            _ => (Monday(today), Monday(today).AddDays(6))
        };
    }

    public static (int[] Present, int[] Absent) AttendanceByWeekday(DateTime from, DateTime to)
    {
        var present = new int[7];
        var absent = new int[7];
        foreach (var (date, status, n) in Db.Query(@"SELECT x.SessionDate, (a.Status>0) AS Abs, COUNT(*) AS N
                FROM Attendance a JOIN Sessions x ON x.Id=a.SessionId WHERE x.SessionDate BETWEEN @a AND @b GROUP BY x.SessionDate, Abs",
                     r => (Fmt.ParseDate(r.Str("SessionDate")), r.Long("Abs"), (int)r.Long("N")),
                     new Args { ["@a"] = Fmt.DbDate(from), ["@b"] = Fmt.DbDate(to) }))
        {
            int i = Fmt.Dow(date) - 2;
            if (status == 1) absent[i] += n; else present[i] += n;
        }
        return (present, absent);
    }

    public static List<TaskItem> Tasks(AppUser user)
    {
        var list = new List<TaskItem>();
        var today = DateTime.Today;
        if (!user.IsStudent)
        {
            foreach (var s in ScheduleService.Range(today.AddDays(-2), today, user.IsTeacher ? user.TeacherId : null))
            {
                if (Db.Count("SELECT COUNT(*) FROM Attendance WHERE SessionId=@s", new Args { ["@s"] = s.Id }) == 0)
                    list.Add(new TaskItem { Title = $"Điểm danh {s.ClassName} — {s.Display}", Tag = "Điểm danh", Color = "blue", Target = "attendance" });
            }
            foreach (var w in AttendanceService.Warnings().Where(w => !user.IsTeacher || ClassService.List(teacherId: user.TeacherId).Any(c => c.Name == w.ClassName)).Take(3))
                list.Add(new TaskItem { Title = $"Nhắc nhở chuyên cần {w.FullName} ({w.Absent} buổi vắng)", Tag = "Học viên", Color = "purple", Target = "attendance" });
        }
        if (user.IsAdmin)
        {
            foreach (var d in Db.Query(@"SELECT st.FullName, k.Name AS ClassName, p.InstallmentNo FROM Payments p JOIN Enrollments e ON e.Id=p.EnrollmentId
                     JOIN Students st ON st.Id=e.StudentId JOIN Classes k ON k.Id=e.ClassId WHERE p.PaidDate IS NULL AND p.DueDate<=@d ORDER BY p.DueDate LIMIT 3",
                         r => (r.Str("FullName"), r.Str("ClassName"), r.Long("InstallmentNo")), new Args { ["@d"] = Fmt.DbDate(today) }))
                list.Add(new TaskItem { Title = $"Thu học phí kỳ {d.Item3} — {d.Item1} ({d.Item2})", Tag = "Tài chính", Color = "orange", Target = "finance" });
            var nextMonday = Monday(today).AddDays(7);
            foreach (var c in ClassService.List(status: "Đang học"))
                if (Db.Count("SELECT COUNT(*) FROM Sessions WHERE ClassId=@c AND SessionDate>=@d", new Args { ["@c"] = c.Id, ["@d"] = Fmt.DbDate(nextMonday) }) == 0)
                    list.Add(new TaskItem { Title = $"Xếp lịch học cho lớp {c.Name}", Tag = "Lịch học", Color = "purple", Target = "schedule" });
        }
        if (user.IsStudent && user.StudentId is long sid)
        {
            foreach (var e in EnrollmentService.List(sid))
                foreach (var p in EnrollmentService.Payments(e.Id).Where(p => !p.IsPaid).Take(1))
                    list.Add(new TaskItem { Title = $"Thanh toán kỳ {p.InstallmentNo} lớp {e.ClassName} — {p.AmountDisplay}", Tag = "Tài chính", Color = "orange", Target = "finance" });
            foreach (var s in ScheduleService.Range(today, today.AddDays(2), studentId: sid))
                list.Add(new TaskItem { Title = $"Tham gia {s.ClassName} — {Fmt.DayName(s.Date)} {s.Start}", Tag = "Lịch học", Color = "blue", Target = "schedule" });
        }
        return list;
    }

    public static List<NotificationItem> Notifications(AppUser user)
    {
        var list = new List<NotificationItem>();
        if (user.IsAdmin)
        {
            long recent = Db.Count("SELECT COUNT(*) FROM Enrollments WHERE EnrollDate>=@d", new Args { ["@d"] = Fmt.DbDate(DateTime.Today.AddDays(-7)) });
            list.Add(new NotificationItem { Title = $"Có {recent} phiếu đăng ký mới", Detail = "Phiếu đăng ký trong 7 ngày gần nhất.", Color = "blue", Target = "finance" });
        }
        var conflicts = ScheduleService.Conflicts();
        if (user.IsTeacher) conflicts = conflicts.Where(s => s.TeacherId == user.TeacherId).ToList();
        if (user.IsStudent)
        {
            var classIds = ClassService.List(studentId: user.StudentId ?? 0).Select(c => c.Id).ToHashSet();
            conflicts = conflicts.Where(s => classIds.Contains(s.ClassId)).ToList();
        }
        list.Add(conflicts.Count > 0
            ? new NotificationItem { Title = "Phát hiện xung đột lịch học", Detail = $"{conflicts[0].RoomName} bị trùng lịch lúc {conflicts[0].Start} ngày {Fmt.Date(conflicts[0].Date)}.", Color = "orange", Target = "schedule" }
            : new NotificationItem { Title = "Lịch học không có xung đột", Detail = "Không có phòng hoặc giáo viên bị trùng lịch.", Color = "green", Target = "schedule" });
        var warnings = AttendanceService.Warnings();
        if (user.IsStudent) warnings = warnings.Where(w => w.StudentId == user.StudentId).ToList();
        if (user.IsTeacher)
        {
            warnings = ClassService.List(teacherId: user.TeacherId ?? 0).SelectMany(c => AttendanceService.Warnings(c.Id)).ToList();
        }
        list.Add(new NotificationItem
        {
            Title = "Cảnh báo chuyên cần",
            Detail = warnings.Count == 0 ? "Chưa có học viên vắng quá 3 buổi." : $"{warnings.Count} học viên đã vắng quá {AttendanceService.WarningThreshold} buổi.",
            Color = "purple", Target = "attendance"
        });
        return list.Where(n => SettingService.GetBool($"Notify_{user.Id}_{(n.Target == "schedule" ? "Schedule" : n.Target == "finance" ? "Finance" : "Attendance")}")).ToList();
    }
}
