using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Net.Mail;
using EnglishCenterManagement.Models;
using EnglishCenterManagement.Services;
using EnglishCenterManagement.UI;

namespace EnglishCenterManagement.Forms;

public partial class FormSettings : Form
{
    private Image avatarImage;
    private string avatarData = "";
    private Button activeNav;
    private AppUser User => AppSession.User;
    private string Key(string section, string name) => $"{section}_{User.Id}_{name}";

    public FormSettings()
    {
        InitializeComponent();
        activeNav = btnProfile;
    }

    private void FormSettings_Load(object sender, EventArgs e)
    {
        btnRole.Text = User.IsAdmin ? "Trung tâm" : User.IsTeacher ? "Giảng dạy" : "Học tập";
        btnRole.Tag = User.IsAdmin ? Ui.GHome : Ui.GEducation;
        LoadProfile();
        LoadRole();
        foreach (var check in NotificationChecks()) check.Checked = SettingService.GetBool(Key("Notify", (string)check.Tag));
        lblSessionDesc.Text = $"Phiên hiện tại · {DateTime.Now:HH:mm} · EduCenter trên Windows";
    }

    private void LoadProfile()
    {
        txtName.Text = User.FullName;
        txtRole.Text = User.RoleDisplay;
        txtEmail.Text = User.Email;
        txtPhone.Text = User.Phone;
        avatarData = SettingService.Get(Key("Profile", "Avatar"));
        avatarImage?.Dispose();
        avatarImage = null;
        if (avatarData.Length > 0)
        {
            using var stream = new MemoryStream(Convert.FromBase64String(avatarData));
            using var image = Image.FromStream(stream);
            avatarImage = new Bitmap(image);
        }
        pnlAvatar.Invalidate();
    }

    private static void SelectValue(ComboBox combo, string value)
    {
        if (!combo.Items.Contains(value)) combo.Items.Add(value);
        combo.SelectedItem = value;
    }

    private void LoadRole()
    {
        if (User.IsAdmin)
        {
            txtCenterName.Text = SettingService.Get("CenterName", "Trung tâm Anh ngữ Northstar");
            txtCenterPhone.Text = SettingService.Get("CenterPhone", "028 3824 6688");
            txtCenterEmail.Text = SettingService.Get("CenterEmail", "hello@northstar.vn");
            txtCenterAddress.Text = SettingService.Get("CenterAddress", "125 Nguyễn Đình Chiểu, Quận 3, TP.HCM");
            cboTimeZone.SelectedIndex = 0;
            cboCurrency.SelectedIndex = 0;
        }
        else if (User.IsTeacher)
        {
            var teacher = User.TeacherId.HasValue ? TeacherService.Get(User.TeacherId.Value) : null;
            btnTeachingSave.Enabled = teacher != null;
            SelectValue(cboSpecialty, teacher?.Specialty ?? "IELTS");
            numYears.Value = Math.Clamp(teacher?.Years ?? 0, (int)numYears.Minimum, (int)numYears.Maximum);
            txtCertificates.Text = teacher?.Certificates;
            SelectValue(cboAvailability, string.IsNullOrWhiteSpace(teacher?.Availability) ? (string)cboAvailability.Items[0] : teacher.Availability);
            chkAutoSchedule.Checked = SettingService.GetBool(Key("Teach", "AutoSchedule"));
            chkScoreReminder.Checked = SettingService.GetBool(Key("Teach", "ScoreReminder"));
        }
        else
        {
            SelectValue(cboGoal, SettingService.Get(Key("Study", "Goal"), (string)cboGoal.Items[0]));
            SelectValue(cboLevel, SettingService.Get(Key("Study", "Level"), (string)cboLevel.Items[0]));
            txtEmergencyContact.Text = SettingService.Get(Key("Study", "EmergencyContact"));
            txtEmergencyPhone.Text = SettingService.Get(Key("Study", "EmergencyPhone"));
            SelectValue(cboReminder, SettingService.Get(Key("Study", "Reminder"), (string)cboReminder.Items[0]));
            chkEmailMaterials.Checked = SettingService.GetBool(Key("Study", "EmailMaterials"));
            chkWeeklyProgress.Checked = SettingService.GetBool(Key("Study", "WeeklyProgress"));
        }
    }

