using EnglishCenterManagement.Models;
using EnglishCenterManagement.Services;
using EnglishCenterManagement.UI;

namespace EnglishCenterManagement.Forms;

public partial class FormSchedule : Form
{
    private DateTime monday = DashboardService.Monday(DateTime.Today);
    private List<SessionInfo> sessions = new();
    private List<SessionInfo> conflicts = new();
    private readonly List<(Rectangle Bounds, SessionInfo Session)> eventBounds = new();
    private bool IsAdmin => AppSession.User?.IsAdmin == true;

    public FormSchedule()
    {
        InitializeComponent();
    }

    private void FormSchedule_Load(object sender, EventArgs e)
    {
        btnAdd.Visible = IsAdmin;
        LoadData();
    }

    private void LoadData()
    {
        var user = AppSession.User;
        sessions = ScheduleService.Range(monday, monday.AddDays(6),
            user?.IsTeacher == true ? user.TeacherId ?? 0 : null,
            user?.IsStudent == true ? user.StudentId ?? 0 : null);
        conflicts = ScheduleService.Conflicts();
        // Do not expose other classes' conflict details to teachers or students.
        if (!IsAdmin)
            conflicts = conflicts.Where(s => user?.IsTeacher == true ? s.TeacherId == user.TeacherId :
                user?.IsStudent == true && ClassService.List(studentId: user.StudentId ?? 0).Any(c => c.Id == s.ClassId)).ToList();
        bool clear = conflicts.Count == 0;
        pnlAlert.BackColor = Ui.Hex(clear ? "#eaf8f2" : "#fff8f2");
        lblAlertTitle.ForeColor = Ui.Hex(clear ? "#218660" : "#87512d");
        lblAlertDetail.ForeColor = Ui.Hex(clear ? "#278460" : "#ad7956");
        lblAlertIcon.ForeColor = Ui.Hex(clear ? "#218660" : "#dc7c3b");
        lblAlertIcon.Tag = clear ? "#d5f1e4" : "#ffe9da";
        lblAlertIcon.Text = clear ? Ui.GCheck : Ui.GWarning;
        lblAlertTitle.Text = clear ? "Lịch học không có xung đột" : $"Phát hiện {conflicts.Count} xung đột lịch học";
        if (clear)
            lblAlertDetail.Text = "Không có phòng hoặc giáo viên bị trùng lịch.";
        else
        {
            var s = conflicts[0];
            lblAlertDetail.Text = $"{s.ClassName} · {s.RoomName} · {s.TeacherName} bị trùng lịch {s.Start}–{s.End}, {Fmt.Date(s.Date)}.";
        }
        btnResolve.Visible = !clear && IsAdmin;
        var end = monday.AddDays(6);
        lblWeek.Text = monday.Month == end.Month && monday.Year == end.Year
            ? $"{monday.Day:00} — {end.Day:00} tháng {end.Month}, {end.Year}"
            : $"{Fmt.Date(monday)} — {Fmt.Date(end)}";
        btnNext.Left = lblWeek.Right + 10;
        var heights = RowHeights();
        pnlCalendar.MinimumSize = new Size(0, 55 + 54 + heights.Sum() + 11);
        pnlCalendar.Height = Math.Max(566, pnlCalendar.MinimumSize.Height);
        eventBounds.Clear();
        pnlAlert.Invalidate(true);
        pnlGrid.Invalidate();
    }

    private static int SlotIndex(SessionInfo s)
    {
        int index = 0;
        for (int i = 0; i < ScheduleService.Slots.Length; i++)
            if (string.CompareOrdinal(s.Start, ScheduleService.SplitSlot(ScheduleService.Slots[i]).Start) >= 0) index = i;
        return index;
    }

    private int[] RowHeights()
    {
        var heights = Enumerable.Repeat(86, ScheduleService.Slots.Length).ToArray();
        foreach (var group in sessions.Where(s => s.Date < monday.AddDays(6)).GroupBy(s => (s.Date.Date, Slot: SlotIndex(s))))
            heights[group.Key.Slot] = Math.Max(heights[group.Key.Slot], group.Count() * 82 + 8);
        return heights;
    }

