using System.Globalization;
using EnglishCenterManagement.Models;
using EnglishCenterManagement.Services;
using EnglishCenterManagement.UI;

namespace EnglishCenterManagement.Forms;

public partial class FormStudentEdit : Form
{
    private readonly Student student;

    public bool Deleted { get; private set; }

    public FormStudentEdit()
    {
        InitializeComponent();
        student = new Student();
    }

    public FormStudentEdit(long id) : this()
    {
        student = StudentService.Get(id);
    }

    private bool IsEdit => student.Id != 0;

    private void FormStudentEdit_Load(object sender, EventArgs e)
    {
        Ui.RoundAll(this, 14);
        cboStatus.SelectedItem = student.Status;
        if (cboStatus.SelectedIndex < 0) cboStatus.SelectedIndex = 0;
        if (!IsEdit) return;
        lblHeaderIcon.Text = Ui.GEdit;
        lblHeaderTitle.Text = "Cập nhật học viên";
        lblHeaderSub.Text = $"Mã học viên {student.Code} · chỉnh sửa hồ sơ hoặc trạng thái học.";
        btnSave.Text = "Cập nhật";
        btnDelete.Visible = true;
        lblStatus.Visible = cboStatus.Visible = true;
        ClientSize = new Size(ClientSize.Width, ClientSize.Height + 70);
        Ui.RoundAll(this, 14);
        txtName.Text = student.FullName;
        txtBirth.Text = string.IsNullOrEmpty(student.BirthDate) ? "" : Fmt.Date(Fmt.ParseDate(student.BirthDate));
        txtPhone.Text = student.Phone;
        txtEmail.Text = student.Email;
        txtAddress.Text = student.Address;
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        string birth = null;
        if (!string.IsNullOrWhiteSpace(txtBirth.Text))
        {
            if (!DateTime.TryParseExact(txtBirth.Text.Trim(), "d/M/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out var d) || d > DateTime.Today)
            {
                Ui.Toast("Ngày sinh không hợp lệ (dd/mm/yyyy).", true);
                txtBirth.Focus();
                return;
            }
            birth = Fmt.DbDate(d);
        }
        student.FullName = txtName.Text;
        student.BirthDate = birth;
        student.Phone = txtPhone.Text;
        student.Email = txtEmail.Text;
        student.Address = txtAddress.Text;
        student.Status = (string)cboStatus.SelectedItem;
        var err = StudentService.Save(student);
        if (err != null)
        {
            Ui.Toast(err, true);
            return;
        }
        DialogResult = DialogResult.OK;
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        if (!Ui.Confirm($"Xóa học viên {student.FullName}?", "Xóa học viên")) return;
        var err = StudentService.Delete(student.Id);
        if (err != null)
        {
            Ui.Toast(err, true);
            return;
        }
        Deleted = true;
        DialogResult = DialogResult.OK;
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.Cancel;
    }

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
