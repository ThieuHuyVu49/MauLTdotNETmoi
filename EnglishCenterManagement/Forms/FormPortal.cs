using System.Drawing.Drawing2D;
using EnglishCenterManagement.Services;
using EnglishCenterManagement.UI;

namespace EnglishCenterManagement.Forms;

public partial class FormPortal : Form
{
    public string SelectedRole { get; private set; }

    public FormPortal()
    {
        InitializeComponent();
    }

    private void FormPortal_Load(object sender, EventArgs e)
    {
        lblFloatClassesValue.Text = $"{DashboardService.ActiveClasses()} lớp";
        pnlLeft_Resize(pnlLeft, EventArgs.Empty);
        pnlVisual_Resize(pnlVisual, EventArgs.Empty);
    }

    private static Panel CardOf(object sender)
    {
        for (var c = (Control)sender; c != null; c = c.Parent)
            if (c is Panel { Tag: string } p) return p;
        return null;
    }

    private void Role_Click(object sender, EventArgs e)
    {
        var card = CardOf(sender);
        if (card == null) return;
        SelectedRole = (string)card.Tag;
        DialogResult = DialogResult.OK;
    }

    private void Role_MouseChanged(object sender, EventArgs e)
    {
        var card = CardOf(sender);
        if (card == null) return;
        card.Invalidate();
        foreach (Control c in card.Controls) c.Invalidate();
    }

    private static bool Hovered(Control card) => card.ClientRectangle.Contains(card.PointToClient(Cursor.Position));

    private void RoleCard_Paint(object sender, PaintEventArgs e)
    {
        var card = (Panel)sender;
        bool hover = Hovered(card);
        Ui.Card(sender, e, 13, hover ? Ui.Hex("#9ccaf0") : Ui.Hex("#e2e8ef"), hover ? Ui.Hex("#f7fbff") : Color.White);
    }

    private void RoleIcon_Paint(object sender, PaintEventArgs e)
    {
        var l = (Label)sender;
        var g = Ui.Smooth(e.Graphics);
        var card = CardOf(l);
        g.Clear(card != null && Hovered(card) ? Ui.Hex("#f7fbff") : Color.White);
        using var path = Ui.Round(new RectangleF(0, 0, l.Width - 1, l.Height - 1), l.Width > 40 ? 11 : 9);
        using var b = new SolidBrush(Ui.Hex((string)l.Tag));
        g.FillPath(b, path);
        Ui.DrawGlyph(g, l.Text, l.ClientRectangle, l.ForeColor, l.Font.SizeInPoints);
    }

    private void RoleArrow_Paint(object sender, PaintEventArgs e)
    {
        var l = (Label)sender;
        var card = CardOf(l);
        bool hover = card != null && Hovered(card);
        var g = Ui.Smooth(e.Graphics);
        g.Clear(hover ? Ui.Hex("#f7fbff") : Color.White);
        using var path = Ui.Round(new RectangleF(0, 0, l.Width - 1, l.Height - 1), 8);
        using var b = new SolidBrush(hover ? Ui.Hex("#267fc9") : Ui.Hex("#f2f5f8"));
        g.FillPath(b, path);
        Ui.DrawGlyph(g, l.Text, l.ClientRectangle, hover ? Color.White : l.ForeColor, 9f);
    }