    private void Nav_Click(object sender, EventArgs e)
    {
        activeNav = (Button)sender;
        var target = activeNav == btnProfile ? pnlProfile : activeNav == btnNotifications ? pnlNotifications
            : activeNav == btnSecurity ? pnlSecurity : User.IsAdmin ? pnlCenter : User.IsTeacher ? pnlTeaching : pnlStudy;
        foreach (var panel in new[] { pnlProfile, pnlCenter, pnlTeaching, pnlStudy, pnlNotifications, pnlSecurity }) panel.Visible = panel == target;
        target.BringToFront();
        foreach (var button in new[] { btnProfile, btnRole, btnNotifications, btnSecurity }) button.Invalidate();
    }

    public void ShowNotificationsTab() => Nav_Click(btnNotifications, EventArgs.Empty);

    private void Cancel_Click(object sender, EventArgs e)
    {
        if (sender == btnProfileCancel) LoadProfile(); else LoadRole();
    }

    private void btnProfileSave_Click(object sender, EventArgs e)
    {
        string error = AuthService.UpdateProfile(User, txtName.Text, txtEmail.Text, txtPhone.Text);
        if (error != null) { Ui.Toast(error, true); return; }
        SettingService.Set(Key("Profile", "Avatar"), avatarData);
        FormMain.Current?.RefreshProfile();
        pnlAvatar.Invalidate();
        Ui.Toast("Đã lưu thông tin cá nhân.");
    }

    private void btnCenterSave_Click(object sender, EventArgs e)
    {
        if (!User.IsAdmin) return;
        if (string.IsNullOrWhiteSpace(txtCenterName.Text) || string.IsNullOrWhiteSpace(txtCenterPhone.Text)
            || string.IsNullOrWhiteSpace(txtCenterAddress.Text) || !MailAddress.TryCreate(txtCenterEmail.Text.Trim(), out _))
        {
            Ui.Toast("Vui lòng nhập đầy đủ thông tin trung tâm và email hợp lệ.", true);
            return;
        }
        SettingService.Set("CenterName", txtCenterName.Text.Trim());
        SettingService.Set("CenterPhone", txtCenterPhone.Text.Trim());
        SettingService.Set("CenterEmail", txtCenterEmail.Text.Trim());
        SettingService.Set("CenterAddress", txtCenterAddress.Text.Trim());
        Ui.Toast("Đã lưu cấu hình trung tâm.");
    }

    private void btnTeachingSave_Click(object sender, EventArgs e)
    {
        if (!User.IsTeacher || !User.TeacherId.HasValue) return;
        var teacher = TeacherService.Get(User.TeacherId.Value);
        teacher.Specialty = cboSpecialty.Text;
        teacher.Years = (int)numYears.Value;
        teacher.Certificates = txtCertificates.Text.Trim();
        teacher.Availability = cboAvailability.Text;
        string error = TeacherService.Save(teacher);
        if (error != null) { Ui.Toast(error, true); return; }
        SettingService.SetBool(Key("Teach", "AutoSchedule"), chkAutoSchedule.Checked);
        SettingService.SetBool(Key("Teach", "ScoreReminder"), chkScoreReminder.Checked);
        Ui.Toast("Đã lưu hồ sơ giảng dạy.");
    }

    private void btnStudySave_Click(object sender, EventArgs e)
    {
        if (!User.IsStudent) return;
        SettingService.Set(Key("Study", "Goal"), cboGoal.Text);
        SettingService.Set(Key("Study", "Level"), cboLevel.Text);
        SettingService.Set(Key("Study", "EmergencyContact"), txtEmergencyContact.Text.Trim());
        SettingService.Set(Key("Study", "EmergencyPhone"), txtEmergencyPhone.Text.Trim());
        SettingService.Set(Key("Study", "Reminder"), cboReminder.Text);
        SettingService.SetBool(Key("Study", "EmailMaterials"), chkEmailMaterials.Checked);
        SettingService.SetBool(Key("Study", "WeeklyProgress"), chkWeeklyProgress.Checked);
        Ui.Toast("Đã lưu cài đặt học tập.");
    }

