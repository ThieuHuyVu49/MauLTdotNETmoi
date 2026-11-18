using System.Globalization;
using EnglishCenterManagement.Models;
using EnglishCenterManagement.Services;
using EnglishCenterManagement.UI;

namespace EnglishCenterManagement.Forms;

public partial class FormAttendance : Form
{
    private const int PageSize = 4;
    private List<AttendanceRow> attendance = new();
    private List<ScoreRow> scores = new();
    private List<WarningRow> warnings = new();
    private bool loading;
    private bool binding;
    private bool ready;
    private bool resultsTab;
    private int page = 1;
    private long classId;
    private long sessionId;
    private bool CanEdit => AppSession.User?.IsAdmin == true || AppSession.User?.IsTeacher == true;
    private long? StudentFilter => AppSession.User?.IsStudent == true ? AppSession.User.StudentId ?? 0 : null;
    private int RowCount => resultsTab ? scores.Count : attendance.Count;
    private int PageCount => Math.Max(1, (RowCount + PageSize - 1) / PageSize);

    public FormAttendance()
    {
        InitializeComponent();
    }

    private void FormAttendance_Load(object sender, EventArgs e)
    {
        loading = true;
        var user = AppSession.User;
        cboClass.Items.AddRange(ClassService.List(
            teacherId: user?.IsTeacher == true ? user.TeacherId ?? 0 : null,
            studentId: StudentFilter).Cast<object>().ToArray());
        if (cboClass.Items.Count > 0) cboClass.SelectedIndex = 0;
        dgvScores.ReadOnly = !CanEdit;
        colMidterm.ReadOnly = colFinal.ReadOnly = !CanEdit;
        dgvAttendance.Cursor = CanEdit ? Cursors.Hand : Cursors.Default;
        loading = false;
        ready = true;
        LoadClass();
    }

    private void LoadClass()
    {
        classId = (cboClass.SelectedItem as ClassInfo)?.Id ?? 0;
        loading = true;
        cboSession.Items.Clear();
        var sessions = classId == 0 ? new List<SessionInfo>() : ScheduleService.OfClass(classId);
        cboSession.Items.AddRange(sessions.Cast<object>().ToArray());
        long defaultId = AttendanceService.DefaultSession(sessions);
        cboSession.SelectedItem = sessions.FirstOrDefault(s => s.Id == defaultId);
        sessionId = (cboSession.SelectedItem as SessionInfo)?.Id ?? 0;
        loading = false;
        LoadRosters();
        LoadWarnings();
        page = 1;
        Bind();
    }

    private void LoadRosters()
    {
        attendance = sessionId == 0 ? new List<AttendanceRow>() : AttendanceService.Roster(sessionId);
        if (StudentFilter.HasValue) attendance = attendance.Where(r => r.StudentId == StudentFilter.Value).ToList();
        scores = classId == 0 ? new List<ScoreRow>() : ScoreService.Roster(classId, StudentFilter);
    }

    private void LoadWarnings()
    {
        warnings = classId == 0 ? new List<WarningRow>() : AttendanceService.Warnings(classId);
        if (StudentFilter.HasValue) warnings = warnings.Where(w => w.StudentId == StudentFilter.Value).ToList();
        pnlWarning.Visible = warnings.Count > 0;
        btnReception.Visible = CanEdit;
        lblWarning.Text = $"{warnings.Count} học viên cần chú ý — vắng quá 3 buổi. Lễ tân cần liên hệ nhắc nhở.";
        int bottom = pnlTable.Bottom;
        int gap = pnlWarning.Top - pnlToolbar.Bottom;
        pnlTable.Top = (warnings.Count > 0 ? pnlWarning.Bottom : pnlToolbar.Bottom) + gap;
        pnlTable.Height = Math.Max(220, bottom - pnlTable.Top);
        pnlWarning.Invalidate(true);
    }

