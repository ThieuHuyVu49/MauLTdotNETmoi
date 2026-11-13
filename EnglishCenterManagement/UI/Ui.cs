using System.Drawing.Drawing2D;
using System.Drawing.Text;
using EnglishCenterManagement.Forms;

namespace EnglishCenterManagement.UI;

public static class Ui
{
    public static Color Hex(string h) => ColorTranslator.FromHtml(h);

    public static readonly Color Bg = Hex("#f5f7fb");
    public static readonly Color Ink = Hex("#17243d");
    public static readonly Color Heading = Hex("#243249");
    public static readonly Color Muted = Hex("#8793a3");
    public static readonly Color Line = Hex("#e6eaf0");
    public static readonly Color InputLine = Hex("#dfe5ec");
    public static readonly Color Primary = Hex("#207dd5");
    public static readonly Color Accent = Hex("#267fc9");
    public static readonly Color Sidebar = Hex("#132b48");

    public const string IconFontName = "Segoe MDL2 Assets";
    public const string GHome = "\uE80F", GPeople = "\uE716", GLibrary = "\uE8F1", GEducation = "\uE7BE", GContact = "\uE77B",
        GCalendar = "\uE787", GPayment = "\uE8C7", GCheckList = "\uE73A", GSetting = "\uE713", GSearch = "\uE721", GBell = "\uEA8F",
        GPower = "\uE7E8", GChevronRight = "\uE76C", GChevronLeft = "\uE76B", GChevronDown = "\uE70D", GAdd = "\uE710", GDownload = "\uE896",
        GMore = "\uE712", GPin = "\uE707", GWarning = "\uE7BA", GDocument = "\uE8A5", GCheck = "\uE73E", GStar = "\uE734", GInfo = "\uE946",
        GClose = "\uE711", GArrowRight = "\uE72A", GPrint = "\uE749", GDelete = "\uE74D", GEdit = "\uE70F", GLock = "\uE72E";

    private static readonly Dictionary<float, Font> IconFonts = new();
    public static Font IconFont(float size)
    {
        if (!IconFonts.TryGetValue(size, out var f)) IconFonts[size] = f = new Font(IconFontName, size, GraphicsUnit.Point);
        return f;
    }

    public static Color Shade(Color c, float amount) => amount < 0
        ? Color.FromArgb(c.A, (int)(c.R * (1 + amount)), (int)(c.G * (1 + amount)), (int)(c.B * (1 + amount)))
        : Color.FromArgb(c.A, (int)(c.R + (255 - c.R) * amount), (int)(c.G + (255 - c.G) * amount), (int)(c.B + (255 - c.B) * amount));

    public static GraphicsPath Round(RectangleF r, float radius) => Round(r, radius, radius, radius, radius);

    public static GraphicsPath Round(RectangleF r, float tl, float tr, float br, float bl)
    {
        var p = new GraphicsPath();
        void Arc(float x, float y, float rad, float start)
        {
            if (rad <= 0) p.AddLine(x, y, x, y);
            else p.AddArc(x, y, rad * 2, rad * 2, start, 90);
        }
        Arc(r.Left, r.Top, tl, 180);
        Arc(r.Right - tr * 2, r.Top, tr, 270);
        Arc(r.Right - br * 2, r.Bottom - br * 2, br, 0);
        Arc(r.Left, r.Bottom - bl * 2, bl, 90);
        p.CloseFigure();
        return p;
    }

    private static Color ParentBack(Control c)
    {
        for (var p = c.Parent; p != null; p = p.Parent)
            if (p.BackColor != Color.Transparent) return p.BackColor;
        return Bg;
    }

    public static Graphics Smooth(Graphics g)
    {
        g.SmoothingMode = SmoothingMode.AntiAlias;
        g.PixelOffsetMode = PixelOffsetMode.HighQuality;
        g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
        return g;
    }