    private void pnlGrid_Paint(object sender, PaintEventArgs e)
    {
        var g = Ui.Smooth(e.Graphics);
        g.Clear(Color.White);
        eventBounds.Clear();
        const int timeWidth = 96, headerHeight = 54;
        if (pnlGrid.Width <= timeWidth || pnlGrid.Height <= headerHeight) return;
        float dayWidth = (pnlGrid.Width - timeWidth) / 6f;
        var heights = RowHeights();
        float extra = Math.Max(0, pnlGrid.Height - headerHeight - heights.Sum()) / (float)heights.Length;
        using var line = new Pen(Ui.Hex("#edf0f4"));
        using var small = new Font("Segoe UI", 8.25F);
        using var bold = new Font("Segoe UI", 8.25F, FontStyle.Bold);
        using var dayFont = new Font("Segoe UI", 10.5F, FontStyle.Bold);
        const TextFormatFlags flags = TextFormatFlags.NoPadding | TextFormatFlags.NoPrefix | TextFormatFlags.EndEllipsis | TextFormatFlags.SingleLine;
        TextRenderer.DrawText(g, "KHUNG GIỜ", bold, new Rectangle(10, 0, timeWidth - 16, headerHeight), Ui.Muted, flags | TextFormatFlags.VerticalCenter);
        for (int day = 0; day < 6; day++)
        {
            var date = monday.AddDays(day);
            int x = timeWidth + (int)(day * dayWidth);
            int right = timeWidth + (int)((day + 1) * dayWidth);
            if (date.Date == DateTime.Today)
            {
                using var today = new SolidBrush(Ui.Hex("#f2f8fe"));
                g.FillRectangle(today, x, 0, right - x, pnlGrid.Height);
            }
            TextRenderer.DrawText(g, $"T{day + 2}", small, new Rectangle(x, 8, right - x, 17), Ui.Muted, flags | TextFormatFlags.HorizontalCenter);
            TextRenderer.DrawText(g, date.Day.ToString("00"), dayFont, new Rectangle(x, 26, right - x, 23), date.Date == DateTime.Today ? Ui.Primary : Ui.Ink, flags | TextFormatFlags.HorizontalCenter);
            g.DrawLine(line, x, 0, x, pnlGrid.Height);
        }
        float y = headerHeight;
        for (int slot = 0; slot < heights.Length; slot++)
        {
            float height = heights[slot] + extra;
            g.DrawLine(line, 0, y, pnlGrid.Width, y);
            var times = ScheduleService.SplitSlot(ScheduleService.Slots[slot]);
            TextRenderer.DrawText(g, times.Start, bold, new Rectangle(12, (int)y + 16, 74, 18), Ui.Heading, flags);
            TextRenderer.DrawText(g, times.End, small, new Rectangle(12, (int)y + 37, 74, 18), Ui.Muted, flags);
            for (int day = 0; day < 6; day++)
            {
                var events = sessions.Where(s => s.Date.Date == monday.AddDays(day) && SlotIndex(s) == slot).ToList();
                int x = timeWidth + (int)(day * dayWidth) + 7;
                int width = (int)((day + 1) * dayWidth) - (int)(day * dayWidth) - 14;
                if (width < 12) continue;
                for (int i = 0; i < events.Count; i++)
                {
                    var s = events[i];
                    var r = new Rectangle(x, (int)y + 5 + i * 82, width, 76);
                    int color = (int)(s.ClassId % 3);
                    var fore = Ui.Hex(s.Conflict ? "#a34040" : color == 1 ? "#67538e" : color == 2 ? "#9b633c" : "#376182");
                    var fill = Ui.Hex(s.Conflict ? "#ffeded" : color == 1 ? "#f1ecfc" : color == 2 ? "#fff0e5" : "#eaf5fe");
                    var edge = Ui.Hex(s.Conflict ? "#e45454" : color == 1 ? "#805dc4" : color == 2 ? "#dc803d" : "#3185cf");
                    using (var path = Ui.Round(r, 6))
                    using (var brush = new SolidBrush(fill)) g.FillPath(brush, path);
                    using (var pen = new Pen(edge, 3)) g.DrawLine(pen, r.Left + 2, r.Top + 6, r.Left + 2, r.Bottom - 6);
                    TextRenderer.DrawText(g, $"{s.Start}–{s.End}", small, new Rectangle(x + 9, r.Top + 5, width - 15, 15), fore, flags);
                    TextRenderer.DrawText(g, s.ClassName, bold, new Rectangle(x + 9, r.Top + 22, width - 15, 16), fore, flags);
                    TextRenderer.DrawText(g, s.RoomName + (s.Conflict ? " · Trùng lịch" : ""), small, new Rectangle(x + 9, r.Top + 40, width - 15, 15), fore, flags);
                    TextRenderer.DrawText(g, s.TeacherName, small, new Rectangle(x + 9, r.Top + 56, width - 15, 15), fore, flags);
                    eventBounds.Add((r, s));
                }
            }
            y += height;
        }
        g.DrawLine(line, 0, y - 1, pnlGrid.Width, y - 1);
    }

