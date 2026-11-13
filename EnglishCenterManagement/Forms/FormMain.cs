using EnglishCenterManagement.Models;
using EnglishCenterManagement.Services;
using EnglishCenterManagement.UI;

namespace EnglishCenterManagement.Forms;

public partial class FormMain : Form
{
    public static FormMain Current { get; private set; }
    public bool LoggedOut { get; private set; }

    private Button activeNav;
    private Form currentPage;
    private bool notificationsRead;
    private int unread = 3;

    public FormMain()
    {
        InitializeComponent();
        Current = this;
    }

    private AppUser User => AppSession.User;

    private Button NavFor(string key) => key switch
    {
        "students" => btnNavStudents,
        "courses" => btnNavCourses,
        "classes" => btnNavClasses,
        "teachers" => btnNavTeachers,
        "schedule" => btnNavSchedule,
        "finance" => btnNavFinance,
        "attendance" => btnNavAttendance,
        "settings" => btnNavSettings,
        _ => btnNavDashboard
    };

    private string KeyOf(Button b) =>
        b == btnNavStudents ? "students" : b == btnNavCourses ? "courses" : b == btnNavClasses ? "classes" :
        b == btnNavTeachers ? "teachers" : b == btnNavSchedule ? "schedule" : b == btnNavFinance ? "finance" :
        b == btnNavAttendance ? "attendance" : b == btnNavSettings ? "settings" : "dashboard";

    private bool Allowed(string key) => key switch
    {
        "students" or "courses" or "teachers" => User.IsAdmin,
        "classes" => !User.IsStudent,
        "finance" => !User.IsTeacher,
        _ => true
    };

    private void FormMain_Load(object sender, EventArgs e)
    {
        lblUserName.Text = User.ShortName;
        lblUserRole.Text = User.RoleDisplay;
        lblToday.Text = Fmt.LongDate(DateTime.Today);
        if (!User.IsAdmin) lblBrandSub.Text = "NORTHSTAR ENGLISH CENTER";
        txtSearch.PlaceholderText = User.IsAdmin ? "Tìm học viên, khóa học, lớp học..."
            : User.IsTeacher ? "Tìm lớp học, lịch dạy, kết quả..." : "Tìm lịch học, học phí, kết quả...";
        unread = DashboardService.Notifications(User).Count;
        LayoutNav();
        Navigate("dashboard");
    }

    public void RefreshProfile()
    {
        lblUserName.Text = User.ShortName;
        lblUserRole.Text = User.RoleDisplay;
        pnlUserAvatar.Invalidate();
    }

    private void LayoutNav()
    {
        int y = btnNavDashboard.Top;
        foreach (var b in new[] { btnNavDashboard, btnNavStudents, btnNavCourses, btnNavClasses, btnNavTeachers, btnNavSchedule, btnNavFinance, btnNavAttendance })
        {
            b.Visible = Allowed(KeyOf(b));
            if (!b.Visible) continue;
            b.Top = y;
            y += 45;
        }
        lblNavSystem.Top = y + 16;
        btnNavSettings.Top = y + 36;
    }

    public Form Navigate(string key)
    {
        if (!Allowed(key)) key = "dashboard";
        Form page = key switch
        {
            "students" => new FormStudents(),
            "courses" => new FormCourses(),
            "classes" => new FormClasses(),
            "teachers" => new FormTeachers(),
            "schedule" => new FormSchedule(),
            "finance" => new FormFinance(),
            "attendance" => new FormAttendance(),
            "settings" => new FormSettings(),
            _ => new FormDashboard()
        };
        pnlContent.SuspendLayout();
        var old = currentPage;
        Ui.Embed(pnlContent, page);
        page.BringToFront();
        currentPage = page;
        if (old != null)
        {
            pnlContent.Controls.Remove(old);
            BeginInvoke(new Action(old.Dispose));
        }
        pnlContent.ResumeLayout();

        var previous = activeNav;
        activeNav = NavFor(key);
        pnlActiveIndicator.Top = activeNav.Top + (activeNav.Height - pnlActiveIndicator.Height) / 2;
        previous?.Invalidate();
        activeNav.Invalidate();
        return page;
    }

    private void Nav_Click(object sender, EventArgs e)
    {
        Navigate(KeyOf((Button)sender));
    }

