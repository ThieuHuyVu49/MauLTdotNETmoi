using System.Globalization;

namespace EnglishCenterManagement.Models;

public static class Fmt
{
    private static readonly CultureInfo Vi = new("vi-VN");

    public static string Money(double v) => v.ToString("#,0", Vi) + "đ";
    public static string Number(double v) => v.ToString("#,0", Vi);
    public static string Millions(double v) => (v / 1_000_000).ToString("#,0.#", Vi) + "M";
    public static string MillionsLong(double v) => (v / 1_000_000).ToString("#,0.#", Vi) + " triệu";
    public static string Date(DateTime d) => d.ToString("dd/MM/yyyy");
    public static DateTime ParseDate(string s) => DateTime.ParseExact(s, "yyyy-MM-dd", CultureInfo.InvariantCulture);
    public static string DbDate(DateTime d) => d.ToString("yyyy-MM-dd");

    public static string DayName(DateTime d) => d.DayOfWeek == DayOfWeek.Sunday ? "Chủ nhật" : "Thứ " + ((int)d.DayOfWeek + 1);
    public static string DayShort(int dow) => dow == 8 ? "CN" : "T" + dow;
    public static int Dow(DateTime d) => ((int)d.DayOfWeek + 6) % 7 + 2;
    public static string LongDate(DateTime d) => (d.DayOfWeek == DayOfWeek.Sunday ? "Chủ Nhật" : DayNames[(int)d.DayOfWeek]) + ", " + d.ToString("dd/MM/yyyy");
    private static readonly string[] DayNames = { "Chủ Nhật", "Thứ Hai", "Thứ Ba", "Thứ Tư", "Thứ Năm", "Thứ Sáu", "Thứ Bảy" };

    public static string Initials(string name)
    {
        if (string.IsNullOrWhiteSpace(name)) return "?";
        var parts = name.Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries);
        if (parts.Length == 1) return parts[0][..Math.Min(2, parts[0].Length)].ToUpper();
        return (parts[^2][0].ToString() + parts[^1][0]).ToUpper();
    }
}

public class AppUser
{
    public long Id { get; set; }
    public string Email { get; set; }
    public string FullName { get; set; }
    public string Phone { get; set; }
    public string Role { get; set; }
    public long? TeacherId { get; set; }
    public long? StudentId { get; set; }

    public bool IsAdmin => Role == "admin";
    public bool IsTeacher => Role == "teacher";
    public bool IsStudent => Role == "student";
    public string RoleDisplay => Role switch { "admin" => "Quản trị viên", "teacher" => "Giáo viên", _ => "Học viên" };
    public string ShortName
    {
        get
        {
            var p = (FullName ?? "").Split(' ', StringSplitOptions.RemoveEmptyEntries);
            return p.Length >= 2 ? p[^2] + " " + p[^1] : FullName;
        }
    }
}

public class Course
{
    public long Id { get; set; }
    public string Code { get; set; }
    public string Name { get; set; }
    public int Weeks { get; set; }
    public int Sessions { get; set; }
    public double Fee { get; set; }
    public string Description { get; set; }
    public string Status { get; set; } = "Đang tuyển sinh";
    public int OpenClasses { get; set; }

    public string DurationDisplay => $"{Weeks} tuần · {Sessions} buổi";
    public string FeeDisplay => Fmt.Money(Fee);
    public string OpenDisplay => $"{OpenClasses} lớp đang mở";
    public override string ToString() => Name;
}

public class Teacher
{
    public long Id { get; set; }
    public string FullName { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public string Specialty { get; set; } = "IELTS";
    public int Years { get; set; }
    public string Certificates { get; set; }
    public string Availability { get; set; }
    public string Status { get; set; } = "Đang giảng dạy";
    public int ClassCount { get; set; }
    public int WeeklySessions { get; set; }

    public string SpecialtyDisplay => $"{Specialty} · {Years} năm";
    public string AssignDisplay => $"{ClassCount} lớp phụ trách";
    public string LoadDisplay => $"{WeeklySessions * 2} tiết / tuần";
    public override string ToString() => FullName;
}

public class Room
{
    public long Id { get; set; }
    public string Name { get; set; }
    public int Capacity { get; set; }
    public string Short => Name.Replace("Phòng ", "");
    public override string ToString() => Name;
}

public class Student
{
    public long Id { get; set; }
    public string Code { get; set; }
    public string FullName { get; set; }
    public string BirthDate { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public string Address { get; set; }
    public string Status { get; set; } = "Đang học";
    public string CurrentClass { get; set; }
    public string FeeStatus { get; set; }
    public override string ToString() => FullName;
}

public class ClassInfo
{
    public long Id { get; set; }
    public long CourseId { get; set; }
    public string CourseName { get; set; }
    public double Fee { get; set; }
    public string Name { get; set; }
    public int MaxStudents { get; set; } = 24;
    public long TeacherId { get; set; }
    public string TeacherName { get; set; }
    public long RoomId { get; set; }
    public string RoomName { get; set; }
    public string Status { get; set; } = "Đang học";
    public int StudentCount { get; set; }
    public string Days { get; set; }

