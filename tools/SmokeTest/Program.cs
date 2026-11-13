using EnglishCenterManagement.Data;
using EnglishCenterManagement.Models;
using EnglishCenterManagement.Services;

if (args.Contains("--ui")) return UiChecks.Run();

if (File.Exists(Db.DbPath)) File.Delete(Db.DbPath);
Db.Init();
int fail = 0;
void Check(string name, bool ok)
{
    Console.WriteLine((ok ? "PASS " : "FAIL ") + name);
    if (!ok) fail++;
}

Check("admin login", AuthService.Login("admin@northstar.vn", "12345678", "admin").User?.IsAdmin == true);
Check("wrong role rejected", AuthService.Login("admin@northstar.vn", "12345678", "teacher").Error != null);
Check("wrong password rejected", AuthService.Login("admin@northstar.vn", "x", "admin").Error != null);

var (p1, d1, f1) = EnrollmentService.Calc(8_900_000, true, false);
Check("old student 10% → 8.010.000đ", p1 == 10 && d1 == 890_000 && f1 == 8_010_000);
var (p2, _, f2) = EnrollmentService.Calc(8_900_000, true, true);
Check("old + group 20% → 7.120.000đ", p2 == 20 && f2 == 7_120_000);

var classes = ClassService.List(status: "Đang học");
Check("4 active classes", classes.Count == 4);
var ielts = classes.First(c => c.Name == "IELTS Foundation 03");
Check("schedule display P.201 · T2-T4-T6", ielts.ScheduleDisplay == "P.201 · T2-T4-T6");

var sessions = ScheduleService.OfClass(ielts.Id);
var s0 = sessions[0];
var other = classes.First(c => c.Id != ielts.Id);
Check("room conflict detected",
    ScheduleService.Check(other.Id, s0.Date, s0.Start, s0.End, s0.RoomId, other.TeacherId)?.StartsWith("Trùng phòng") == true);
Check("teacher conflict detected",
    ScheduleService.Check(other.Id, s0.Date, s0.Start, s0.End, other.RoomId, s0.TeacherId)?.StartsWith("Trùng lịch giáo viên") == true);
Check("free slot passes", ScheduleService.Check(other.Id, s0.Date, "19:45", "21:15", other.RoomId, other.TeacherId) == null);

var warnings = AttendanceService.Warnings();
Check("attendance warnings (> 3 absences) exist", warnings.Count > 0 && warnings.All(w => w.Absent > 3));

var students = StudentService.List();
var newbie = new Student { FullName = "Kiểm Thử", Phone = "0900000000" };
Check("student saved", StudentService.Save(newbie) == null && newbie.Id > 0);
Check("old-student discount refused for newcomer", EnrollmentService.Enroll(newbie.Id, ielts.Id, true, false, 1).Error != null);
var (err, eid) = EnrollmentService.Enroll(newbie.Id, ielts.Id, false, true, 3);
Check("enroll with group discount, 3 installments", err == null && eid > 0);
var pays = EnrollmentService.Payments(eid);
Check("3 installments sum to final fee", pays.Count == 3 && pays.Sum(p => p.Amount) == 8_010_000);
Check("must pay in order", EnrollmentService.Pay(pays[1].Id).Error != null);
Check("pay installment 1", EnrollmentService.Pay(pays[0].Id).Error == null);
Check("duplicate enrollment refused", EnrollmentService.Enroll(newbie.Id, ielts.Id, false, false, 1).Error != null);

var held = sessions.Last(s => s.Date <= DateTime.Today);
var roster = AttendanceService.Roster(held.Id);
Check("roster includes new student", roster.Any(r => r.StudentId == newbie.Id));
roster.First(r => r.StudentId == newbie.Id).Status = 2;
Check("attendance saved", AttendanceService.Save(held.Id, roster) == null);
var future = sessions.FirstOrDefault(s => s.Date > DateTime.Today);
if (future != null) Check("future session blocked", AttendanceService.Save(future.Id, AttendanceService.Roster(future.Id)) != null);

