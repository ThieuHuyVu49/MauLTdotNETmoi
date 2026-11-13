using EnglishCenterManagement.Models;
using EnglishCenterManagement.Services;
using EnglishCenterManagement.UI;

namespace EnglishCenterManagement.Forms;

public partial class FormClassEdit : Form
{
    private readonly ClassInfo classInfo;

    public bool Deleted { get; private set; }

    public FormClassEdit()
    {
        InitializeComponent();
        classInfo = new ClassInfo();
    }

    public FormClassEdit(long id) : this()
    {
        classInfo = ClassService.List().First(c => c.Id == id);
    }

    private bool IsEdit => classInfo.Id != 0;

    private void FormClassEdit_Load(object sender, EventArgs e)
    {
        Ui.RoundAll(this, 14);
        if (AppSession.User?.IsAdmin != true)
        {
            Ui.Toast("Chỉ quản trị viên được thêm, sửa hoặc xóa lớp học.", true);
            DialogResult = DialogResult.Cancel;
            return;
        }

        cboCourse.Items.AddRange(CourseService.List().ToArray());
        cboTeacher.Items.AddRange(TeacherService.List().ToArray());
        cboRoom.Items.AddRange(RoomService.List().ToArray());
        cboStatus.SelectedItem = classInfo.Status;
        if (cboStatus.SelectedIndex < 0) cboStatus.SelectedIndex = 0;

        if (!IsEdit)
        {
            if (cboCourse.Items.Count > 0) cboCourse.SelectedIndex = 0;
            if (cboTeacher.Items.Count > 0) cboTeacher.SelectedIndex = 0;
            if (cboRoom.Items.Count > 0)
                cboRoom.SelectedItem = cboRoom.Items.Cast<Room>().FirstOrDefault(r => r.Capacity >= numSize.Value) ?? cboRoom.Items[0];
            return;
        }

        lblHeaderIcon.Text = Ui.GEdit;
        lblHeaderTitle.Text = "Cập nhật lớp học";
        lblHeaderSub.Text = "Chỉnh sửa thông tin lớp và phân công giảng viên.";
        btnSave.Text = "Cập nhật";
        btnDelete.Visible = true;
        lblStatus.Visible = cboStatus.Visible = true;
        ClientSize = new Size(ClientSize.Width, ClientSize.Height + 70);
        Ui.RoundAll(this, 14);
        txtName.Text = classInfo.Name;
        numSize.Value = Math.Clamp(classInfo.MaxStudents, (int)numSize.Minimum, (int)numSize.Maximum);
        cboCourse.SelectedItem = cboCourse.Items.Cast<Course>().FirstOrDefault(c => c.Id == classInfo.CourseId);
        cboTeacher.SelectedItem = cboTeacher.Items.Cast<Teacher>().FirstOrDefault(t => t.Id == classInfo.TeacherId);
        cboRoom.SelectedItem = cboRoom.Items.Cast<Room>().FirstOrDefault(r => r.Id == classInfo.RoomId);
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        if (AppSession.User?.IsAdmin != true) return;
        classInfo.CourseId = (cboCourse.SelectedItem as Course)?.Id ?? 0;
        classInfo.Name = txtName.Text;
        classInfo.MaxStudents = (int)numSize.Value;
        classInfo.TeacherId = (cboTeacher.SelectedItem as Teacher)?.Id ?? 0;
        classInfo.RoomId = (cboRoom.SelectedItem as Room)?.Id ?? 0;
        classInfo.Status = (string)cboStatus.SelectedItem;
        var err = ClassService.Save(classInfo);
        if (err != null)
        {
            Ui.Toast(err, true);
            return;
        }
        DialogResult = DialogResult.OK;
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        if (AppSession.User?.IsAdmin != true || !IsEdit) return;
        if (!Ui.Confirm($"Xóa lớp học {classInfo.Name}?", "Xóa lớp học")) return;
        var err = ClassService.Delete(classInfo.Id);
        if (err != null)
        {
            Ui.Toast(err, true);
            return;
        }
        Deleted = true;
        DialogResult = DialogResult.OK;
    }

    private void btnCancel_Click(object sender, EventArgs e) => DialogResult = DialogResult.Cancel;
    private void Input_Click(object sender, EventArgs e) => ((Control)sender).Controls[0].Focus();

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