    public string DaysDisplay => string.IsNullOrEmpty(Days) ? "Chưa xếp lịch" : string.Join("-", Days.Split(',').Select(d => Fmt.DayShort(int.Parse(d))));
    public string ScheduleDisplay => $"P.{(RoomName ?? "").Replace("Phòng ", "")} · {DaysDisplay}";
    public string SizeDisplay => $"{StudentCount}/{MaxStudents} học viên";
    public string FeeOption => $"{Name} — {Fmt.Money(Fee)}";
    public override string ToString() => Name;
}

public class SessionInfo
{
    public long Id { get; set; }
    public long ClassId { get; set; }
    public string ClassName { get; set; }
    public DateTime Date { get; set; }
    public string Start { get; set; }
    public string End { get; set; }
    public long RoomId { get; set; }
    public string RoomName { get; set; }
    public long TeacherId { get; set; }
    public string TeacherName { get; set; }
    public int No { get; set; }
    public bool Conflict { get; set; }

    public string Display => $"Buổi {No} · {Fmt.Date(Date)}";
    public override string ToString() => Display;
}

public class EnrollmentInfo
{
    public long Id { get; set; }
    public long StudentId { get; set; }
    public string StudentName { get; set; }
    public string StudentCode { get; set; }
    public long ClassId { get; set; }
    public string ClassName { get; set; }
    public string CourseName { get; set; }
    public DateTime EnrollDate { get; set; }
    public double BaseFee { get; set; }
    public double DiscountPercent { get; set; }
    public double FinalFee { get; set; }
    public string Policy { get; set; }
    public int Installments { get; set; }
    public double Paid { get; set; }

    public double Remaining => FinalFee - Paid;
    public string PlanDisplay => Installments <= 1 ? "Một lần" : $"Chia {Installments} kỳ";
}

public class PaymentInfo
{
    public long Id { get; set; }
    public long EnrollmentId { get; set; }
    public int InstallmentNo { get; set; }
    public DateTime DueDate { get; set; }
    public double Amount { get; set; }
    public string PaidDate { get; set; }
    public string ReceiptNo { get; set; }

    public bool IsPaid => !string.IsNullOrEmpty(PaidDate);
    public string Title => $"Kỳ {InstallmentNo}";
    public string DueDisplay => Fmt.Date(DueDate);
    public string AmountDisplay => Fmt.Money(Amount);
    public string StatusText => IsPaid ? "Đã thu" : DueDate < DateTime.Today ? "Quá hạn" : "Chưa thu";
}

public class AttendanceRow
{
    public long StudentId { get; set; }
    public string Code { get; set; }
    public string FullName { get; set; }
    public string Phone { get; set; }
    public int Status { get; set; }
    public int Held { get; set; }
    public int Absent { get; set; }

    public string AttendanceDisplay => $"{Held - Absent}/{Held}";
    public string AbsentDisplay => Absent == 0 ? "0 buổi" : $"{Absent} buổi";
    public bool Warning => Absent > 3;
}

public class ScoreRow
{
    public long EnrollmentId { get; set; }
    public long StudentId { get; set; }
    public string FullName { get; set; }
    public string ClassName { get; set; }
    public string CourseName { get; set; }
    public int Held { get; set; }
    public int Absent { get; set; }
    public double? Midterm { get; set; }
    public double? Final { get; set; }

    public double? Average => Midterm.HasValue && Final.HasValue
        ? Math.Round((Midterm.Value + Final.Value) / 2, 1, MidpointRounding.AwayFromZero)
        : null;
    public bool Passed => Average >= 5;
    public string Result => Average == null ? "Chưa đủ điểm" : Passed ? "Đạt" : "Chưa đạt";
    public string AttendanceDisplay => $"{Held - Absent}/{Held}";
}

public class WarningRow
{
    public long StudentId { get; set; }
    public string FullName { get; set; }
    public string Phone { get; set; }
    public string ClassName { get; set; }
    public int Absent { get; set; }
}

public class TaskItem
{
    public string Title { get; set; }
    public string Tag { get; set; }
    public string Color { get; set; }
    public bool Done { get; set; }
    public string Target { get; set; }
}

public class NotificationItem
{
    public string Title { get; set; }
    public string Detail { get; set; }
    public string Color { get; set; }
    public string Target { get; set; }
}
