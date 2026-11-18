using System.Drawing.Drawing2D;
using EnglishCenterManagement.Models;
using EnglishCenterManagement.Services;
using EnglishCenterManagement.UI;

namespace EnglishCenterManagement.Forms;

public partial class FormLogin : Form
{
    private readonly string role = "admin";
    private bool registerMode;

    public AppUser User { get; private set; }

    public FormLogin()
    {
        InitializeComponent();
    }

    public FormLogin(string role) : this()
    {
        this.role = role;
    }

    private string DemoEmail => role + "@northstar.vn";

    private void FormLogin_Load(object sender, EventArgs e)
    {
        lblTitle.Text = "Đăng nhập " + AuthService.RoleName(role);
        switch (role)
        {
            case "teacher":
                lblIntro.Text = "Xem lịch dạy, điểm danh và cập nhật kết quả học tập của lớp phụ trách.";
                lblRoleIcon.Text = Ui.GEducation;
                lblRoleIcon.ForeColor = Ui.Hex("#7a5bbb");
                lblRoleIcon.Tag = "#f0ebfc";
                break;
            case "student":
                lblIntro.Text = "Theo dõi lịch học, học phí và kết quả học tập của bạn tại trung tâm.";
                lblRoleIcon.Text = Ui.GContact;
                lblRoleIcon.ForeColor = Ui.Hex("#dc7b39");
                lblRoleIcon.Tag = "#fff0e4";
                break;
        }
        lblDemo.Text = $"Tài khoản demo: {DemoEmail} · Mật khẩu: 12345678";
        txtEmail.Text = SettingService.Get("LastEmail_" + role, DemoEmail);
        txtPassword.Text = "12345678";
        SetMode(false);
    }

    private void SetMode(bool register)
    {
        registerMode = register;
        pnlGroupName.Visible = register;
        pnlGroupConfirm.Visible = register;
        pnlOptions.Visible = !register;
        lblDemo.Visible = !register;
        btnSubmit.Text = register ? "Tạo tài khoản  →" : "Đăng nhập  →";
        lblTitle.Text = (register ? "Đăng ký " : "Đăng nhập ") + AuthService.RoleName(role);
        if (register)
        {
            txtName.Clear();
            txtEmail.Clear();
            txtPassword.Clear();
            txtConfirm.Clear();
        }
        var shown = register
            ? new Control[] { pnlGroupName, pnlGroupEmail, pnlGroupPassword, pnlGroupConfirm, btnSubmit }
            : new Control[] { pnlGroupEmail, pnlGroupPassword, pnlOptions, btnSubmit, lblDemo };
        Ui.Stack(pnlForm, shown);
        pnlCard.Height = pnlForm.Top + pnlForm.Height + 26;
        btnTabLogin.Invalidate();
        btnTabRegister.Invalidate();
        FormLogin_Resize(this, EventArgs.Empty);
        (register ? txtName : txtEmail).Focus();
    }

    private void FormLogin_Resize(object sender, EventArgs e)
    {
        pnlCard.Location = new Point(Math.Max(0, (ClientSize.Width - pnlCard.Width) / 2), Math.Max(72, (ClientSize.Height - pnlCard.Height) / 2));
        Invalidate();
    }

    private void FormLogin_Paint(object sender, PaintEventArgs e)
    {
        var g = Ui.Smooth(e.Graphics);
        void Glow(Rectangle r, Color c)
        {
            using var path = new GraphicsPath();
            path.AddEllipse(r);
            using var b = new PathGradientBrush(path) { CenterColor = c, SurroundColors = new[] { Color.FromArgb(0, c) } };
            g.FillEllipse(b, r);
        }
        Glow(new Rectangle(-260, -260, 760, 760), Color.FromArgb(70, 196, 224, 252));
        Glow(new Rectangle(ClientSize.Width - 520, ClientSize.Height - 520, 820, 820), Color.FromArgb(60, 214, 232, 250));
    }

    private void pnlCard_Paint(object sender, PaintEventArgs e)
    {
        Ui.Card(sender, e, 18, Ui.Hex("#e3e8ef"));
    }

