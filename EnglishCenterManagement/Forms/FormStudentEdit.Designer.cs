namespace EnglishCenterManagement.Forms
{
    partial class FormStudentEdit
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
            this.lblBirth = new System.Windows.Forms.Label();
            this.pnlBirth = new System.Windows.Forms.Panel();
            this.txtBirth = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.pnlPhone = new System.Windows.Forms.Panel();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.pnlEmail = new System.Windows.Forms.Panel();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.pnlAddress = new System.Windows.Forms.Panel();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pnlName.SuspendLayout();
            this.pnlBirth.SuspendLayout();
            this.pnlPhone.SuspendLayout();
            this.pnlEmail.SuspendLayout();
            this.pnlAddress.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeaderIcon
            // 
            this.lblHeaderIcon.Font = new System.Drawing.Font("Segoe MDL2 Assets", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHeaderIcon.ForeColor = System.Drawing.Color.FromArgb(39, 127, 201);
            this.lblHeaderIcon.Location = new System.Drawing.Point(24, 22);
            this.lblHeaderIcon.Name = "lblHeaderIcon";
            this.lblHeaderIcon.Size = new System.Drawing.Size(38, 38);
            this.lblHeaderIcon.TabIndex = 0;
            this.lblHeaderIcon.Tag = "#eaf5fe";
            this.lblHeaderIcon.Text = "\uE8FA";
            this.lblHeaderIcon.Paint += new System.Windows.Forms.PaintEventHandler(this.HeaderIcon_Paint);
            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeaderTitle.ForeColor = System.Drawing.Color.FromArgb(23, 36, 61);
            this.lblHeaderTitle.Location = new System.Drawing.Point(74, 19);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(162, 21);
            this.lblHeaderTitle.TabIndex = 1;
            this.lblHeaderTitle.Text = "Thêm học viên mới";
            // 
            // lblHeaderSub
            // 
            this.lblHeaderSub.AutoSize = true;
            this.lblHeaderSub.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHeaderSub.ForeColor = System.Drawing.Color.FromArgb(135, 147, 163);
            this.lblHeaderSub.Location = new System.Drawing.Point(75, 43);
            this.lblHeaderSub.Name = "lblHeaderSub";
            this.lblHeaderSub.Size = new System.Drawing.Size(265, 13);
            this.lblHeaderSub.TabIndex = 2;
            this.lblHeaderSub.Text = "Tạo hồ sơ học viên và thông tin liên hệ.";
            // 
            // btnClose
            // 
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
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(58, 73, 96);
            this.lblName.Location = new System.Drawing.Point(24, 100);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(70, 13);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Họ và tên *";
            // 
            // pnlName
            // 
            this.pnlName.BackColor = System.Drawing.Color.FromArgb(250, 251, 252);
            this.pnlName.Controls.Add(this.txtName);
            this.pnlName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pnlName.Location = new System.Drawing.Point(24, 120);
            this.pnlName.Name = "pnlName";
            this.pnlName.Size = new System.Drawing.Size(258, 38);
            this.pnlName.TabIndex = 4;
            this.pnlName.Click += new System.EventHandler(this.Input_Click);
            this.pnlName.Paint += new System.Windows.Forms.PaintEventHandler(this.Input_Paint);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(250, 251, 252);
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(31, 45, 68);
            this.txtName.Location = new System.Drawing.Point(12, 11);
            this.txtName.Name = "txtName";
            this.txtName.PlaceholderText = "Nguyễn Văn An";
            this.txtName.Size = new System.Drawing.Size(234, 16);
            this.txtName.TabIndex = 0;
            // 
            // lblBirth
            // 
            this.lblBirth.AutoSize = true;
            this.lblBirth.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBirth.ForeColor = System.Drawing.Color.FromArgb(58, 73, 96);
            this.lblBirth.Location = new System.Drawing.Point(298, 100);
            this.lblBirth.Name = "lblBirth";
            this.lblBirth.Size = new System.Drawing.Size(60, 13);
            this.lblBirth.TabIndex = 5;
            this.lblBirth.Text = "Ngày sinh";
            // 
            // pnlBirth
            // 
            this.pnlBirth.BackColor = System.Drawing.Color.FromArgb(250, 251, 252);
            this.pnlBirth.Controls.Add(this.txtBirth);
            this.pnlBirth.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pnlBirth.Location = new System.Drawing.Point(298, 120);
            this.pnlBirth.Name = "pnlBirth";
            this.pnlBirth.Size = new System.Drawing.Size(258, 38);
            this.pnlBirth.TabIndex = 6;
            this.pnlBirth.Click += new System.EventHandler(this.Input_Click);
            this.pnlBirth.Paint += new System.Windows.Forms.PaintEventHandler(this.Input_Paint);
            // 
            // txtBirth
            // 
            this.txtBirth.BackColor = System.Drawing.Color.FromArgb(250, 251, 252);
            this.txtBirth.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBirth.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBirth.ForeColor = System.Drawing.Color.FromArgb(31, 45, 68);
            this.txtBirth.Location = new System.Drawing.Point(12, 11);
            this.txtBirth.Name = "txtBirth";
            this.txtBirth.PlaceholderText = "dd/mm/yyyy";
            this.txtBirth.Size = new System.Drawing.Size(234, 16);
            this.txtBirth.TabIndex = 0;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPhone.ForeColor = System.Drawing.Color.FromArgb(58, 73, 96);
            this.lblPhone.Location = new System.Drawing.Point(24, 170);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(93, 13);
            this.lblPhone.TabIndex = 7;
            this.lblPhone.Text = "Số điện thoại *";
            // 
            // pnlPhone
            // 
            this.pnlPhone.BackColor = System.Drawing.Color.FromArgb(250, 251, 252);
            this.pnlPhone.Controls.Add(this.txtPhone);
            this.pnlPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pnlPhone.Location = new System.Drawing.Point(24, 190);
            this.pnlPhone.Name = "pnlPhone";
            this.pnlPhone.Size = new System.Drawing.Size(258, 38);
            this.pnlPhone.TabIndex = 8;
            this.pnlPhone.Click += new System.EventHandler(this.Input_Click);
            this.pnlPhone.Paint += new System.Windows.Forms.PaintEventHandler(this.Input_Paint);
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.FromArgb(250, 251, 252);
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPhone.ForeColor = System.Drawing.Color.FromArgb(31, 45, 68);
            this.txtPhone.Location = new System.Drawing.Point(12, 11);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PlaceholderText = "0901 234 567";
            this.txtPhone.Size = new System.Drawing.Size(234, 16);
            this.txtPhone.TabIndex = 0;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(58, 73, 96);
            this.lblEmail.Location = new System.Drawing.Point(298, 170);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(36, 13);
            this.lblEmail.TabIndex = 9;
            this.lblEmail.Text = "Email";
            // 
            // pnlEmail
            // 
            this.pnlEmail.BackColor = System.Drawing.Color.FromArgb(250, 251, 252);
            this.pnlEmail.Controls.Add(this.txtEmail);
            this.pnlEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pnlEmail.Location = new System.Drawing.Point(298, 190);
            this.pnlEmail.Name = "pnlEmail";
            this.pnlEmail.Size = new System.Drawing.Size(258, 38);
            this.pnlEmail.TabIndex = 10;
            this.pnlEmail.Click += new System.EventHandler(this.Input_Click);
            this.pnlEmail.Paint += new System.Windows.Forms.PaintEventHandler(this.Input_Paint);
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(250, 251, 252);
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(31, 45, 68);
            this.txtEmail.Location = new System.Drawing.Point(12, 11);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PlaceholderText = "hocvien@email.com";
            this.txtEmail.Size = new System.Drawing.Size(234, 16);
            this.txtEmail.TabIndex = 0;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(58, 73, 96);
            this.lblStatus.Location = new System.Drawing.Point(24, 310);
            this.lblStatus.Visible = false;
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(63, 13);
            this.lblStatus.TabIndex = 11;
            this.lblStatus.Text = "Trạng thái";
            // 
            // cboStatus
            // 
            this.cboStatus.BackColor = System.Drawing.Color.FromArgb(250, 251, 252);
            this.cboStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboStatus.ForeColor = System.Drawing.Color.FromArgb(43, 58, 82);
            this.cboStatus.ItemHeight = 32;
            this.cboStatus.Items.AddRange(new object[] {
            "Đang học",
            "Bảo lưu",
            "Nghỉ"});
            this.cboStatus.Location = new System.Drawing.Point(24, 330);
            this.cboStatus.Visible = false;
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(258, 38);
            this.cboStatus.TabIndex = 12;
            this.cboStatus.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.Combo_DrawItem);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAddress.ForeColor = System.Drawing.Color.FromArgb(58, 73, 96);
            this.lblAddress.Location = new System.Drawing.Point(24, 240);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(45, 13);
            this.lblAddress.TabIndex = 13;
            this.lblAddress.Text = "Địa chỉ";
            // 
            // pnlAddress
            // 
            this.pnlAddress.BackColor = System.Drawing.Color.FromArgb(250, 251, 252);
            this.pnlAddress.Controls.Add(this.txtAddress);
            this.pnlAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pnlAddress.Location = new System.Drawing.Point(24, 260);
            this.pnlAddress.Name = "pnlAddress";
            this.pnlAddress.Size = new System.Drawing.Size(532, 38);
            this.pnlAddress.TabIndex = 14;
            this.pnlAddress.Click += new System.EventHandler(this.Input_Click);
            this.pnlAddress.Paint += new System.Windows.Forms.PaintEventHandler(this.Input_Paint);
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.FromArgb(250, 251, 252);
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAddress.ForeColor = System.Drawing.Color.FromArgb(31, 45, 68);
            this.txtAddress.Location = new System.Drawing.Point(12, 11);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PlaceholderText = "Nhập địa chỉ liên hệ";
            this.txtAddress.Size = new System.Drawing.Size(508, 16);
            this.txtAddress.TabIndex = 0;
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.FromArgb(250, 251, 252);
            this.pnlFooter.Controls.Add(this.btnDelete);
            this.pnlFooter.Controls.Add(this.btnCancel);
            this.pnlFooter.Controls.Add(this.btnSave);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 324);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(580, 68);
            this.pnlFooter.TabIndex = 15;
            this.pnlFooter.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlFooter_Paint);
            // 
            // btnDelete
            // 
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
            // 
            // btnCancel
            // 
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
            // 
            // btnSave
            // 
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
            this.btnSave.Text = "Thêm học viên";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.Paint += new System.Windows.Forms.PaintEventHandler(this.Accent_Paint);
            // 
            // FormStudentEdit
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(580, 392);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.cboStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.pnlEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.pnlPhone);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.pnlBirth);
            this.Controls.Add(this.lblBirth);
            this.Controls.Add(this.pnlName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblHeaderSub);
            this.Controls.Add(this.lblHeaderTitle);
            this.Controls.Add(this.lblHeaderIcon);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormStudentEdit";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Học viên";
            this.Load += new System.EventHandler(this.FormStudentEdit_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Dialog_Paint);
            this.pnlName.ResumeLayout(false);
            this.pnlName.PerformLayout();
            this.pnlBirth.ResumeLayout(false);
            this.pnlBirth.PerformLayout();
            this.pnlPhone.ResumeLayout(false);
            this.pnlPhone.PerformLayout();
            this.pnlEmail.ResumeLayout(false);
            this.pnlEmail.PerformLayout();
            this.pnlAddress.ResumeLayout(false);
            this.pnlAddress.PerformLayout();
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
        private System.Windows.Forms.Label lblBirth;
        private System.Windows.Forms.Panel pnlBirth;
        private System.Windows.Forms.TextBox txtBirth;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Panel pnlPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Panel pnlEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Panel pnlAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
    }
}
