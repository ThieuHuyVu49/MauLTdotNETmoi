using System.Text;
using EnglishCenterManagement.Models;
using EnglishCenterManagement.Services;
using EnglishCenterManagement.UI;

namespace EnglishCenterManagement.Forms;

public partial class FormStudents : Form
{
    private const int PageSize = 4;
    private List<Student> data = new();
    private int page = 1;

    public FormStudents()
    {
        InitializeComponent();
    }

    private int PageCount => Math.Max(1, (data.Count + PageSize - 1) / PageSize);

    private void FormStudents_Load(object sender, EventArgs e)
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
        string status = cboStatus.SelectedIndex <= 0 ? null : (string)cboStatus.SelectedItem;
        data = StudentService.List(txtSearch.Text, status);
        page = Math.Min(page, PageCount);
        Bind();
    }

    private void Bind()
    {
        dgvStudents.Rows.Clear();
        foreach (var s in data.Skip((page - 1) * PageSize).Take(PageSize))
        {
            int i = dgvStudents.Rows.Add(s.FullName, s.Code, s.CurrentClass, s.FeeStatus, s.Status, "");
            dgvStudents.Rows[i].Tag = s;
        }
        dgvStudents.ClearSelection();
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
        using var dlg = new FormStudentEdit();
        if (dlg.ShowDialog(this) == DialogResult.OK)
        {
            LoadData();
            Ui.Toast("Đã thêm học viên mới.");
        }
    }

    private void btnExport_Click(object sender, EventArgs e)
    {
        using var dlg = new SaveFileDialog { Filter = "CSV (*.csv)|*.csv", FileName = $"hoc-vien-{DateTime.Today:yyyyMMdd}.csv" };
        if (dlg.ShowDialog(this) != DialogResult.OK) return;
        var sb = new StringBuilder("Mã học viên,Họ và tên,Số điện thoại,Email,Lớp đang học,Học phí,Trạng thái\n");
        static string Q(string v) => "\"" + (v ?? "").Replace("\"", "\"\"") + "\"";
        foreach (var s in data)
            sb.AppendLine(string.Join(",", Q(s.Code), Q(s.FullName), Q(s.Phone), Q(s.Email), Q(s.CurrentClass), Q(s.FeeStatus), Q(s.Status)));
        File.WriteAllText(dlg.FileName, sb.ToString(), new UTF8Encoding(true));
        Ui.Toast($"Đã xuất {data.Count} học viên ra file CSV.");
    }

    private void dgvStudents_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || e.ColumnIndex != colAction.Index) return;
        var s = (Student)dgvStudents.Rows[e.RowIndex].Tag;
        using var dlg = new FormStudentDetail(s.Id);
        dlg.ShowDialog(this);
        LoadData();
    }

    private void dgvStudents_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || e.ColumnIndex == colAction.Index) return;
        var s = (Student)dgvStudents.Rows[e.RowIndex].Tag;
        using var dlg = new FormStudentEdit(s.Id);
        if (dlg.ShowDialog(this) == DialogResult.OK)
        {
            LoadData();
            Ui.Toast(dlg.Deleted ? "Đã xóa học viên." : "Đã cập nhật thông tin học viên.");
        }
    }

    private void dgvStudents_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
    {
        if (e.RowIndex < 0) return;
        var s = (Student)dgvStudents.Rows[e.RowIndex].Tag;
        if (e.ColumnIndex == colStudent.Index)
            Ui.PersonCell(e, s.FullName, string.IsNullOrEmpty(s.Phone) ? s.Email : s.Phone, Fmt.Initials(s.FullName), false);
        else if (e.ColumnIndex == colCode.Index)
            Ui.TextCell(e, s.Code, Ui.Hex("#3a4960"), true);
        else if (e.ColumnIndex == colClass.Index)
            Ui.TextCell(e, s.CurrentClass, s.CurrentClass == "Chưa đăng ký" ? Ui.Muted : Ui.Hex("#2b3a52"));
        else if (e.ColumnIndex == colFee.Index)
            Ui.TextCell(e, s.FeeStatus, s.FeeStatus == "Đã thanh toán" ? Ui.Hex("#218660") : s.FeeStatus == "Chưa đăng ký" ? Ui.Muted : Ui.Hex("#bd6e34"), true);
        else if (e.ColumnIndex == colStatus.Index)
            Ui.BadgeCell(e, s.Status);
        else if (e.ColumnIndex == colAction.Index)
            Ui.GlyphCell(e, Ui.GMore, Ui.Hex("#8f9baa"));
    }

    private void Grid_SizeChanged(object sender, EventArgs e)
    {
        Ui.RoundTop((Control)sender, 11);
    }

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

    private void pnlSearchBox_Click(object sender, EventArgs e)
    {
        txtSearch.Focus();
    }
}
