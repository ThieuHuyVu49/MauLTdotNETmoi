using EnglishCenterManagement.Models;
using EnglishCenterManagement.Services;
using EnglishCenterManagement.UI;

namespace EnglishCenterManagement.Forms;

public partial class FormRegistration : Form
{
    private bool loading;
    private bool oldStudentEligible;

    public long EnrollmentId { get; private set; }

    public FormRegistration()
    {
        InitializeComponent();
    }

    private bool OldStudent => oldStudentEligible && (cboPolicy.SelectedIndex == 1 || cboPolicy.SelectedIndex == 3);
    private bool Group => cboPolicy.SelectedIndex == 2 || cboPolicy.SelectedIndex == 3;
    private int Installments => Math.Max(1, cboPlan.SelectedIndex + 1);

    private void FormRegistration_Load(object sender, EventArgs e)
    {
        Ui.RoundAll(this, 14);
        if (AppSession.User?.IsAdmin != true)
        {
            Ui.Toast("Chỉ quản trị viên được tạo phiếu đăng ký.", true);
            DialogResult = DialogResult.Cancel;
            return;
        }
        loading = true;
        cboStudent.DisplayMember = nameof(Student.FullName);
        cboStudent.DataSource = StudentService.List();
        cboClass.DisplayMember = nameof(ClassInfo.FeeOption);
        cboClass.DataSource = ClassService.List(status: "Đang học");
        cboPlan.SelectedIndex = 0;
        loading = false;
        UpdateStudentPolicy();
    }

    private void UpdateStudentPolicy()
    {
        var student = cboStudent.SelectedItem as Student;
        oldStudentEligible = student != null && EnrollmentService.IsOldStudent(student.Id);
        bool group = Group;
        cboPolicy.SelectedIndex = oldStudentEligible ? (group ? 3 : 1) : (group ? 2 : 0);
        cboPolicy.Invalidate();
        Recalculate();
    }

    private void Recalculate()
    {
        if (loading) return;
        var cls = cboClass.SelectedItem as ClassInfo;
        double fee = cls?.Fee ?? 0;
        var calc = EnrollmentService.Calc(fee, OldStudent, Group);
        lblBaseValue.Text = Fmt.Money(fee);
        lblDiscountValue.Text = "−" + Fmt.Money(calc.Discount);
        lblFinalValue.Text = Fmt.Money(calc.Final);
        double each = Math.Round(calc.Final / Installments);
        double last = calc.Final - each * (Installments - 1);
        lblInstallmentNote.Text = Installments == 1 ? "Thanh toán một lần khi thu học phí."
            : last == each ? $"Chia {Installments} kỳ · {Fmt.Money(each)}/kỳ"
            : $"Chia {Installments} kỳ · {Fmt.Money(each)}/kỳ · Kỳ cuối {Fmt.Money(last)}";
        btnSave.Enabled = AppSession.User?.IsAdmin == true && cboStudent.SelectedItem is Student && cls != null;
    }

    private void cboStudent_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (!loading) UpdateStudentPolicy();
    }

    private void Calculation_Changed(object sender, EventArgs e) => Recalculate();

    private void cboPolicy_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (loading) return;
        if (!oldStudentEligible && (cboPolicy.SelectedIndex == 1 || cboPolicy.SelectedIndex == 3))
        {
            cboPolicy.SelectedIndex = cboPolicy.SelectedIndex == 3 ? 2 : 0;
            Ui.Toast("Học viên chưa từng học tại trung tâm nên không được ưu đãi học viên cũ.", true);
            return;
        }
        Recalculate();
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        if (AppSession.User?.IsAdmin != true) return;
        if (cboStudent.SelectedItem is not Student student || cboClass.SelectedItem is not ClassInfo cls)
        {
            Ui.Toast("Vui lòng chọn học viên và lớp.", true);
            return;
        }
        btnSave.Enabled = false;
        try
        {
            var result = EnrollmentService.Enroll(student.Id, cls.Id, OldStudent, Group, Installments);
            if (result.Error != null)
            {
                Ui.Toast(result.Error, true);
                return;
            }
            EnrollmentId = result.Id;
            DialogResult = DialogResult.OK;
        }
        catch (Exception ex)
        {
            Ui.Toast(ex.Message, true);
        }
        finally
        {
            if (!IsDisposed) Recalculate();
        }
    }

    private void btnCancel_Click(object sender, EventArgs e) => DialogResult = DialogResult.Cancel;

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
        using var brush = new SolidBrush(Ui.Hex("#eaf5fe"));
        g.FillPath(brush, path);
        Ui.DrawGlyph(g, l.Text, l.ClientRectangle, l.ForeColor, l.Font.SizeInPoints);
    }

    private void Summary_Paint(object sender, PaintEventArgs e)
    {
        Ui.Card(sender, e, 9, Color.Empty);
        using var pen = new Pen(Ui.Hex("#dfe9f2"));
        e.Graphics.DrawLine(pen, 16, 98, pnlSummary.Width - 16, 98);
    }

    private void pnlFooter_Paint(object sender, PaintEventArgs e)
    {
        using var pen = new Pen(Ui.Hex("#edf0f4"));
        e.Graphics.DrawLine(pen, 0, 0, pnlFooter.Width, 0);
    }

    private void Policy_DrawItem(object sender, DrawItemEventArgs e)
    {
        Ui.ComboItem(sender, e);
        if (e.Index < 0 || oldStudentEligible || (e.Index != 1 && e.Index != 3)) return;
        using var brush = new SolidBrush(cboPolicy.BackColor);
        e.Graphics.FillRectangle(brush, e.Bounds);
        TextRenderer.DrawText(e.Graphics, cboPolicy.GetItemText(cboPolicy.Items[e.Index]), cboPolicy.Font,
            new Rectangle(e.Bounds.X + 6, e.Bounds.Y, e.Bounds.Width - 8, e.Bounds.Height), Ui.Muted,
            TextFormatFlags.VerticalCenter | TextFormatFlags.EndEllipsis | TextFormatFlags.NoPrefix);
    }

    private void Combo_DrawItem(object sender, DrawItemEventArgs e) => Ui.ComboItem(sender, e);
    private void Accent_Paint(object sender, PaintEventArgs e) => Ui.AccentButton(sender, e);
    private void Outline_Paint(object sender, PaintEventArgs e) => Ui.OutlineButton(sender, e);
    private void Soft_Paint(object sender, PaintEventArgs e) => Ui.SoftButton(sender, e);
}
