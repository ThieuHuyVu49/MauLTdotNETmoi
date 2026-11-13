using EnglishCenterManagement.UI;

namespace EnglishCenterManagement.Forms;

public partial class FormToast : Form
{
    private readonly bool error;

    public FormToast()
    {
        InitializeComponent();
    }

    public FormToast(string message, bool error) : this()
    {
        this.error = error;
        lblMessage.Text = message;
        var size = TextRenderer.MeasureText(message, lblMessage.Font, new Size(lblMessage.Width, 0), TextFormatFlags.WordBreak);
        if (size.Height > 34) Height = size.Height + 30;
        lblIcon.Top = (ClientSize.Height - lblIcon.Height) / 2;
    }

    protected override bool ShowWithoutActivation => true;

    public async void ShowNear(Form owner)
    {
        var area = owner is { Visible: true, WindowState: not FormWindowState.Minimized }
            ? owner.RectangleToScreen(owner.ClientRectangle)
            : Screen.PrimaryScreen!.WorkingArea;
        Location = new Point(area.Right - Width - 24, area.Bottom - Height - 24);
        Show();
        await Task.Delay(error ? 3600 : 2600);
        if (!IsDisposed) Close();
    }

    private void FormToast_Load(object sender, EventArgs e)
    {
        Ui.RoundAll(this, 10);
    }

    private void FormToast_Paint(object sender, PaintEventArgs e)
    {
        using var path = Ui.Round(new RectangleF(0, 0, Width - 1, Height - 1), 10);
        using var pen = new Pen(Ui.Hex("#e1e6ee"));
        Ui.Smooth(e.Graphics).DrawPath(pen, path);
        using var accent = new SolidBrush(error ? Ui.Hex("#e45454") : Ui.Hex("#2ca778"));
        e.Graphics.FillRectangle(accent, 0, 10, 3, Height - 20);
    }

    private void lblIcon_Paint(object sender, PaintEventArgs e)
    {
        var g = Ui.Smooth(e.Graphics);
        g.Clear(Color.White);
        using var b = new SolidBrush(error ? Ui.Hex("#e45454") : Ui.Hex("#2ca778"));
        g.FillEllipse(b, 0, 0, lblIcon.Width - 1, lblIcon.Height - 1);
        Ui.DrawGlyph(g, error ? "\uE8BB" : Ui.GCheck, lblIcon.ClientRectangle, Color.White, error ? 7.5f : 9f);
    }

    private void FormToast_Click(object sender, EventArgs e)
    {
        Close();
    }
}