    // Rounded surface in the control's own BackColor, corners cleared to the parent's color.
    public static void Card(object sender, PaintEventArgs e, float radius = 11, Color? border = null, Color? fill = null)
    {
        var c = (Control)sender;
        var g = Smooth(e.Graphics);
        g.Clear(ParentBack(c));
        using var path = Round(new RectangleF(0.5f, 0.5f, c.Width - 1.5f, c.Height - 1.5f), radius);
        using (var b = new SolidBrush(fill ?? c.BackColor)) g.FillPath(b, path);
        if (border != Color.Empty)
            using (var pen = new Pen(border ?? Line)) g.DrawPath(pen, path);
    }

    public static void Input(object sender, PaintEventArgs e) => Card(sender, e, 8, InputLine);

    public static void Gradient(object sender, PaintEventArgs e, Color from, Color to, float radius, float angle = 90f)
    {
        var c = (Control)sender;
        var g = Smooth(e.Graphics);
        g.Clear(ParentBack(c));
        if (c.Width <= 0 || c.Height <= 0) return;
        var rect = new RectangleF(0, 0, c.Width - 0.5f, c.Height - 0.5f);
        using var path = Round(rect, radius);
        using var b = new LinearGradientBrush(new RectangleF(0, 0, c.Width, c.Height), from, to, angle);
        g.FillPath(b, path);
    }

    public static void DrawGlyph(Graphics g, string glyph, Rectangle r, Color color, float size)
    {
        TextRenderer.DrawText(g, glyph, IconFont(size), r, color,
            TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.NoPadding | TextFormatFlags.NoPrefix);
    }

    // Draws a whole button: rounded fill, optional border, glyph from Tag, then Text.
    public static void Button(object sender, PaintEventArgs e, Color back, Color fore, Color? border = null, float radius = 8)
    {
        var b = (Control)sender;
        var g = Smooth(e.Graphics);
        bool hover = b.Enabled && b.ClientRectangle.Contains(b.PointToClient(Cursor.Position));
        var fill = !b.Enabled ? Shade(back, 0.35f) : hover ? (back.GetBrightness() > 0.9f ? Shade(back, -0.03f) : Shade(back, -0.08f)) : back;
        g.Clear(ParentBack(b));
        using (var path = Round(new RectangleF(0.5f, 0.5f, b.Width - 1.5f, b.Height - 1.5f), radius))
        {
            using (var br = new SolidBrush(fill)) g.FillPath(br, path);
            if (border.HasValue) using (var pen = new Pen(border.Value)) g.DrawPath(pen, path);
        }
        var glyph = b.Tag as string;
        var flags = TextFormatFlags.NoPadding | TextFormatFlags.NoPrefix | TextFormatFlags.VerticalCenter | TextFormatFlags.SingleLine;
        var textSize = string.IsNullOrEmpty(b.Text) ? Size.Empty : TextRenderer.MeasureText(g, b.Text, b.Font, Size.Empty, flags);
        float gs = b.Font.SizeInPoints;
        int gw = string.IsNullOrEmpty(glyph) ? 0 : (int)(gs * 1.6f);
        int gap = gw > 0 && textSize.Width > 0 ? 7 : 0;
        int total = gw + gap + textSize.Width;
        int x = (b.Width - total) / 2;
        if (gw > 0) DrawGlyph(g, glyph, new Rectangle(x, 0, gw, b.Height), fore, gs);
        if (textSize.Width > 0)
            TextRenderer.DrawText(g, b.Text, b.Font, new Rectangle(x + gw + gap, 0, textSize.Width + 2, b.Height), fore, flags);
    }

    public static void PrimaryButton(object s, PaintEventArgs e) => Button(s, e, Primary, Color.White);
    public static void AccentButton(object s, PaintEventArgs e) => Button(s, e, Accent, Color.White);
    public static void OutlineButton(object s, PaintEventArgs e) => Button(s, e, Color.White, Hex("#3a4960"), Hex("#e2e7ed"));
    public static void DangerButton(object s, PaintEventArgs e) => Button(s, e, Color.White, Hex("#c75a5a"), Hex("#f0d3d3"));
    public static void SoftButton(object s, PaintEventArgs e) => Button(s, e, Hex("#f3f5f7"), Hex("#6b778a"), null, 8);
    public static void WhiteButton(object s, PaintEventArgs e) => Button(s, e, Color.White, Hex("#173b5e"), null, 9);

