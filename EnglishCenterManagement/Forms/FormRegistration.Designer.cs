namespace EnglishCenterManagement.Forms
{
    partial class FormRegistration
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
            this.lblStudent = new System.Windows.Forms.Label();
            this.cboStudent = new System.Windows.Forms.ComboBox();
            this.lblClass = new System.Windows.Forms.Label();
            this.cboClass = new System.Windows.Forms.ComboBox();
            this.lblPolicy = new System.Windows.Forms.Label();
            this.cboPolicy = new System.Windows.Forms.ComboBox();
            this.lblPlan = new System.Windows.Forms.Label();
            this.cboPlan = new System.Windows.Forms.ComboBox();
            this.pnlSummary = new System.Windows.Forms.Panel();
            this.lblSummary = new System.Windows.Forms.Label();
            this.lblBase = new System.Windows.Forms.Label();
            this.lblBaseValue = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblDiscountValue = new System.Windows.Forms.Label();
            this.lblFinal = new System.Windows.Forms.Label();
            this.lblFinalValue = new System.Windows.Forms.Label();
            this.lblInstallmentNote = new System.Windows.Forms.Label();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pnlSummary.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.SuspendLayout();
            // lblHeaderIcon
            this.lblHeaderIcon.Font = new System.Drawing.Font("Segoe MDL2 Assets", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHeaderIcon.ForeColor = System.Drawing.Color.FromArgb(39, 127, 201);
            this.lblHeaderIcon.Location = new System.Drawing.Point(24, 22);
            this.lblHeaderIcon.Name = "lblHeaderIcon";
            this.lblHeaderIcon.Size = new System.Drawing.Size(38, 38);
            this.lblHeaderIcon.Text = "\uE8C7";
            this.lblHeaderIcon.Paint += new System.Windows.Forms.PaintEventHandler(this.HeaderIcon_Paint);
            // lblHeaderTitle
            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeaderTitle.ForeColor = System.Drawing.Color.FromArgb(23, 36, 61);
            this.lblHeaderTitle.Location = new System.Drawing.Point(74, 19);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Text = "Tạo phiếu đăng ký";
            // lblHeaderSub
            this.lblHeaderSub.AutoSize = true;
            this.lblHeaderSub.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHeaderSub.ForeColor = System.Drawing.Color.FromArgb(135, 147, 163);
            this.lblHeaderSub.Location = new System.Drawing.Point(75, 43);
            this.lblHeaderSub.Name = "lblHeaderSub";
            this.lblHeaderSub.Text = "Chọn lớp, tính ưu đãi và phương thức thanh toán.";
            // btnClose
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClose.Location = new System.Drawing.Point(526, 24);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 9;
            this.btnClose.TabStop = false;
            this.btnClose.Tag = "\uE711";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnCancel_Click);
            this.btnClose.Paint += new System.Windows.Forms.PaintEventHandler(this.Soft_Paint);
            // lblStudent
            this.lblStudent.AutoSize = true;
            this.lblStudent.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStudent.ForeColor = System.Drawing.Color.FromArgb(58, 73, 96);
            this.lblStudent.Location = new System.Drawing.Point(24, 100);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Text = "Học viên *";
            // cboStudent
            this.cboStudent.BackColor = System.Drawing.Color.FromArgb(250, 251, 252);
            this.cboStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboStudent.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboStudent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboStudent.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboStudent.ForeColor = System.Drawing.Color.FromArgb(43, 58, 82);
            this.cboStudent.ItemHeight = 32;
            this.cboStudent.Location = new System.Drawing.Point(24, 120);
            this.cboStudent.Name = "cboStudent";
            this.cboStudent.Size = new System.Drawing.Size(532, 38);
            this.cboStudent.TabIndex = 0;
            this.cboStudent.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.Combo_DrawItem);
            this.cboStudent.SelectedIndexChanged += new System.EventHandler(this.cboStudent_SelectedIndexChanged);
            // lblClass
            this.lblClass.AutoSize = true;
            this.lblClass.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblClass.ForeColor = System.Drawing.Color.FromArgb(58, 73, 96);
            this.lblClass.Location = new System.Drawing.Point(24, 174);
            this.lblClass.Name = "lblClass";
            this.lblClass.Text = "Lớp đăng ký *";
            // cboClass
            this.cboClass.BackColor = System.Drawing.Color.FromArgb(250, 251, 252);
            this.cboClass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboClass.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboClass.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboClass.ForeColor = System.Drawing.Color.FromArgb(43, 58, 82);
            this.cboClass.ItemHeight = 32;
            this.cboClass.Location = new System.Drawing.Point(24, 194);
            this.cboClass.Name = "cboClass";
            this.cboClass.Size = new System.Drawing.Size(532, 38);
            this.cboClass.TabIndex = 1;
            this.cboClass.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.Combo_DrawItem);
            this.cboClass.SelectedIndexChanged += new System.EventHandler(this.Calculation_Changed);
            // lblPolicy
            this.lblPolicy.AutoSize = true;
            this.lblPolicy.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPolicy.ForeColor = System.Drawing.Color.FromArgb(58, 73, 96);
            this.lblPolicy.Location = new System.Drawing.Point(24, 248);
            this.lblPolicy.Name = "lblPolicy";
            this.lblPolicy.Text = "Chính sách ưu đãi";
            // cboPolicy
            this.cboPolicy.BackColor = System.Drawing.Color.FromArgb(250, 251, 252);
            this.cboPolicy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboPolicy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboPolicy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPolicy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboPolicy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboPolicy.ForeColor = System.Drawing.Color.FromArgb(43, 58, 82);
            this.cboPolicy.ItemHeight = 32;
            this.cboPolicy.Items.AddRange(new object[] {
                "Không áp dụng",
                "Học viên cũ −10%",
                "Đăng ký nhóm −10%",
                "Học viên cũ −10% + Đăng ký nhóm −10%"});
            this.cboPolicy.DropDownWidth = 350;
            this.cboPolicy.Location = new System.Drawing.Point(24, 268);
            this.cboPolicy.Name = "cboPolicy";
            this.cboPolicy.Size = new System.Drawing.Size(258, 38);
            this.cboPolicy.TabIndex = 2;
            this.cboPolicy.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.Policy_DrawItem);
            this.cboPolicy.SelectedIndexChanged += new System.EventHandler(this.cboPolicy_SelectedIndexChanged);
            // lblPlan
            this.lblPlan.AutoSize = true;
            this.lblPlan.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPlan.ForeColor = System.Drawing.Color.FromArgb(58, 73, 96);
            this.lblPlan.Location = new System.Drawing.Point(298, 248);
            this.lblPlan.Name = "lblPlan";
            this.lblPlan.Text = "Thanh toán";
            // cboPlan
            this.cboPlan.BackColor = System.Drawing.Color.FromArgb(250, 251, 252);
            this.cboPlan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboPlan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboPlan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboPlan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboPlan.ForeColor = System.Drawing.Color.FromArgb(43, 58, 82);
            this.cboPlan.ItemHeight = 32;
            this.cboPlan.Items.AddRange(new object[] { "Một lần", "Chia 2 kỳ", "Chia 3 kỳ" });
            this.cboPlan.Location = new System.Drawing.Point(298, 268);
            this.cboPlan.Name = "cboPlan";
            this.cboPlan.Size = new System.Drawing.Size(258, 38);
            this.cboPlan.TabIndex = 3;
            this.cboPlan.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.Combo_DrawItem);
            this.cboPlan.SelectedIndexChanged += new System.EventHandler(this.Calculation_Changed);
            // pnlSummary
            this.pnlSummary.BackColor = System.Drawing.Color.FromArgb(242, 247, 251);
            this.pnlSummary.Controls.Add(this.lblSummary);
            this.pnlSummary.Controls.Add(this.lblBase);
            this.pnlSummary.Controls.Add(this.lblBaseValue);
            this.pnlSummary.Controls.Add(this.lblDiscount);
            this.pnlSummary.Controls.Add(this.lblDiscountValue);
            this.pnlSummary.Controls.Add(this.lblFinal);
            this.pnlSummary.Controls.Add(this.lblFinalValue);
            this.pnlSummary.Location = new System.Drawing.Point(24, 326);
            this.pnlSummary.Name = "pnlSummary";
            this.pnlSummary.Size = new System.Drawing.Size(532, 144);
            this.pnlSummary.TabIndex = 4;
            this.pnlSummary.Paint += new System.Windows.Forms.PaintEventHandler(this.Summary_Paint);
            // lblSummary
            this.lblSummary.AutoSize = true;
            this.lblSummary.BackColor = System.Drawing.Color.Transparent;
            this.lblSummary.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSummary.ForeColor = System.Drawing.Color.FromArgb(64, 83, 106);
            this.lblSummary.Location = new System.Drawing.Point(16, 14);
            this.lblSummary.Name = "lblSummary";
            this.lblSummary.Text = "Học phí tạm tính";
            // lblBase
            this.lblBase.AutoSize = true;
            this.lblBase.BackColor = System.Drawing.Color.Transparent;
            this.lblBase.ForeColor = System.Drawing.Color.FromArgb(101, 116, 137);
            this.lblBase.Location = new System.Drawing.Point(16, 45);
            this.lblBase.Name = "lblBase";
            this.lblBase.Text = "Học phí gốc";
            // lblBaseValue
            this.lblBaseValue.BackColor = System.Drawing.Color.Transparent;
            this.lblBaseValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBaseValue.ForeColor = System.Drawing.Color.FromArgb(64, 83, 106);
            this.lblBaseValue.Location = new System.Drawing.Point(266, 43);
            this.lblBaseValue.Name = "lblBaseValue";
            this.lblBaseValue.Size = new System.Drawing.Size(250, 22);
            this.lblBaseValue.Text = "0đ";
            this.lblBaseValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // lblDiscount
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.BackColor = System.Drawing.Color.Transparent;
            this.lblDiscount.ForeColor = System.Drawing.Color.FromArgb(101, 116, 137);
            this.lblDiscount.Location = new System.Drawing.Point(16, 75);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Text = "Ưu đãi";
            // lblDiscountValue
            this.lblDiscountValue.BackColor = System.Drawing.Color.Transparent;
            this.lblDiscountValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDiscountValue.ForeColor = System.Drawing.Color.FromArgb(37, 150, 108);
            this.lblDiscountValue.Location = new System.Drawing.Point(266, 73);
            this.lblDiscountValue.Name = "lblDiscountValue";
            this.lblDiscountValue.Size = new System.Drawing.Size(250, 22);
            this.lblDiscountValue.Text = "−0đ";
            this.lblDiscountValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // lblFinal
            this.lblFinal.AutoSize = true;
            this.lblFinal.BackColor = System.Drawing.Color.Transparent;
            this.lblFinal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFinal.ForeColor = System.Drawing.Color.FromArgb(64, 83, 106);
            this.lblFinal.Location = new System.Drawing.Point(16, 113);
            this.lblFinal.Name = "lblFinal";
            this.lblFinal.Text = "Tổng thanh toán";
            // lblFinalValue
            this.lblFinalValue.BackColor = System.Drawing.Color.Transparent;
            this.lblFinalValue.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFinalValue.ForeColor = System.Drawing.Color.FromArgb(32, 123, 199);
            this.lblFinalValue.Location = new System.Drawing.Point(230, 104);
            this.lblFinalValue.Name = "lblFinalValue";
            this.lblFinalValue.Size = new System.Drawing.Size(286, 32);
            this.lblFinalValue.Text = "0đ";
            this.lblFinalValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // lblInstallmentNote
            this.lblInstallmentNote.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblInstallmentNote.ForeColor = System.Drawing.Color.FromArgb(135, 147, 163);
            this.lblInstallmentNote.Location = new System.Drawing.Point(24, 478);
            this.lblInstallmentNote.Name = "lblInstallmentNote";
            this.lblInstallmentNote.Size = new System.Drawing.Size(532, 22);
            this.lblInstallmentNote.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // pnlFooter
            this.pnlFooter.BackColor = System.Drawing.Color.FromArgb(250, 251, 252);
            this.pnlFooter.Controls.Add(this.btnCancel);
            this.pnlFooter.Controls.Add(this.btnSave);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 508);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(580, 68);
            this.pnlFooter.TabIndex = 5;
            this.pnlFooter.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlFooter_Paint);
            // btnCancel
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.Location = new System.Drawing.Point(286, 16);
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
            this.btnSave.Location = new System.Drawing.Point(380, 16);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(176, 36);
            this.btnSave.TabIndex = 0;
            this.btnSave.Tag = "\uE73E";
            this.btnSave.Text = "Tạo phiếu đăng ký";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.Paint += new System.Windows.Forms.PaintEventHandler(this.Accent_Paint);
            // FormRegistration
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(580, 576);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.lblInstallmentNote);
            this.Controls.Add(this.pnlSummary);
            this.Controls.Add(this.cboPlan);
            this.Controls.Add(this.lblPlan);
            this.Controls.Add(this.cboPolicy);
            this.Controls.Add(this.lblPolicy);
            this.Controls.Add(this.cboClass);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.cboStudent);
            this.Controls.Add(this.lblStudent);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblHeaderSub);
            this.Controls.Add(this.lblHeaderTitle);
            this.Controls.Add(this.lblHeaderIcon);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRegistration";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tạo phiếu đăng ký";
            this.Load += new System.EventHandler(this.FormRegistration_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Dialog_Paint);
            this.pnlSummary.ResumeLayout(false);
            this.pnlSummary.PerformLayout();
            this.pnlFooter.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblHeaderIcon;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Label lblHeaderSub;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.ComboBox cboStudent;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.ComboBox cboClass;
        private System.Windows.Forms.Label lblPolicy;
        private System.Windows.Forms.ComboBox cboPolicy;
        private System.Windows.Forms.Label lblPlan;
        private System.Windows.Forms.ComboBox cboPlan;
        private System.Windows.Forms.Panel pnlSummary;
        private System.Windows.Forms.Label lblSummary;
        private System.Windows.Forms.Label lblBase;
        private System.Windows.Forms.Label lblBaseValue;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblDiscountValue;
        private System.Windows.Forms.Label lblFinal;
        private System.Windows.Forms.Label lblFinalValue;
        private System.Windows.Forms.Label lblInstallmentNote;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
    }
}