var scores = ScoreService.Roster(ielts.Id);
var mine = scores.First(s => s.StudentId == newbie.Id);
mine.Midterm = 7.5; mine.Final = 8;
Check("scores saved", ScoreService.Save(new[] { mine }) == null);
Check("average 7.8 + Đạt", ScoreService.Roster(ielts.Id, newbie.Id)[0] is { Average: 7.8, Result: "Đạt" });
mine.Final = 11;
Check("score > 10 rejected", ScoreService.Save(new[] { mine }) != null);

Check("dashboard tasks load", DashboardService.Tasks(AppSession.User = AuthService.Login("admin@northstar.vn", "12345678", "admin").User) != null);
Check("notifications = 3", DashboardService.Notifications(AppSession.User).Count == 3);
Check("course list", CourseService.List().Count == 4 && students.Count == 12);

Check("teacher login", AuthService.Login("teacher@northstar.vn", "12345678", "teacher").User?.IsTeacher == true);
Check("student login", AuthService.Login("student@northstar.vn", "12345678", "student").User?.IsStudent == true);
Check("invalid email rejected", AuthService.Register("Test", "not-email", "12345678", "student").Error != null);
Check("duplicate email rejected", AuthService.Register("Test", "admin@northstar.vn", "12345678", "student").Error != null);
Check("Sunday scheduling rejected", ScheduleService.Check(other.Id, DashboardService.Monday(DateTime.Today).AddDays(6), "08:00", "09:30", other.RoomId, other.TeacherId) != null);
Check("reversed interval rejected", ScheduleService.Check(other.Id, DashboardService.Monday(DateTime.Today), "10:00", "09:30", other.RoomId, other.TeacherId) != null);
Check("enrolled student cannot be deleted", StudentService.Delete(newbie.Id) != null);
Check("enrolled class cannot be deleted", ClassService.Delete(ielts.Id) != null);
Check("used course cannot be deleted", CourseService.Delete(ielts.CourseId) != null);
Check("assigned teacher cannot be deleted", TeacherService.Delete(ielts.TeacherId) != null);
Check("invalid installment count rejected", EnrollmentService.Enroll(newbie.Id, other.Id, false, false, 4).Error != null);
Check("duplicate payment rejected", EnrollmentService.Pay(pays[0].Id).Error != null);
Check("student now qualifies for returning discount", EnrollmentService.IsOldStudent(newbie.Id));
Check("discount rounding keeps final amount", EnrollmentService.Calc(8_900_001, true, true).Final == 7_120_001);

var temporaryCourse = new Course { Code = "UI-TEMP", Name = "Khóa kiểm thử", Weeks = 4, Sessions = 12, Fee = 1_000_000 };
Check("create course", CourseService.Save(temporaryCourse) == null && temporaryCourse.Id > 0);
temporaryCourse.Fee = 1_200_000;
Check("update course", CourseService.Save(temporaryCourse) == null && CourseService.List("UI-TEMP")[0].Fee == 1_200_000);
Check("delete unused course", CourseService.Delete(temporaryCourse.Id) == null && CourseService.List("UI-TEMP").Count == 0);

var latestSessions = sessions.Where(s => s.Date <= DateTime.Today).TakeLast(4).ToList();
foreach (var session in latestSessions)
{
    var attendance = AttendanceService.Roster(session.Id);
    attendance.First(r => r.StudentId == newbie.Id).Status = 2;
    AttendanceService.Save(session.Id, attendance);
}
Check("four absences trigger warning", AttendanceService.Warnings(ielts.Id).Any(w => w.StudentId == newbie.Id && w.Absent >= 4));
mine.Midterm = 4; mine.Final = 6;
ScoreService.Save(new[] { mine });
Check("average 5 passes", ScoreService.Roster(ielts.Id, newbie.Id)[0].Passed);
mine.Final = null;
ScoreService.Save(new[] { mine });
Check("incomplete scores have no average", ScoreService.Roster(ielts.Id, newbie.Id)[0].Average == null);

Console.WriteLine(fail == 0 ? "ALL PASSED" : $"{fail} FAILED");
return fail;
