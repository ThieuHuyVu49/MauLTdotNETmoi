using System.Security.Cryptography;
using System.Text;
using Microsoft.Data.Sqlite;

namespace EnglishCenterManagement.Data;

public static class Db
{
    public static string DbPath => Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "english_center.db");

    public static SqliteConnection Open()
    {
        var conn = new SqliteConnection("Data Source=" + DbPath);
        conn.Open();
        using var cmd = conn.CreateCommand();
        cmd.CommandText = "PRAGMA foreign_keys = ON;";
        cmd.ExecuteNonQuery();
        return conn;
    }

    private static void Bind(SqliteCommand cmd, Dictionary<string, object> args)
    {
        if (args == null) return;
        foreach (var kv in args) cmd.Parameters.AddWithValue(kv.Key, kv.Value ?? DBNull.Value);
    }

    public static int Execute(string sql, Dictionary<string, object> args = null)
    {
        using var conn = Open();
        using var cmd = conn.CreateCommand();
        cmd.CommandText = sql;
        Bind(cmd, args);
        return cmd.ExecuteNonQuery();
    }

    public static object Scalar(string sql, Dictionary<string, object> args = null)
    {
        using var conn = Open();
        using var cmd = conn.CreateCommand();
        cmd.CommandText = sql;
        Bind(cmd, args);
        var v = cmd.ExecuteScalar();
        return v == DBNull.Value ? null : v;
    }

    public static long Count(string sql, Dictionary<string, object> args = null) => Convert.ToInt64(Scalar(sql, args) ?? 0L);

    public static double Sum(string sql, Dictionary<string, object> args = null) => Convert.ToDouble(Scalar(sql, args) ?? 0.0);

    public static long Insert(string sql, Dictionary<string, object> args = null)
    {
        using var conn = Open();
        using var cmd = conn.CreateCommand();
        cmd.CommandText = sql + "; SELECT last_insert_rowid();";
        Bind(cmd, args);
        return (long)cmd.ExecuteScalar();
    }

    public static List<T> Query<T>(string sql, Func<SqliteDataReader, T> map, Dictionary<string, object> args = null)
    {
        var list = new List<T>();
        using var conn = Open();
        using var cmd = conn.CreateCommand();
        cmd.CommandText = sql;
        Bind(cmd, args);
        using var r = cmd.ExecuteReader();
        while (r.Read()) list.Add(map(r));
        return list;
    }

    public static string Str(this SqliteDataReader r, string col) => r[col] is DBNull ? null : Convert.ToString(r[col]);
    public static long Long(this SqliteDataReader r, string col) => r[col] is DBNull ? 0 : Convert.ToInt64(r[col]);
    public static double Dbl(this SqliteDataReader r, string col) => r[col] is DBNull ? 0 : Convert.ToDouble(r[col]);
    public static double? DblN(this SqliteDataReader r, string col) => r[col] is DBNull ? null : Convert.ToDouble(r[col]);

    public static string Hash(string password)
    {
        var bytes = SHA256.HashData(Encoding.UTF8.GetBytes("northstar:" + password));
        return Convert.ToHexString(bytes);
    }

    public static void Init()
    {
        using (var conn = Open())
        using (var cmd = conn.CreateCommand())
        {
            cmd.CommandText = Schema;
            cmd.ExecuteNonQuery();
        }
        if (Count("SELECT COUNT(*) FROM Users") == 0) Seed();
    }

    public const string Schema = @"
