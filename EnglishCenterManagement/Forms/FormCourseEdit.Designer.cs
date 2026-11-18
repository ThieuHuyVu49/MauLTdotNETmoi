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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblHeaderIcon = new System.Windows.Forms.Label();
            lblHeaderTitle = new System.Windows.Forms.Label();
            lblHeaderSub = new System.Windows.Forms.Label();
            btnClose = new System.Windows.Forms.Button();
            lblName = new System.Windows.Forms.Label();
            pnlName = new System.Windows.Forms.Panel();
            txtName = new System.Windows.Forms.TextBox();
            lblCode = new System.Windows.Forms.Label();
            pnlCode = new System.Windows.Forms.Panel();
            txtCode = new System.Windows.Forms.TextBox();
            lblDuration = new System.Windows.Forms.Label();
            cboDuration = new System.Windows.Forms.ComboBox();
            lblFee = new System.Windows.Forms.Label();
            pnlFee = new System.Windows.Forms.Panel();
            txtFee = new System.Windows.Forms.TextBox();
            lblDescription = new System.Windows.Forms.Label();
            pnlDescription = new System.Windows.Forms.Panel();
            txtDescription = new System.Windows.Forms.TextBox();
            lblStatus = new System.Windows.Forms.Label();
            cboStatus = new System.Windows.Forms.ComboBox();
            pnlFooter = new System.Windows.Forms.Panel();
            btnDelete = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            btnSave = new System.Windows.Forms.Button();
            pnlName.SuspendLayout();
            pnlCode.SuspendLayout();
            pnlFee.SuspendLayout();
            pnlDescription.SuspendLayout();
            pnlFooter.SuspendLayout();
            SuspendLayout();
            // 
            // lblHeaderIcon
            // 
            lblHeaderIcon.Font = new System.Drawing.Font("Segoe MDL2 Assets", 11F);
            lblHeaderIcon.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)39)), ((int)((byte)127)), ((int)((byte)201)));
            lblHeaderIcon.Location = new System.Drawing.Point(27, 29);
            lblHeaderIcon.Name = "lblHeaderIcon";
            lblHeaderIcon.Size = new System.Drawing.Size(43, 51);
            lblHeaderIcon.TabIndex = 0;
            lblHeaderIcon.Tag = "#eaf5fe";
            lblHeaderIcon.Text = "";
            lblHeaderIcon.Paint += HeaderIcon_Paint;
            // 
            // lblHeaderTitle
            // 
            lblHeaderTitle.AutoSize = true;
            lblHeaderTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            lblHeaderTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)23)), ((int)((byte)36)), ((int)((byte)61)));
            lblHeaderTitle.Location = new System.Drawing.Point(85, 25);
            lblHeaderTitle.Name = "lblHeaderTitle";
            lblHeaderTitle.Size = new System.Drawing.Size(157, 28);
            lblHeaderTitle.TabIndex = 1;
            lblHeaderTitle.Text = "Thêm khóa học";
            // 
            // lblHeaderSub
            // 
            lblHeaderSub.AutoSize = true;
            lblHeaderSub.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            lblHeaderSub.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)135)), ((int)((byte)147)), ((int)((byte)163)));
            lblHeaderSub.Location = new System.Drawing.Point(86, 57);
            lblHeaderSub.Name = "lblHeaderSub";
            lblHeaderSub.Size = new System.Drawing.Size(295, 19);
            lblHeaderSub.TabIndex = 2;
            lblHeaderSub.Text = "Thiết lập chương trình đào tạo và mức học phí.";
            // 
            // btnClose
            // 
            btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnClose.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            btnClose.Location = new System.Drawing.Point(601, 32);
            btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(34, 40);
            btnClose.TabIndex = 20;
            btnClose.TabStop = false;
            btnClose.Tag = "";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnCancel_Click;
            btnClose.Paint += Soft_Paint;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            lblName.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)58)), ((int)((byte)73)), ((int)((byte)96)));
            lblName.Location = new System.Drawing.Point(27, 133);
            lblName.Name = "lblName";
            lblName.Size = new System.Drawing.Size(107, 19);
            lblName.TabIndex = 3;
            lblName.Text = "Tên khóa học *";
            // 
            // pnlName
            // 
            pnlName.BackColor = System.Drawing.Color.FromArgb(((int)((byte)250)), ((int)((byte)251)), ((int)((byte)252)));
            pnlName.Controls.Add(txtName);
            pnlName.Cursor = System.Windows.Forms.Cursors.IBeam;
            pnlName.Location = new System.Drawing.Point(27, 160);
            pnlName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pnlName.Name = "pnlName";
            pnlName.Size = new System.Drawing.Size(295, 51);
            pnlName.TabIndex = 4;
            pnlName.Click += Input_Click;
            pnlName.Paint += Input_Paint;
            // 
            // txtName
            // 
            txtName.BackColor = System.Drawing.Color.FromArgb(((int)((byte)250)), ((int)((byte)251)), ((int)((byte)252)));
            txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtName.Font = new System.Drawing.Font("Segoe UI", 9F);
            txtName.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)31)), ((int)((byte)45)), ((int)((byte)68)));
            txtName.Location = new System.Drawing.Point(14, 15);
            txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Ví dụ: IELTS 6.5";
            txtName.Size = new System.Drawing.Size(267, 20);
            txtName.TabIndex = 0;
            // 
            // lblCode
            // 
            lblCode.AutoSize = true;
            lblCode.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            lblCode.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)58)), ((int)((byte)73)), ((int)((byte)96)));
            lblCode.Location = new System.Drawing.Point(341, 133);
            lblCode.Name = "lblCode";
            lblCode.Size = new System.Drawing.Size(105, 19);
            lblCode.TabIndex = 5;
            lblCode.Text = "Mã khóa học *";
            // 
            // pnlCode
            // 
            pnlCode.BackColor = System.Drawing.Color.FromArgb(((int)((byte)250)), ((int)((byte)251)), ((int)((byte)252)));
            pnlCode.Controls.Add(txtCode);
            pnlCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            pnlCode.Location = new System.Drawing.Point(341, 160);
            pnlCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pnlCode.Name = "pnlCode";
            pnlCode.Size = new System.Drawing.Size(295, 51);
            pnlCode.TabIndex = 6;
            pnlCode.Click += Input_Click;
            pnlCode.Paint += Input_Paint;
            // 
            // txtCode
            // 
            txtCode.BackColor = System.Drawing.Color.FromArgb(((int)((byte)250)), ((int)((byte)251)), ((int)((byte)252)));
            txtCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtCode.Font = new System.Drawing.Font("Segoe UI", 9F);
            txtCode.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)31)), ((int)((byte)45)), ((int)((byte)68)));
            txtCode.Location = new System.Drawing.Point(14, 15);
            txtCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtCode.Name = "txtCode";
            txtCode.PlaceholderText = "IELTS-65";
            txtCode.Size = new System.Drawing.Size(267, 20);
            txtCode.TabIndex = 0;
            // 
            // lblDuration
            // 
            lblDuration.AutoSize = true;
            lblDuration.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            lblDuration.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)58)), ((int)((byte)73)), ((int)((byte)96)));
            lblDuration.Location = new System.Drawing.Point(27, 227);
            lblDuration.Name = "lblDuration";
            lblDuration.Size = new System.Drawing.Size(81, 19);
            lblDuration.TabIndex = 7;
            lblDuration.Text = "Thời lượng";
            // 
            // cboDuration
            // 
            cboDuration.BackColor = System.Drawing.Color.FromArgb(((int)((byte)250)), ((int)((byte)251)), ((int)((byte)252)));
            cboDuration.Cursor = System.Windows.Forms.Cursors.Hand;
            cboDuration.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            cboDuration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboDuration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboDuration.Font = new System.Drawing.Font("Segoe UI", 9F);
            cboDuration.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)43)), ((int)((byte)58)), ((int)((byte)82)));
            cboDuration.ItemHeight = 32;
            cboDuration.Items.AddRange(new object[] { "12 tuần · 36 buổi", "10 tuần · 30 buổi", "8 tuần · 24 buổi" });
            cboDuration.Location = new System.Drawing.Point(27, 253);
            cboDuration.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cboDuration.Name = "cboDuration";
            cboDuration.Size = new System.Drawing.Size(294, 38);
            cboDuration.TabIndex = 8;
            cboDuration.DrawItem += Combo_DrawItem;
            // 
            // lblFee
            // 
            lblFee.AutoSize = true;
            lblFee.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            lblFee.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)58)), ((int)((byte)73)), ((int)((byte)96)));
            lblFee.Location = new System.Drawing.Point(341, 227);
            lblFee.Name = "lblFee";
            lblFee.Size = new System.Drawing.Size(71, 19);
            lblFee.TabIndex = 9;
            lblFee.Text = "Học phí *";
            // 
            // pnlFee
            // 
            pnlFee.BackColor = System.Drawing.Color.FromArgb(((int)((byte)250)), ((int)((byte)251)), ((int)((byte)252)));
            pnlFee.Controls.Add(txtFee);
            pnlFee.Cursor = System.Windows.Forms.Cursors.IBeam;
            pnlFee.Location = new System.Drawing.Point(341, 253);
            pnlFee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pnlFee.Name = "pnlFee";
            pnlFee.Size = new System.Drawing.Size(295, 51);
            pnlFee.TabIndex = 10;
            pnlFee.Click += Input_Click;
            pnlFee.Paint += Input_Paint;
            // 
            // txtFee
            // 
            txtFee.BackColor = System.Drawing.Color.FromArgb(((int)((byte)250)), ((int)((byte)251)), ((int)((byte)252)));
            txtFee.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtFee.Font = new System.Drawing.Font("Segoe UI", 9F);
            txtFee.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)31)), ((int)((byte)45)), ((int)((byte)68)));
            txtFee.Location = new System.Drawing.Point(14, 15);
            txtFee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtFee.Name = "txtFee";
            txtFee.PlaceholderText = "8.900.000";
            txtFee.Size = new System.Drawing.Size(267, 20);
            txtFee.TabIndex = 0;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            lblDescription.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)58)), ((int)((byte)73)), ((int)((byte)96)));
            lblDescription.Location = new System.Drawing.Point(27, 320);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new System.Drawing.Size(137, 19);
            lblDescription.TabIndex = 11;
            lblDescription.Text = "Mô tả chương trình";
            // 
            // pnlDescription
            // 
            pnlDescription.BackColor = System.Drawing.Color.FromArgb(((int)((byte)250)), ((int)((byte)251)), ((int)((byte)252)));
            pnlDescription.Controls.Add(txtDescription);
            pnlDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            pnlDescription.Location = new System.Drawing.Point(27, 347);
            pnlDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pnlDescription.Name = "pnlDescription";
            pnlDescription.Size = new System.Drawing.Size(608, 93);
            pnlDescription.TabIndex = 12;
            pnlDescription.Click += Input_Click;
            pnlDescription.Paint += Input_Paint;
            // 
            // txtDescription
            // 
            txtDescription.AcceptsReturn = true;
            txtDescription.BackColor = System.Drawing.Color.FromArgb(((int)((byte)250)), ((int)((byte)251)), ((int)((byte)252)));
            txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtDescription.Font = new System.Drawing.Font("Segoe UI", 9F);
            txtDescription.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)31)), ((int)((byte)45)), ((int)((byte)68)));
            txtDescription.Location = new System.Drawing.Point(14, 16);
            txtDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.PlaceholderText = "Mục tiêu và nội dung khóa học";
            txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            txtDescription.Size = new System.Drawing.Size(581, 64);
            txtDescription.TabIndex = 0;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)58)), ((int)((byte)73)), ((int)((byte)96)));
            lblStatus.Location = new System.Drawing.Point(27, 456);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new System.Drawing.Size(76, 19);
            lblStatus.TabIndex = 13;
            lblStatus.Text = "Trạng thái";
            lblStatus.Visible = false;
            // 
            // cboStatus
            // 
            cboStatus.BackColor = System.Drawing.Color.FromArgb(((int)((byte)250)), ((int)((byte)251)), ((int)((byte)252)));
            cboStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            cboStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            cboStatus.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)43)), ((int)((byte)58)), ((int)((byte)82)));
            cboStatus.ItemHeight = 32;
            cboStatus.Items.AddRange(new object[] { "Đang tuyển sinh", "Tạm dừng" });
            cboStatus.Location = new System.Drawing.Point(27, 483);
            cboStatus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new System.Drawing.Size(294, 38);
            cboStatus.TabIndex = 14;
            cboStatus.Visible = false;
            cboStatus.DrawItem += Combo_DrawItem;
            // 
            // pnlFooter
            // 
            pnlFooter.BackColor = System.Drawing.Color.FromArgb(((int)((byte)250)), ((int)((byte)251)), ((int)((byte)252)));
            pnlFooter.Controls.Add(btnDelete);
            pnlFooter.Controls.Add(btnCancel);
            pnlFooter.Controls.Add(btnSave);
            pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            pnlFooter.Location = new System.Drawing.Point(0, 466);
            pnlFooter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pnlFooter.Name = "pnlFooter";
            pnlFooter.Size = new System.Drawing.Size(663, 91);
            pnlFooter.TabIndex = 15;
            pnlFooter.Paint += pnlFooter_Paint;
            // 
            // btnDelete
            // 
            btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            btnDelete.Location = new System.Drawing.Point(27, 21);
            btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(96, 48);
            btnDelete.TabIndex = 2;
            btnDelete.Tag = "";
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Visible = false;
            btnDelete.Click += btnDelete_Click;
            btnDelete.Paint += Danger_Paint;
            // 
            // btnCancel
            // 
            btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            btnCancel.Location = new System.Drawing.Point(375, 21);
            btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(96, 48);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Hủy";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            btnCancel.Paint += Outline_Paint;
            // 
            // btnSave
            // 
            btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            btnSave.ForeColor = System.Drawing.Color.White;
            btnSave.Location = new System.Drawing.Point(482, 21);
            btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(153, 48);
            btnSave.TabIndex = 0;
            btnSave.Tag = "";
            btnSave.Text = "Tạo khóa học";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            btnSave.Paint += Accent_Paint;
            // 
            // FormCourseEdit
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            CancelButton = btnCancel;
            ClientSize = new System.Drawing.Size(663, 557);
            Controls.Add(pnlFooter);
            Controls.Add(cboStatus);
            Controls.Add(lblStatus);
            Controls.Add(pnlDescription);
            Controls.Add(lblDescription);
            Controls.Add(pnlFee);
            Controls.Add(lblFee);
            Controls.Add(cboDuration);
            Controls.Add(lblDuration);
            Controls.Add(pnlCode);
            Controls.Add(lblCode);
            Controls.Add(pnlName);
            Controls.Add(lblName);
            Controls.Add(btnClose);
            Controls.Add(lblHeaderSub);
            Controls.Add(lblHeaderTitle);
            Controls.Add(lblHeaderIcon);
            Font = new System.Drawing.Font("Segoe UI", 9F);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Thêm khóa học";
            Load += FormCourseEdit_Load;
            Paint += Dialog_Paint;
            pnlName.ResumeLayout(false);
            pnlName.PerformLayout();
            pnlCode.ResumeLayout(false);
            pnlCode.PerformLayout();
            pnlFee.ResumeLayout(false);
            pnlFee.PerformLayout();
            pnlDescription.ResumeLayout(false);
            pnlDescription.PerformLayout();
            pnlFooter.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
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
