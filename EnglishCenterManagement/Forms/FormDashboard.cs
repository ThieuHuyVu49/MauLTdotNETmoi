using System.Globalization;
using System.Drawing.Drawing2D;
using EnglishCenterManagement.Data;
using EnglishCenterManagement.Models;
using EnglishCenterManagement.Services;
using EnglishCenterManagement.UI;

namespace EnglishCenterManagement.Forms;

public partial class FormDashboard : Form
{
    private readonly Font doneFont;
    private readonly CultureInfo vi = new("vi-VN");
    private List<TaskItem> tasks = new();
    private int rangeIndex;
    private int[] present = new int[7];
    private int[] absent = new int[7];
    private string[] statTargets = { "students", "classes", "teachers", "finance" };
    private AppUser User => AppSession.User;
    // A missing role link must never turn a scoped query into an all-center query.
    private long? TeacherId => User?.IsTeacher == true ? User.TeacherId ?? -1L : null;
    private long? StudentId => User?.IsStudent == true ? User.StudentId ?? -1L : null;

    public FormDashboard()
    {
        InitializeComponent();
        normalTaskFont = lblTask1Title.Font;
        doneFont = new Font(normalTaskFont, FontStyle.Bold | FontStyle.Strikeout);
    }

    private void FormDashboard_Load(object sender, EventArgs e)
    {
        if (User == null) return;
        LoadData();
    }

