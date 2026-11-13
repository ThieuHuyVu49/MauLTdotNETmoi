using EnglishCenterManagement.Models;
using EnglishCenterManagement.Services;
using EnglishCenterManagement.UI;

namespace EnglishCenterManagement.Forms;

public partial class FormStudentDetail : Form
{
    private readonly long studentId;
    private Student student;
    private bool binding;
    private bool changed;

    public FormStudentDetail(long studentId)
    {
        InitializeComponent();
        this.studentId = studentId;
    }

    private bool CanCollect => AppSession.User?.IsAdmin == true;
    private EnrollmentInfo SelectedEnrollment => dgvEnrollments.SelectedRows.Count > 0
        ? dgvEnrollments.SelectedRows[0].Tag as EnrollmentInfo
        : null;

    private void FormStudentDetail_Load(object sender, EventArgs e)
    {
        Ui.RoundAll(this, 14);
        lblPaymentHint.Text = CanCollect ? "Thu tiền theo thứ tự từng kỳ" : "Biên lai các kỳ đã thu";
        LoadData();
    }

    private void LoadData(long? enrollmentId = null)
    {
        student = StudentService.Get(studentId);
        if (student == null)
        {
            Ui.Toast("Không tìm thấy học viên.", true);
            DialogResult = DialogResult.Cancel;
            return;
        }
        lblHeaderTitle.Text = student.FullName;
        lblHeaderSub.Text = $"{student.Code} · Hồ sơ và tình trạng học phí";
        static string V(string value) => string.IsNullOrWhiteSpace(value) ? "—" : value;
        lblContact.Text = $"Điện thoại: {V(student.Phone)} · Email: {V(student.Email)}";
        lblBirth.Text = "Ngày sinh: " + (string.IsNullOrEmpty(student.BirthDate) ? "—" : Fmt.Date(Fmt.ParseDate(student.BirthDate)));
        lblAddress.Text = "Địa chỉ: " + V(student.Address);
        pnlAvatar.Invalidate();
        pnlStatus.Invalidate();

        long? selectedId = enrollmentId ?? SelectedEnrollment?.Id;
        var enrollments = EnrollmentService.List(studentId);
        binding = true;
        try
        {
            dgvEnrollments.Rows.Clear();
            foreach (var en in enrollments)
            {
                int i = dgvEnrollments.Rows.Add(en.ClassName, Fmt.Money(en.FinalFee), en.Policy, en.PlanDisplay,
                    $"Đã thu: {Fmt.Money(en.Paid)} / Còn: {Fmt.Money(en.Remaining)}");
                var row = dgvEnrollments.Rows[i];
                row.Tag = en;
                row.Cells[colClass.Index].ToolTipText = $"{en.ClassName} · {en.CourseName}";
                row.Cells[colPolicy.Index].ToolTipText = en.Policy;
                row.Cells[colBalance.Index].ToolTipText = $"Đã thu: {Fmt.Money(en.Paid)} · Còn lại: {Fmt.Money(en.Remaining)}";
            }
            dgvEnrollments.ClearSelection();
            if (dgvEnrollments.Rows.Count > 0)
            {
                var row = dgvEnrollments.Rows.Cast<DataGridViewRow>().FirstOrDefault(r => ((EnrollmentInfo)r.Tag).Id == selectedId)
                    ?? dgvEnrollments.Rows[0];
                dgvEnrollments.CurrentCell = row.Cells[colClass.Index];
                row.Selected = true;
            }
        }
        finally
        {
            binding = false;
        }
        lblEnrollments.Text = $"Các lớp đăng ký ({enrollments.Count})";
        lblEnrollmentEmpty.Visible = enrollments.Count == 0;
        LoadPayments();
    }

    private void LoadPayments()
    {
        var enrollment = SelectedEnrollment;
        foreach (DataGridViewRow row in dgvEnrollments.Rows)
            row.DefaultCellStyle.BackColor = row.Selected ? Ui.Hex("#f0f7fe") : Color.White;
        dgvEnrollments.Invalidate();
        dgvPayments.Rows.Clear();
        lblPayments.Text = enrollment == null ? "Các kỳ thanh toán" : $"Các kỳ thanh toán · {enrollment.ClassName}";
        if (enrollment != null)
        {
            foreach (var p in EnrollmentService.Payments(enrollment.Id))
            {
                string action = p.IsPaid ? "In biên lai" : CanCollect ? "Thu tiền" : "";
                int i = dgvPayments.Rows.Add(p.Title, p.DueDisplay, p.AmountDisplay, p.StatusText, action);
                dgvPayments.Rows[i].Tag = p;
            }
        }
        dgvPayments.ClearSelection();
        lblPaymentEmpty.Text = enrollment == null ? "Chọn lớp để xem các kỳ thanh toán." : "Chưa có kỳ thanh toán.";
        lblPaymentEmpty.Visible = dgvPayments.Rows.Count == 0;
    }

    private void dgvEnrollments_SelectionChanged(object sender, EventArgs e)
    {
        if (!binding) LoadPayments();
    }