    private CheckBox[] NotificationChecks() => new[] { chkNotifySchedule, chkNotifyFinance, chkNotifyAttendance, chkNotifyReports };

    private void btnNotificationsSave_Click(object sender, EventArgs e)
    {
        foreach (var check in NotificationChecks()) SettingService.SetBool(Key("Notify", (string)check.Tag), check.Checked);
        FormMain.Current?.RefreshNotifications();
        Ui.Toast("Đã lưu tùy chọn thông báo.");
    }

    private void btnPasswordSave_Click(object sender, EventArgs e)
    {
        string error = AuthService.ChangePassword(User, txtCurrentPassword.Text, txtNewPassword.Text, txtConfirmPassword.Text);
        if (error != null) { Ui.Toast(error, true); return; }
        txtCurrentPassword.Clear();
        txtNewPassword.Clear();
        txtConfirmPassword.Clear();
        Ui.Toast("Đã cập nhật mật khẩu.");
    }

    private void btnAvatar_Click(object sender, EventArgs e)
    {
        using var dialog = new OpenFileDialog { Filter = "Ảnh PNG hoặc JPG|*.png;*.jpg;*.jpeg", Title = "Chọn ảnh đại diện" };
        if (dialog.ShowDialog(this) != DialogResult.OK) return;
        try
        {
            if (new FileInfo(dialog.FileName).Length > 2 * 1024 * 1024) { Ui.Toast("Ảnh phải có dung lượng tối đa 2MB.", true); return; }
            using var original = Image.FromFile(dialog.FileName);
            if (original.RawFormat.Guid != ImageFormat.Png.Guid && original.RawFormat.Guid != ImageFormat.Jpeg.Guid)
            { Ui.Toast("Chỉ chấp nhận ảnh PNG hoặc JPG.", true); return; }
            var image = new Bitmap(128, 128);
            using (var g = Graphics.FromImage(image))
            {
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                int side = Math.Min(original.Width, original.Height);
                g.DrawImage(original, new Rectangle(0, 0, 128, 128), new Rectangle((original.Width - side) / 2, (original.Height - side) / 2, side, side), GraphicsUnit.Pixel);
            }
            using var stream = new MemoryStream();
            image.Save(stream, ImageFormat.Png);
            avatarData = Convert.ToBase64String(stream.ToArray());
            avatarImage?.Dispose();
            avatarImage = image;
            pnlAvatar.Invalidate();
        }
        catch (Exception ex) when (ex is ArgumentException or IOException or OutOfMemoryException)
        { Ui.Toast("Không thể mở ảnh. Vui lòng chọn ảnh PNG hoặc JPG hợp lệ.", true); }
    }

    private void Avatar_Paint(object sender, PaintEventArgs e)
    {
        if (avatarImage == null) { Ui.AvatarPanel(sender, e, User?.FullName ?? "", 13F); return; }
        var g = Ui.Smooth(e.Graphics);
        g.Clear(Color.White);
        using var path = new GraphicsPath();
        path.AddEllipse(pnlAvatar.ClientRectangle);
        g.SetClip(path);
        g.DrawImage(avatarImage, pnlAvatar.ClientRectangle);
        g.ResetClip();
    }

    private void Preference_Click(object sender, EventArgs e)
    {
        string tag = (string)((Control)sender).Tag;
        var check = NotificationChecks().First(c => (string)c.Tag == tag);
        check.Checked = !check.Checked;
    }

    private void Nav_Paint(object sender, PaintEventArgs e)
    {
        var button = (Button)sender;
        bool selected = button == activeNav;
        Ui.Card(sender, e, 7, Color.Empty, selected ? Ui.Hex("#eaf4fd") : Color.White);
        Color fore = selected ? Ui.Primary : Ui.Hex("#788699");
        Ui.DrawGlyph(e.Graphics, (string)button.Tag, new Rectangle(12, 0, 20, button.Height), fore, 10F);
        TextRenderer.DrawText(e.Graphics, button.Text, button.Font, new Rectangle(42, 0, button.Width - 64, button.Height), fore, TextFormatFlags.VerticalCenter | TextFormatFlags.NoPrefix);
        Ui.DrawGlyph(e.Graphics, Ui.GChevronRight, new Rectangle(button.Width - 24, 0, 14, button.Height), fore, 7F);
    }