    private void LoadData()
    {
        var today = DateTime.Today;
        var sessions = ScheduleService.Range(today, today, TeacherId, StudentId);
        string greeting = DateTime.Now.Hour < 12 ? "sáng" : DateTime.Now.Hour < 18 ? "chiều" : "tối";
        lblTitle.Text = $"Chào buổi {greeting}, {User.ShortName} !";
        if (User.IsAdmin)
        {
            lblDesc.Text = "Đây là tình hình hoạt động của trung tâm hôm nay.";
            var finance = EnrollmentService.Stats();
            long teachers = DashboardService.Teachers();
            long scheduled = DashboardService.TeachersWithSessionsThisWeek();
            SetStat(0, "Tổng học viên", Fmt.Number(DashboardService.Students()), $"+{DashboardService.NewStudentsThisMonth()} đăng ký tháng này");
            SetStat(1, "Lớp đang hoạt động", Fmt.Number(DashboardService.ActiveClasses()), "Lớp đang tổ chức học");
            SetStat(2, "Giảng viên", Fmt.Number(teachers), $"{(teachers == 0 ? 0 : scheduled * 100d / teachers).ToString("0.#", vi)}% đang có lịch dạy");
            string change = finance.LastRevenue > 0
                ? ((finance.Revenue - finance.LastRevenue) * 100 / finance.LastRevenue).ToString("+0.#;-0.#;0", vi) + "% so với tháng trước"
                : finance.Revenue == 0 ? "0% so với tháng trước" : "Chưa có thu tháng trước";
            SetStat(3, "Doanh thu tháng", Fmt.Millions(finance.Revenue), change);
            lblStat4Hint.ForeColor = finance.Revenue < finance.LastRevenue ? Ui.Hex("#c24848") : Ui.Hex("#23a478");
        }
        else
        {
            btnWelcome.Text = "Xem lịch hôm nay";
            btnWelcome.Tag = Ui.GCalendar;
            var classes = ClassService.List(teacherId: TeacherId, studentId: StudentId);
            var active = classes.Where(c => c.Status == "Đang học").ToList();
            var monday = DashboardService.Monday(today);
            var week = ScheduleService.Range(monday, monday.AddDays(6), TeacherId, StudentId);
            var scores = classes.SelectMany(c => ScoreService.Roster(c.Id, StudentId)).ToList();
            if (User.IsTeacher)
            {
                int waiting = sessions.Count(s => !HasAttendance(s.Id));
                lblDesc.Text = $"Bạn có {sessions.Count * 2} tiết dạy và {waiting} lớp cần điểm danh hôm nay.";
                statTargets = new[] { "classes", "classes", "schedule", "attendance" };
                SetStat(0, "Học viên phụ trách", Fmt.Number(TeacherStudentCount(TeacherId.Value)), $"Trong {active.Count} lớp đang dạy");
                SetStat(1, "Lớp đang hoạt động", Fmt.Number(active.Count), "Lớp học được phân công");
                SetStat(2, "Tiết dạy tuần này", Fmt.Number(week.Count * 2), $"{week.Count} buổi dạy trong tuần");
                SetStat(3, "Chờ nhập điểm", Fmt.Number(scores.Count(s => s.Average == null)), "Kết quả học tập chưa đủ điểm");
                lblStat3Icon.Text = Ui.GCalendar;
                lblStat4Icon.Text = Ui.GDocument;
            }
            else
            {
                lblDesc.Text = $"Bạn có {sessions.Count} buổi học hôm nay. Theo dõi lịch học, học phí và kết quả của bạn.";
                statTargets = new[] { "schedule", "schedule", "attendance", "finance" };
                var enrollments = EnrollmentService.List(StudentId);
                var averages = scores.Where(s => s.Average.HasValue).Select(s => s.Average.Value).ToList();
                SetStat(0, "Lớp đang học", Fmt.Number(active.Count), $"{enrollments.Count} lớp đã đăng ký");
                SetStat(1, "Buổi học tuần này", Fmt.Number(week.Count), $"{sessions.Count} buổi học hôm nay");
                SetStat(2, "Điểm trung bình", averages.Count == 0 ? "—" : averages.Average().ToString("0.0", vi), averages.Count == 0 ? "Chưa có kết quả học tập" : $"{averages.Count} lớp có đủ điểm");
                double debt = enrollments.Sum(en => Math.Max(0, en.Remaining));
                SetStat(3, "Học phí còn lại", Fmt.Millions(debt), debt == 0 ? "Đã hoàn tất thanh toán" : "Xem các kỳ thanh toán");
                lblStat1Icon.Text = Ui.GEducation;
                lblStat2Icon.Text = Ui.GCalendar;
                lblStat3Icon.Text = Ui.GStar;
            }
        }
        BindSessions(sessions);
        tasks = (User.IsTeacher && !User.TeacherId.HasValue) || (User.IsStudent && !User.StudentId.HasValue)
            ? new List<TaskItem>() : DashboardService.Tasks(User);
        BindTasks();
        LoadChart();
    }

    private void SetStat(int index, string title, string value, string hint)
    {
        var names = new[] { lblStat1Name, lblStat2Name, lblStat3Name, lblStat4Name };
        var values = new[] { lblStat1Value, lblStat2Value, lblStat3Value, lblStat4Value };
        var hints = new[] { lblStat1Hint, lblStat2Hint, lblStat3Hint, lblStat4Hint };
        names[index].Text = title;
        values[index].Text = value;
        hints[index].Text = hint;
    }

    private static bool HasAttendance(long sessionId) => Db.Count("SELECT COUNT(*) FROM Attendance WHERE SessionId=@id",
        new Dictionary<string, object> { ["@id"] = sessionId }) > 0;

    private static long TeacherStudentCount(long teacherId) => Db.Count(@"SELECT COUNT(DISTINCT e.StudentId)
        FROM Enrollments e JOIN Classes c ON c.Id=e.ClassId WHERE c.TeacherId=@id AND c.Status='Đang học'",
        new Dictionary<string, object> { ["@id"] = teacherId });

    private void BindSessions(List<SessionInfo> sessions)
    {
        var panels = new[] { pnlSession1, pnlSession2, pnlSession3, pnlSession4 };
        var starts = new[] { lblSession1Start, lblSession2Start, lblSession3Start, lblSession4Start };
        var ends = new[] { lblSession1End, lblSession2End, lblSession3End, lblSession4End };
        var titles = new[] { lblSession1Title, lblSession2Title, lblSession3Title, lblSession4Title };
        var details = new[] { lblSession1Detail, lblSession2Detail, lblSession3Detail, lblSession4Detail };
        for (int i = 0; i < panels.Length; i++)
        {
            panels[i].Visible = i < sessions.Count;
            if (i >= sessions.Count) continue;
            var session = sessions[i];
            starts[i].Text = session.Start;
            ends[i].Text = session.End;
            titles[i].Text = session.ClassName;
            details[i].Text = $"{session.RoomName} · {session.TeacherName}";
        }
        lblScheduleEmpty.Visible = sessions.Count == 0;
        lblScheduleDesc.Text = $"{DateTime.Today.Day} tháng {DateTime.Today.Month} · {sessions.Count} buổi học"
            + (sessions.Count > panels.Length ? $" · hiển thị {panels.Length}" : "");
    }

    private void BindTasks()
    {
        var panels = new[] { pnlTask1, pnlTask2, pnlTask3, pnlTask4, pnlTask5 };
        var titles = new[] { lblTask1Title, lblTask2Title, lblTask3Title, lblTask4Title, lblTask5Title };
        var tags = new[] { lblTask1Tag, lblTask2Tag, lblTask3Tag, lblTask4Tag, lblTask5Tag };
        var checks = new[] { chkTask1, chkTask2, chkTask3, chkTask4, chkTask5 };
        for (int i = 0; i < panels.Length; i++)
        {
            panels[i].Visible = i < tasks.Count;
            if (i >= tasks.Count) continue;
            titles[i].Text = tasks[i].Title;
            titles[i].Font = tasks[i].Done ? doneFont : normalTaskFont;
            titles[i].ForeColor = tasks[i].Done ? Ui.Hex("#9aa4b1") : Ui.Hex("#3d4a5f");
            tags[i].Text = tasks[i].Tag;
            checks[i].AccessibleName = "Hoàn tất: " + tasks[i].Title;
            checks[i].Checked = tasks[i].Done;
            tags[i].Invalidate();
            checks[i].Invalidate();
        }
        lblTasksEmpty.Visible = tasks.Count == 0;
        tblTasks.Visible = tasks.Count > 0;
        UpdateTaskCount();
    }

    private readonly Font normalTaskFont;

    private void UpdateTaskCount()
    {
        lblTasksDesc.Text = $"{tasks.Count(t => !t.Done)} công việc đang chờ"
            + (tasks.Count > 5 ? " · hiển thị 5 công việc đầu tiên" : "");
    }

    private void LoadChart()
    {
        if (User == null) return;
        var (from, to) = DashboardService.RangeOf(rangeIndex);
        (present, absent) = User.IsAdmin
            ? DashboardService.AttendanceByWeekday(from, to)
            : ScopedAttendance(from, to, TeacherId, StudentId);
        int total = present.Sum() + absent.Sum();
        lblPresentTotal.Text = Fmt.Number(present.Sum());
        lblAttendanceRate.Text = total == 0 ? "—" : (present.Sum() * 100d / total).ToString("0.#", vi) + "%";
        lblChartPeriod.Text = $"{Fmt.Date(from)} — {Fmt.Date(to)}";
        pnlBars.Invalidate();
        foreach (var button in new[] { btnWeek, btnMonth, btnQuarter }) button.Invalidate();
    }

    private static (int[] Present, int[] Absent) ScopedAttendance(DateTime from, DateTime to, long? teacherId, long? studentId)
    {
        var p = new int[7];
        var a = new int[7];
        foreach (var row in Db.Query(@"SELECT x.SessionDate, (at.Status>0) AS Abs, COUNT(*) AS N
            FROM Attendance at JOIN Sessions x ON x.Id=at.SessionId
            WHERE x.SessionDate BETWEEN @from AND @to AND (@teacher IS NULL OR x.TeacherId=@teacher)
            AND (@student IS NULL OR at.StudentId=@student) GROUP BY x.SessionDate, Abs",
            r => (Date: Fmt.ParseDate(r.Str("SessionDate")), Absent: r.Long("Abs"), Count: (int)r.Long("N")),
            new Dictionary<string, object> { ["@from"] = Fmt.DbDate(from), ["@to"] = Fmt.DbDate(to), ["@teacher"] = teacherId, ["@student"] = studentId }))
        {
            int i = Fmt.Dow(row.Date) - 2;
            if (row.Absent == 0) p[i] += row.Count; else a[i] += row.Count;
        }
        return (p, a);
    }

    private void btnWelcome_Click(object sender, EventArgs e)
    {
        if (User == null) return;
        if (!User.IsAdmin) { FormMain.Current?.Navigate("schedule"); return; }
        using var dialog = new FormStudentEdit();
        if (dialog.ShowDialog(this) == DialogResult.OK)
        {
            LoadData();
            Ui.Toast("Đã thêm học viên mới.");
        }
    }

    private void Stat_Click(object sender, EventArgs e)
    {
        int i = sender == btnStat1 ? 0 : sender == btnStat2 ? 1 : sender == btnStat3 ? 2 : 3;
        FormMain.Current?.Navigate(statTargets[i]);
    }

    private void Schedule_Click(object sender, EventArgs e) => FormMain.Current?.Navigate("schedule");

    private void Range_Click(object sender, EventArgs e)
    {
        rangeIndex = sender == btnWeek ? 0 : sender == btnMonth ? 1 : 2;
        LoadChart();
    }

    private void TaskTitle_Click(object sender, EventArgs e)
    {
        int i = int.Parse((string)((Control)sender).Tag);
        if (i < tasks.Count) FormMain.Current?.Navigate(tasks[i].Target);
    }

    private void Task_CheckedChanged(object sender, EventArgs e)
    {
        var check = (CheckBox)sender;
        int i = int.Parse((string)check.Tag);
        if (i >= tasks.Count) return;
        tasks[i].Done = check.Checked;
        var titles = new[] { lblTask1Title, lblTask2Title, lblTask3Title, lblTask4Title, lblTask5Title };
        titles[i].Font = check.Checked ? doneFont : normalTaskFont;
        titles[i].ForeColor = check.Checked ? Ui.Hex("#9aa4b1") : Ui.Hex("#3d4a5f");
        check.Invalidate();
        UpdateTaskCount();
    }

    private void pnlBars_Paint(object sender, PaintEventArgs e)
    {
        var g = Ui.Smooth(e.Graphics);
        g.Clear(Color.White);
        var area = new Rectangle(32, 29, Math.Max(1, pnlBars.Width - 43), Math.Max(1, pnlBars.Height - 52));
        int peak = present.Concat(absent).DefaultIfEmpty(0).Max();
        int step = Math.Max(1, (int)Math.Ceiling(peak / 4d));
        int maximum = step * 4;
        using var axisFont = new Font("Segoe UI", 7.5F);
        using var gridPen = new Pen(Ui.Hex("#eef1f5"));
        for (int i = 0; i <= 4; i++)
        {
            int y = area.Bottom - area.Height * i / 4;
            g.DrawLine(gridPen, area.Left, y, area.Right, y);
            TextRenderer.DrawText(g, (step * i).ToString(), axisFont, new Rectangle(0, y - 8, 25, 16), Ui.Hex("#a2acb8"), TextFormatFlags.Right | TextFormatFlags.NoPadding);
        }
        float groupWidth = area.Width / 7f;
        float barWidth = Math.Min(15, groupWidth * .18f);
        for (int i = 0; i < 7; i++)
        {
            float center = area.Left + (i + .5f) * groupWidth;
            DrawBar(g, new RectangleF(center - barWidth - 2, area.Bottom - area.Height * present[i] / (float)maximum, barWidth, area.Height * present[i] / (float)maximum), true);
            DrawBar(g, new RectangleF(center + 2, area.Bottom - area.Height * absent[i] / (float)maximum, barWidth * .8f, area.Height * absent[i] / (float)maximum), false);
            TextRenderer.DrawText(g, Fmt.DayShort(i + 2), axisFont, new Rectangle((int)(center - groupWidth / 2), area.Bottom + 5, (int)groupWidth, 17), Ui.Hex("#8995a5"), TextFormatFlags.HorizontalCenter | TextFormatFlags.NoPadding);
        }
        int legendX = Math.Max(32, pnlBars.Width - 181);
        using (var blue = new SolidBrush(Ui.Hex("#2985d9"))) g.FillEllipse(blue, legendX, 8, 6, 6);
        TextRenderer.DrawText(g, "Có mặt", axisFont, new Point(legendX + 12, 3), Ui.Hex("#7f8b9b"));
        using (var pale = new SolidBrush(Ui.Hex("#c6ddef"))) g.FillEllipse(pale, legendX + 89, 8, 6, 6);
        TextRenderer.DrawText(g, "Vắng học", axisFont, new Point(legendX + 101, 3), Ui.Hex("#7f8b9b"));
        if (peak == 0)
            TextRenderer.DrawText(g, "Chưa có dữ liệu điểm danh trong kỳ này", axisFont, area, Ui.Muted, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
    }

    private static void DrawBar(Graphics g, RectangleF rect, bool isPresent)
    {
        if (rect.Height <= 0 || rect.Width <= 0) return;
        using var path = Ui.Round(rect, Math.Min(3, rect.Height / 2), Math.Min(3, rect.Height / 2), 1, 1);
        if (isPresent)
        {
            using var brush = new LinearGradientBrush(rect, Ui.Hex("#4ca1ed"), Ui.Hex("#287dcc"), 90F);
            g.FillPath(brush, path);
        }
        else
        {
            using var brush = new SolidBrush(Ui.Hex("#c7def0"));
            g.FillPath(brush, path);
        }
    }

    private void Chart_SizeChanged(object sender, EventArgs e) => pnlBars.Invalidate();
    private void Range_Paint(object sender, PaintEventArgs e)
    {
        int index = sender == btnWeek ? 0 : sender == btnMonth ? 1 : 2;
        Ui.Button(sender, e, index == rangeIndex ? Color.White : Ui.Hex("#f0f3f6"), index == rangeIndex ? Ui.Primary : Ui.Muted, null, 5);
    }

    private void Icon_Paint(object sender, PaintEventArgs e)
    {
        var label = (Label)sender;
        Ui.Card(sender, e, 10, Color.Empty, Ui.Hex((string)label.Tag));
        Ui.DrawGlyph(e.Graphics, label.Text, label.ClientRectangle, label.ForeColor, label.Font.SizeInPoints);
    }

    private void TaskCheck_Paint(object sender, PaintEventArgs e)
    {
        var check = (CheckBox)sender;
        Ui.Card(sender, e, 5, check.Checked ? Ui.Hex("#35a97a") : Ui.Hex("#d3d9e2"), check.Checked ? Ui.Hex("#35a97a") : Color.White);
        if (check.Checked) Ui.DrawGlyph(e.Graphics, Ui.GCheck, check.ClientRectangle, Color.White, 8F);
    }

    private void TaskTag_Paint(object sender, PaintEventArgs e)
    {
        var label = (Label)sender;
        int i = int.Parse((string)label.Tag);
        string color = i < tasks.Count ? tasks[i].Color : "blue";
        var (fore, back) = color switch
        {
            "orange" => (Ui.Hex("#c77638"), Ui.Hex("#fff0e5")),
            "purple" => (Ui.Hex("#785eba"), Ui.Hex("#f0eafa")),
            "green" => (Ui.Hex("#288b65"), Ui.Hex("#e4f6ed")),
            _ => (Ui.Hex("#327ebd"), Ui.Hex("#e9f4fd"))
        };
        Ui.Card(sender, e, 4, Color.Empty, back);
        TextRenderer.DrawText(e.Graphics, label.Text, label.Font, label.ClientRectangle, fore, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.NoPadding);
    }

    private void Separator_Paint(object sender, PaintEventArgs e)
    {
        using var pen = new Pen(Ui.Hex("#edf0f4"));
        e.Graphics.DrawLine(pen, 0, 0, ((Control)sender).Width, 0);
    }

    private void Card_Paint(object sender, PaintEventArgs e) => Ui.Card(sender, e);
    private void RangeCard_Paint(object sender, PaintEventArgs e) => Ui.Card(sender, e, 7, Color.Empty);
    private void Primary_Paint(object sender, PaintEventArgs e) => Ui.PrimaryButton(sender, e);
    private void Soft_Paint(object sender, PaintEventArgs e) => Ui.SoftButton(sender, e);
    private void Link_Paint(object sender, PaintEventArgs e) => Ui.Button(sender, e, Color.White, Ui.Primary);
}