    public static void Pager(object sender, PaintEventArgs e, bool active)
    {
        if (active) Button(sender, e, Hex("#2b82cb"), Color.White, null, 6);
        else Button(sender, e, Color.White, Hex("#6b778a"), Hex("#e3e7ed"), 6);
    }

    // On/off switch drawn over a CheckBox (31×18).
    public static void Toggle(object sender, PaintEventArgs e)
    {
        var cb = (CheckBox)sender;
        var g = Smooth(e.Graphics);
        g.Clear(ParentBack(cb));
        var r = new RectangleF(0.5f, 0.5f, cb.Width - 1.5f, cb.Height - 1.5f);
        using (var path = Round(r, r.Height / 2))
        using (var b = new SolidBrush(cb.Checked ? Hex("#2d85cf") : Hex("#ccd4dd")))
            g.FillPath(b, path);
        float d = r.Height - 4;
        float x = cb.Checked ? r.Right - d - 2 : r.Left + 2;
        g.FillEllipse(Brushes.White, x, r.Top + 2, d, d);
    }

    public static void Avatar(Graphics g, Rectangle r, string name, float fontSize, Color? c1 = null, Color? c2 = null, Color? fore = null)
    {
        Smooth(g);
        using var b = new LinearGradientBrush(r, c1 ?? Hex("#d3ecfa"), c2 ?? Hex("#9fcde8"), 45f);
        g.FillEllipse(b, r);
        using var f = new Font("Segoe UI", fontSize, FontStyle.Bold);
        TextRenderer.DrawText(g, Models.Fmt.Initials(name), f, r, fore ?? Hex("#244b77"),
            TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.NoPadding);
    }

    public static void AvatarPanel(object sender, PaintEventArgs e, string name, float fontSize)
    {
        var c = (Control)sender;
        e.Graphics.Clear(ParentBack(c));
        Avatar(e.Graphics, new Rectangle(0, 0, c.Width - 1, c.Height - 1), name, fontSize);
    }

    public static (Color Fore, Color Back, Color Dot) StatusColors(string status) => status switch
    {
        "Đang học" or "Đang tuyển sinh" or "Đang giảng dạy" or "Đạt" or "Đã thanh toán" or "Có mặt" or "Đã thu" or "Hoạt động"
            => (Hex("#218660"), Hex("#e7f6ef"), Hex("#2ca778")),
        "Vắng có phép" or "Chưa thu" or "Đang mở"
            => (Hex("#2b74b8"), Hex("#eaf4fd"), Hex("#3d8fd8")),
        "Vắng không phép" or "Quá hạn" or "Trùng lịch"
            => (Hex("#c24848"), Hex("#ffeded"), Hex("#e45454")),
        "Đã kết thúc" or "Chưa đủ điểm" or "Nghỉ" or "Chưa đăng ký"
            => (Hex("#6b778a"), Hex("#f0f2f5"), Hex("#a2acb9")),
        _ => (Hex("#bd6e34"), Hex("#fff0e4"), Hex("#e58a45"))
    };

    private static readonly Font BadgeFont = new("Segoe UI", 8.25F, FontStyle.Bold);

    public static void Badge(Graphics g, int x, int centerY, string text)
    {
        if (string.IsNullOrEmpty(text)) return;
        var (fore, back, dot) = StatusColors(text);
        Smooth(g);
        var size = TextRenderer.MeasureText(g, text, BadgeFont, Size.Empty, TextFormatFlags.NoPadding);
        var r = new Rectangle(x, centerY - 12, size.Width + 30, 24);
        using (var path = Round(r, 12))
        using (var b = new SolidBrush(back)) g.FillPath(b, path);
        using (var b = new SolidBrush(dot)) g.FillEllipse(b, r.X + 10, centerY - 3, 6, 6);
        TextRenderer.DrawText(g, text, BadgeFont, new Rectangle(r.X + 21, r.Y, size.Width + 4, r.Height), fore,
            TextFormatFlags.VerticalCenter | TextFormatFlags.NoPadding);
    }

