using EnglishCenterManagement.Models;
using EnglishCenterManagement.UI;

namespace EnglishCenterManagement.Forms;

public partial class FormNotifications : Form
{
    private readonly List<NotificationItem> items = new();
    private bool unread = true;

    public event EventHandler MarkedRead;

    public FormNotifications()
    {
        InitializeComponent();
    }

    public FormNotifications(List<NotificationItem> items, bool unread) : this()
    {
        this.items = items;
        this.unread = unread;
    }

    private void FormNotifications_Load(object sender, EventArgs e)
    {
        Ui.RoundAll(this, 12);
        var titles = new[] { lblItem1Title, lblItem2Title, lblItem3Title };
        var details = new[] { lblItem1Detail, lblItem2Detail, lblItem3Detail };
        var panels = new[] { pnlItem1, pnlItem2, pnlItem3 };
        for (int i = 0; i < panels.Length; i++)
        {
            panels[i].Visible = i < items.Count;
            if (i >= items.Count) continue;
            titles[i].Text = items[i].Title;
            details[i].Text = items[i].Detail;
        }
        UpdateHeader();
    }

    private void UpdateHeader()
    {
        lblSub.Text = unread ? $"{items.Count} thông báo chưa đọc" : "Bạn đã đọc tất cả thông báo";
        lblMarkRead.Visible = unread;
    }

    private void FormNotifications_Paint(object sender, PaintEventArgs e)
    {
        using var path = Ui.Round(new RectangleF(0, 0, Width - 1, Height - 1), 12);
        using var pen = new Pen(Ui.Hex("#e1e6ee"));
        Ui.Smooth(e.Graphics).DrawPath(pen, path);
    }

    private (Color Fore, Color Back, string Glyph) Style(string color) => color switch
    {
        "orange" => (Ui.Hex("#dc7b39"), Ui.Hex("#fff0e4"), Ui.GWarning),
        "purple" => (Ui.Hex("#805fc5"), Ui.Hex("#f2edff"), Ui.GPeople),
        "green" => (Ui.Hex("#29a171"), Ui.Hex("#e7f8f0"), Ui.GCheck),
        _ => (Ui.Hex("#247ed1"), Ui.Hex("#eaf4ff"), Ui.GDocument)
    };

    private void ItemIcon_Paint(object sender, PaintEventArgs e)
    {
        var lbl = (Label)sender;
        int i = int.Parse((string)lbl.Tag);
        var g = Ui.Smooth(e.Graphics);
        g.Clear(Color.White);
        if (i >= items.Count) return;
        var (fore, back, glyph) = Style(items[i].Color);
        using (var path = Ui.Round(new RectangleF(0, 0, lbl.Width - 1, lbl.Height - 1), 10))
        using (var b = new SolidBrush(back)) g.FillPath(b, path);
        Ui.DrawGlyph(g, glyph, lbl.ClientRectangle, fore, 11f);
        if (unread)
            using (var dot = new SolidBrush(Ui.Hex("#f35b61"))) g.FillEllipse(dot, lbl.Width - 9, 1, 7, 7);
    }

    private void Item_Click(object sender, EventArgs e)
    {
        int i = int.Parse((string)((Control)sender).Tag);
        if (i >= items.Count) return;
        var target = items[i].Target;
        Close();
        FormMain.Current?.Navigate(target);
    }

    private void lblMarkRead_Click(object sender, EventArgs e)
    {
        unread = false;
        UpdateHeader();
        foreach (var l in new[] { lblItem1Icon, lblItem2Icon, lblItem3Icon }) l.Invalidate();
        MarkedRead?.Invoke(this, EventArgs.Empty);
    }

    private void lblFooter_Click(object sender, EventArgs e)
    {
        Close();
        if (FormMain.Current?.Navigate("settings") is FormSettings settings) settings.ShowNotificationsTab();
    }

    private void FormNotifications_Deactivate(object sender, EventArgs e)
    {
        BeginInvoke(new Action(Close));
    }
}
