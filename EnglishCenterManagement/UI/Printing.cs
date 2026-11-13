using System.Drawing.Printing;
using EnglishCenterManagement.Models;
using EnglishCenterManagement.Services;

namespace EnglishCenterManagement.UI;

public static class Printing
{
    private static void Preview(string title, bool landscape, PrintPageEventHandler page)
    {
        if (!new PrinterSettings().IsValid)
        {
            Ui.Toast("Vui lòng cài máy in hoặc Microsoft Print to PDF để xem trước và in.", true);
            return;
        }
        using var doc = new PrintDocument { DocumentName = title };
        doc.DefaultPageSettings.Landscape = landscape;
        doc.PrintPage += page;
        using var dlg = new PrintPreviewDialog
        {
            Document = doc, Text = title, Width = 1000, Height = 760, StartPosition = FormStartPosition.CenterScreen, UseAntiAlias = true
        };
        dlg.ShowDialog();
    }

    public static void Receipt(EnrollmentInfo en, PaymentInfo pay)
    {
        string center = SettingService.Get("CenterName", "Trung tâm Anh ngữ Northstar");
        string address = SettingService.Get("CenterAddress");
        string phone = SettingService.Get("CenterPhone");
        string email = SettingService.Get("CenterEmail");

        Preview("Phiếu thu " + pay.ReceiptNo, false, (s, e) =>
        {
            var g = e.Graphics;
            var m = e.MarginBounds;
            using var h1 = new Font("Segoe UI", 18, FontStyle.Bold);
            using var h2 = new Font("Segoe UI", 12, FontStyle.Bold);
            using var normal = new Font("Segoe UI", 10.5f);
            using var bold = new Font("Segoe UI", 10.5f, FontStyle.Bold);
            using var small = new Font("Segoe UI", 9f);
            using var blue = new SolidBrush(Ui.Hex("#207dd5"));
            using var ink = new SolidBrush(Ui.Hex("#17243d"));
            using var muted = new SolidBrush(Ui.Hex("#6b778a"));
            using var line = new Pen(Ui.Hex("#d5dde7"));
            var center1 = new StringFormat { Alignment = StringAlignment.Center };
            var right = new StringFormat { Alignment = StringAlignment.Far };

            float y = m.Top;
            g.DrawString(center.ToUpper(), h2, blue, m.Left, y);
            g.DrawString($"{address}\nĐT: {phone} · {email}", small, muted, m.Left, y + 24);
            g.DrawString($"Số phiếu: {pay.ReceiptNo}\nNgày thu: {Fmt.Date(DateTime.Parse(pay.PaidDate))}", small, muted, m.Right, y + 4, right);
            y += 80;
            g.DrawLine(line, m.Left, y, m.Right, y);
            y += 22;
            g.DrawString("PHIẾU THU HỌC PHÍ", h1, ink, new RectangleF(m.Left, y, m.Width, 36), center1);
            y += 56;

            void Row(string label, string value, Font f = null)
            {
                g.DrawString(label, normal, muted, m.Left + 10, y);
                g.DrawString(value, f ?? normal, ink, m.Right - 10, y, right);
                y += 30;
                g.DrawLine(line, m.Left, y - 6, m.Right, y - 6);
            }

            Row("Học viên", $"{en.StudentName} ({en.StudentCode})", bold);
            Row("Lớp học", en.ClassName);
            Row("Khóa học", en.CourseName);
            Row("Học phí gốc", Fmt.Money(en.BaseFee));
            Row("Ưu đãi áp dụng", en.DiscountPercent > 0 ? $"{en.Policy} (−{en.DiscountPercent:0}%)" : "Không áp dụng");
            Row("Học phí sau ưu đãi", Fmt.Money(en.FinalFee));
            Row("Phương thức", en.PlanDisplay);
            Row("Kỳ thanh toán", $"Kỳ {pay.InstallmentNo}/{en.Installments}");
            y += 8;
            var box = new RectangleF(m.Left, y, m.Width, 54);
            using (var fill = new SolidBrush(Ui.Hex("#f2f7fb"))) g.FillRectangle(fill, box);
            g.DrawString("SỐ TIỀN ĐÃ THU", bold, muted, box.Left + 14, box.Top + 16);
            g.DrawString(Fmt.Money(pay.Amount), h1, blue, box.Right - 14, box.Top + 10, right);
            y += 66;
            g.DrawString($"Còn lại phải thu: {Fmt.Money(en.Remaining)}", normal, muted, m.Left + 10, y);
            y += 60;
            float half = m.Width / 2f;
            g.DrawString("Người nộp tiền", bold, ink, new RectangleF(m.Left, y, half, 24), center1);
            g.DrawString("Người thu tiền", bold, ink, new RectangleF(m.Left + half, y, half, 24), center1);
            g.DrawString("(Ký, ghi rõ họ tên)", small, muted, new RectangleF(m.Left, y + 22, half, 20), center1);
            g.DrawString("(Ký, ghi rõ họ tên)", small, muted, new RectangleF(m.Left + half, y + 22, half, 20), center1);
            g.DrawString(en.StudentName, normal, ink, new RectangleF(m.Left, y + 100, half, 24), center1);
            g.DrawString(AppSession.User?.FullName ?? "", normal, ink, new RectangleF(m.Left + half, y + 100, half, 24), center1);
        });
    }

