using System.Globalization;
using EnglishCenterManagement.Models;
using EnglishCenterManagement.Services;
using EnglishCenterManagement.UI;

namespace EnglishCenterManagement.Forms;

public partial class FormFinance : Form
{
    private const int PageSize = 4;
    private List<EnrollmentInfo> data = new();
    private readonly Dictionary<long, List<PaymentInfo>> payments = new();
    private int page = 1;
    private bool loading;

    public FormFinance()
    {
        InitializeComponent();
    }

    private bool IsAdmin => AppSession.User?.IsAdmin == true;
    private long? StudentScope => IsAdmin ? null : AppSession.User?.StudentId ?? 0;
    private int Installments => Math.Max(1, cboPlan.SelectedIndex + 1);
    private int PageCount => Math.Max(1, (data.Count + PageSize - 1) / PageSize);

    private void FormFinance_Load(object sender, EventArgs e)
    {
        btnAdd.Visible = pnlRegistration.Visible = IsAdmin;
        if (!IsAdmin)
        {
            pnlTable.Top = 245;
            AutoScrollMinSize = new Size(0, pnlTable.Bottom + 31);
        }
        if (!IsAdmin && AppSession.User?.IsStudent != true) return;
        if (IsAdmin) LoadChoices();
        LoadData();
    }

    private void LoadChoices()
    {
        long studentId = (cboStudent.SelectedItem as Student)?.Id ?? 0;
        long classId = (cboClass.SelectedItem as ClassInfo)?.Id ?? 0;
        loading = true;
        var students = StudentService.List();
        var classes = ClassService.List(status: "Đang học");
        cboStudent.DisplayMember = nameof(Student.FullName);
        cboStudent.DataSource = students;
        cboClass.DisplayMember = nameof(ClassInfo.FeeOption);
        cboClass.DataSource = classes;
        if (students.Any(s => s.Id == studentId)) cboStudent.SelectedItem = students.First(s => s.Id == studentId);
        if (classes.Any(c => c.Id == classId)) cboClass.SelectedItem = classes.First(c => c.Id == classId);
        if (cboPlan.SelectedIndex < 0) cboPlan.SelectedIndex = 0;
        loading = false;
        UpdateStudentPolicy();
    }

    private void UpdateStudentPolicy()
    {
        var student = cboStudent.SelectedItem as Student;
        bool eligible = student != null && EnrollmentService.IsOldStudent(student.Id);
        chkOldStudent.Enabled = eligible;
        chkOldStudent.Checked = eligible;
        Recalculate();
    }

    private void Recalculate()
    {
        if (loading) return;
        var cls = cboClass.SelectedItem as ClassInfo;
        double fee = cls?.Fee ?? 0;
        var calc = EnrollmentService.Calc(fee, chkOldStudent.Checked && chkOldStudent.Enabled, chkGroup.Checked);
        lblBaseValue.Text = Fmt.Money(fee);
        lblDiscountValue.Text = "−" + Fmt.Money(calc.Discount);
        lblTotalValue.Text = Fmt.Money(calc.Final);
        double each = Math.Round(calc.Final / Installments);
        double last = calc.Final - each * (Installments - 1);
        lblInstallmentNote.Text = Installments == 1
            ? $"Có thể chia 3 kỳ · {Fmt.Money(Math.Round(calc.Final / 3))}/kỳ"
            : last == each ? $"Chia {Installments} kỳ · {Fmt.Money(each)}/kỳ"
            : $"Chia {Installments} kỳ · {Fmt.Money(each)}/kỳ\nKỳ cuối: {Fmt.Money(last)}";
        btnConfirm.Enabled = IsAdmin && cboStudent.SelectedItem is Student && cls != null;
    }