    public static void BadgePanel(object sender, PaintEventArgs e, string text)
    {
        var c = (Control)sender;
        e.Graphics.Clear(ParentBack(c));
        Badge(e.Graphics, 0, c.Height / 2, text);
    }

    // ---- DataGridView cell painting ----

    private static void CellBackground(DataGridViewCellPaintingEventArgs e)
    {
        e.PaintBackground(e.CellBounds, false);
        e.Handled = true;
    }

    public static void TextCell(DataGridViewCellPaintingEventArgs e, string text, Color? color = null, bool bold = false, bool center = false)
    {
        CellBackground(e);
        var font = bold ? new Font(e.CellStyle.Font, FontStyle.Bold) : e.CellStyle.Font;
        TextRenderer.DrawText(e.Graphics, text, font, Rectangle.Inflate(e.CellBounds, -16, 0), color ?? e.CellStyle.ForeColor,
            TextFormatFlags.VerticalCenter | TextFormatFlags.EndEllipsis | TextFormatFlags.NoPrefix | (center ? TextFormatFlags.HorizontalCenter : 0));
        if (bold) font.Dispose();
    }

    public static void PersonCell(DataGridViewCellPaintingEventArgs e, string title, string subtitle, string boxText, bool boxIsGlyph,
        Color? boxBack = null, Color? boxFore = null)
    {
        CellBackground(e);
        var g = Smooth(e.Graphics);
        var r = e.CellBounds;
        var box = new Rectangle(r.X + 16, r.Y + (r.Height - 30) / 2, 30, 30);
        using (var path = Round(box, 8))
        using (var b = new SolidBrush(boxBack ?? Hex("#e9f4fd"))) g.FillPath(b, path);
        var fore = boxFore ?? Hex("#277bc2");
        if (boxIsGlyph) DrawGlyph(g, boxText, box, fore, 11f);
        else
            using (var f = new Font("Segoe UI", 8.25F, FontStyle.Bold))
                TextRenderer.DrawText(g, boxText, f, box, fore, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.NoPadding);

        var textRect = new Rectangle(box.Right + 11, r.Y, r.Right - box.Right - 16, r.Height);
        using var bold = new Font("Segoe UI", 9F, FontStyle.Bold);
        var flags = TextFormatFlags.EndEllipsis | TextFormatFlags.NoPrefix | TextFormatFlags.NoPadding;
        if (string.IsNullOrEmpty(subtitle))
            TextRenderer.DrawText(g, title, bold, textRect, Hex("#1f2d44"), flags | TextFormatFlags.VerticalCenter);
        else
        {
            TextRenderer.DrawText(g, title, bold, new Rectangle(textRect.X, r.Y + r.Height / 2 - 17, textRect.Width, 18), Hex("#1f2d44"), flags);
            using var small = new Font("Segoe UI", 8.25F);
            TextRenderer.DrawText(g, subtitle, small, new Rectangle(textRect.X, r.Y + r.Height / 2 + 2, textRect.Width, 16), Hex("#98a2b0"), flags);
        }
    }

    public static void BadgeCell(DataGridViewCellPaintingEventArgs e, string status)
    {
        CellBackground(e);
        Badge(e.Graphics, e.CellBounds.X + 16, e.CellBounds.Y + e.CellBounds.Height / 2, status);
    }

    public static void GlyphCell(DataGridViewCellPaintingEventArgs e, string glyph, Color color, float size = 11f)
    {
        CellBackground(e);
        DrawGlyph(e.Graphics, glyph, e.CellBounds, color, size);
    }