CREATE TABLE IF NOT EXISTS Settings(
    Key   TEXT PRIMARY KEY,
    Value TEXT
);
CREATE TABLE IF NOT EXISTS Rooms(
    Id       INTEGER PRIMARY KEY AUTOINCREMENT,
    Name     TEXT NOT NULL UNIQUE,
    Capacity INTEGER NOT NULL DEFAULT 24
);
CREATE TABLE IF NOT EXISTS Teachers(
    Id           INTEGER PRIMARY KEY AUTOINCREMENT,
    FullName     TEXT NOT NULL,
    Phone        TEXT,
    Email        TEXT,
    Specialty    TEXT,
    Years        INTEGER NOT NULL DEFAULT 0,
    Certificates TEXT,
    Availability TEXT,
    Status       TEXT NOT NULL DEFAULT 'Đang giảng dạy'
);
CREATE TABLE IF NOT EXISTS Courses(
    Id          INTEGER PRIMARY KEY AUTOINCREMENT,
    Code        TEXT NOT NULL UNIQUE,
    Name        TEXT NOT NULL,
    Weeks       INTEGER NOT NULL,
    Sessions    INTEGER NOT NULL,
    Fee         REAL NOT NULL,
    Description TEXT,
    Status      TEXT NOT NULL DEFAULT 'Đang tuyển sinh'
);
CREATE TABLE IF NOT EXISTS Students(
    Id        INTEGER PRIMARY KEY AUTOINCREMENT,
    Code      TEXT NOT NULL UNIQUE,
    FullName  TEXT NOT NULL,
    BirthDate TEXT,
    Phone     TEXT,
    Email     TEXT,
    Address   TEXT,
    Status    TEXT NOT NULL DEFAULT 'Đang học'
);
CREATE TABLE IF NOT EXISTS Users(
    Id           INTEGER PRIMARY KEY AUTOINCREMENT,
    Email        TEXT NOT NULL UNIQUE,
    PasswordHash TEXT NOT NULL,
    FullName     TEXT NOT NULL,
    Phone        TEXT,
    Role         TEXT NOT NULL CHECK(Role IN ('admin','teacher','student')),
    TeacherId    INTEGER REFERENCES Teachers(Id),
    StudentId    INTEGER REFERENCES Students(Id)
);
CREATE TABLE IF NOT EXISTS Classes(
    Id          INTEGER PRIMARY KEY AUTOINCREMENT,
    CourseId    INTEGER NOT NULL REFERENCES Courses(Id),
    Name        TEXT NOT NULL UNIQUE,
    MaxStudents INTEGER NOT NULL DEFAULT 24,
    TeacherId   INTEGER NOT NULL REFERENCES Teachers(Id),
    RoomId      INTEGER NOT NULL REFERENCES Rooms(Id),
    Status      TEXT NOT NULL DEFAULT 'Đang học'
);
CREATE TABLE IF NOT EXISTS Sessions(
    Id          INTEGER PRIMARY KEY AUTOINCREMENT,
    ClassId     INTEGER NOT NULL REFERENCES Classes(Id) ON DELETE CASCADE,
    SessionDate TEXT NOT NULL,
    StartTime   TEXT NOT NULL,
    EndTime     TEXT NOT NULL,
    RoomId      INTEGER NOT NULL REFERENCES Rooms(Id),
    TeacherId   INTEGER NOT NULL REFERENCES Teachers(Id)
);
CREATE TABLE IF NOT EXISTS Enrollments(
    Id              INTEGER PRIMARY KEY AUTOINCREMENT,
    StudentId       INTEGER NOT NULL REFERENCES Students(Id),
    ClassId         INTEGER NOT NULL REFERENCES Classes(Id),
    EnrollDate      TEXT NOT NULL,
    BaseFee         REAL NOT NULL,
    DiscountPercent REAL NOT NULL DEFAULT 0,
    FinalFee        REAL NOT NULL,
    Policy          TEXT,
    Installments    INTEGER NOT NULL DEFAULT 1,
    UNIQUE(StudentId, ClassId)
);
CREATE TABLE IF NOT EXISTS Payments(
    Id            INTEGER PRIMARY KEY AUTOINCREMENT,
    EnrollmentId  INTEGER NOT NULL REFERENCES Enrollments(Id) ON DELETE CASCADE,
    InstallmentNo INTEGER NOT NULL,
    DueDate       TEXT NOT NULL,
    Amount        REAL NOT NULL,
    PaidDate      TEXT,
    ReceiptNo     TEXT
);
CREATE TABLE IF NOT EXISTS Attendance(
    Id        INTEGER PRIMARY KEY AUTOINCREMENT,
    SessionId INTEGER NOT NULL REFERENCES Sessions(Id) ON DELETE CASCADE,
    StudentId INTEGER NOT NULL REFERENCES Students(Id),
    Status    INTEGER NOT NULL DEFAULT 0,
    UNIQUE(SessionId, StudentId)
);
CREATE TABLE IF NOT EXISTS Scores(
    EnrollmentId INTEGER PRIMARY KEY REFERENCES Enrollments(Id) ON DELETE CASCADE,
    Midterm      REAL,
    Final        REAL
);";

    private static string D(DateTime d) => d.ToString("yyyy-MM-dd");

    private static void Seed()
    {
        using var conn = Open();
        using var tx = conn.BeginTransaction();

        long Ins(string sql, params (string, object)[] p)
        {
            using var cmd = conn.CreateCommand();
            cmd.Transaction = tx;
            cmd.CommandText = sql + "; SELECT last_insert_rowid();";
            foreach (var (k, v) in p) cmd.Parameters.AddWithValue(k, v ?? DBNull.Value);
            return (long)cmd.ExecuteScalar();
        }

        foreach (var (k, v) in new[]
                 {
                     ("CenterName", "Trung tâm Anh ngữ Northstar"), ("CenterPhone", "028 3824 6688"),
                     ("CenterEmail", "hello@northstar.vn"), ("CenterAddress", "125 Nguyễn Đình Chiểu, Quận 3, TP.HCM"),
                     ("TimeZone", "GMT+7 · Việt Nam"), ("Currency", "VND · Việt Nam Đồng")
                 })
            Ins("INSERT INTO Settings(Key,Value) VALUES(@k,@v)", ("@k", k), ("@v", v));

        long r201 = Ins("INSERT INTO Rooms(Name,Capacity) VALUES('Phòng 201',26)");
        long r302 = Ins("INSERT INTO Rooms(Name,Capacity) VALUES('Phòng 302',24)");
        long r105 = Ins("INSERT INTO Rooms(Name,Capacity) VALUES('Phòng 105',20)");
        long r202 = Ins("INSERT INTO Rooms(Name,Capacity) VALUES('Phòng 202',22)");

        const string tSql = "INSERT INTO Teachers(FullName,Phone,Email,Specialty,Years,Certificates,Availability) VALUES(@n,@p,@e,@s,@y,@c,'Thứ 2 — Thứ 6 · 08:00 — 20:00')";
        long tLinh = Ins(tSql, ("@n", "Linh Nguyễn"), ("@p", "0903 112 233"), ("@e", "linh.nguyen@northstar.vn"), ("@s", "IELTS"), ("@y", 8), ("@c", "TESOL, IELTS 8.0"));
        long tMinh = Ins(tSql, ("@n", "Minh Trần"), ("@p", "0904 445 566"), ("@e", "minh.tran@northstar.vn"), ("@s", "Giao tiếp"), ("@y", 6), ("@c", "CELTA"));
        long tAn = Ins(tSql, ("@n", "An Phạm"), ("@p", "0905 778 899"), ("@e", "an.pham@northstar.vn"), ("@s", "TOEIC"), ("@y", 5), ("@c", "TOEIC 950"));
        long tSarah = Ins(tSql, ("@n", "Sarah Wood"), ("@p", "0906 001 122"), ("@e", "sarah.wood@northstar.vn"), ("@s", "IELTS"), ("@y", 10), ("@c", "DELTA, CELTA"));

        const string cSql = "INSERT INTO Courses(Code,Name,Weeks,Sessions,Fee,Description,Status) VALUES(@c,@n,@w,@s,@f,@d,@st)";
        long cIelts = Ins(cSql, ("@c", "IELTS-65"), ("@n", "IELTS 6.5"), ("@w", 12), ("@s", 36), ("@f", 8900000), ("@d", "Luyện thi IELTS mục tiêu 6.5+"), ("@st", "Đang tuyển sinh"));
        long cToeic = Ins(cSql, ("@c", "TOEIC-500"), ("@n", "TOEIC 500+"), ("@w", 10), ("@s", 30), ("@f", 6500000), ("@d", "Luyện thi TOEIC mục tiêu 500+"), ("@st", "Đang tuyển sinh"));
        long cGt = Ins(cSql, ("@c", "GT-B1"), ("@n", "Giao tiếp B1"), ("@w", 8), ("@s", 24), ("@f", 4800000), ("@d", "Giao tiếp công sở và đời sống"), ("@st", "Đang tuyển sinh"));
        long cAdv = Ins(cSql, ("@c", "IELTS-75"), ("@n", "IELTS 7.5+"), ("@w", 12), ("@s", 36), ("@f", 11500000), ("@d", "IELTS nâng cao mục tiêu 7.5+"), ("@st", "Tạm dừng"));

        var names = new[]
        {
            "Nguyễn Minh Anh", "Trần Gia Hân", "Lê Hoàng Nam", "Phạm Khánh Linh", "Võ Thanh Tùng", "Đặng Thu Trang",
            "Bùi Quang Huy", "Hoàng Mai Phương", "Ngô Đức Thịnh", "Lý Ngọc Hân", "Phan Bảo Ngọc", "Trịnh Gia Bảo"
        };
        var students = new long[names.Length];
        for (int i = 0; i < names.Length; i++)
        {
            students[i] = Ins("INSERT INTO Students(Code,FullName,BirthDate,Phone,Email,Address,Status) VALUES(@c,@n,@b,@p,@e,@a,@s)",
                ("@c", $"HV-2025-{184 - i:0000}"), ("@n", names[i]), ("@b", D(new DateTime(1998 + i % 9, 1 + i % 12, 3 + i * 2))),
                ("@p", $"09{10 + i} {200 + i * 7:000} {300 + i * 11:000}"), ("@e", $"hocvien{184 - i}@email.com"),
                ("@a", "TP. Hồ Chí Minh"), ("@s", i == 3 ? "Bảo lưu" : "Đang học"));
        }

        Ins("INSERT INTO Users(Email,PasswordHash,FullName,Phone,Role) VALUES('admin@northstar.vn',@h,'Nguyễn Thu Hà','0901 234 567','admin')", ("@h", Hash("12345678")));
        Ins("INSERT INTO Users(Email,PasswordHash,FullName,Phone,Role,TeacherId) VALUES('teacher@northstar.vn',@h,'Linh Nguyễn','0903 112 233','teacher',@t)", ("@h", Hash("12345678")), ("@t", tLinh));
        Ins("INSERT INTO Users(Email,PasswordHash,FullName,Phone,Role,StudentId) VALUES('student@northstar.vn',@h,'Nguyễn Minh Anh','0910 200 300','student',@s)", ("@h", Hash("12345678")), ("@s", students[0]));

        var today = DateTime.Today;
        var monday = today.AddDays(-(((int)today.DayOfWeek + 6) % 7));
        var start = monday.AddDays(-7 * 6);
        var oldStart = monday.AddDays(-7 * 26);

        long gtOld = Ins("INSERT INTO Classes(CourseId,Name,MaxStudents,TeacherId,RoomId,Status) VALUES(@c,'Giao tiếp B1 — K10',20,@t,@r,'Đã kết thúc')", ("@c", cGt), ("@t", tMinh), ("@r", r105));
        long cls1 = Ins("INSERT INTO Classes(CourseId,Name,MaxStudents,TeacherId,RoomId) VALUES(@c,'IELTS Foundation 03',26,@t,@r)", ("@c", cIelts), ("@t", tLinh), ("@r", r201));
        long cls2 = Ins("INSERT INTO Classes(CourseId,Name,MaxStudents,TeacherId,RoomId) VALUES(@c,'TOEIC Intensive 06',24,@t,@r)", ("@c", cToeic), ("@t", tAn), ("@r", r302));
        long cls3 = Ins("INSERT INTO Classes(CourseId,Name,MaxStudents,TeacherId,RoomId) VALUES(@c,'Giao tiếp B1 — K12',20,@t,@r)", ("@c", cGt), ("@t", tMinh), ("@r", r105));
        long cls4 = Ins("INSERT INTO Classes(CourseId,Name,MaxStudents,TeacherId,RoomId) VALUES(@c,'IELTS Advanced 02',22,@t,@r)", ("@c", cAdv), ("@t", tSarah), ("@r", r202));

        var sessions = new Dictionary<long, List<(long Id, DateTime Date)>>();
        void Plan(long cls, DateTime from, int[] dows, string s, string e, long room, long teacher, int total)
        {
            var list = new List<(long, DateTime)>();
            var d = from;
            while (list.Count < total)
            {
                int dow = ((int)d.DayOfWeek + 6) % 7 + 2;
                if (dows.Contains(dow))
                {
                    long id = Ins("INSERT INTO Sessions(ClassId,SessionDate,StartTime,EndTime,RoomId,TeacherId) VALUES(@c,@d,@s,@e,@r,@t)",
                        ("@c", cls), ("@d", D(d)), ("@s", s), ("@e", e), ("@r", room), ("@t", teacher));
                    list.Add((id, d));
                }
                d = d.AddDays(1);
            }
            sessions[cls] = list;
        }

        Plan(gtOld, oldStart, new[] { 3, 5, 7 }, "18:00", "19:30", r105, tMinh, 24);
        Plan(cls1, start, new[] { 2, 4, 6 }, "08:00", "09:30", r201, tLinh, 36);
        Plan(cls2, start, new[] { 3, 5, 7 }, "14:00", "15:30", r302, tAn, 30);
        Plan(cls3, start, new[] { 2, 4, 6 }, "09:45", "11:15", r105, tMinh, 24);
        Plan(cls4, start, new[] { 2, 4, 6 }, "18:00", "19:30", r202, tSarah, 36);

        long Enroll(long student, long cls, double fee, double disc, string policy, int inst, DateTime date, int paidCount)
        {
            double final = Math.Round(fee * (100 - disc) / 100);
            long id = Ins("INSERT INTO Enrollments(StudentId,ClassId,EnrollDate,BaseFee,DiscountPercent,FinalFee,Policy,Installments) VALUES(@s,@c,@d,@b,@p,@f,@po,@i)",
                ("@s", student), ("@c", cls), ("@d", D(date)), ("@b", fee), ("@p", disc), ("@f", final), ("@po", policy), ("@i", inst));
            double each = Math.Round(final / inst);
            for (int k = 1; k <= inst; k++)
            {
                double amount = k == inst ? final - each * (inst - 1) : each;
                bool paid = k <= paidCount;
                Ins("INSERT INTO Payments(EnrollmentId,InstallmentNo,DueDate,Amount,PaidDate,ReceiptNo) VALUES(@e,@n,@d,@a,@pd,@r)",
                    ("@e", id), ("@n", k), ("@d", D(date.AddMonths(k - 1))), ("@a", amount),
                    ("@pd", paid ? D(date.AddMonths(k - 1)) : null), ("@r", paid ? $"PT{date.AddMonths(k - 1):yyMMdd}{id:000}{k}" : null));
            }
            return id;
        }

        var enrollDate = start.AddDays(-5);
        Enroll(students[0], gtOld, 4800000, 0, "Không áp dụng", 1, oldStart.AddDays(-3), 1);
        Enroll(students[2], gtOld, 4800000, 0, "Không áp dụng", 1, oldStart.AddDays(-3), 1);

        var roster = new Dictionary<long, List<(long Student, long Enrollment)>>
        {
            [cls1] = new(), [cls2] = new(), [cls3] = new(), [cls4] = new()
        };
        void Add(long cls, int idx, double fee, double disc, string policy, int inst, int paid)
            => roster[cls].Add((students[idx], Enroll(students[idx], cls, fee, disc, policy, inst, enrollDate, paid)));

        Add(cls1, 0, 8900000, 10, "Học viên cũ −10%", 1, 1);
        Add(cls1, 4, 8900000, 0, "Không áp dụng", 1, 1);
        Add(cls1, 5, 8900000, 10, "Đăng ký nhóm −10%", 3, 2);
        Add(cls1, 6, 8900000, 10, "Đăng ký nhóm −10%", 2, 1);
        Add(cls1, 7, 8900000, 10, "Đăng ký nhóm −10%", 1, 1);
        Add(cls1, 8, 8900000, 0, "Không áp dụng", 2, 2);
        Add(cls2, 1, 6500000, 0, "Không áp dụng", 2, 1);
        Add(cls2, 9, 6500000, 0, "Không áp dụng", 1, 1);
        Add(cls2, 10, 6500000, 0, "Không áp dụng", 3, 1);
        Add(cls3, 2, 4800000, 10, "Học viên cũ −10%", 1, 1);
        Add(cls3, 11, 4800000, 0, "Không áp dụng", 1, 1);
        Add(cls4, 3, 11500000, 0, "Không áp dụng", 3, 1);
        Add(cls4, 10, 11500000, 0, "Không áp dụng", 2, 2);

        var absences = new Dictionary<long, int[]>
        {
            [students[5]] = new[] { 2, 5, 9, 12 },
            [students[6]] = new[] { 4, 8, 11, 14, 16 },
            [students[1]] = new[] { 3, 6, 10, 13 },
            [students[4]] = new[] { 7 },
            [students[8]] = new[] { 3, 15 }
        };
        foreach (var (cls, members) in roster)
        {
            var held = sessions[cls].Where(s => s.Date <= today).ToList();
            foreach (var (student, enrollment) in members)
            {
                absences.TryGetValue(student, out var abs);
                for (int i = 0; i < held.Count; i++)
                {
                    int status = abs != null && abs.Contains(i + 1) ? (i % 2 == 0 ? 1 : 2) : 0;
                    Ins("INSERT INTO Attendance(SessionId,StudentId,Status) VALUES(@s,@st,@v)", ("@s", held[i].Id), ("@st", student), ("@v", status));
                }
            }
        }

        var mid = new double[] { 8.5, 7.2, 6.8, 5.5, 4.2, 7.9 };
        var fin = new double?[] { 8.8, 7.8, null, 6.0, 4.0, null };
        for (int i = 0; i < roster[cls1].Count; i++)
            Ins("INSERT INTO Scores(EnrollmentId,Midterm,Final) VALUES(@e,@m,@f)", ("@e", roster[cls1][i].Enrollment), ("@m", mid[i]), ("@f", fin[i]));
        Ins("INSERT INTO Scores(EnrollmentId,Midterm,Final) VALUES(@e,8.0,8.4)", ("@e", 1L));
        Ins("INSERT INTO Scores(EnrollmentId,Midterm,Final) VALUES(@e,6.4,7.0)", ("@e", 2L));

        tx.Commit();
    }
}