    private void pnlBrandMark_Paint(object sender, PaintEventArgs e)
    {
        var g = Ui.Smooth(e.Graphics);
        g.Clear(Color.White);
        var r = new RectangleF(0, 0, pnlBrandMark.Width - 1, pnlBrandMark.Height - 1);
        using var path = Ui.Round(r, 12, 12, 12, 4);
        using var brush = new LinearGradientBrush(r, Ui.Hex("#39a4ff"), Ui.Hex("#1a72dc"), 45f);
        g.FillPath(brush, path);
        using var f = new Font("Segoe UI", 15f, FontStyle.Bold | FontStyle.Italic);
        TextRenderer.DrawText(g, "e", f, Rectangle.Round(r), Color.White, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
    }

    private void lblPill_Paint(object sender, PaintEventArgs e)
    {
        Ui.Button(sender, e, Ui.Hex("#f0f8ff"), lblPill.ForeColor, Ui.Hex("#d6e8f8"), 14);
    }

    private void lblSupport_Click(object sender, EventArgs e)
    {
        Ui.Toast("Hỗ trợ kỹ thuật: hello@northstar.vn · 028 3824 6688");
    }

    private void pnlLeft_Resize(object sender, EventArgs e)
    {
        int contentHeight = pnlRoleStudent.Bottom - pnlBrandMark.Top;
        int top = Math.Max(40, (pnlLeft.Height - 60 - contentHeight) / 2);
        int dy = top - pnlBrandMark.Top;
        if (dy == 0) return;
        foreach (Control c in new Control[] { pnlBrandMark, lblBrandName, lblBrandSub, lblPill, lblWelcome1, lblWelcome2, lblIntro, lblRoleCaption, pnlRoleAdmin, pnlRoleTeacher, pnlRoleStudent })
            c.Top += dy;
    }

    private void pnlVisual_Resize(object sender, EventArgs e)
    {
        int x0 = Math.Max(40, (pnlVisual.Width - 560) / 2);
        int y0 = Math.Max(40, (pnlVisual.Height - 580) / 2);
        lblKicker.Location = new Point(x0, y0);
        lblVisualTitle1.Location = new Point(x0 - 5, y0 + 24);
        lblVisualTitle2.Location = new Point(x0 - 5, y0 + 64);
        lblVisualText.Location = new Point(x0, y0 + 116);
        pnlMock.Location = new Point(x0, y0 + 198);
        pnlFloatClasses.Location = new Point(pnlMock.Right - pnlFloatClasses.Width + 30, pnlMock.Top - 26);
        pnlFloatRetention.Location = new Point(pnlMock.Left - 30, pnlMock.Bottom - 52);
        pnlVisual.Invalidate();
    }

    private void pnlVisual_Paint(object sender, PaintEventArgs e)
    {
        var g = Ui.Smooth(e.Graphics);
        var r = pnlVisual.ClientRectangle;
        if (r.Width <= 0 || r.Height <= 0) return;
        using (var b = new LinearGradientBrush(r, Ui.Hex("#173b63"), Ui.Hex("#0d2947"), 60f)) g.FillRectangle(b, r);
        using (var glow = new SolidBrush(Color.FromArgb(28, 104, 189, 255))) g.FillEllipse(glow, r.Width - 260, -160, 420, 420);
        using (var glow = new SolidBrush(Color.FromArgb(18, 104, 189, 255))) g.FillEllipse(glow, -140, r.Height - 220, 360, 360);
        using var dot = new SolidBrush(Color.FromArgb(22, 255, 255, 255));
        for (int x = 24; x < 150; x += 18)
            for (int y = r.Height - 130; y < r.Height - 30; y += 18)
                g.FillEllipse(dot, r.Width - 170 + x - 24, y, 3, 3);
    }

    private void FloatCard_Paint(object sender, PaintEventArgs e)
    {
        var c = (Control)sender;
        var g = Ui.Smooth(e.Graphics);
        using (var b = new LinearGradientBrush(new Rectangle(-c.Left, -c.Top, c.Parent.Width, c.Parent.Height), Ui.Hex("#173b63"), Ui.Hex("#0d2947"), 60f))
            g.FillRectangle(b, c.ClientRectangle);
        using var path = Ui.Round(new RectangleF(0.5f, 0.5f, c.Width - 1.5f, c.Height - 1.5f), 12);
        g.FillPath(Brushes.White, path);
    }

    private void pnlMock_Paint(object sender, PaintEventArgs e)
    {
        var g = Ui.Smooth(e.Graphics);
        int w = pnlMock.Width, h = pnlMock.Height;
        var frame = new RectangleF(0.5f, 0.5f, w - 1.5f, h - 1.5f);
        using (var path = Ui.Round(frame, 16))
        {
            using (var b = new SolidBrush(Color.FromArgb(26, 255, 255, 255))) g.FillPath(b, path);
            using (var pen = new Pen(Color.FromArgb(40, 255, 255, 255))) g.DrawPath(pen, path);
        }
        using (var b = new SolidBrush(Color.FromArgb(70, 255, 255, 255)))
            for (int i = 0; i < 3; i++) g.FillEllipse(b, 18 + i * 14, 17, 8, 8);
        using (var b = new SolidBrush(Color.FromArgb(30, 255, 255, 255)))
        using (var p = Ui.Round(new RectangleF(w - 170, 12, 150, 18), 9)) g.FillPath(b, p);

        var tileColors = new[] { "#5aaef5", "#a58bf0", "#f3a86a" };
        var tileValues = new[] { "1.248", "42", "36" };
        var tileLabels = new[] { "Học viên", "Lớp học", "Giảng viên" };
        int tw = (w - 36 - 24) / 3;
        using var valueFont = new Font("Segoe UI", 12f, FontStyle.Bold);
        using var smallFont = new Font("Segoe UI", 7.5f);
        for (int i = 0; i < 3; i++)
        {
            var t = new RectangleF(18 + i * (tw + 12), 46, tw, 70);
            using (var p = Ui.Round(t, 10))
            using (var b = new SolidBrush(Color.FromArgb(22, 255, 255, 255))) g.FillPath(b, p);
            using (var b = new SolidBrush(Ui.Hex(tileColors[i]))) g.FillEllipse(b, t.X + 14, t.Y + 15, 9, 9);
            TextRenderer.DrawText(g, tileLabels[i], smallFont, new Point((int)t.X + 28, (int)t.Y + 12), Ui.Hex("#a9bed2"));
            TextRenderer.DrawText(g, tileValues[i], valueFont, new Point((int)t.X + 12, (int)t.Y + 34), Color.White);
        }

        var chart = new RectangleF(18, 130, w * 0.58f, h - 148);
        using (var p = Ui.Round(chart, 10))
        using (var b = new SolidBrush(Color.FromArgb(18, 255, 255, 255))) g.FillPath(b, p);
        TextRenderer.DrawText(g, "Học viên mới theo tuần", smallFont, new Point((int)chart.X + 14, (int)chart.Y + 12), Ui.Hex("#c9d8e6"));
        var heights = new[] { 0.45f, 0.62f, 0.5f, 0.78f, 0.66f, 0.9f, 0.58f };
        float slot = (chart.Width - 28) / heights.Length;
        float baseY = chart.Bottom - 18;
        float maxH = chart.Height - 60;
        for (int i = 0; i < heights.Length; i++)
        {
            float bh = maxH * heights[i];
            var bar = new RectangleF(chart.X + 14 + i * slot + slot * 0.22f, baseY - bh, slot * 0.56f, bh);
            using var p = Ui.Round(bar, 4, 4, 0, 0);
            using var b = new LinearGradientBrush(bar, Ui.Hex("#68bdff"), Ui.Hex("#2b86d8"), 90f);
            g.FillPath(b, p);
        }

        var list = new RectangleF(chart.Right + 12, 130, w - chart.Right - 30, h - 148);
        using (var p = Ui.Round(list, 10))
        using (var b = new SolidBrush(Color.FromArgb(18, 255, 255, 255))) g.FillPath(b, p);
        TextRenderer.DrawText(g, "Lịch hôm nay", smallFont, new Point((int)list.X + 14, (int)list.Y + 12), Ui.Hex("#c9d8e6"));
        var lineColors = new[] { "#3187d6", "#8663ce", "#ec914c", "#36ae7c" };
        for (int i = 0; i < 4; i++)
        {
            float y = list.Y + 40 + i * 42;
            if (y + 30 > list.Bottom) break;
            using (var b = new SolidBrush(Ui.Hex(lineColors[i]))) g.FillRectangle(b, list.X + 14, y, 3, 28);
            using (var b = new SolidBrush(Color.FromArgb(60, 255, 255, 255)))
            using (var p = Ui.Round(new RectangleF(list.X + 26, y + 3, list.Width * 0.55f, 8), 4)) g.FillPath(b, p);
            using (var b = new SolidBrush(Color.FromArgb(30, 255, 255, 255)))
            using (var p = Ui.Round(new RectangleF(list.X + 26, y + 17, list.Width * 0.38f, 7), 3.5f)) g.FillPath(b, p);
        }
    }
}
