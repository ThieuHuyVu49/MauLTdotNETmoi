using EnglishCenterManagement.Models;
using EnglishCenterManagement.Services;
using EnglishCenterManagement.UI;

namespace EnglishCenterManagement.Forms;

public partial class FormScheduleEdit : Form
{
    private bool loading;
    private bool ready;

    public FormScheduleEdit()
    {
        InitializeComponent();
    }

    private void FormScheduleEdit_Load(object sender, EventArgs e)
    {
        Ui.RoundAll(this, 14);
        loading = true;
        cboRoom.Items.AddRange(RoomService.List().Cast<object>().ToArray());
        cboTeacher.Items.AddRange(TeacherService.List().Cast<object>().ToArray());
        cboClass.Items.AddRange(ClassService.List(status: "Đang học").Cast<object>().ToArray());
        cboSlot.Items.AddRange(ScheduleService.Slots);
        dtpDate.Value = DateTime.Today;
        if (cboRoom.Items.Count > 0) cboRoom.SelectedIndex = 0;
        if (cboTeacher.Items.Count > 0) cboTeacher.SelectedIndex = 0;
        if (cboClass.Items.Count > 0) cboClass.SelectedIndex = 0;
        if (cboSlot.Items.Count > 0) cboSlot.SelectedIndex = 0;
        ApplyClassDefaults();
        loading = false;
        ready = true;
        CheckSchedule();
    }

    private void ApplyClassDefaults()
    {
        if (cboClass.SelectedItem is not ClassInfo cls) return;
        cboRoom.SelectedItem = cboRoom.Items.Cast<Room>().FirstOrDefault(r => r.Id == cls.RoomId);
        cboTeacher.SelectedItem = cboTeacher.Items.Cast<Teacher>().FirstOrDefault(t => t.Id == cls.TeacherId);
    }

    private void cboClass_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (loading || !ready) return;
        loading = true;
        ApplyClassDefaults();
        loading = false;
        CheckSchedule();
    }

    private void Field_Changed(object sender, EventArgs e)
    {
        if (ready && !loading) CheckSchedule();
    }

    private string CheckSchedule()
    {
        string error;
        if (cboClass.SelectedItem is not ClassInfo cls || cboSlot.SelectedItem is not string slot ||
            cboRoom.SelectedItem is not Room room || cboTeacher.SelectedItem is not Teacher teacher)
            error = "Vui lòng chọn lớp học, khung giờ, phòng học và giảng viên.";
        else
        {
            var (start, end) = ScheduleService.SplitSlot(slot);
            error = ScheduleService.Check(cls.Id, dtpDate.Value.Date, start, end, room.Id, teacher.Id);
        }
        pnlCheck.BackColor = Ui.Hex(error == null ? "#eaf8f2" : "#ffeded");
        lblCheck.ForeColor = lblCheckIcon.ForeColor = Ui.Hex(error == null ? "#278460" : "#c24848");
        lblCheckIcon.Text = error == null ? Ui.GCheck : Ui.GWarning;
        lblCheck.Text = error ?? "Không phát hiện xung đột phòng hoặc giáo viên";
        pnlCheck.Invalidate(true);
        return error;
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        if (AppSession.User?.IsAdmin != true)
        {
            Ui.Toast("Chỉ quản trị viên được xếp lịch học.", true);
            return;
        }
        var error = CheckSchedule();
        if (error != null) { Ui.Toast(error, true); return; }
        error = ScheduleService.Add(((ClassInfo)cboClass.SelectedItem).Id, dtpDate.Value.Date,
            (string)cboSlot.SelectedItem, ((Room)cboRoom.SelectedItem).Id, ((Teacher)cboTeacher.SelectedItem).Id);
        if (error != null)
        {
            CheckSchedule();
            Ui.Toast(error, true);
            return;
        }
        DialogResult = DialogResult.OK;
    }

    private void btnCancel_Click(object sender, EventArgs e) => DialogResult = DialogResult.Cancel;
    private void pnlDate_Click(object sender, EventArgs e) => dtpDate.Focus();
    private void Input_Paint(object sender, PaintEventArgs e) => Ui.Input(sender, e);
    private void Combo_DrawItem(object sender, DrawItemEventArgs e) => Ui.ComboItem(sender, e);
    private void Accent_Paint(object sender, PaintEventArgs e) => Ui.AccentButton(sender, e);
    private void Outline_Paint(object sender, PaintEventArgs e) => Ui.OutlineButton(sender, e);
    private void Soft_Paint(object sender, PaintEventArgs e) => Ui.SoftButton(sender, e);
    private void Check_Paint(object sender, PaintEventArgs e) => Ui.Card(sender, e, 8, Color.Empty);
    private void CheckIcon_Paint(object sender, PaintEventArgs e)
    {
        var label = (Label)sender;
        e.Graphics.Clear(pnlCheck.BackColor);
        Ui.DrawGlyph(e.Graphics, label.Text, label.ClientRectangle, label.ForeColor, 10);
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
        var label = (Label)sender;
        Ui.Card(sender, e, 10, Color.Empty, Ui.Hex((string)label.Tag));
        Ui.DrawGlyph(e.Graphics, label.Text, label.ClientRectangle, label.ForeColor, label.Font.SizeInPoints);
    }

    private void pnlFooter_Paint(object sender, PaintEventArgs e)
    {
        using var pen = new Pen(Ui.Hex("#edf0f4"));
        e.Graphics.DrawLine(pen, 0, 0, pnlFooter.Width, 0);
    }
}