    private void Nav_Paint(object sender, PaintEventArgs e)
    {
        var b = (Button)sender;
        var g = Ui.Smooth(e.Graphics);
        g.Clear(Ui.Sidebar);
        bool active = b == activeNav;
        bool hover = b.ClientRectangle.Contains(b.PointToClient(Cursor.Position));
        var rect = new RectangleF(0, 0, b.Width - 1, b.Height - 1);
        if (active)
        {
            using var path = Ui.Round(rect, 9);
            using var brush = new System.Drawing.Drawing2D.LinearGradientBrush(rect, Ui.Hex("#207cdd"), Ui.Hex("#2473c6"), 0f);
            g.FillPath(brush, path);
        }
        else if (hover)
        {
            using var path = Ui.Round(rect, 9);
            using var brush = new SolidBrush(Ui.Hex("#1b3858"));
            g.FillPath(brush, path);
        }
        var fore = active ? Color.White : hover ? Ui.Hex("#dce5ef") : b.ForeColor;
        Ui.DrawGlyph(g, (string)b.Tag, new Rectangle(13, 0, 22, b.Height), fore, 11f);
        using var font = new Font(b.Font, active ? FontStyle.Bold : FontStyle.Regular);
        TextRenderer.DrawText(g, b.Text, font, new Rectangle(46, 0, b.Width - 50, b.Height), fore,
            TextFormatFlags.VerticalCenter | TextFormatFlags.NoPrefix | TextFormatFlags.EndEllipsis);
    }