    private void Section_SizeChanged(object sender, EventArgs e)
    {
        var panel = (Panel)sender;
        int width = (panel.Width - 58) / 2;
        Control left = panel == pnlProfile ? pnlName : panel == pnlCenter ? pnlCenterPhone : panel == pnlTeaching ? cboSpecialty : cboGoal;
        Control right = panel == pnlProfile ? pnlProfileRole : panel == pnlCenter ? pnlCenterEmail : panel == pnlTeaching ? numYears : cboLevel;
        left.Width = width;
        right.SetBounds(37 + width, right.Top, width, right.Height);
        Label rightLabel = panel == pnlProfile ? lblRole : panel == pnlCenter ? lblCenterEmail : panel == pnlTeaching ? lblYears : lblLevel;
        rightLabel.Left = right.Left;
        if (panel == pnlProfile || panel == pnlStudy)
        {
            Control lowerLeft = panel == pnlProfile ? pnlEmail : pnlEmergencyContact;
            Control lowerRight = panel == pnlProfile ? pnlPhone : pnlEmergencyPhone;
            lowerLeft.Width = width;
            lowerRight.SetBounds(right.Left, lowerRight.Top, width, lowerRight.Height);
            (panel == pnlProfile ? lblPhone : lblEmergencyPhone).Left = right.Left;
        }
        if (panel == pnlCenter)
        {
            cboTimeZone.Width = width;
            cboCurrency.SetBounds(right.Left, cboCurrency.Top, width, cboCurrency.Height);
            lblCurrency.Left = right.Left;
        }
    }

    private void Input_Click(object sender, EventArgs e) => ((Control)sender).Controls[0].Focus();
    private void Toggle_CheckedChanged(object sender, EventArgs e) => ((Control)sender).Invalidate();
    private void Toggle_Paint(object sender, PaintEventArgs e) => Ui.Toggle(sender, e);
    private void Combo_DrawItem(object sender, DrawItemEventArgs e) => Ui.ComboItem(sender, e);
    private void Card_Paint(object sender, PaintEventArgs e) => Ui.Card(sender, e);
    private void Section_Paint(object sender, PaintEventArgs e) => Ui.Card(sender, e);
    private void Input_Paint(object sender, PaintEventArgs e) => Ui.Input(sender, e);
    private void Options_Paint(object sender, PaintEventArgs e) => Ui.Card(sender, e, 8, Color.Empty, Ui.Hex("#f8fafc"));
    private void SecurityNote_Paint(object sender, PaintEventArgs e) => Ui.Card(sender, e, 8, Color.Empty, Ui.Hex("#f0f6fb"));
    private void Preference_Paint(object sender, PaintEventArgs e)
    {
        using var pen = new Pen(Ui.Line);
        e.Graphics.DrawLine(pen, 0, ((Control)sender).Height - 1, ((Control)sender).Width, ((Control)sender).Height - 1);
    }
    private void Footer_Paint(object sender, PaintEventArgs e)
    {
        using var pen = new Pen(Ui.Line);
        e.Graphics.DrawLine(pen, 0, 0, ((Control)sender).Width, 0);
    }
    private void Accent_Paint(object sender, PaintEventArgs e) => Ui.AccentButton(sender, e);
    private void Outline_Paint(object sender, PaintEventArgs e) => Ui.OutlineButton(sender, e);
    private void Link_Paint(object sender, PaintEventArgs e) => Ui.Button(sender, e, Color.White, Ui.Primary);
    private void OtherDevices_Paint(object sender, PaintEventArgs e) => Ui.Button(sender, e, Ui.Hex("#f0f6fb"), Ui.Muted);
}