    public static void Certificate(ScoreRow r)
    {
        string center = SettingService.Get("CenterName", "Trung tâm Anh ngữ Northstar");
        string address = SettingService.Get("CenterAddress");

        Preview("Chứng nhận - " + r.FullName, true, (s, e) =>
        {
            var g = Ui.Smooth(e.Graphics);
            var page = e.MarginBounds;
            var outer = Rectangle.Inflate(page, 20, 20);
            using (var p = new Pen(Ui.Hex("#173b63"), 4)) g.DrawRectangle(p, outer);
            using (var p = new Pen(Ui.Hex("#68bdff"), 1.5f)) g.DrawRectangle(p, Rectangle.Inflate(outer, -12, -12));

            var c = new StringFormat { Alignment = StringAlignment.Center };
            using var brand = new Font("Segoe UI", 13, FontStyle.Bold);
            using var title = new Font("Segoe UI", 30, FontStyle.Bold);
            using var sub = new Font("Segoe UI", 13);
            using var name = new Font("Segoe UI", 34, FontStyle.Bold | FontStyle.Italic);
            using var body = new Font("Segoe UI", 13.5f);
            using var bold = new Font("Segoe UI", 13.5f, FontStyle.Bold);
            using var navy = new SolidBrush(Ui.Hex("#173b63"));
            using var blue = new SolidBrush(Ui.Hex("#207dd5"));
            using var muted = new SolidBrush(Ui.Hex("#6b778a"));

            float y = page.Top + 10;
            RectangleF Line(float h) { var rr = new RectangleF(page.Left, y, page.Width, h); y += h; return rr; }
            g.DrawString(center.ToUpper(), brand, blue, Line(34), c);
            g.DrawString("CHỨNG NHẬN HOÀN THÀNH KHÓA HỌC", title, navy, Line(70), c);
            g.DrawString("Trân trọng chứng nhận học viên", sub, muted, Line(40), c);
            g.DrawString(r.FullName, name, navy, Line(76), c);
            g.DrawString($"đã hoàn thành khóa học {r.CourseName} — lớp {r.ClassName}", body, navy, Line(36), c);
            g.DrawString($"Điểm giữa kỳ {r.Midterm:0.0} · Điểm cuối kỳ {r.Final:0.0} · Điểm trung bình {r.Average:0.0}", bold, blue, Line(36), c);
            g.DrawString($"Chuyên cần {r.AttendanceDisplay} buổi · Kết quả: {r.Result}", body, muted, Line(60), c);

            float half = page.Width / 2f;
            g.DrawString($"{address}\nNgày {DateTime.Today:dd} tháng {DateTime.Today:MM} năm {DateTime.Today:yyyy}", body, muted,
                new RectangleF(page.Left, y, half, 60), c);
            g.DrawString("GIÁM ĐỐC TRUNG TÂM\n(Ký tên, đóng dấu)", bold, navy, new RectangleF(page.Left + half, y, half, 60), c);
        });
    }
}
