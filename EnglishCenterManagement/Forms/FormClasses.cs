using System.Text;
using EnglishCenterManagement.Models;
using EnglishCenterManagement.Services;
using EnglishCenterManagement.UI;

namespace EnglishCenterManagement.Forms;

public partial class FormClasses : Form
{
    private const int PageSize = 4;
    private List<ClassInfo> data = new();
    private int page = 1;

    public FormClasses()
    {
        InitializeComponent();
        btnAdd.Visible = AppSession.User?.IsAdmin == true;
    }

    private int PageCount => Math.Max(1, (data.Count + PageSize - 1) / PageSize);

    private void FormClasses_Load(object sender, EventArgs e)
    {
        cboStatus.SelectedIndex = 0;
        LoadData();
    }

    public void SetSearch(string q)
    {
        txtSearch.Text = q;
        txtSearch.Focus();
        txtSearch.SelectionStart = txtSearch.TextLength;
    }

    private void LoadData()
    {
        var user = AppSession.User;
        if (user == null) return;
        string status = cboStatus.SelectedIndex <= 0 ? null : (string)cboStatus.SelectedItem;
        data = ClassService.List(txtSearch.Text, status, teacherId: user.IsTeacher ? user.TeacherId : null);
        // A teacher without a linked teaching profile must not see everybody's classes.
        if (user.IsTeacher && !user.TeacherId.HasValue) data.Clear();
        page = Math.Min(page, PageCount);
        Bind();
    }

    private void Bind()
    {
        dgvClasses.Rows.Clear();
        foreach (var c in data.Skip((page - 1) * PageSize).Take(PageSize))
        {
            int i = dgvClasses.Rows.Add(c.Name, c.ScheduleDisplay, c.TeacherName, c.SizeDisplay, c.Status, "");
            dgvClasses.Rows[i].Tag = c;
        }
        dgvClasses.ClearSelection();
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
    }

    private void txtSearch_TextChanged(object sender, EventArgs e)
    {
        page = 1;
        LoadData();
    }

    private void cboStatus_SelectedIndexChanged(object sender, EventArgs e)
    {
        page = 1;
        LoadData();
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        if (AppSession.User?.IsAdmin != true) return;
        using var dlg = new FormClassEdit();
        if (dlg.ShowDialog(this) == DialogResult.OK)
        {
            LoadData();
            Ui.Toast("Đã thêm lớp học mới.");
        }
    }

    private void EditClass(ClassInfo c)
    {
        if (AppSession.User?.IsAdmin != true) return;
        using var dlg = new FormClassEdit(c.Id);
        if (dlg.ShowDialog(this) == DialogResult.OK)
        {
            LoadData();
            Ui.Toast(dlg.Deleted ? "Đã xóa lớp học." : "Đã cập nhật lớp học.");
        }
    }

    private void btnExport_Click(object sender, EventArgs e)
    {
        using var dlg = new SaveFileDialog { Filter = "CSV (*.csv)|*.csv", FileName = $"lop-hoc-{DateTime.Today:yyyyMMdd}.csv" };
        if (dlg.ShowDialog(this) != DialogResult.OK) return;
        var sb = new StringBuilder("Lớp học,Khóa học,Lịch học,Giáo viên,Sĩ số,Trạng thái\n");
        static string Q(string v) => "\"" + (v ?? "").Replace("\"", "\"\"") + "\"";
        foreach (var c in data)
            sb.AppendLine(string.Join(",", Q(c.Name), Q(c.CourseName), Q(c.ScheduleDisplay), Q(c.TeacherName), Q(c.SizeDisplay), Q(c.Status)));
        try
        {
            File.WriteAllText(dlg.FileName, sb.ToString(), new UTF8Encoding(true));
            Ui.Toast($"Đã xuất {data.Count} lớp học ra file CSV.");
        }
        catch (Exception ex) when (ex is IOException or UnauthorizedAccessException)
        {
            Ui.Toast("Không thể xuất báo cáo: " + ex.Message, true);
        }
    }

    private void dgvClasses_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || e.ColumnIndex != colAction.Index || dgvClasses.Rows[e.RowIndex].Tag is not ClassInfo c) return;
        if (AppSession.User?.IsTeacher == true)
        {
            FormMain.Current?.Navigate("attendance");
            return;
        }
        EditClass(c);
    }

    private void dgvClasses_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || e.ColumnIndex == colAction.Index || dgvClasses.Rows[e.RowIndex].Tag is not ClassInfo c) return;
        EditClass(c);
    }

    private void dgvClasses_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
    {
        if (e.RowIndex < 0 || dgvClasses.Rows[e.RowIndex].Tag is not ClassInfo c) return;
        if (e.ColumnIndex == colClass.Index)
            Ui.PersonCell(e, c.Name, c.CourseName, Ui.GEducation, true);
        else if (e.ColumnIndex == colSchedule.Index)
            Ui.TextCell(e, c.ScheduleDisplay, string.IsNullOrEmpty(c.Days) ? Ui.Muted : Ui.Hex("#2b3a52"));
        else if (e.ColumnIndex == colTeacher.Index)
            Ui.TextCell(e, c.TeacherName);
        else if (e.ColumnIndex == colSize.Index)
            Ui.TextCell(e, c.SizeDisplay, Ui.Hex("#3a4960"));
        else if (e.ColumnIndex == colStatus.Index)
            Ui.BadgeCell(e, c.Status);
        else if (e.ColumnIndex == colAction.Index)
            Ui.GlyphCell(e, Ui.GMore, Ui.Hex("#8f9baa"));
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

    private void pnlFooter_Paint(object sender, PaintEventArgs e)
    {
        using var pen = new Pen(Ui.Hex("#edf0f4"));
        e.Graphics.DrawLine(pen, 0, 0, pnlFooter.Width, 0);
    }

    private void Primary_Paint(object sender, PaintEventArgs e) => Ui.PrimaryButton(sender, e);
    private void Outline_Paint(object sender, PaintEventArgs e) => Ui.OutlineButton(sender, e);
    private void Card_Paint(object sender, PaintEventArgs e) => Ui.Card(sender, e);
    private void SearchBox_Paint(object sender, PaintEventArgs e) => Ui.Card(sender, e, 8, Ui.Hex("#e0e5ec"));
    private void Combo_DrawItem(object sender, DrawItemEventArgs e) => Ui.ComboItem(sender, e);
    private void pnlSearchBox_Click(object sender, EventArgs e) => txtSearch.Focus();
}
