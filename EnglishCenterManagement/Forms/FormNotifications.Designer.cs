namespace EnglishCenterManagement.Forms
{
    partial class FormNotifications
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSub = new System.Windows.Forms.Label();
            this.lblMarkRead = new System.Windows.Forms.Label();
            this.pnlLineTop = new System.Windows.Forms.Panel();
            this.pnlItem1 = new System.Windows.Forms.Panel();
            this.lblItem1Detail = new System.Windows.Forms.Label();
            this.lblItem1Title = new System.Windows.Forms.Label();
            this.lblItem1Icon = new System.Windows.Forms.Label();
            this.pnlItem2 = new System.Windows.Forms.Panel();
            this.lblItem2Detail = new System.Windows.Forms.Label();
            this.lblItem2Title = new System.Windows.Forms.Label();
            this.lblItem2Icon = new System.Windows.Forms.Label();
            this.pnlItem3 = new System.Windows.Forms.Panel();
            this.lblItem3Detail = new System.Windows.Forms.Label();
            this.lblItem3Title = new System.Windows.Forms.Label();
            this.lblItem3Icon = new System.Windows.Forms.Label();
            this.pnlLineBottom = new System.Windows.Forms.Panel();
            this.lblFooter = new System.Windows.Forms.Label();
            this.pnlItem1.SuspendLayout();
            this.pnlItem2.SuspendLayout();
            this.pnlItem3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(36, 50, 73);
            this.lblTitle.Location = new System.Drawing.Point(18, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(77, 19);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Thông báo";
            // 
            // lblSub
            // 
            this.lblSub.AutoSize = true;
            this.lblSub.Font = new System.Drawing.Font("Segoe UI", 7.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSub.ForeColor = System.Drawing.Color.FromArgb(152, 162, 176);
            this.lblSub.Location = new System.Drawing.Point(19, 37);
            this.lblSub.Name = "lblSub";
            this.lblSub.Size = new System.Drawing.Size(116, 13);
            this.lblSub.TabIndex = 1;
            this.lblSub.Text = "3 thông báo chưa đọc";
            // 
            // lblMarkRead
            // 
            this.lblMarkRead.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMarkRead.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMarkRead.ForeColor = System.Drawing.Color.FromArgb(38, 127, 201);
            this.lblMarkRead.Location = new System.Drawing.Point(200, 20);
            this.lblMarkRead.Name = "lblMarkRead";
            this.lblMarkRead.Size = new System.Drawing.Size(124, 20);
            this.lblMarkRead.TabIndex = 2;
            this.lblMarkRead.Text = "Đánh dấu đã đọc";
            this.lblMarkRead.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblMarkRead.Click += new System.EventHandler(this.lblMarkRead_Click);
            // 
            // pnlLineTop
            // 
            this.pnlLineTop.BackColor = System.Drawing.Color.FromArgb(237, 240, 244);
            this.pnlLineTop.Location = new System.Drawing.Point(0, 62);
            this.pnlLineTop.Name = "pnlLineTop";
            this.pnlLineTop.Size = new System.Drawing.Size(340, 1);
            this.pnlLineTop.TabIndex = 3;
            // 
            // pnlItem1
            // 
            this.pnlItem1.BackColor = System.Drawing.Color.White;
            this.pnlItem1.Controls.Add(this.lblItem1Detail);
            this.pnlItem1.Controls.Add(this.lblItem1Title);
            this.pnlItem1.Controls.Add(this.lblItem1Icon);
            this.pnlItem1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlItem1.Location = new System.Drawing.Point(8, 70);
            this.pnlItem1.Name = "pnlItem1";
            this.pnlItem1.Size = new System.Drawing.Size(324, 68);
            this.pnlItem1.TabIndex = 4;
            this.pnlItem1.Tag = "0";
            this.pnlItem1.Click += new System.EventHandler(this.Item_Click);
            // 
            // lblItem1Icon
            // 
            this.lblItem1Icon.Location = new System.Drawing.Point(10, 14);
            this.lblItem1Icon.Name = "lblItem1Icon";
            this.lblItem1Icon.Size = new System.Drawing.Size(36, 36);
            this.lblItem1Icon.TabIndex = 0;
            this.lblItem1Icon.Tag = "0";
            this.lblItem1Icon.Click += new System.EventHandler(this.Item_Click);
            this.lblItem1Icon.Paint += new System.Windows.Forms.PaintEventHandler(this.ItemIcon_Paint);
            // 
            // lblItem1Title
            // 
            this.lblItem1Title.AutoEllipsis = true;
            this.lblItem1Title.Font = new System.Drawing.Font("Segoe UI", 8.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblItem1Title.ForeColor = System.Drawing.Color.FromArgb(36, 50, 73);
            this.lblItem1Title.Location = new System.Drawing.Point(56, 12);
            this.lblItem1Title.Name = "lblItem1Title";
            this.lblItem1Title.Size = new System.Drawing.Size(260, 18);
            this.lblItem1Title.TabIndex = 1;
            this.lblItem1Title.Tag = "0";
            this.lblItem1Title.Text = "Có 3 phiếu đăng ký mới";
            this.lblItem1Title.Click += new System.EventHandler(this.Item_Click);
            // 
            // lblItem1Detail
            // 
            this.lblItem1Detail.Font = new System.Drawing.Font("Segoe UI", 7.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblItem1Detail.ForeColor = System.Drawing.Color.FromArgb(135, 147, 163);
            this.lblItem1Detail.Location = new System.Drawing.Point(56, 32);
            this.lblItem1Detail.Name = "lblItem1Detail";
            this.lblItem1Detail.Size = new System.Drawing.Size(260, 30);
            this.lblItem1Detail.TabIndex = 2;
            this.lblItem1Detail.Tag = "0";
            this.lblItem1Detail.Text = "Phiếu đăng ký trong 7 ngày gần nhất.";
            this.lblItem1Detail.Click += new System.EventHandler(this.Item_Click);
            // 
            // pnlItem2
            // 
            this.pnlItem2.BackColor = System.Drawing.Color.White;
            this.pnlItem2.Controls.Add(this.lblItem2Detail);
            this.pnlItem2.Controls.Add(this.lblItem2Title);
            this.pnlItem2.Controls.Add(this.lblItem2Icon);
            this.pnlItem2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlItem2.Location = new System.Drawing.Point(8, 142);
            this.pnlItem2.Name = "pnlItem2";
            this.pnlItem2.Size = new System.Drawing.Size(324, 68);
            this.pnlItem2.TabIndex = 5;
            this.pnlItem2.Tag = "1";
            this.pnlItem2.Click += new System.EventHandler(this.Item_Click);
            // 
            // lblItem2Icon
            // 
            this.lblItem2Icon.Location = new System.Drawing.Point(10, 14);
            this.lblItem2Icon.Name = "lblItem2Icon";
            this.lblItem2Icon.Size = new System.Drawing.Size(36, 36);
            this.lblItem2Icon.TabIndex = 0;
            this.lblItem2Icon.Tag = "1";
            this.lblItem2Icon.Click += new System.EventHandler(this.Item_Click);
            this.lblItem2Icon.Paint += new System.Windows.Forms.PaintEventHandler(this.ItemIcon_Paint);
            // 
            // lblItem2Title
            // 
            this.lblItem2Title.AutoEllipsis = true;
            this.lblItem2Title.Font = new System.Drawing.Font("Segoe UI", 8.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblItem2Title.ForeColor = System.Drawing.Color.FromArgb(36, 50, 73);
            this.lblItem2Title.Location = new System.Drawing.Point(56, 12);
            this.lblItem2Title.Name = "lblItem2Title";
            this.lblItem2Title.Size = new System.Drawing.Size(260, 18);
            this.lblItem2Title.TabIndex = 1;
            this.lblItem2Title.Tag = "1";
            this.lblItem2Title.Text = "Phát hiện xung đột lịch học";
            this.lblItem2Title.Click += new System.EventHandler(this.Item_Click);
            // 
            // lblItem2Detail
            // 
            this.lblItem2Detail.Font = new System.Drawing.Font("Segoe UI", 7.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblItem2Detail.ForeColor = System.Drawing.Color.FromArgb(135, 147, 163);
            this.lblItem2Detail.Location = new System.Drawing.Point(56, 32);
            this.lblItem2Detail.Name = "lblItem2Detail";
            this.lblItem2Detail.Size = new System.Drawing.Size(260, 30);
            this.lblItem2Detail.TabIndex = 2;
            this.lblItem2Detail.Tag = "1";
            this.lblItem2Detail.Text = "Phòng 201 bị trùng lịch lúc 18:00.";
            this.lblItem2Detail.Click += new System.EventHandler(this.Item_Click);
            // 
            // pnlItem3
            // 
            this.pnlItem3.BackColor = System.Drawing.Color.White;
            this.pnlItem3.Controls.Add(this.lblItem3Detail);
            this.pnlItem3.Controls.Add(this.lblItem3Title);
            this.pnlItem3.Controls.Add(this.lblItem3Icon);
            this.pnlItem3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlItem3.Location = new System.Drawing.Point(8, 214);
            this.pnlItem3.Name = "pnlItem3";
            this.pnlItem3.Size = new System.Drawing.Size(324, 68);
            this.pnlItem3.TabIndex = 6;
            this.pnlItem3.Tag = "2";
            this.pnlItem3.Click += new System.EventHandler(this.Item_Click);
            // 
            // lblItem3Icon
            // 
            this.lblItem3Icon.Location = new System.Drawing.Point(10, 14);
            this.lblItem3Icon.Name = "lblItem3Icon";
            this.lblItem3Icon.Size = new System.Drawing.Size(36, 36);
            this.lblItem3Icon.TabIndex = 0;
            this.lblItem3Icon.Tag = "2";
            this.lblItem3Icon.Click += new System.EventHandler(this.Item_Click);
            this.lblItem3Icon.Paint += new System.Windows.Forms.PaintEventHandler(this.ItemIcon_Paint);
            // 
            // lblItem3Title
            // 
            this.lblItem3Title.AutoEllipsis = true;
            this.lblItem3Title.Font = new System.Drawing.Font("Segoe UI", 8.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblItem3Title.ForeColor = System.Drawing.Color.FromArgb(36, 50, 73);
            this.lblItem3Title.Location = new System.Drawing.Point(56, 12);
            this.lblItem3Title.Name = "lblItem3Title";
            this.lblItem3Title.Size = new System.Drawing.Size(260, 18);
            this.lblItem3Title.TabIndex = 1;
            this.lblItem3Title.Tag = "2";
            this.lblItem3Title.Text = "Cảnh báo chuyên cần";
            this.lblItem3Title.Click += new System.EventHandler(this.Item_Click);
            // 
            // lblItem3Detail
            // 
            this.lblItem3Detail.Font = new System.Drawing.Font("Segoe UI", 7.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblItem3Detail.ForeColor = System.Drawing.Color.FromArgb(135, 147, 163);
            this.lblItem3Detail.Location = new System.Drawing.Point(56, 32);
            this.lblItem3Detail.Name = "lblItem3Detail";
            this.lblItem3Detail.Size = new System.Drawing.Size(260, 30);
            this.lblItem3Detail.TabIndex = 2;
            this.lblItem3Detail.Tag = "2";
            this.lblItem3Detail.Text = "3 học viên đã vắng quá 3 buổi.";
            this.lblItem3Detail.Click += new System.EventHandler(this.Item_Click);
            // 
            // pnlLineBottom
            // 
            this.pnlLineBottom.BackColor = System.Drawing.Color.FromArgb(237, 240, 244);
            this.pnlLineBottom.Location = new System.Drawing.Point(0, 290);
            this.pnlLineBottom.Name = "pnlLineBottom";
            this.pnlLineBottom.Size = new System.Drawing.Size(340, 1);
            this.pnlLineBottom.TabIndex = 7;
            // 
            // lblFooter
            // 
            this.lblFooter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblFooter.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFooter.ForeColor = System.Drawing.Color.FromArgb(38, 127, 201);
            this.lblFooter.Location = new System.Drawing.Point(1, 291);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(338, 42);
            this.lblFooter.TabIndex = 8;
            this.lblFooter.Text = "Xem cài đặt thông báo";
            this.lblFooter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFooter.Click += new System.EventHandler(this.lblFooter_Click);
            // 
            // FormNotifications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(340, 334);
            this.Controls.Add(this.lblFooter);
            this.Controls.Add(this.pnlLineBottom);
            this.Controls.Add(this.pnlItem3);
            this.Controls.Add(this.pnlItem2);
            this.Controls.Add(this.pnlItem1);
            this.Controls.Add(this.pnlLineTop);
            this.Controls.Add(this.lblMarkRead);
            this.Controls.Add(this.lblSub);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormNotifications";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Thông báo";
            this.Deactivate += new System.EventHandler(this.FormNotifications_Deactivate);
            this.Load += new System.EventHandler(this.FormNotifications_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormNotifications_Paint);
            this.pnlItem1.ResumeLayout(false);
            this.pnlItem2.ResumeLayout(false);
            this.pnlItem3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSub;
        private System.Windows.Forms.Label lblMarkRead;
        private System.Windows.Forms.Panel pnlLineTop;
        private System.Windows.Forms.Panel pnlItem1;
        private System.Windows.Forms.Label lblItem1Icon;
        private System.Windows.Forms.Label lblItem1Title;
        private System.Windows.Forms.Label lblItem1Detail;
        private System.Windows.Forms.Panel pnlItem2;
        private System.Windows.Forms.Label lblItem2Icon;
        private System.Windows.Forms.Label lblItem2Title;
        private System.Windows.Forms.Label lblItem2Detail;
        private System.Windows.Forms.Panel pnlItem3;
        private System.Windows.Forms.Label lblItem3Icon;
        private System.Windows.Forms.Label lblItem3Title;
        private System.Windows.Forms.Label lblItem3Detail;
        private System.Windows.Forms.Panel pnlLineBottom;
        private System.Windows.Forms.Label lblFooter;
    }
}
