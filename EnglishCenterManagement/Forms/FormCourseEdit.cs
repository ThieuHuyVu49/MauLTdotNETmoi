using System.Globalization;
using EnglishCenterManagement.Models;
using EnglishCenterManagement.Services;
using EnglishCenterManagement.UI;

namespace EnglishCenterManagement.Forms;

public partial class FormCourseEdit : Form
{
    private readonly Course course;

    public bool Deleted { get; private set; }

    public FormCourseEdit()
    {
        InitializeComponent();
        course = new Course { Weeks = 12, Sessions = 36 };
    }

    public FormCourseEdit(long id) : this()
    {
        course = CourseService.List().First(c => c.Id == id);
    }

    private bool IsEdit => course.Id != 0;

    private void FormCourseEdit_Load(object sender, EventArgs e)
    {
        Ui.RoundAll(this, 14);
        cboStatus.SelectedItem = course.Status;
        if (cboStatus.SelectedIndex < 0) cboStatus.SelectedIndex = 0;
        string duration = $"{course.Weeks} tuần · {course.Sessions} buổi";
        if (!cboDuration.Items.Contains(duration)) cboDuration.Items.Add(duration);
        cboDuration.SelectedItem = duration;
        if (!IsEdit) return;
        lblHeaderIcon.Text = Ui.GEdit;
        Text = lblHeaderTitle.Text = "Cập nhật khóa học";
        btnSave.Text = "Cập nhật";
        btnDelete.Visible = true;
        lblStatus.Visible = cboStatus.Visible = true;
        ClientSize = new Size(ClientSize.Width, ClientSize.Height + 70);
        Ui.RoundAll(this, 14);
        txtName.Text = course.Name;
        txtCode.Text = course.Code;
        txtFee.Text = course.Fee.ToString("#,0.##", CultureInfo.GetCultureInfo("vi-VN"));
        txtDescription.Text = course.Description;
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        string[] duration = cboDuration.Text.Split(' ');
        int weeks = int.Parse(duration[0], CultureInfo.InvariantCulture);
        int sessions = int.Parse(duration[3], CultureInfo.InvariantCulture);
        if (!double.TryParse(txtFee.Text.Trim(), NumberStyles.Number, CultureInfo.GetCultureInfo("vi-VN"), out double fee) || !double.IsFinite(fee) || fee <= 0)
        {
            Ui.Toast("Học phí phải là số lớn hơn 0 (ví dụ: 8.900.000).", true);
            txtFee.Focus();
            return;
        }
        course.Code = txtCode.Text.Trim();
        course.Name = txtName.Text.Trim();
        course.Weeks = weeks;
        course.Sessions = sessions;
        course.Fee = fee;
        course.Description = txtDescription.Text.Trim();
        course.Status = (string)cboStatus.SelectedItem;
        var err = CourseService.Save(course);
        if (err != null)
        {
            Ui.Toast(err, true);
            return;
        }
        DialogResult = DialogResult.OK;
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        if (!IsEdit || !Ui.Confirm($"Xóa khóa học {course.Name}?", "Xóa khóa học")) return;
        var err = CourseService.Delete(course.Id);
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