    private void dgvPayments_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || e.ColumnIndex != colPaymentAction.Index || dgvPayments.Rows[e.RowIndex].Tag is not PaymentInfo payment) return;
        long enrollmentId = payment.EnrollmentId;
        long paymentId = payment.Id;
        if (!payment.IsPaid)
        {
            if (!CanCollect) return;
            if (!Ui.Confirm($"Thu {payment.AmountDisplay} cho {payment.Title.ToLower()} của {student.FullName}?", "Thu học phí")) return;
            var result = EnrollmentService.Pay(paymentId);
            if (result.Error != null)
            {
                Ui.Toast(result.Error, true);
                return;
            }
            changed = true;
            LoadData(enrollmentId);
            Ui.Toast("Đã thu học phí và lập biên lai.");
        }
        var enrollment = EnrollmentService.List(enrollmentId: enrollmentId).First();
        var reloadedPayment = EnrollmentService.Payments(enrollmentId).First(p => p.Id == paymentId);
        if (reloadedPayment.IsPaid) Printing.Receipt(enrollment, reloadedPayment);
    }

    private void btnEdit_Click(object sender, EventArgs e)
    {
        using var dlg = new FormStudentEdit(studentId);
        if (dlg.ShowDialog(this) != DialogResult.OK) return;
        changed = true;
        if (dlg.Deleted)
        {
            Ui.Toast("Đã xóa học viên.");
            DialogResult = DialogResult.OK;
            return;
        }
        LoadData();
        Ui.Toast("Đã cập nhật thông tin học viên.");
    }

    private void btnCancel_Click(object sender, EventArgs e) => DialogResult = changed ? DialogResult.OK : DialogResult.Cancel;

    private void dgvEnrollments_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
    {
        if (e.RowIndex < 0 || dgvEnrollments.Rows[e.RowIndex].Tag is not EnrollmentInfo en) return;
        if (e.ColumnIndex == colClass.Index)
            Ui.TextCell(e, en.ClassName, Ui.Hex("#2b3a52"), true);
        else if (e.ColumnIndex == colFee.Index)
            Ui.TextCell(e, Fmt.Money(en.FinalFee), Ui.Hex("#3a4960"), true);
        else if (e.ColumnIndex == colPolicy.Index)
        {
            Ui.TextCell(e, "");
            TextRenderer.DrawText(e.Graphics, en.Policy ?? "Không áp dụng", e.CellStyle.Font,
                Rectangle.Inflate(e.CellBounds, -14, -7), Ui.Hex("#657489"),
                TextFormatFlags.WordBreak | TextFormatFlags.VerticalCenter | TextFormatFlags.EndEllipsis | TextFormatFlags.NoPrefix);
        }
        else if (e.ColumnIndex == colPlan.Index)
            Ui.TextCell(e, en.PlanDisplay);
        else if (e.ColumnIndex == colBalance.Index)
        {
            Ui.TextCell(e, "");
            var r = e.CellBounds;
            using var font = new Font("Segoe UI", 8.25F, FontStyle.Bold);
            var flags = TextFormatFlags.EndEllipsis | TextFormatFlags.NoPrefix | TextFormatFlags.NoPadding;
            TextRenderer.DrawText(e.Graphics, $"Đã thu: {Fmt.Money(en.Paid)}", font,
                new Rectangle(r.X + 16, r.Y + r.Height / 2 - 18, r.Width - 30, 18), Ui.Hex("#218660"), flags);
            TextRenderer.DrawText(e.Graphics, $"Còn: {Fmt.Money(en.Remaining)}", font,
                new Rectangle(r.X + 16, r.Y + r.Height / 2 + 3, r.Width - 30, 18),
                en.Remaining > 0 ? Ui.Hex("#bd6e34") : Ui.Muted, flags);
        }
    }

    private void dgvPayments_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
    {
        if (e.RowIndex < 0 || dgvPayments.Rows[e.RowIndex].Tag is not PaymentInfo p) return;
        if (e.ColumnIndex == colTerm.Index)
            Ui.TextCell(e, p.Title, Ui.Hex("#3a4960"), true);
        else if (e.ColumnIndex == colDue.Index)
            Ui.TextCell(e, p.DueDisplay);
        else if (e.ColumnIndex == colAmount.Index)
            Ui.TextCell(e, p.AmountDisplay, Ui.Hex("#3a4960"), true);
        else if (e.ColumnIndex == colPaymentStatus.Index)
            Ui.BadgeCell(e, p.StatusText);
        else if (e.ColumnIndex == colPaymentAction.Index)
        {
            if (p.IsPaid) Ui.LinkButtonCell(e, "In biên lai", true);
            else if (CanCollect) Ui.LinkButtonCell(e, "Thu tiền", true);
            else Ui.TextCell(e, "");
        }
    }

    private void Avatar_Paint(object sender, PaintEventArgs e) => Ui.AvatarPanel(sender, e, student?.FullName ?? "", 11F);
    private void Status_Paint(object sender, PaintEventArgs e) => Ui.BadgePanel(sender, e, student?.Status);
    private void Grid_SizeChanged(object sender, EventArgs e) => Ui.RoundTop((Control)sender, 11);
    private void Card_Paint(object sender, PaintEventArgs e) => Ui.Card(sender, e);
    private void Accent_Paint(object sender, PaintEventArgs e) => Ui.AccentButton(sender, e);
    private void Outline_Paint(object sender, PaintEventArgs e) => Ui.OutlineButton(sender, e);
    private void Soft_Paint(object sender, PaintEventArgs e) => Ui.SoftButton(sender, e);

    private void Dialog_Paint(object sender, PaintEventArgs e)
    {
        using var pen = new Pen(Ui.Hex("#edf0f4"));
        e.Graphics.DrawLine(pen, 0, 80, Width, 80);
        using var border = Ui.Round(new RectangleF(0, 0, Width - 1, Height - 1), 14);
        using var bpen = new Pen(Ui.Hex("#dfe5ec"));
        Ui.Smooth(e.Graphics).DrawPath(bpen, border);
    }

    private void pnlFooter_Paint(object sender, PaintEventArgs e)
    {
        using var pen = new Pen(Ui.Hex("#edf0f4"));
        e.Graphics.DrawLine(pen, 0, 0, pnlFooter.Width, 0);
    }
}
