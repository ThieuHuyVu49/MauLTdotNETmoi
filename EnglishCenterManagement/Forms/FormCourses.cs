using System.Text;
using EnglishCenterManagement.Models;
using EnglishCenterManagement.Services;
using EnglishCenterManagement.UI;

namespace EnglishCenterManagement.Forms;

public partial class FormCourses : Form
{
    private const int PageSize = 4;
    private List<Course> data = new();
    private int page = 1;

    public FormCourses()
    {
        InitializeComponent();
    }

    private int PageCount => Math.Max(1, (data.Count + PageSize - 1) / PageSize);

    private void FormCourses_Load(object sender, EventArgs e)
    {
        if (AppSession.User?.IsAdmin != true)
        {
            pnlToolbar.Enabled = pnlTable.Enabled = btnAdd.Enabled = false;
            Ui.Toast("Chỉ quản trị viên được quản lý khóa học.", true);
            return;
        }
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
        if (AppSession.User?.IsAdmin != true) return;
        string status = cboStatus.SelectedIndex <= 0 ? null : (string)cboStatus.SelectedItem;
        data = CourseService.List(txtSearch.Text, status);
        page = Math.Min(page, PageCount);
        Bind();
    }

    private void Bind()
    {
        dgvCourses.Rows.Clear();
        foreach (var c in data.Skip((page - 1) * PageSize).Take(PageSize))
        {
            int i = dgvCourses.Rows.Add(c.Name, c.DurationDisplay, c.FeeDisplay, c.OpenDisplay, c.Status, "");
            dgvCourses.Rows[i].Tag = c;
        }
        dgvCourses.ClearSelection();
        lblPageInfo.Text = $"Trang {page} / {PageCount} · Hiển thị {data.Count} kết quả";
        int start = Math.Max(1, Math.Min(page - 1, PageCount - 2));
        var buttons = new[] { btnPage1, btnPage2, btnPage3 };
        for (int k = 0; k < 3; k++)
        {
            buttons[k].Text = (start + k).ToString();
            buttons[k].Visible = start + k <= PageCount;
            buttons[k].Invalidate();
        }
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
        using var dlg = new FormCourseEdit();
        if (dlg.ShowDialog(this) == DialogResult.OK)
        {
            LoadData();
            Ui.Toast("Đã thêm khóa học mới.");
        }
    }

    private void btnExport_Click(object sender, EventArgs e)
    {
        using var dlg = new SaveFileDialog { Filter = "CSV (*.csv)|*.csv", FileName = $"khoa-hoc-{DateTime.Today:yyyyMMdd}.csv" };
        if (dlg.ShowDialog(this) != DialogResult.OK) return;
        var sb = new StringBuilder("Mã khóa học,Khóa học,Thời lượng,Học phí,Lớp đang mở,Trạng thái\n");
        static string Q(string v) => "\"" + (v ?? "").Replace("\"", "\"\"") + "\"";
        foreach (var c in data)
            sb.AppendLine(string.Join(",", Q(c.Code), Q(c.Name), Q(c.DurationDisplay), Q(c.FeeDisplay), Q(c.OpenDisplay), Q(c.Status)));
        try
        {
            File.WriteAllText(dlg.FileName, sb.ToString(), new UTF8Encoding(true));
            Ui.Toast($"Đã xuất {data.Count} khóa học ra file CSV.");
        }
        catch (Exception ex) when (ex is IOException or UnauthorizedAccessException)
        {
            Ui.Toast("Không thể xuất báo cáo: " + ex.Message, true);
        }
    }

    private void EditRow(int rowIndex)
    {
        if (rowIndex < 0 || dgvCourses.Rows[rowIndex].Tag is not Course c) return;
        using var dlg = new FormCourseEdit(c.Id);
        if (dlg.ShowDialog(this) == DialogResult.OK)
        {
            LoadData();
            Ui.Toast(dlg.Deleted ? "Đã xóa khóa học." : "Đã cập nhật khóa học.");
        }
    }

    private void dgvCourses_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.ColumnIndex == colAction.Index) EditRow(e.RowIndex);
    }

    private void dgvCourses_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.ColumnIndex != colAction.Index) EditRow(e.RowIndex);
    }

    private void dgvCourses_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
    {
        if (e.RowIndex < 0 || dgvCourses.Rows[e.RowIndex].Tag is not Course c) return;
        if (e.ColumnIndex == colCourse.Index)
            Ui.PersonCell(e, c.Name, c.Code, Ui.GLibrary, true);
        else if (e.ColumnIndex == colDuration.Index)
            Ui.TextCell(e, c.DurationDisplay);
        else if (e.ColumnIndex == colFee.Index)
            Ui.TextCell(e, c.FeeDisplay, Ui.Hex("#3a4960"), true);
        else if (e.ColumnIndex == colOpen.Index)
            Ui.TextCell(e, c.OpenDisplay);
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
