namespace EnglishCenterManagement.Forms
{
    partial class FormSchedule
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
            this.lblEyebrow = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pnlAlert = new System.Windows.Forms.Panel();
            this.btnResolve = new System.Windows.Forms.Button();
            this.lblAlertDetail = new System.Windows.Forms.Label();
            this.lblAlertTitle = new System.Windows.Forms.Label();
            this.lblAlertIcon = new System.Windows.Forms.Label();
            this.pnlCalendar = new System.Windows.Forms.Panel();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.btnToday = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblWeek = new System.Windows.Forms.Label();
            this.btnPrev = new System.Windows.Forms.Button();
            this.pnlAlert.SuspendLayout();
            this.pnlCalendar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEyebrow
            // 
            this.lblEyebrow.AutoSize = true;
            this.lblEyebrow.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEyebrow.ForeColor = System.Drawing.Color.FromArgb(37, 131, 215);
            this.lblEyebrow.Location = new System.Drawing.Point(31, 27);
            this.lblEyebrow.Name = "lblEyebrow";
            this.lblEyebrow.Size = new System.Drawing.Size(121, 12);
            this.lblEyebrow.TabIndex = 0;
            this.lblEyebrow.Text = "XẾP LỊCH THÔNG MINH";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(23, 36, 61);
            this.lblTitle.Location = new System.Drawing.Point(27, 42);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(237, 32);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Lịch học trung tâm";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDesc.ForeColor = System.Drawing.Color.FromArgb(135, 147, 163);
            this.lblDesc.Location = new System.Drawing.Point(31, 79);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(305, 15);
            this.lblDesc.TabIndex = 2;
            this.lblDesc.Text = "Kiểm tra trùng phòng và trùng lịch giáo viên tự động.";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(940, 46);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(145, 38);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Tag = "\uE710";
            this.btnAdd.Text = "Xếp lịch học";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnAdd.Paint += new System.Windows.Forms.PaintEventHandler(this.Primary_Paint);
            // 
            // pnlAlert
            // 
            this.pnlAlert.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAlert.BackColor = System.Drawing.Color.FromArgb(255, 248, 242);
            this.pnlAlert.Controls.Add(this.btnResolve);
            this.pnlAlert.Controls.Add(this.lblAlertDetail);
            this.pnlAlert.Controls.Add(this.lblAlertTitle);
            this.pnlAlert.Controls.Add(this.lblAlertIcon);
            this.pnlAlert.Location = new System.Drawing.Point(31, 116);
            this.pnlAlert.Name = "pnlAlert";
            this.pnlAlert.Size = new System.Drawing.Size(1054, 58);
            this.pnlAlert.TabIndex = 4;
            this.pnlAlert.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlAlert_Paint);
            // 
            // lblAlertIcon
            // 
            this.lblAlertIcon.Font = new System.Drawing.Font("Segoe MDL2 Assets", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAlertIcon.ForeColor = System.Drawing.Color.FromArgb(220, 124, 59);
            this.lblAlertIcon.Location = new System.Drawing.Point(14, 13);
            this.lblAlertIcon.Name = "lblAlertIcon";
            this.lblAlertIcon.Size = new System.Drawing.Size(32, 32);
            this.lblAlertIcon.TabIndex = 0;
            this.lblAlertIcon.Tag = "#ffe9da";
            this.lblAlertIcon.Text = "\uE7BA";
            this.lblAlertIcon.Paint += new System.Windows.Forms.PaintEventHandler(this.AlertIcon_Paint);
            // 
            // lblAlertTitle
            // 
            this.lblAlertTitle.AutoSize = true;
            this.lblAlertTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAlertTitle.ForeColor = System.Drawing.Color.FromArgb(135, 81, 45);
            this.lblAlertTitle.Location = new System.Drawing.Point(56, 11);
            this.lblAlertTitle.Name = "lblAlertTitle";
            this.lblAlertTitle.Size = new System.Drawing.Size(210, 15);
            this.lblAlertTitle.TabIndex = 1;
            this.lblAlertTitle.Text = "Phát hiện 0 xung đột lịch học";
            // 
            // lblAlertDetail
            // 
            this.lblAlertDetail.AutoSize = true;
            this.lblAlertDetail.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAlertDetail.ForeColor = System.Drawing.Color.FromArgb(173, 121, 86);
            this.lblAlertDetail.Location = new System.Drawing.Point(56, 31);
            this.lblAlertDetail.Name = "lblAlertDetail";
            this.lblAlertDetail.Size = new System.Drawing.Size(380, 13);
            this.lblAlertDetail.TabIndex = 2;
            this.lblAlertDetail.Text = "Không có phòng hoặc giáo viên bị trùng lịch.";
            // 
            // btnResolve
            // 
            this.btnResolve.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResolve.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResolve.FlatAppearance.BorderSize = 0;
            this.btnResolve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResolve.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnResolve.ForeColor = System.Drawing.Color.FromArgb(191, 105, 49);
            this.btnResolve.Location = new System.Drawing.Point(946, 13);
            this.btnResolve.Name = "btnResolve";
            this.btnResolve.Size = new System.Drawing.Size(94, 32);
            this.btnResolve.TabIndex = 3;
            this.btnResolve.Text = "Xử lý ngay";
            this.btnResolve.UseVisualStyleBackColor = false;
            this.btnResolve.Click += new System.EventHandler(this.btnResolve_Click);
            this.btnResolve.Paint += new System.Windows.Forms.PaintEventHandler(this.AlertButton_Paint);
            // 
            // pnlCalendar
            // 
            this.pnlCalendar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCalendar.BackColor = System.Drawing.Color.White;
            this.pnlCalendar.Controls.Add(this.pnlGrid);
            this.pnlCalendar.Controls.Add(this.btnToday);
            this.pnlCalendar.Controls.Add(this.btnNext);
            this.pnlCalendar.Controls.Add(this.lblWeek);
            this.pnlCalendar.Controls.Add(this.btnPrev);
            this.pnlCalendar.Location = new System.Drawing.Point(31, 188);
            this.pnlCalendar.Name = "pnlCalendar";
            this.pnlCalendar.Size = new System.Drawing.Size(1054, 566);
            this.pnlCalendar.TabIndex = 5;
            this.pnlCalendar.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCalendar_Paint);
            // 
            // btnPrev
            // 
            this.btnPrev.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrev.FlatAppearance.BorderSize = 0;
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrev.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPrev.ForeColor = System.Drawing.Color.FromArgb(113, 128, 148);
            this.btnPrev.Location = new System.Drawing.Point(16, 13);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(28, 28);
            this.btnPrev.TabIndex = 0;
            this.btnPrev.Tag = "\uE76B";
            this.btnPrev.UseVisualStyleBackColor = false;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            this.btnPrev.Paint += new System.Windows.Forms.PaintEventHandler(this.Nav_Paint);
            // 
            // lblWeek
            // 
            this.lblWeek.AutoSize = true;
            this.lblWeek.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWeek.ForeColor = System.Drawing.Color.FromArgb(23, 36, 61);
            this.lblWeek.Location = new System.Drawing.Point(54, 17);
            this.lblWeek.Name = "lblWeek";
            this.lblWeek.Size = new System.Drawing.Size(180, 19);
            this.lblWeek.TabIndex = 1;
            this.lblWeek.Text = "24 — 30 tháng 11, 2025";
            // 
            // btnNext
            // 
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNext.ForeColor = System.Drawing.Color.FromArgb(113, 128, 148);
            this.btnNext.Location = new System.Drawing.Point(242, 13);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(28, 28);
            this.btnNext.TabIndex = 2;
            this.btnNext.Tag = "\uE76C";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            this.btnNext.Paint += new System.Windows.Forms.PaintEventHandler(this.Nav_Paint);
            // 
            // btnToday
            // 
            this.btnToday.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnToday.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnToday.FlatAppearance.BorderSize = 0;
            this.btnToday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToday.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnToday.ForeColor = System.Drawing.Color.FromArgb(43, 127, 197);
            this.btnToday.Location = new System.Drawing.Point(958, 13);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(80, 28);
            this.btnToday.TabIndex = 3;
            this.btnToday.Text = "Hôm nay";
            this.btnToday.UseVisualStyleBackColor = false;
            this.btnToday.Click += new System.EventHandler(this.btnToday_Click);
            this.btnToday.Paint += new System.Windows.Forms.PaintEventHandler(this.Nav_Paint);
            // 
            // pnlGrid
            // 
            this.pnlGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGrid.BackColor = System.Drawing.Color.White;
            this.pnlGrid.Location = new System.Drawing.Point(1, 55);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(1052, 500);
            this.pnlGrid.TabIndex = 4;
            this.pnlGrid.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlGrid_Paint);
            this.pnlGrid.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlGrid_MouseClick);
            this.pnlGrid.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlGrid_MouseMove);
            this.pnlGrid.Resize += new System.EventHandler(this.pnlGrid_Resize);
            // 
            // FormSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(245, 247, 251);
            this.ClientSize = new System.Drawing.Size(1116, 790);
            this.Controls.Add(this.pnlCalendar);
            this.Controls.Add(this.pnlAlert);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblEyebrow);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSchedule";
            this.Text = "Lịch học";
            this.Load += new System.EventHandler(this.FormSchedule_Load);
            this.pnlAlert.ResumeLayout(false);
            this.pnlAlert.PerformLayout();
            this.pnlCalendar.ResumeLayout(false);
            this.pnlCalendar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblEyebrow;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel pnlAlert;
        private System.Windows.Forms.Label lblAlertIcon;
        private System.Windows.Forms.Label lblAlertTitle;
        private System.Windows.Forms.Label lblAlertDetail;
        private System.Windows.Forms.Button btnResolve;
        private System.Windows.Forms.Panel pnlCalendar;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Label lblWeek;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnToday;
        private System.Windows.Forms.Panel pnlGrid;
    }
}
