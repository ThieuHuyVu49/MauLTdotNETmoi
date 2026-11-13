namespace EnglishCenterManagement.Forms
{
    partial class FormCourseEdit
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
            this.lblHeaderIcon = new System.Windows.Forms.Label();
            this.lblHeaderTitle = new System.Windows.Forms.Label();
            this.lblHeaderSub = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.pnlName = new System.Windows.Forms.Panel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.pnlCode = new System.Windows.Forms.Panel();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.lblDuration = new System.Windows.Forms.Label();
            this.cboDuration = new System.Windows.Forms.ComboBox();
            this.lblFee = new System.Windows.Forms.Label();
            this.pnlFee = new System.Windows.Forms.Panel();
            this.txtFee = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.pnlDescription = new System.Windows.Forms.Panel();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pnlName.SuspendLayout();
            this.pnlCode.SuspendLayout();
            this.pnlFee.SuspendLayout();
            this.pnlDescription.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.SuspendLayout();
            // lblHeaderIcon
            this.lblHeaderIcon.Font = new System.Drawing.Font("Segoe MDL2 Assets", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHeaderIcon.ForeColor = System.Drawing.Color.FromArgb(39, 127, 201);
            this.lblHeaderIcon.Location = new System.Drawing.Point(24, 22);
            this.lblHeaderIcon.Name = "lblHeaderIcon";
            this.lblHeaderIcon.Size = new System.Drawing.Size(38, 38);
            this.lblHeaderIcon.TabIndex = 0;
            this.lblHeaderIcon.Tag = "#eaf5fe";
            this.lblHeaderIcon.Text = "\uE8F1";
            this.lblHeaderIcon.Paint += new System.Windows.Forms.PaintEventHandler(this.HeaderIcon_Paint);
            // lblHeaderTitle
            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeaderTitle.ForeColor = System.Drawing.Color.FromArgb(23, 36, 61);
            this.lblHeaderTitle.Location = new System.Drawing.Point(74, 19);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(134, 21);
            this.lblHeaderTitle.TabIndex = 1;
            this.lblHeaderTitle.Text = "Thêm khóa học";
            // lblHeaderSub
            this.lblHeaderSub.AutoSize = true;
            this.lblHeaderSub.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHeaderSub.ForeColor = System.Drawing.Color.FromArgb(135, 147, 163);
            this.lblHeaderSub.Location = new System.Drawing.Point(75, 43);
            this.lblHeaderSub.Name = "lblHeaderSub";
            this.lblHeaderSub.Size = new System.Drawing.Size(286, 13);
            this.lblHeaderSub.TabIndex = 2;
            this.lblHeaderSub.Text = "Thiết lập chương trình đào tạo và mức học phí.";
            // btnClose
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClose.Location = new System.Drawing.Point(526, 24);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 20;
            this.btnClose.TabStop = false;
            this.btnClose.Tag = "\uE711";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnCancel_Click);
            this.btnClose.Paint += new System.Windows.Forms.PaintEventHandler(this.Soft_Paint);
            // lblName
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(58, 73, 96);
            this.lblName.Location = new System.Drawing.Point(24, 100);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(86, 13);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Tên khóa học *";
            // pnlName
            this.pnlName.BackColor = System.Drawing.Color.FromArgb(250, 251, 252);
            this.pnlName.Controls.Add(this.txtName);
            this.pnlName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pnlName.Location = new System.Drawing.Point(24, 120);
            this.pnlName.Name = "pnlName";
            this.pnlName.Size = new System.Drawing.Size(258, 38);
            this.pnlName.TabIndex = 4;
            this.pnlName.Click += new System.EventHandler(this.Input_Click);
            this.pnlName.Paint += new System.Windows.Forms.PaintEventHandler(this.Input_Paint);
            // txtName
            this.txtName.BackColor = System.Drawing.Color.FromArgb(250, 251, 252);
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(31, 45, 68);
            this.txtName.Location = new System.Drawing.Point(12, 11);
            this.txtName.Name = "txtName";
            this.txtName.PlaceholderText = "Ví dụ: IELTS 6.5";
            this.txtName.Size = new System.Drawing.Size(234, 16);
            this.txtName.TabIndex = 0;
            // lblCode
            this.lblCode.AutoSize = true;
            this.lblCode.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCode.ForeColor = System.Drawing.Color.FromArgb(58, 73, 96);
            this.lblCode.Location = new System.Drawing.Point(298, 100);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(85, 13);
            this.lblCode.TabIndex = 5;
            this.lblCode.Text = "Mã khóa học *";
            // pnlCode
            this.pnlCode.BackColor = System.Drawing.Color.FromArgb(250, 251, 252);
            this.pnlCode.Controls.Add(this.txtCode);
            this.pnlCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pnlCode.Location = new System.Drawing.Point(298, 120);
            this.pnlCode.Name = "pnlCode";
            this.pnlCode.Size = new System.Drawing.Size(258, 38);
            this.pnlCode.TabIndex = 6;
            this.pnlCode.Click += new System.EventHandler(this.Input_Click);
            this.pnlCode.Paint += new System.Windows.Forms.PaintEventHandler(this.Input_Paint);
            // txtCode
            this.txtCode.BackColor = System.Drawing.Color.FromArgb(250, 251, 252);
            this.txtCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCode.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCode.ForeColor = System.Drawing.Color.FromArgb(31, 45, 68);
            this.txtCode.Location = new System.Drawing.Point(12, 11);
            this.txtCode.Name = "txtCode";
            this.txtCode.PlaceholderText = "IELTS-65";
            this.txtCode.Size = new System.Drawing.Size(234, 16);
            this.txtCode.TabIndex = 0;
            // lblDuration
            this.lblDuration.AutoSize = true;
            this.lblDuration.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDuration.ForeColor = System.Drawing.Color.FromArgb(58, 73, 96);
            this.lblDuration.Location = new System.Drawing.Point(24, 170);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(65, 13);
            this.lblDuration.TabIndex = 7;
            this.lblDuration.Text = "Thời lượng";
            this.cboDuration.BackColor = System.Drawing.Color.FromArgb(250, 251, 252);
            this.cboDuration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboDuration.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboDuration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDuration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboDuration.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboDuration.ForeColor = System.Drawing.Color.FromArgb(43, 58, 82);
            this.cboDuration.ItemHeight = 32;
            this.cboDuration.Items.AddRange(new object[] { "12 tuần · 36 buổi", "10 tuần · 30 buổi", "8 tuần · 24 buổi" });
            this.cboDuration.Location = new System.Drawing.Point(24, 190);
            this.cboDuration.Name = "cboDuration";
            this.cboDuration.Size = new System.Drawing.Size(258, 38);
            this.cboDuration.TabIndex = 8;
            this.cboDuration.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.Combo_DrawItem);
            // lblFee
            this.lblFee.AutoSize = true;
            this.lblFee.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFee.ForeColor = System.Drawing.Color.FromArgb(58, 73, 96);
            this.lblFee.Location = new System.Drawing.Point(298, 170);
            this.lblFee.Name = "lblFee";
            this.lblFee.Size = new System.Drawing.Size(58, 13);
            this.lblFee.TabIndex = 9;
            this.lblFee.Text = "Học phí *";
            // pnlFee
            this.pnlFee.BackColor = System.Drawing.Color.FromArgb(250, 251, 252);
            this.pnlFee.Controls.Add(this.txtFee);
            this.pnlFee.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pnlFee.Location = new System.Drawing.Point(298, 190);
            this.pnlFee.Name = "pnlFee";
            this.pnlFee.Size = new System.Drawing.Size(258, 38);
            this.pnlFee.TabIndex = 10;
            this.pnlFee.Click += new System.EventHandler(this.Input_Click);
            this.pnlFee.Paint += new System.Windows.Forms.PaintEventHandler(this.Input_Paint);
            // txtFee
            this.txtFee.BackColor = System.Drawing.Color.FromArgb(250, 251, 252);
            this.txtFee.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFee.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFee.ForeColor = System.Drawing.Color.FromArgb(31, 45, 68);
            this.txtFee.Location = new System.Drawing.Point(12, 11);
            this.txtFee.Name = "txtFee";
            this.txtFee.PlaceholderText = "8.900.000";
            this.txtFee.Size = new System.Drawing.Size(234, 16);
            this.txtFee.TabIndex = 0;
            // lblDescription
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDescription.ForeColor = System.Drawing.Color.FromArgb(58, 73, 96);
            this.lblDescription.Location = new System.Drawing.Point(24, 240);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(112, 13);
            this.lblDescription.TabIndex = 11;
            this.lblDescription.Text = "Mô tả chương trình";
            // pnlDescription
            this.pnlDescription.BackColor = System.Drawing.Color.FromArgb(250, 251, 252);
            this.pnlDescription.Controls.Add(this.txtDescription);
            this.pnlDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pnlDescription.Location = new System.Drawing.Point(24, 260);
            this.pnlDescription.Name = "pnlDescription";
            this.pnlDescription.Size = new System.Drawing.Size(532, 70);
            this.pnlDescription.TabIndex = 12;
            this.pnlDescription.Click += new System.EventHandler(this.Input_Click);
            this.pnlDescription.Paint += new System.Windows.Forms.PaintEventHandler(this.Input_Paint);
            // txtDescription
            this.txtDescription.AcceptsReturn = true;
            this.txtDescription.BackColor = System.Drawing.Color.FromArgb(250, 251, 252);
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDescription.ForeColor = System.Drawing.Color.FromArgb(31, 45, 68);
            this.txtDescription.Location = new System.Drawing.Point(12, 11);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PlaceholderText = "Mục tiêu và nội dung khóa học";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(508, 48);
            this.txtDescription.TabIndex = 0;
            // lblStatus
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(58, 73, 96);
            this.lblStatus.Location = new System.Drawing.Point(24, 342);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(63, 13);
            this.lblStatus.TabIndex = 13;
            this.lblStatus.Text = "Trạng thái";
            this.lblStatus.Visible = false;
            // cboStatus
            this.cboStatus.BackColor = System.Drawing.Color.FromArgb(250, 251, 252);
            this.cboStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboStatus.ForeColor = System.Drawing.Color.FromArgb(43, 58, 82);
            this.cboStatus.ItemHeight = 32;
            this.cboStatus.Items.AddRange(new object[] {
            "Đang tuyển sinh",
            "Tạm dừng"});
            this.cboStatus.Location = new System.Drawing.Point(24, 362);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(258, 38);
            this.cboStatus.TabIndex = 14;
            this.cboStatus.Visible = false;
            this.cboStatus.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.Combo_DrawItem);
            // pnlFooter
            this.pnlFooter.BackColor = System.Drawing.Color.FromArgb(250, 251, 252);
            this.pnlFooter.Controls.Add(this.btnDelete);
            this.pnlFooter.Controls.Add(this.btnCancel);
            this.pnlFooter.Controls.Add(this.btnSave);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 350);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(580, 68);
            this.pnlFooter.TabIndex = 15;
            this.pnlFooter.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlFooter_Paint);
            // btnDelete
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.Location = new System.Drawing.Point(24, 16);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(84, 36);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Tag = "\uE74D";
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnDelete.Paint += new System.Windows.Forms.PaintEventHandler(this.Danger_Paint);
            // btnCancel
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.Location = new System.Drawing.Point(328, 16);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(84, 36);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            this.btnCancel.Paint += new System.Windows.Forms.PaintEventHandler(this.Outline_Paint);
            // btnSave
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(422, 16);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(134, 36);
            this.btnSave.TabIndex = 0;
            this.btnSave.Tag = "\uE73E";
            this.btnSave.Text = "Tạo khóa học";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.Paint += new System.Windows.Forms.PaintEventHandler(this.Accent_Paint);
            // FormCourseEdit
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(580, 418);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.cboStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.pnlDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.pnlFee);
            this.Controls.Add(this.lblFee);
            this.Controls.Add(this.cboDuration);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.pnlCode);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.pnlName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblHeaderSub);
            this.Controls.Add(this.lblHeaderTitle);
            this.Controls.Add(this.lblHeaderIcon);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCourseEdit";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thêm khóa học";
            this.Load += new System.EventHandler(this.FormCourseEdit_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Dialog_Paint);
            this.pnlName.ResumeLayout(false);
            this.pnlName.PerformLayout();
            this.pnlCode.ResumeLayout(false);
            this.pnlCode.PerformLayout();
            this.pnlFee.ResumeLayout(false);
            this.pnlFee.PerformLayout();
            this.pnlDescription.ResumeLayout(false);
            this.pnlDescription.PerformLayout();
            this.pnlFooter.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblHeaderIcon;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Label lblHeaderSub;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel pnlName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Panel pnlCode;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.ComboBox cboDuration;
        private System.Windows.Forms.Label lblFee;
        private System.Windows.Forms.Panel pnlFee;
        private System.Windows.Forms.TextBox txtFee;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Panel pnlDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
    }
}
