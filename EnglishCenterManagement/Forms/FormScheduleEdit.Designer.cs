namespace EnglishCenterManagement.Forms
{
    partial class FormScheduleEdit
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
            this.lblClass = new System.Windows.Forms.Label();
            this.cboClass = new System.Windows.Forms.ComboBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.pnlDate = new System.Windows.Forms.Panel();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblSlot = new System.Windows.Forms.Label();
            this.cboSlot = new System.Windows.Forms.ComboBox();
            this.lblRoom = new System.Windows.Forms.Label();
            this.cboRoom = new System.Windows.Forms.ComboBox();
            this.lblTeacher = new System.Windows.Forms.Label();
            this.cboTeacher = new System.Windows.Forms.ComboBox();
            this.pnlCheck = new System.Windows.Forms.Panel();
            this.lblCheckIcon = new System.Windows.Forms.Label();
            this.lblCheck = new System.Windows.Forms.Label();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pnlDate.SuspendLayout();
            this.pnlCheck.SuspendLayout();
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
            this.lblHeaderIcon.Text = "\uE787";
            this.lblHeaderIcon.Paint += new System.Windows.Forms.PaintEventHandler(this.HeaderIcon_Paint);
            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeaderTitle.ForeColor = System.Drawing.Color.FromArgb(23, 36, 61);
            this.lblHeaderTitle.Location = new System.Drawing.Point(74, 19);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(175, 21);
            this.lblHeaderTitle.TabIndex = 1;
            this.lblHeaderTitle.Text = "Xếp lịch học mới";
            // 
            // lblHeaderSub
            // 
            this.lblHeaderSub.AutoSize = true;
            this.lblHeaderSub.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHeaderSub.ForeColor = System.Drawing.Color.FromArgb(135, 147, 163);
            this.lblHeaderSub.Location = new System.Drawing.Point(75, 43);
            this.lblHeaderSub.Name = "lblHeaderSub";
            this.lblHeaderSub.Size = new System.Drawing.Size(282, 13);
            this.lblHeaderSub.TabIndex = 2;
            this.lblHeaderSub.Text = "Hệ thống sẽ tự kiểm tra trùng phòng và giáo viên.";
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
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblClass.ForeColor = System.Drawing.Color.FromArgb(58, 73, 96);
            this.lblClass.Location = new System.Drawing.Point(24, 100);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(67, 13);
            this.lblClass.TabIndex = 3;
            this.lblClass.Text = "Lớp học *";
            // 
            // cboClass
            // 
            this.cboClass.BackColor = System.Drawing.Color.FromArgb(250, 251, 252);
            this.cboClass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboClass.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboClass.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboClass.ForeColor = System.Drawing.Color.FromArgb(43, 58, 82);
            this.cboClass.ItemHeight = 32;
            this.cboClass.Location = new System.Drawing.Point(24, 120);
            this.cboClass.Name = "cboClass";
            this.cboClass.Size = new System.Drawing.Size(532, 38);
            this.cboClass.TabIndex = 4;
            this.cboClass.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.Combo_DrawItem);
            this.cboClass.SelectedIndexChanged += new System.EventHandler(this.cboClass_SelectedIndexChanged);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(58, 73, 96);
            this.lblDate.Location = new System.Drawing.Point(24, 170);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(72, 13);
            this.lblDate.TabIndex = 5;
            this.lblDate.Text = "Ngày học *";
            // 
            // pnlDate
            // 
            this.pnlDate.BackColor = System.Drawing.Color.FromArgb(250, 251, 252);
            this.pnlDate.Controls.Add(this.dtpDate);
            this.pnlDate.Location = new System.Drawing.Point(24, 190);
            this.pnlDate.Name = "pnlDate";
            this.pnlDate.Size = new System.Drawing.Size(258, 38);
            this.pnlDate.TabIndex = 6;
            this.pnlDate.Click += new System.EventHandler(this.pnlDate_Click);
            this.pnlDate.Paint += new System.Windows.Forms.PaintEventHandler(this.Input_Paint);
            // 
            // dtpDate
            // 
            this.dtpDate.CalendarForeColor = System.Drawing.Color.FromArgb(43, 58, 82);
            this.dtpDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(250, 251, 252);
            this.dtpDate.CustomFormat = "dd/MM/yyyy";
            this.dtpDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(12, 7);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(234, 23);
            this.dtpDate.TabIndex = 0;
            this.dtpDate.ValueChanged += new System.EventHandler(this.Field_Changed);
            // 
            // lblSlot
            // 
            this.lblSlot.AutoSize = true;
            this.lblSlot.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSlot.ForeColor = System.Drawing.Color.FromArgb(58, 73, 96);
            this.lblSlot.Location = new System.Drawing.Point(298, 170);
            this.lblSlot.Name = "lblSlot";
            this.lblSlot.Size = new System.Drawing.Size(75, 13);
            this.lblSlot.TabIndex = 7;
            this.lblSlot.Text = "Khung giờ *";
            // 
            // cboSlot
            // 
            this.cboSlot.BackColor = System.Drawing.Color.FromArgb(250, 251, 252);
            this.cboSlot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboSlot.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboSlot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSlot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboSlot.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboSlot.ForeColor = System.Drawing.Color.FromArgb(43, 58, 82);
            this.cboSlot.ItemHeight = 32;
            this.cboSlot.Location = new System.Drawing.Point(298, 190);
            this.cboSlot.Name = "cboSlot";
            this.cboSlot.Size = new System.Drawing.Size(258, 38);
            this.cboSlot.TabIndex = 8;
            this.cboSlot.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.Combo_DrawItem);
            this.cboSlot.SelectedIndexChanged += new System.EventHandler(this.Field_Changed);
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRoom.ForeColor = System.Drawing.Color.FromArgb(58, 73, 96);
            this.lblRoom.Location = new System.Drawing.Point(24, 240);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(69, 13);
            this.lblRoom.TabIndex = 9;
            this.lblRoom.Text = "Phòng học";
            // 
            // cboRoom
            // 
            this.cboRoom.BackColor = System.Drawing.Color.FromArgb(250, 251, 252);
            this.cboRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboRoom.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboRoom.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboRoom.ForeColor = System.Drawing.Color.FromArgb(43, 58, 82);
            this.cboRoom.ItemHeight = 32;
            this.cboRoom.Location = new System.Drawing.Point(24, 260);
            this.cboRoom.Name = "cboRoom";
            this.cboRoom.Size = new System.Drawing.Size(258, 38);
            this.cboRoom.TabIndex = 10;
            this.cboRoom.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.Combo_DrawItem);
            this.cboRoom.SelectedIndexChanged += new System.EventHandler(this.Field_Changed);
            // 
            // lblTeacher
            // 
            this.lblTeacher.AutoSize = true;
            this.lblTeacher.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTeacher.ForeColor = System.Drawing.Color.FromArgb(58, 73, 96);
            this.lblTeacher.Location = new System.Drawing.Point(298, 240);
            this.lblTeacher.Name = "lblTeacher";
            this.lblTeacher.Size = new System.Drawing.Size(72, 13);
            this.lblTeacher.TabIndex = 11;
            this.lblTeacher.Text = "Giảng viên";
            // 
            // cboTeacher
            // 
            this.cboTeacher.BackColor = System.Drawing.Color.FromArgb(250, 251, 252);
            this.cboTeacher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboTeacher.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboTeacher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboTeacher.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboTeacher.ForeColor = System.Drawing.Color.FromArgb(43, 58, 82);
            this.cboTeacher.ItemHeight = 32;
            this.cboTeacher.Location = new System.Drawing.Point(298, 260);
            this.cboTeacher.Name = "cboTeacher";
            this.cboTeacher.Size = new System.Drawing.Size(258, 38);
            this.cboTeacher.TabIndex = 12;
            this.cboTeacher.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.Combo_DrawItem);
            this.cboTeacher.SelectedIndexChanged += new System.EventHandler(this.Field_Changed);
            // 
            // pnlCheck
            // 
            this.pnlCheck.BackColor = System.Drawing.Color.FromArgb(234, 248, 242);
            this.pnlCheck.Controls.Add(this.lblCheck);
            this.pnlCheck.Controls.Add(this.lblCheckIcon);
            this.pnlCheck.Location = new System.Drawing.Point(24, 314);
            this.pnlCheck.Name = "pnlCheck";
            this.pnlCheck.Size = new System.Drawing.Size(532, 60);
            this.pnlCheck.TabIndex = 13;
            this.pnlCheck.Paint += new System.Windows.Forms.PaintEventHandler(this.Check_Paint);
            // 
            // lblCheckIcon
            // 
            this.lblCheckIcon.Font = new System.Drawing.Font("Segoe MDL2 Assets", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCheckIcon.ForeColor = System.Drawing.Color.FromArgb(39, 132, 96);
            this.lblCheckIcon.Location = new System.Drawing.Point(10, 17);
            this.lblCheckIcon.Name = "lblCheckIcon";
            this.lblCheckIcon.Size = new System.Drawing.Size(24, 24);
            this.lblCheckIcon.TabIndex = 0;
            this.lblCheckIcon.Text = "\uE73E";
            this.lblCheckIcon.Paint += new System.Windows.Forms.PaintEventHandler(this.CheckIcon_Paint);
            // 
            // lblCheck
            // 
            this.lblCheck.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCheck.ForeColor = System.Drawing.Color.FromArgb(39, 132, 96);
            this.lblCheck.Location = new System.Drawing.Point(43, 8);
            this.lblCheck.Name = "lblCheck";
            this.lblCheck.Size = new System.Drawing.Size(477, 44);
            this.lblCheck.TabIndex = 1;
            this.lblCheck.Text = "Không phát hiện xung đột phòng hoặc giáo viên";
            this.lblCheck.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.FromArgb(250, 251, 252);
            this.pnlFooter.Controls.Add(this.btnCancel);
            this.pnlFooter.Controls.Add(this.btnSave);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 394);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(580, 68);
            this.pnlFooter.TabIndex = 14;
            this.pnlFooter.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlFooter_Paint);
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
            this.btnSave.Text = "Xếp lịch";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.Paint += new System.Windows.Forms.PaintEventHandler(this.Accent_Paint);
            // 
            // FormScheduleEdit
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(580, 462);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlCheck);
            this.Controls.Add(this.cboTeacher);
            this.Controls.Add(this.lblTeacher);
            this.Controls.Add(this.cboRoom);
            this.Controls.Add(this.lblRoom);
            this.Controls.Add(this.cboSlot);
            this.Controls.Add(this.lblSlot);
            this.Controls.Add(this.pnlDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.cboClass);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblHeaderSub);
            this.Controls.Add(this.lblHeaderTitle);
            this.Controls.Add(this.lblHeaderIcon);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormScheduleEdit";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Xếp lịch học mới";
            this.Load += new System.EventHandler(this.FormScheduleEdit_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Dialog_Paint);
            this.pnlDate.ResumeLayout(false);
            this.pnlCheck.ResumeLayout(false);
            this.pnlFooter.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblHeaderIcon;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Label lblHeaderSub;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.ComboBox cboClass;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Panel pnlDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblSlot;
        private System.Windows.Forms.ComboBox cboSlot;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.ComboBox cboRoom;
        private System.Windows.Forms.Label lblTeacher;
        private System.Windows.Forms.ComboBox cboTeacher;
        private System.Windows.Forms.Panel pnlCheck;
        private System.Windows.Forms.Label lblCheckIcon;
        private System.Windows.Forms.Label lblCheck;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
    }
}