    public static void LinkButtonCell(DataGridViewCellPaintingEventArgs e, string text, bool enabled)
    {
        CellBackground(e);
        var g = Smooth(e.Graphics);
        var r = e.CellBounds;
        using var f = new Font("Segoe UI", 8.25F, FontStyle.Bold);
        var size = TextRenderer.MeasureText(g, text, f);
        var box = new Rectangle(r.X + 12, r.Y + (r.Height - 28) / 2, size.Width + 30, 28);
        var fore = enabled ? Hex("#277dc4") : Hex("#a9b3c0");
        using (var path = Round(box, 7))
        {
            using (var b = new SolidBrush(enabled ? Hex("#eef6fd") : Hex("#f3f5f7"))) g.FillPath(b, path);
        }
        DrawGlyph(g, GDocument, new Rectangle(box.X + 6, box.Y, 16, box.Height), fore, 8.5f);
        TextRenderer.DrawText(g, text, f, new Rectangle(box.X + 22, box.Y, box.Width - 22, box.Height), fore,
            TextFormatFlags.VerticalCenter | TextFormatFlags.NoPadding);
    }

    public static void ComboCell(DataGridViewCellPaintingEventArgs e, string text, Color fore, Color back)
    {
        CellBackground(e);
        var g = Smooth(e.Graphics);
        var r = e.CellBounds;
        var box = new Rectangle(r.X + 12, r.Y + (r.Height - 30) / 2, Math.Min(170, r.Width - 24), 30);
        using (var path = Round(box, 7))
        {
            using (var b = new SolidBrush(back)) g.FillPath(b, path);
            using (var pen = new Pen(Shade(fore, 0.7f))) g.DrawPath(pen, path);
        }
        using (var f = new Font("Segoe UI", 8.25F, FontStyle.Bold))
            TextRenderer.DrawText(g, text, f, new Rectangle(box.X + 10, box.Y, box.Width - 30, box.Height), fore, TextFormatFlags.VerticalCenter | TextFormatFlags.NoPadding);
        DrawGlyph(g, GChevronDown, new Rectangle(box.Right - 24, box.Y, 18, box.Height), fore, 7f);
    }

    public static void RoundTop(Control c, int radius)
    {
        if (c.Width <= 0 || c.Height <= 0) return;
        using var path = Round(new RectangleF(0, 0, c.Width, c.Height), radius, radius, 0, 0);
        c.Region = new Region(path);
    }

    public static void RoundAll(Control c, int radius)
    {
        if (c.Width <= 0 || c.Height <= 0) return;
        using var path = Round(new RectangleF(0, 0, c.Width, c.Height), radius);
        c.Region = new Region(path);
    }

    // ---- ComboBox owner draw (DrawMode.OwnerDrawFixed) ----
    public static void ComboItem(object sender, DrawItemEventArgs e)
    {
        var cb = (ComboBox)sender;
        bool editArea = (e.State & DrawItemState.ComboBoxEdit) != 0;
        bool selected = !editArea && (e.State & DrawItemState.Selected) != 0;
        using (var b = new SolidBrush(selected ? Hex("#eaf4fd") : cb.BackColor)) e.Graphics.FillRectangle(b, e.Bounds);
        if (e.Index < 0) return;
        var text = cb.GetItemText(cb.Items[e.Index]);
        TextRenderer.DrawText(e.Graphics, text, cb.Font, new Rectangle(e.Bounds.X + 6, e.Bounds.Y, e.Bounds.Width - 8, e.Bounds.Height),
            selected ? Hex("#1f6fb8") : Hex("#2b3a52"), TextFormatFlags.VerticalCenter | TextFormatFlags.EndEllipsis | TextFormatFlags.NoPrefix);
    }

    // ---- Messages ----
    public static void Toast(string message, bool error = false)
    {
        var owner = Form.ActiveForm ?? FormMain.Current;
        new FormToast(message, error).ShowNear(owner);
    }

    public static bool Confirm(string message, string title = "Xác nhận") =>
        MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;

    public static void Embed(Panel host, Form page)
    {
        page.TopLevel = false;
        page.FormBorderStyle = FormBorderStyle.None;
        page.Dock = DockStyle.Fill;
        host.Controls.Add(page);
        page.Show();
    }
}