    private void pnlBrandMark_Paint(object sender, PaintEventArgs e)
    {
        var g = Ui.Smooth(e.Graphics);
        g.Clear(pnlSidebar.BackColor);
        var r = new RectangleF(0, 0, pnlBrandMark.Width - 1, pnlBrandMark.Height - 1);
        using var path = Ui.Round(r, 12, 12, 12, 4);
        using var brush = new System.Drawing.Drawing2D.LinearGradientBrush(r, Ui.Hex("#39a4ff"), Ui.Hex("#1a72dc"), 45f);
        g.FillPath(brush, path);
        using var f = new Font("Segoe UI", 15f, FontStyle.Bold | FontStyle.Italic);
        TextRenderer.DrawText(g, "e", f, Rectangle.Round(r), Color.White, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
    }

    private void pnlUpgrade_Paint(object sender, PaintEventArgs e)
    {
        Ui.Card(sender, e, 12, Ui.Hex("#2a4766"));
    }

    private void lblUpgradeIcon_Paint(object sender, PaintEventArgs e)
    {
        var g = Ui.Smooth(e.Graphics);
        g.Clear(pnlUpgrade.BackColor);
        using var path = Ui.Round(new RectangleF(0, 0, lblUpgradeIcon.Width - 1, lblUpgradeIcon.Height - 1), 8);
        using var b = new SolidBrush(Ui.Hex("#28507a"));
        g.FillPath(b, path);
        Ui.DrawGlyph(g, lblUpgradeIcon.Text, lblUpgradeIcon.ClientRectangle, lblUpgradeIcon.ForeColor, 10f);
    }

    private void pnlUser_Paint(object sender, PaintEventArgs e)
    {
        using var pen = new Pen(Ui.Hex("#22405f"));
        e.Graphics.DrawLine(pen, 0, 0, pnlUser.Width, 0);
    }

    private void pnlUserAvatar_Paint(object sender, PaintEventArgs e)
    {
        Ui.AvatarPanel(sender, e, User?.FullName ?? "", 8.5f);
    }

    private void btnSideLogout_Paint(object sender, PaintEventArgs e)
    {
        Ui.Button(sender, e, Ui.Hex("#213853"), Ui.Hex("#a7b6c7"), null, 8);
    }

    private void pnlSidebar_Resize(object sender, EventArgs e)
    {
        pnlUpgrade.Visible = pnlSidebar.Height >= 800;
    }

    private void lblUpgradeLink_Click(object sender, EventArgs e)
    {
        Ui.Toast("EduCenter Pro: báo cáo nâng cao sẽ sớm được mở cho trung tâm của bạn.");
    }

    private void pnlTopbar_Paint(object sender, PaintEventArgs e)
    {
        using var pen = new Pen(Ui.Hex("#e5e9f0"));
        e.Graphics.DrawLine(pen, 0, pnlTopbar.Height - 1, pnlTopbar.Width, pnlTopbar.Height - 1);
    }

    private void pnlSearch_Paint(object sender, PaintEventArgs e)
    {
        Ui.Card(sender, e, 9, Ui.Hex("#e2e6ec"));
    }

    private void lblKbd_Paint(object sender, PaintEventArgs e)
    {
        Ui.Button(sender, e, Color.White, lblKbd.ForeColor, Ui.Hex("#e2e6ec"), 5);
    }

    private void pnlSearch_Click(object sender, EventArgs e)
    {
        txtSearch.Focus();
    }

    private void FormMain_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.Control && e.KeyCode == Keys.K)
        {
            txtSearch.Focus();
            txtSearch.SelectAll();
            e.SuppressKeyPress = true;
        }
    }

    private void txtSearch_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Escape)
        {
            txtSearch.Clear();
            e.SuppressKeyPress = true;
            return;
        }
        if (e.KeyCode != Keys.Enter) return;
        e.SuppressKeyPress = true;
        Search(txtSearch.Text.Trim());
    }

    private void Search(string q)
    {
        if (TrySearchCurrent(currentPage, q)) return;
        var k = q.ToLowerInvariant();
        string target =
            k.Contains("lịch") ? "schedule" :
            k.Contains("phí") || k.Contains("thanh toán") || k.Contains("tài chính") ? "finance" :
            k.Contains("điểm") || k.Contains("kết quả") || k.Contains("chứng nhận") ? "attendance" :
            k.Contains("khóa") ? "courses" :
            k.Contains("giảng viên") || k.Contains("giáo viên") ? "teachers" :
            k.Contains("cài đặt") ? "settings" : null;
        if (target != null && Allowed(target))
        {
            Navigate(target);
            return;
        }
        string fallback = User.IsAdmin ? "students" : User.IsTeacher ? "classes" : "schedule";
        TrySearchCurrent(Navigate(fallback), q);
    }

    private static bool TrySearchCurrent(Form page, string q)
    {
        switch (page)
        {
            case FormStudents p: p.SetSearch(q); return true;
            case FormCourses p: p.SetSearch(q); return true;
            case FormClasses p: p.SetSearch(q); return true;
            case FormTeachers p: p.SetSearch(q); return true;
            default: return false;
        }
    }

    private void btnNotify_Paint(object sender, PaintEventArgs e)
    {
        var g = Ui.Smooth(e.Graphics);
        g.Clear(Color.White);
        bool hover = btnNotify.ClientRectangle.Contains(btnNotify.PointToClient(Cursor.Position));
        var r = new RectangleF(0.5f, 2.5f, 35, 35);
        using (var path = Ui.Round(r, 9))
        {
            using (var b = new SolidBrush(hover ? Ui.Hex("#f5f7fa") : Color.White)) g.FillPath(b, path);
            using (var pen = new Pen(Ui.Hex("#e3e7ed"))) g.DrawPath(pen, path);
        }
        Ui.DrawGlyph(g, (string)btnNotify.Tag, Rectangle.Round(r), Ui.Hex("#526176"), 11f);
        if (!notificationsRead && unread > 0)
        {
            var badge = new RectangleF(btnNotify.Width - 16, 0, 15, 15);
            using (var b = new SolidBrush(Ui.Hex("#f35b61"))) g.FillEllipse(b, badge);
            using (var pen = new Pen(Color.White, 1.5f)) g.DrawEllipse(pen, badge);
            TextRenderer.DrawText(g, unread.ToString(), btnNotify.Font, Rectangle.Round(badge), Color.White,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.NoPadding);
        }
    }

    public void RefreshNotifications()
    {
        unread = DashboardService.Notifications(User).Count;
        btnNotify.Invalidate();
    }

    private void btnNotify_Click(object sender, EventArgs e)
    {
        RefreshNotifications();
        var popup = new FormNotifications(DashboardService.Notifications(User), !notificationsRead);
        var p = btnNotify.PointToScreen(new Point(btnNotify.Width, btnNotify.Height + 8));
        popup.Location = new Point(p.X - popup.Width + 60, p.Y);
        popup.MarkedRead += (_, _) =>
        {
            notificationsRead = true;
            btnNotify.Invalidate();
        };
        popup.Show(this);
    }

    private void pnlDate_Paint(object sender, PaintEventArgs e)
    {
        using var pen = new Pen(Ui.Hex("#e6e9ef"));
        e.Graphics.DrawLine(pen, 0, 2, 0, pnlDate.Height - 2);
    }

    private void pnlProfile_Paint(object sender, PaintEventArgs e)
    {
        var g = e.Graphics;
        g.Clear(Color.White);
        Ui.Avatar(g, new Rectangle(0, 2, 34, 34), User?.FullName ?? "", 8.5f);
        Ui.DrawGlyph(g, Ui.GChevronDown, new Rectangle(38, 0, 18, pnlProfile.Height), Ui.Hex("#8f9baa"), 7f);
    }

    private void Profile_Click(object sender, EventArgs e)
    {
        Navigate("settings");
    }

    private void btnTopLogout_Paint(object sender, PaintEventArgs e)
    {
        Ui.OutlineButton(sender, e);
    }

    private void Logout_Click(object sender, EventArgs e)
    {
        if (!Ui.Confirm("Bạn có chắc muốn đăng xuất khỏi EduCenter?", "Đăng xuất")) return;
        LoggedOut = true;
        AppSession.User = null;
        Close();
    }
}