    private void cboStudent_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (!loading) UpdateStudentPolicy();
    }

    private void Calculation_Changed(object sender, EventArgs e) => Recalculate();

    private void LoadData()
    {
        data = EnrollmentService.List(StudentScope);
        payments.Clear();
        foreach (var enrollment in data) payments[enrollment.Id] = EnrollmentService.Payments(enrollment.Id);
        LoadStats();
        page = Math.Min(page, PageCount);
        Bind();
    }

    private void LoadStats()
    {
        var stats = IsAdmin ? EnrollmentService.Stats() : OwnStats(data, payments);
        lblRevenueValue.Text = Fmt.MillionsLong(stats.Revenue);
        double change = stats.LastRevenue > 0 ? (stats.Revenue - stats.LastRevenue) / stats.LastRevenue * 100
            : stats.Revenue > 0 ? 100 : 0;
        string percent = Math.Abs(change).ToString("0.#", CultureInfo.GetCultureInfo("vi-VN"));
        lblRevenueNote.Text = $"{(change < 0 ? "↓" : "↑")} {percent}% so với tháng trước";
        lblRevenueNote.ForeColor = change < 0 ? Ui.Hex("#dc7b39") : Ui.Hex("#35a078");
        lblDebtValue.Text = Fmt.MillionsLong(stats.Debt);
        lblDebtNote.Text = $"{stats.DebtStudents} học viên chưa hoàn tất";
        lblInstallmentsValue.Text = $"{stats.InstallmentStudents} học viên";
        lblInstallmentsNote.Text = $"{stats.InstallmentsLeft} kỳ thanh toán còn lại";
    }

    private static (double Revenue, double LastRevenue, double Debt, long DebtStudents, long InstallmentStudents, long InstallmentsLeft)
        OwnStats(List<EnrollmentInfo> enrollments, Dictionary<long, List<PaymentInfo>> paymentLists)
    {
        var all = paymentLists.Values.SelectMany(p => p).ToList();
        var first = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
        var previous = first.AddMonths(-1);
        var next = first.AddMonths(1);
        double revenue = all.Where(p => p.IsPaid && Fmt.ParseDate(p.PaidDate) >= first && Fmt.ParseDate(p.PaidDate) < next).Sum(p => p.Amount);
        double last = all.Where(p => p.IsPaid && Fmt.ParseDate(p.PaidDate) >= previous && Fmt.ParseDate(p.PaidDate) < first).Sum(p => p.Amount);
        double debt = all.Where(p => !p.IsPaid).Sum(p => p.Amount);
        long debtStudents = enrollments.Where(e => paymentLists[e.Id].Any(p => !p.IsPaid)).Select(e => e.StudentId).Distinct().LongCount();
        var installmentEnrollments = enrollments.Where(e => e.Installments > 1 && paymentLists[e.Id].Any(p => !p.IsPaid)).ToList();
        long installmentStudents = installmentEnrollments.Select(e => e.StudentId).Distinct().LongCount();
        long left = installmentEnrollments.Sum(e => paymentLists[e.Id].LongCount(p => !p.IsPaid));
        return (revenue, last, debt, debtStudents, installmentStudents, left);
    }

    private void Bind()
    {
        dgvEnrollments.Rows.Clear();
        foreach (var enrollment in data.Skip((page - 1) * PageSize).Take(PageSize))
        {
            int i = dgvEnrollments.Rows.Add(enrollment.StudentName, enrollment.ClassName, Fmt.Money(enrollment.FinalFee),
                enrollment.PlanDisplay, Fmt.Money(enrollment.Paid), ActionText(enrollment));
            dgvEnrollments.Rows[i].Tag = enrollment;
        }
        dgvEnrollments.ClearSelection();
        lblPageInfo.Text = $"Trang {page} / {PageCount} · Hiển thị {data.Count} kết quả";
        int start = Math.Max(1, Math.Min(page - 1, PageCount - 2));
        var buttons = new[] { btnPage1, btnPage2, btnPage3 };
        for (int k = 0; k < 3; k++)
        {
            buttons[k].Text = (start + k).ToString();
            buttons[k].Visible = start + k <= PageCount;
            buttons[k].Invalidate();
        }
        btnPrev.Enabled = page > 1;
        btnNext.Enabled = page < PageCount;
        btnPrev.Invalidate();
        btnNext.Invalidate();
    }

    private string ActionText(EnrollmentInfo enrollment)
    {
        var list = payments[enrollment.Id];
        var next = list.FirstOrDefault(p => !p.IsPaid);
        if (IsAdmin && next != null) return $"Thu kỳ {next.InstallmentNo}";
        return list.Any(p => p.IsPaid) ? "In biên lai" : "";
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        if (!IsAdmin) return;
        using var dlg = new FormRegistration();
        if (dlg.ShowDialog(this) != DialogResult.OK) return;
        RegistrationSucceeded(dlg.EnrollmentId);
    }

    private void btnConfirm_Click(object sender, EventArgs e)
    {
        if (!IsAdmin) return;
        if (cboStudent.SelectedItem is not Student student || cboClass.SelectedItem is not ClassInfo cls)
        {
            Ui.Toast("Vui lòng chọn học viên và lớp.", true);
            return;
        }
        btnConfirm.Enabled = false;
        try
        {
            var result = EnrollmentService.Enroll(student.Id, cls.Id, chkOldStudent.Checked && chkOldStudent.Enabled, chkGroup.Checked, Installments);
            if (result.Error != null)
            {
                Ui.Toast(result.Error, true);
                return;
            }
            RegistrationSucceeded(result.Id);
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

    private void RegistrationSucceeded(long enrollmentId)
    {
        page = 1;
        LoadData();
        LoadChoices();
        Ui.Toast("Đã tạo phiếu đăng ký.");
        var first = payments.TryGetValue(enrollmentId, out var list) ? list.FirstOrDefault(p => p.InstallmentNo == 1 && !p.IsPaid) : null;
        if (IsAdmin && first != null && Ui.Confirm("Thu kỳ 1 ngay và in biên lai?")) PayAndPrint(enrollmentId, first.Id);
    }

    private void PayAndPrint(long enrollmentId, long paymentId)
    {
        if (!IsAdmin) return;
        try
        {
            var result = EnrollmentService.Pay(paymentId);
            if (result.Error != null)
            {
                Ui.Toast(result.Error, true);
                LoadData();
                return;
            }
            LoadData();
            Ui.Toast("Đã thu học phí.");
            var enrollment = data.FirstOrDefault(en => en.Id == enrollmentId);
            var payment = payments.TryGetValue(enrollmentId, out var list) ? list.FirstOrDefault(p => p.Id == paymentId && p.IsPaid) : null;
            if (enrollment != null && payment != null) Printing.Receipt(enrollment, payment);
        }
        catch (Exception ex)
        {
            Ui.Toast(ex.Message, true);
        }
    }

    private void dgvEnrollments_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || e.ColumnIndex != colAction.Index) return;
        if (dgvEnrollments.Rows[e.RowIndex].Tag is not EnrollmentInfo enrollment) return;
        if (!IsAdmin && (AppSession.User?.IsStudent != true || enrollment.StudentId != AppSession.User.StudentId)) return;
        var list = EnrollmentService.Payments(enrollment.Id);
        var next = list.FirstOrDefault(p => !p.IsPaid);
        if (IsAdmin && next != null)
        {
            if (Ui.Confirm($"Thu kỳ {next.InstallmentNo} của {enrollment.StudentName}: {Fmt.Money(next.Amount)}?", "Thu học phí"))
                PayAndPrint(enrollment.Id, next.Id);
            return;
        }
        var paid = list.LastOrDefault(p => p.IsPaid);
        if (paid == null) return;
        var current = EnrollmentService.List(StudentScope, enrollment.Id).FirstOrDefault();
        if (current == null) return;
        try { Printing.Receipt(current, paid); }
        catch (Exception ex) { Ui.Toast(ex.Message, true); }
    }

    private void dgvEnrollments_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
    {
        if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
        if (dgvEnrollments.Rows[e.RowIndex].Tag is not EnrollmentInfo enrollment) return;
        if (e.ColumnIndex == colStudent.Index)
            Ui.PersonCell(e, enrollment.StudentName, enrollment.StudentCode, Fmt.Initials(enrollment.StudentName), false);
        else if (e.ColumnIndex == colClass.Index)
            Ui.TextCell(e, enrollment.ClassName, Ui.Hex("#2b3a52"), true);
        else if (e.ColumnIndex == colFee.Index)
            TwoLineCell(e, Fmt.Money(enrollment.FinalFee), enrollment.Policy ?? "Không áp dụng", Ui.Heading,
                enrollment.DiscountPercent > 0 ? Ui.Hex("#25966c") : Ui.Muted);
        else if (e.ColumnIndex == colPlan.Index)
            Ui.TextCell(e, enrollment.PlanDisplay, Ui.Hex("#657489"));
        else if (e.ColumnIndex == colPaid.Index)
            TwoLineCell(e, Fmt.Money(enrollment.Paid), "Còn " + Fmt.Money(enrollment.Remaining), Ui.Hex("#218660"),
                enrollment.Remaining > 0 ? Ui.Hex("#dc7b39") : Ui.Muted);
        else if (e.ColumnIndex == colAction.Index)
        {
            string action = ActionText(enrollment);
            if (action.Length == 0) Ui.TextCell(e, "");
            else Ui.LinkButtonCell(e, action, true);
        }
    }

    private static void TwoLineCell(DataGridViewCellPaintingEventArgs e, string title, string subtitle, Color titleColor, Color subtitleColor)
    {
        Ui.TextCell(e, "");
        var r = e.CellBounds;
        using var bold = new Font("Segoe UI", 9F, FontStyle.Bold);
        using var small = new Font("Segoe UI", 8.25F);
        var flags = TextFormatFlags.EndEllipsis | TextFormatFlags.NoPrefix | TextFormatFlags.NoPadding;
        TextRenderer.DrawText(e.Graphics, title, bold, new Rectangle(r.X + 16, r.Y + r.Height / 2 - 17, r.Width - 24, 18), titleColor, flags);
        TextRenderer.DrawText(e.Graphics, subtitle, small, new Rectangle(r.X + 16, r.Y + r.Height / 2 + 2, r.Width - 24, 16), subtitleColor, flags);
    }

    private void Grid_SizeChanged(object sender, EventArgs e) => Ui.RoundTop((Control)sender, 11);

    private void Page_Click(object sender, EventArgs e)
    {
        page = int.Parse(((Button)sender).Text);
        Bind();
    }

    private void btnPrev_Click(object sender, EventArgs e)
    {
        if (page <= 1) return;
        page--;
        Bind();
    }

    private void btnNext_Click(object sender, EventArgs e)
    {
        if (page >= PageCount) return;
        page++;
        Bind();
    }

    private void Pager_Paint(object sender, PaintEventArgs e)
    {
        var b = (Button)sender;
        Ui.Pager(sender, e, b.Tag == null && b.Text == page.ToString());
    }

    private void Invoice_Paint(object sender, PaintEventArgs e)
    {
        Ui.Gradient(sender, e, Ui.Hex("#173c63"), Ui.Hex("#102d4d"), 12, 145);
        using var pen = new Pen(Color.FromArgb(31, 255, 255, 255));
        e.Graphics.DrawLine(pen, 20, 141, pnlInvoice.Width - 20, 141);
    }

    private void pnlFooter_Paint(object sender, PaintEventArgs e)
    {
        using var pen = new Pen(Ui.Hex("#edf0f4"));
        e.Graphics.DrawLine(pen, 0, 0, pnlFooter.Width, 0);
    }

    private void Primary_Paint(object sender, PaintEventArgs e) => Ui.PrimaryButton(sender, e);
    private void White_Paint(object sender, PaintEventArgs e) => Ui.WhiteButton(sender, e);
    private void Card_Paint(object sender, PaintEventArgs e) => Ui.Card(sender, e);
    private void Policy_Paint(object sender, PaintEventArgs e) => Ui.Card(sender, e, 8, Color.Empty);
    private void Combo_DrawItem(object sender, DrawItemEventArgs e) => Ui.ComboItem(sender, e);
}