    private void Bind()
    {
        binding = true;
        try
        {
            page = Math.Min(page, PageCount);
            dgvAttendance.Visible = !resultsTab;
            dgvScores.Visible = resultsTab;
            btnSave.Visible = CanEdit;
            btnSave.Enabled = resultsTab ? classId != 0 && scores.Count > 0 : sessionId != 0 && attendance.Count > 0;
            btnSave.Text = resultsTab ? "Lưu điểm" : "Lưu điểm danh";
            cboSession.Enabled = !resultsTab && cboSession.Items.Count > 0;
            btnAttendance.Invalidate();
            btnResults.Invalidate();
            btnSave.Invalidate();
            if (resultsTab)
            {
                dgvScores.Rows.Clear();
                foreach (var row in scores.Skip((page - 1) * PageSize).Take(PageSize))
                {
                    int i = dgvScores.Rows.Add(row.FullName, row.AttendanceDisplay,
                        row.Midterm?.ToString(CultureInfo.InvariantCulture), row.Final?.ToString(CultureInfo.InvariantCulture),
                        ScoreText(row.Average), row.Result, "Chứng nhận");
                    dgvScores.Rows[i].Tag = row;
                }
                dgvScores.ClearSelection();
                dgvScores.BringToFront();
                Ui.RoundTop(dgvScores, 11);
            }
            else
            {
                dgvAttendance.Rows.Clear();
                foreach (var row in attendance.Skip((page - 1) * PageSize).Take(PageSize))
                {
                    int i = dgvAttendance.Rows.Add(row.FullName, row.Phone, row.AttendanceDisplay,
                        row.AbsentDisplay, AttendanceService.Statuses[row.Status]);
                    dgvAttendance.Rows[i].Tag = row;
                }
                dgvAttendance.ClearSelection();
                dgvAttendance.BringToFront();
                Ui.RoundTop(dgvAttendance, 11);
            }
            lblPageInfo.Text = $"Trang {page} / {PageCount} · Hiển thị {RowCount} kết quả";
            int start = Math.Max(1, Math.Min(page - 1, PageCount - 2));
            var buttons = new[] { btnPage1, btnPage2, btnPage3 };
            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i].Text = (start + i).ToString();
                buttons[i].Visible = start + i <= PageCount;
                buttons[i].Invalidate();
            }
        }
        finally { binding = false; }
    }

    private void cboClass_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (loading || !ready) return;
        if (!EndScoreEdit())
        {
            loading = true;
            cboClass.SelectedItem = cboClass.Items.Cast<ClassInfo>().FirstOrDefault(c => c.Id == classId);
            loading = false;
            return;
        }
        LoadClass();
    }

    private void cboSession_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (loading || !ready) return;
        sessionId = (cboSession.SelectedItem as SessionInfo)?.Id ?? 0;
        attendance = sessionId == 0 ? new List<AttendanceRow>() : AttendanceService.Roster(sessionId);
        if (StudentFilter.HasValue) attendance = attendance.Where(r => r.StudentId == StudentFilter.Value).ToList();
        page = 1;
        Bind();
    }

    private bool EndScoreEdit()
    {
        if (!resultsTab) return true;
        if (dgvScores.IsCurrentCellInEditMode && dgvScores.CurrentCell != null)
        {
            var cell = dgvScores.CurrentCell;
            if ((cell.ColumnIndex == colMidterm.Index || cell.ColumnIndex == colFinal.Index) && !TryScore(cell.EditedFormattedValue, out _))
            {
                cell.ErrorText = "Điểm phải nằm trong khoảng 0 – 10.";
                Ui.Toast("Điểm phải nằm trong khoảng 0 – 10. Để trống nếu chưa có điểm.", true);
                return false;
            }
        }
        return dgvScores.EndEdit();
    }

    private void SwitchTab(bool results)
    {
        if (resultsTab == results || !EndScoreEdit()) return;
        resultsTab = results;
        page = 1;
        Bind();
    }

    private void btnAttendance_Click(object sender, EventArgs e) => SwitchTab(false);
    private void btnResults_Click(object sender, EventArgs e) => SwitchTab(true);

    private void dgvAttendance_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (!CanEdit || e.RowIndex < 0 || e.ColumnIndex != colStatus.Index ||
            dgvAttendance.Rows[e.RowIndex].Tag is not AttendanceRow row) return;
        int oldAbsent = row.Status > 0 ? 1 : 0;
        row.Status = (row.Status + 1) % AttendanceService.Statuses.Length;
        row.Absent = Math.Max(0, row.Absent + (row.Status > 0 ? 1 : 0) - oldAbsent);
        var gridRow = dgvAttendance.Rows[e.RowIndex];
        gridRow.Cells[colStatus.Index].Value = AttendanceService.Statuses[row.Status];
        gridRow.Cells[colAttendance.Index].Value = row.AttendanceDisplay;
        gridRow.Cells[colAbsent.Index].Value = row.AbsentDisplay;
        dgvAttendance.InvalidateRow(e.RowIndex);
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        if (!CanEdit || !EndScoreEdit()) return;
        string error;
        if (resultsTab)
        {
            if (classId == 0 || scores.Count == 0) return;
            error = ScoreService.Save(scores);
        }
        else
        {
            if (sessionId == 0 || attendance.Count == 0) return;
            error = AttendanceService.Save(sessionId, attendance);
        }
        if (error != null) { Ui.Toast(error, true); return; }
        LoadRosters();
        LoadWarnings();
        Bind();
        Ui.Toast(resultsTab ? "Đã lưu điểm học tập." : "Đã lưu điểm danh.");
    }

    private void btnReception_Click(object sender, EventArgs e)
    {
        if (!CanEdit || warnings.Count == 0) return;
        string contacts = string.Join(Environment.NewLine,
            warnings.Select(w => $"{w.FullName} · {w.Phone} · {w.ClassName} · {w.Absent} buổi vắng"));
        MessageBox.Show(this, contacts, "Gửi lễ tân — Nhắc nhở chuyên cần", MessageBoxButtons.OK, MessageBoxIcon.Information);
        Ui.Toast("Đã hiển thị danh sách liên hệ để lễ tân nhắc nhở học viên.");
    }

    private void dgvAttendance_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
    {
        if (e.RowIndex < 0 || dgvAttendance.Rows[e.RowIndex].Tag is not AttendanceRow row) return;
        if (e.ColumnIndex == colStudent.Index)
            Ui.PersonCell(e, row.FullName, row.Code, Fmt.Initials(row.FullName), false);
        else if (e.ColumnIndex == colPhone.Index)
            Ui.TextCell(e, row.Phone);
        else if (e.ColumnIndex == colAttendance.Index)
            Ui.TextCell(e, row.AttendanceDisplay, Ui.Hex("#47586c"));
        else if (e.ColumnIndex == colAbsent.Index)
            Ui.TextCell(e, row.AbsentDisplay, row.Warning ? Ui.Hex("#c24848") : Ui.Muted, row.Warning);
        else if (e.ColumnIndex == colStatus.Index)
        {
            string status = AttendanceService.Statuses[row.Status];
            var colors = Ui.StatusColors(status);
            Ui.ComboCell(e, status, colors.Fore, colors.Back);
        }
    }

    private static string ScoreText(double? value) => value?.ToString("0.#", CultureInfo.InvariantCulture) ?? "—";

    private void dgvScores_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
    {
        if (e.RowIndex < 0 || dgvScores.Rows[e.RowIndex].Tag is not ScoreRow row) return;
        if (e.ColumnIndex == colScoreStudent.Index)
            Ui.PersonCell(e, row.FullName, "", Fmt.Initials(row.FullName), false);
        else if (e.ColumnIndex == colScoreAttendance.Index)
            Ui.TextCell(e, row.AttendanceDisplay, Ui.Hex("#47586c"));
        else if (e.ColumnIndex == colMidterm.Index || e.ColumnIndex == colFinal.Index)
        {
            var value = e.ColumnIndex == colMidterm.Index ? row.Midterm : row.Final;
            if (!CanEdit) { Ui.TextCell(e, ScoreText(value), Ui.Hex("#47586c"), false, true); return; }
            e.PaintBackground(e.CellBounds, false);
            e.Handled = true;
            int width = Math.Min(56, e.CellBounds.Width - 24);
            if (width <= 0) return;
            var box = new Rectangle(e.CellBounds.X + (e.CellBounds.Width - width) / 2,
                e.CellBounds.Y + (e.CellBounds.Height - 28) / 2, width, 28);
            using (var path = Ui.Round(box, 6))
            {
                using var brush = new SolidBrush(Ui.Hex("#fafbfc"));
                using var pen = new Pen(Ui.Hex("#dfe5eb"));
                Ui.Smooth(e.Graphics).FillPath(brush, path);
                e.Graphics.DrawPath(pen, path);
            }
            TextRenderer.DrawText(e.Graphics, ScoreText(value), e.CellStyle.Font, box,
                value.HasValue ? Ui.Hex("#47586c") : Ui.Muted,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.NoPadding);
        }
        else if (e.ColumnIndex == colAverage.Index)
            Ui.TextCell(e, ScoreText(row.Average), Ui.Hex("#243249"), true, true);
        else if (e.ColumnIndex == colResult.Index)
            Ui.BadgeCell(e, row.Result);
        else if (e.ColumnIndex == colCertificate.Index)
            Ui.LinkButtonCell(e, "Chứng nhận", row.Passed);
    }

    private static bool TryScore(object value, out double? score)
    {
        score = null;
        string text = Convert.ToString(value, CultureInfo.InvariantCulture)?.Trim();
        if (string.IsNullOrEmpty(text) || text == "—") return true;
        if (!double.TryParse(text.Replace(',', '.'), NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingSign,
            CultureInfo.InvariantCulture, out double parsed) || !double.IsFinite(parsed) || parsed < 0 || parsed > 10) return false;
        score = parsed;
        return true;
    }

    private void dgvScores_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
    {
        if (binding || !CanEdit || e.RowIndex < 0 ||
            (e.ColumnIndex != colMidterm.Index && e.ColumnIndex != colFinal.Index)) return;
        if (TryScore(e.FormattedValue, out _))
        {
            dgvScores.Rows[e.RowIndex].Cells[e.ColumnIndex].ErrorText = "";
            return;
        }
        e.Cancel = true;
        dgvScores.Rows[e.RowIndex].Cells[e.ColumnIndex].ErrorText = "Điểm phải nằm trong khoảng 0 – 10.";
        Ui.Toast("Điểm phải nằm trong khoảng 0 – 10. Để trống nếu chưa có điểm.", true);
    }

    private void dgvScores_CellEndEdit(object sender, DataGridViewCellEventArgs e)
    {
        if (binding || !CanEdit || e.RowIndex < 0 ||
            (e.ColumnIndex != colMidterm.Index && e.ColumnIndex != colFinal.Index) ||
            dgvScores.Rows[e.RowIndex].Tag is not ScoreRow row) return;
        var gridRow = dgvScores.Rows[e.RowIndex];
        if (!TryScore(gridRow.Cells[e.ColumnIndex].Value, out var score)) return;
        if (e.ColumnIndex == colMidterm.Index) row.Midterm = score;
        else row.Final = score;
        gridRow.Cells[e.ColumnIndex].ErrorText = "";
        gridRow.Cells[colAverage.Index].Value = ScoreText(row.Average);
        gridRow.Cells[colResult.Index].Value = row.Result;
        dgvScores.InvalidateRow(e.RowIndex);
    }

    private void dgvScores_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || e.ColumnIndex != colCertificate.Index || !EndScoreEdit() ||
            dgvScores.Rows[e.RowIndex].Tag is not ScoreRow row || !row.Passed) return;
        Printing.Certificate(row);
    }

    private void Page_Click(object sender, EventArgs e)
    {
        if (!EndScoreEdit()) return;
        page = int.Parse(((Button)sender).Text);
        Bind();
    }

    private void btnPrev_Click(object sender, EventArgs e)
    {
        if (page <= 1 || !EndScoreEdit()) return;
        page--;
        Bind();
    }

    private void btnNext_Click(object sender, EventArgs e)
    {
        if (page >= PageCount || !EndScoreEdit()) return;
        page++;
        Bind();
    }

    private void Grid_SizeChanged(object sender, EventArgs e) => Ui.RoundTop((Control)sender, 11);
    private void Primary_Paint(object sender, PaintEventArgs e) => Ui.PrimaryButton(sender, e);
    private void Card_Paint(object sender, PaintEventArgs e) => Ui.Card(sender, e);
    private void Combo_DrawItem(object sender, DrawItemEventArgs e) => Ui.ComboItem(sender, e);
    private void Tabs_Paint(object sender, PaintEventArgs e) => Ui.Card(sender, e, 7, Color.Empty);
    private void Tab_Paint(object sender, PaintEventArgs e)
    {
        bool active = resultsTab ? sender == btnResults : sender == btnAttendance;
        Ui.Button(sender, e, active ? Color.White : pnlTabs.BackColor,
            Ui.Hex(active ? "#287dc6" : "#7a899a"), null, 5);
    }

    private void Warning_Paint(object sender, PaintEventArgs e) => Ui.Card(sender, e, 10, Ui.Hex("#f1d4c0"));
    private void WarningIcon_Paint(object sender, PaintEventArgs e)
    {
        e.Graphics.Clear(pnlWarning.BackColor);
        Ui.DrawGlyph(e.Graphics, lblWarningIcon.Text, lblWarningIcon.ClientRectangle, lblWarningIcon.ForeColor, 11);
    }

    private void Reception_Paint(object sender, PaintEventArgs e) => Ui.Button(sender, e, pnlWarning.BackColor, Ui.Hex("#bf6931"));
    private void Pager_Paint(object sender, PaintEventArgs e)
    {
        var button = (Button)sender;
        Ui.Pager(sender, e, button.Tag == null && button.Text == page.ToString());
    }

    private void pnlFooter_Paint(object sender, PaintEventArgs e)
    {
        using var pen = new Pen(Ui.Hex("#edf0f4"));
        e.Graphics.DrawLine(pen, 0, 0, pnlFooter.Width, 0);
    }
}
