using System.Globalization;
using EnglishCenterManagement.Models;
using EnglishCenterManagement.Services;
using EnglishCenterManagement.UI;

namespace EnglishCenterManagement.Forms;

public partial class FormTeacherEdit : Form
{
    private readonly Teacher teacher;

    public bool Deleted { get; private set; }

    public FormTeacherEdit()
    {
        InitializeComponent();
        teacher = new Teacher { Years = 3 };
    }

    public FormTeacherEdit(long id) : this()
    {
        teacher = TeacherService.Get(id) ?? throw new ArgumentException("Không tìm thấy giảng viên.", nameof(id));
    }

    private bool IsEdit => teacher.Id != 0;

    private void FormTeacherEdit_Load(object sender, EventArgs e)
    {
        Ui.RoundAll(this, 14);
        if (!string.IsNullOrWhiteSpace(teacher.Specialty) && !cboSpecialty.Items.Contains(teacher.Specialty))
            cboSpecialty.Items.Add(teacher.Specialty);
        cboSpecialty.SelectedItem = teacher.Specialty;
        if (cboSpecialty.SelectedIndex < 0) cboSpecialty.SelectedIndex = 0;
        cboStatus.SelectedItem = teacher.Status;
        if (cboStatus.SelectedIndex < 0) cboStatus.SelectedIndex = 0;
        txtYears.Text = teacher.Years.ToString(CultureInfo.InvariantCulture);
        if (!IsEdit) return;
        lblCertificates.Visible = pnlCertificates.Visible = true;
        lblAvailability.Visible = pnlAvailability.Visible = true;
        lblHeaderIcon.Text = Ui.GEdit;
        Text = lblHeaderTitle.Text = "Cập nhật giảng viên";
        btnSave.Text = "Cập nhật";
        btnDelete.Visible = true;
        lblStatus.Visible = cboStatus.Visible = true;
        ClientSize = new Size(ClientSize.Width, 596);
        Ui.RoundAll(this, 14);
        txtName.Text = teacher.FullName;
        txtPhone.Text = teacher.Phone;
        txtEmail.Text = teacher.Email;
        txtCertificates.Text = teacher.Certificates;
        txtAvailability.Text = teacher.Availability;
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        if (!int.TryParse(txtYears.Text.Trim(), NumberStyles.None, CultureInfo.InvariantCulture, out int years) || years < 0)
        {
            Ui.Toast("Số năm kinh nghiệm phải là số nguyên không âm.", true);
            txtYears.Focus();
            return;
        }
        teacher.FullName = txtName.Text.Trim();
        teacher.Phone = txtPhone.Text.Trim();
        teacher.Email = txtEmail.Text.Trim();
        teacher.Specialty = (string)cboSpecialty.SelectedItem;
        teacher.Years = years;
        teacher.Certificates = txtCertificates.Text.Trim();
        teacher.Availability = txtAvailability.Text.Trim();
        teacher.Status = (string)cboStatus.SelectedItem;
        var err = TeacherService.Save(teacher);
        if (err != null)
        {
            Ui.Toast(err, true);
            return;
        }
        DialogResult = DialogResult.OK;
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        if (!IsEdit || !Ui.Confirm($"Xóa giảng viên {teacher.FullName}?", "Xóa giảng viên")) return;
        var err = TeacherService.Delete(teacher.Id);
        if (err != null)
        {
            Ui.Toast(err, true);
            return;
        }
        Deleted = true;
        DialogResult = DialogResult.OK;
    }

    private void btnCancel_Click(object sender, EventArgs e) => DialogResult = DialogResult.Cancel;

    private void Input_Click(object sender, EventArgs e)
    {
        ((Control)sender).Controls[0].Focus();
    }

    private void Dialog_Paint(object sender, PaintEventArgs e)
    {
        using var pen = new Pen(Ui.Hex("#edf0f4"));
        e.Graphics.DrawLine(pen, 0, 80, Width, 80);
        using var border = Ui.Round(new RectangleF(0, 0, Width - 1, Height - 1), 14);
        using var bpen = new Pen(Ui.Hex("#dfe5ec"));
        Ui.Smooth(e.Graphics).DrawPath(bpen, border);
    }

    private void HeaderIcon_Paint(object sender, PaintEventArgs e)
    {
        var l = (Label)sender;
        var g = Ui.Smooth(e.Graphics);
        g.Clear(BackColor);
        using var path = Ui.Round(new RectangleF(0, 0, l.Width - 1, l.Height - 1), 10);
        using var b = new SolidBrush(Ui.Hex((string)l.Tag));
        g.FillPath(b, path);
        Ui.DrawGlyph(g, l.Text, l.ClientRectangle, l.ForeColor, l.Font.SizeInPoints);
    }

    private void pnlFooter_Paint(object sender, PaintEventArgs e)
    {
        using var pen = new Pen(Ui.Hex("#edf0f4"));
        e.Graphics.DrawLine(pen, 0, 0, pnlFooter.Width, 0);
    }

    private void Input_Paint(object sender, PaintEventArgs e) => Ui.Input(sender, e);
    private void Combo_DrawItem(object sender, DrawItemEventArgs e) => Ui.ComboItem(sender, e);
    private void Accent_Paint(object sender, PaintEventArgs e) => Ui.AccentButton(sender, e);
    private void Outline_Paint(object sender, PaintEventArgs e) => Ui.OutlineButton(sender, e);
    private void Danger_Paint(object sender, PaintEventArgs e) => Ui.DangerButton(sender, e);
    private void Soft_Paint(object sender, PaintEventArgs e) => Ui.SoftButton(sender, e);
}
