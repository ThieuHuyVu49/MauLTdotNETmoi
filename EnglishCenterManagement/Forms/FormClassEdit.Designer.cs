namespace EnglishCenterManagement.Forms
{
    partial class FormClassEdit
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
            this.lblCourse = new System.Windows.Forms.Label();
            this.cboCourse = new System.Windows.Forms.ComboBox();
            this.lblName = new System.Windows.Forms.Label();
            this.pnlName = new System.Windows.Forms.Panel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblSize = new System.Windows.Forms.Label();
            this.pnlSize = new System.Windows.Forms.Panel();
            this.numSize = new System.Windows.Forms.NumericUpDown();
            this.lblTeacher = new System.Windows.Forms.Label();
            this.cboTeacher = new System.Windows.Forms.ComboBox();
            this.lblRoom = new System.Windows.Forms.Label();
            this.cboRoom = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pnlName.SuspendLayout();
            this.pnlSize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSize)).BeginInit();
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
            this.lblHeaderIcon.Text = "\uE7BE";
            this.lblHeaderIcon.Paint += new System.Windows.Forms.PaintEventHandler(this.HeaderIcon_Paint);
            // lblHeaderTitle
            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeaderTitle.ForeColor = System.Drawing.Color.FromArgb(23, 36, 61);
            this.lblHeaderTitle.Location = new System.Drawing.Point(74, 19);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(116, 21);
            this.lblHeaderTitle.TabIndex = 1;
            this.lblHeaderTitle.Text = "Thêm lớp học";
            // lblHeaderSub
            this.lblHeaderSub.AutoSize = true;
            this.lblHeaderSub.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHeaderSub.ForeColor = System.Drawing.Color.FromArgb(135, 147, 163);
            this.lblHeaderSub.Location = new System.Drawing.Point(75, 43);
            this.lblHeaderSub.Name = "lblHeaderSub";
            this.lblHeaderSub.Size = new System.Drawing.Size(295, 13);
            this.lblHeaderSub.TabIndex = 2;
            this.lblHeaderSub.Text = "Mở lớp mới từ khóa học và phân công giảng viên.";
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
            // lblCourse
            this.lblCourse.AutoSize = true;
            this.lblCourse.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCourse.ForeColor = System.Drawing.Color.FromArgb(58, 73, 96);
            this.lblCourse.Location = new System.Drawing.Point(24, 100);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(70, 13);
            this.lblCourse.TabIndex = 3;
            this.lblCourse.Text = "Khóa học *";
            // cboCourse
            this.cboCourse.BackColor = System.Drawing.Color.FromArgb(250, 251, 252);
            this.cboCourse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboCourse.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCourse.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboCourse.ForeColor = System.Drawing.Color.FromArgb(43, 58, 82);
            this.cboCourse.ItemHeight = 32;
            this.cboCourse.Location = new System.Drawing.Point(24, 120);
            this.cboCourse.Name = "cboCourse";
            this.cboCourse.Size = new System.Drawing.Size(532, 38);
            this.cboCourse.TabIndex = 4;
            this.cboCourse.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.Combo_DrawItem);
            // lblName
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(58, 73, 96);
            this.lblName.Location = new System.Drawing.Point(24, 170);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(59, 13);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Tên lớp *";
            // pnlName
            this.pnlName.BackColor = System.Drawing.Color.FromArgb(250, 251, 252);
            this.pnlName.Controls.Add(this.txtName);
            this.pnlName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pnlName.Location = new System.Drawing.Point(24, 190);
            this.pnlName.Name = "pnlName";
            this.pnlName.Size = new System.Drawing.Size(258, 38);
            this.pnlName.TabIndex = 6;
            this.pnlName.Click += new System.EventHandler(this.Input_Click);
            this.pnlName.Paint += new System.Windows.Forms.PaintEventHandler(this.Input_Paint);
            // txtName
            this.txtName.BackColor = System.Drawing.Color.FromArgb(250, 251, 252);
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(31, 45, 68);
            this.txtName.Location = new System.Drawing.Point(12, 11);
            this.txtName.Name = "txtName";
            this.txtName.PlaceholderText = "IELTS Foundation 04";
            this.txtName.Size = new System.Drawing.Size(234, 16);
            this.txtName.TabIndex = 0;
            // lblSize
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSize.ForeColor = System.Drawing.Color.FromArgb(58, 73, 96);
            this.lblSize.Location = new System.Drawing.Point(298, 170);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(75, 13);
            this.lblSize.TabIndex = 7;
            this.lblSize.Text = "Sĩ số tối đa";
            // pnlSize
            this.pnlSize.BackColor = System.Drawing.Color.FromArgb(250, 251, 252);
            this.pnlSize.Controls.Add(this.numSize);
            this.pnlSize.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pnlSize.Location = new System.Drawing.Point(298, 190);
            this.pnlSize.Name = "pnlSize";
            this.pnlSize.Size = new System.Drawing.Size(258, 38);
            this.pnlSize.TabIndex = 8;
            this.pnlSize.Click += new System.EventHandler(this.Input_Click);
            this.pnlSize.Paint += new System.Windows.Forms.PaintEventHandler(this.Input_Paint);
            // numSize
            this.numSize.BackColor = System.Drawing.Color.FromArgb(250, 251, 252);
            this.numSize.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numSize.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numSize.ForeColor = System.Drawing.Color.FromArgb(31, 45, 68);
            this.numSize.Location = new System.Drawing.Point(12, 9);
            this.numSize.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            this.numSize.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numSize.Name = "numSize";
            this.numSize.Size = new System.Drawing.Size(234, 23);
            this.numSize.TabIndex = 0;
            this.numSize.Value = new decimal(new int[] { 24, 0, 0, 0 });
            // lblTeacher
            this.lblTeacher.AutoSize = true;
            this.lblTeacher.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTeacher.ForeColor = System.Drawing.Color.FromArgb(58, 73, 96);
            this.lblTeacher.Location = new System.Drawing.Point(24, 240);
            this.lblTeacher.Name = "lblTeacher";
            this.lblTeacher.Size = new System.Drawing.Size(68, 13);
            this.lblTeacher.TabIndex = 9;
            this.lblTeacher.Text = "Giảng viên";
            // cboTeacher
            this.cboTeacher.BackColor = System.Drawing.Color.FromArgb(250, 251, 252);
            this.cboTeacher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboTeacher.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboTeacher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboTeacher.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboTeacher.ForeColor = System.Drawing.Color.FromArgb(43, 58, 82);
            this.cboTeacher.ItemHeight = 32;
            this.cboTeacher.Location = new System.Drawing.Point(24, 260);
            this.cboTeacher.Name = "cboTeacher";
            this.cboTeacher.Size = new System.Drawing.Size(258, 38);
            this.cboTeacher.TabIndex = 10;
            this.cboTeacher.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.Combo_DrawItem);
            // lblRoom
            this.lblRoom.AutoSize = true;
            this.lblRoom.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRoom.ForeColor = System.Drawing.Color.FromArgb(58, 73, 96);
            this.lblRoom.Location = new System.Drawing.Point(298, 240);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(69, 13);
            this.lblRoom.TabIndex = 11;
            this.lblRoom.Text = "Phòng học";
            // cboRoom
            this.cboRoom.BackColor = System.Drawing.Color.FromArgb(250, 251, 252);
            this.cboRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboRoom.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboRoom.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboRoom.ForeColor = System.Drawing.Color.FromArgb(43, 58, 82);
            this.cboRoom.ItemHeight = 32;
            this.cboRoom.Location = new System.Drawing.Point(298, 260);
            this.cboRoom.Name = "cboRoom";
            this.cboRoom.Size = new System.Drawing.Size(258, 38);
            this.cboRoom.TabIndex = 12;
            this.cboRoom.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.Combo_DrawItem);
            // lblStatus
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(58, 73, 96);
            this.lblStatus.Location = new System.Drawing.Point(24, 310);
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
            this.cboStatus.Items.AddRange(new object[] { "Đang học", "Đã kết thúc" });
            this.cboStatus.Location = new System.Drawing.Point(24, 330);
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
            this.pnlFooter.Location = new System.Drawing.Point(0, 324);
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
            this.btnSave.Text = "Tạo lớp học";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.Paint += new System.Windows.Forms.PaintEventHandler(this.Accent_Paint);
            // FormClassEdit
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(580, 392);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.cboStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.cboRoom);
            this.Controls.Add(this.lblRoom);
            this.Controls.Add(this.cboTeacher);
            this.Controls.Add(this.lblTeacher);
            this.Controls.Add(this.pnlSize);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.pnlName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.cboCourse);
            this.Controls.Add(this.lblCourse);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblHeaderSub);
            this.Controls.Add(this.lblHeaderTitle);
            this.Controls.Add(this.lblHeaderIcon);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormClassEdit";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Lớp học";
            this.Load += new System.EventHandler(this.FormClassEdit_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Dialog_Paint);
            this.pnlName.ResumeLayout(false);
            this.pnlName.PerformLayout();
            this.pnlSize.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numSize)).EndInit();
            this.pnlFooter.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblHeaderIcon;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Label lblHeaderSub;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.ComboBox cboCourse;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel pnlName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Panel pnlSize;
        private System.Windows.Forms.NumericUpDown numSize;
        private System.Windows.Forms.Label lblTeacher;
        private System.Windows.Forms.ComboBox cboTeacher;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.ComboBox cboRoom;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
    }
}