    private void pnlBrandMark_Paint(object sender, PaintEventArgs e)
    {
        var g = Ui.Smooth(e.Graphics);
        g.Clear(Color.White);
        var r = new RectangleF(0, 0, pnlBrandMark.Width - 1, pnlBrandMark.Height - 1);
        using var path = Ui.Round(r, 11, 11, 11, 4);
        using var brush = new LinearGradientBrush(r, Ui.Hex("#39a4ff"), Ui.Hex("#1a72dc"), 45f);
        g.FillPath(brush, path);
        using var f = new Font("Segoe UI", 13f, FontStyle.Bold | FontStyle.Italic);
        TextRenderer.DrawText(g, "e", f, Rectangle.Round(r), Color.White, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
    }

    private void lblRoleIcon_Paint(object sender, PaintEventArgs e)
    {
        var g = Ui.Smooth(e.Graphics);
        g.Clear(Color.White);
        using var path = Ui.Round(new RectangleF(0, 0, lblRoleIcon.Width - 1, lblRoleIcon.Height - 1), 12);
        using var b = new SolidBrush(Ui.Hex((string)lblRoleIcon.Tag));
        g.FillPath(b, path);
        Ui.DrawGlyph(g, lblRoleIcon.Text, lblRoleIcon.ClientRectangle, lblRoleIcon.ForeColor, 14f);
    }

    private void pnlTabs_Paint(object sender, PaintEventArgs e)
    {
        Ui.Card(sender, e, 9, Color.Empty);
    }

    private void Tab_Paint(object sender, PaintEventArgs e)
    {
        bool active = (sender == btnTabRegister) == registerMode;
        if (active) Ui.Button(sender, e, Color.White, Ui.Hex("#287dc6"), Ui.Hex("#e3e8ef"), 7);
        else Ui.Button(sender, e, pnlTabs.BackColor, Ui.Hex("#6b778a"), null, 7);
    }

    private void btnTabLogin_Click(object sender, EventArgs e)
    {
        if (!registerMode) return;
        SetMode(false);
        txtEmail.Text = SettingService.Get("LastEmail_" + role, DemoEmail);
        txtPassword.Text = "12345678";
    }

    private void btnTabRegister_Click(object sender, EventArgs e)
    {
        if (role == "admin")
        {
            Ui.Toast("Tài khoản quản trị viên chỉ được cấp bởi trung tâm.", true);
            return;
        }
        if (!registerMode) SetMode(true);
    }

    private void Input_Paint(object sender, PaintEventArgs e)
    {
        Ui.Input(sender, e);
    }

    private void Input_Click(object sender, EventArgs e)
    {
        ((Control)sender).Controls.OfType<TextBox>().FirstOrDefault()?.Focus();
    }

    private void lblShowPassword_Click(object sender, EventArgs e)
    {
        bool show = txtPassword.UseSystemPasswordChar;
        txtPassword.UseSystemPasswordChar = !show;
        txtConfirm.UseSystemPasswordChar = !show;
        lblShowPassword.Text = show ? "Ẩn" : "Hiện";
    }

    private void lblForgot_Click(object sender, EventArgs e)
    {
        Ui.Toast("Vui lòng liên hệ quản trị viên trung tâm (028 3824 6688) để đặt lại mật khẩu.");
    }

    private void btnBack_Paint(object sender, PaintEventArgs e)
    {
        Ui.Button(sender, e, Color.White, btnBack.ForeColor, Ui.Hex("#e2e7ed"), 9);
    }

    private void btnBack_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.Retry;
    }

    private void btnSubmit_Paint(object sender, PaintEventArgs e)
    {
        Ui.Button(sender, e, Ui.Hex("#237dca"), Color.White, null, 9);
    }

    private void lblDemo_Paint(object sender, PaintEventArgs e)
    {
        var g = Ui.Smooth(e.Graphics);
        g.Clear(Color.White);
        using (var path = Ui.Round(new RectangleF(0.5f, 0.5f, lblDemo.Width - 1.5f, lblDemo.Height - 1.5f), 9))
        {
            using (var b = new SolidBrush(Ui.Hex("#f2f7fb"))) g.FillPath(b, path);
            using (var pen = new Pen(Ui.Hex("#dbe9f5"))) g.DrawPath(pen, path);
        }
        Ui.DrawGlyph(g, Ui.GInfo, new Rectangle(10, 0, 22, lblDemo.Height), Ui.Hex("#2b7fc7"), 10f);
        TextRenderer.DrawText(g, lblDemo.Text, lblDemo.Font, new Rectangle(38, 0, lblDemo.Width - 46, lblDemo.Height), lblDemo.ForeColor,
            TextFormatFlags.VerticalCenter | TextFormatFlags.WordBreak | TextFormatFlags.NoPrefix);
    }

    private void btnSubmit_Click(object sender, EventArgs e)
    {
        string error;
        AppUser user;
        if (registerMode)
        {
            if (txtPassword.Text != txtConfirm.Text)
            {
                Ui.Toast("Xác nhận mật khẩu không khớp.", true);
                return;
            }
            (error, user) = AuthService.Register(txtName.Text, txtEmail.Text, txtPassword.Text, role);
        }
        else
        {
            (error, user) = AuthService.Login(txtEmail.Text, txtPassword.Text, role);
        }
        if (error != null)
        {
            Ui.Toast(error, true);
            return;
        }
        if (registerMode || chkRemember.Checked) SettingService.Set("LastEmail_" + role, user.Email);
        User = user;
        DialogResult = DialogResult.OK;
    }
}