    private void pnlGrid_MouseClick(object sender, MouseEventArgs e)
    {
        if (!IsAdmin || e.Button != MouseButtons.Left) return;
        var s = eventBounds.FirstOrDefault(item => item.Bounds.Contains(e.Location)).Session;
        if (s == null) return;
        if (!Ui.Confirm($"Xóa lịch học {s.ClassName}, {Fmt.Date(s.Date)} ({s.Start}–{s.End})?", "Xóa lịch học")) return;
        var error = ScheduleService.Delete(s.Id);
        if (error != null) { Ui.Toast(error, true); return; }
        LoadData();
        Ui.Toast("Đã xóa lịch học.");
    }

    private void pnlGrid_MouseMove(object sender, MouseEventArgs e) =>
        pnlGrid.Cursor = IsAdmin && eventBounds.Any(item => item.Bounds.Contains(e.Location)) ? Cursors.Hand : Cursors.Default;

    private void btnAdd_Click(object sender, EventArgs e)
    {
        if (!IsAdmin) return;
        using var dlg = new FormScheduleEdit();
        if (dlg.ShowDialog(this) != DialogResult.OK) return;
        LoadData();
        Ui.Toast("Đã xếp lịch học mới.");
    }

    private void btnResolve_Click(object sender, EventArgs e)
    {
        if (!IsAdmin || conflicts.Count == 0) return;
        monday = DashboardService.Monday(conflicts[0].Date);
        LoadData();
        Ui.Toast("Chọn buổi học màu đỏ để xóa lịch bị trùng.");
    }

    private void btnPrev_Click(object sender, EventArgs e) { monday = monday.AddDays(-7); LoadData(); }
    private void btnNext_Click(object sender, EventArgs e) { monday = monday.AddDays(7); LoadData(); }
    private void btnToday_Click(object sender, EventArgs e) { monday = DashboardService.Monday(DateTime.Today); LoadData(); }
    private void pnlGrid_Resize(object sender, EventArgs e) { eventBounds.Clear(); pnlGrid.Invalidate(); }
    private void Primary_Paint(object sender, PaintEventArgs e) => Ui.PrimaryButton(sender, e);
    private void Nav_Paint(object sender, PaintEventArgs e) => Ui.Button(sender, e, Color.White, ((Control)sender).ForeColor, Ui.InputLine, 7);
    private void AlertButton_Paint(object sender, PaintEventArgs e) => Ui.Button(sender, e, pnlAlert.BackColor, Ui.Hex("#bf6931"));
    private void pnlAlert_Paint(object sender, PaintEventArgs e) => Ui.Card(sender, e, 10, Ui.Hex(conflicts.Count == 0 ? "#cde9da" : "#f2d2bc"));
    private void pnlCalendar_Paint(object sender, PaintEventArgs e)
    {
        Ui.Card(sender, e);
        using var pen = new Pen(Ui.Hex("#e9edf2"));
        e.Graphics.DrawLine(pen, 1, 54, pnlCalendar.Width - 2, 54);
    }

    private void AlertIcon_Paint(object sender, PaintEventArgs e)
    {
        var label = (Label)sender;
        Ui.Card(sender, e, 8, Color.Empty, Ui.Hex((string)label.Tag));
        Ui.DrawGlyph(e.Graphics, label.Text, label.ClientRectangle, label.ForeColor, 11);
    }
}
