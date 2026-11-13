namespace EnglishCenterManagement.Forms
{
    partial class FormAttendance
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
            System.Windows.Forms.DataGridViewCellStyle attendanceHeaderStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle attendanceCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle scoreHeaderStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle scoreCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblEyebrow = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.pnlToolbar = new System.Windows.Forms.Panel();
            this.cboClass = new System.Windows.Forms.ComboBox();
            this.cboSession = new System.Windows.Forms.ComboBox();
            this.pnlTabs = new System.Windows.Forms.Panel();
            this.btnAttendance = new System.Windows.Forms.Button();
            this.btnResults = new System.Windows.Forms.Button();
            this.pnlWarning = new System.Windows.Forms.Panel();
            this.lblWarningIcon = new System.Windows.Forms.Label();
            this.lblWarning = new System.Windows.Forms.Label();
            this.btnReception = new System.Windows.Forms.Button();
            this.pnlTable = new System.Windows.Forms.Panel();
            this.dgvAttendance = new System.Windows.Forms.DataGridView();
            this.colStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAttendance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAbsent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvScores = new System.Windows.Forms.DataGridView();
            this.colScoreStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colScoreAttendance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMidterm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAverage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCertificate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.lblPageInfo = new System.Windows.Forms.Label();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnPage1 = new System.Windows.Forms.Button();
            this.btnPage2 = new System.Windows.Forms.Button();
            this.btnPage3 = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.pnlToolbar.SuspendLayout();
            this.pnlTabs.SuspendLayout();
            this.pnlWarning.SuspendLayout();
            this.pnlTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScores)).BeginInit();
            this.pnlFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEyebrow
            // 
            this.lblEyebrow.AutoSize = true;
            this.lblEyebrow.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEyebrow.ForeColor = System.Drawing.Color.FromArgb(37, 131, 215);
            this.lblEyebrow.Location = new System.Drawing.Point(31, 27);
            this.lblEyebrow.Name = "lblEyebrow";
            this.lblEyebrow.Size = new System.Drawing.Size(144, 12);
            this.lblEyebrow.TabIndex = 0;
            this.lblEyebrow.Text = "CHẤT LƯỢNG ĐÀO TẠO";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(23, 36, 61);
            this.lblTitle.Location = new System.Drawing.Point(27, 42);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(249, 32);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Điểm danh & Kết quả";
            this.lblTitle.UseMnemonic = false;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDesc.ForeColor = System.Drawing.Color.FromArgb(135, 147, 163);
            this.lblDesc.Location = new System.Drawing.Point(31, 79);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(304, 15);
            this.lblDesc.TabIndex = 2;
            this.lblDesc.Text = "Theo dõi chuyên cần, điểm thi và cấp chứng nhận.";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(932, 46);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(153, 38);
            this.btnSave.TabIndex = 3;
            this.btnSave.Tag = "\uE73E";
            this.btnSave.Text = "Lưu điểm danh";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.Paint += new System.Windows.Forms.PaintEventHandler(this.Primary_Paint);
            // 
            // pnlToolbar
            // 
            this.pnlToolbar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlToolbar.BackColor = System.Drawing.Color.White;
            this.pnlToolbar.Controls.Add(this.pnlTabs);
            this.pnlToolbar.Controls.Add(this.cboSession);
            this.pnlToolbar.Controls.Add(this.cboClass);
            this.pnlToolbar.Location = new System.Drawing.Point(31, 116);
            this.pnlToolbar.Name = "pnlToolbar";
            this.pnlToolbar.Size = new System.Drawing.Size(1054, 60);
            this.pnlToolbar.TabIndex = 4;
            this.pnlToolbar.Paint += new System.Windows.Forms.PaintEventHandler(this.Card_Paint);
            // 
            // cboClass
            // 
            this.cboClass.BackColor = System.Drawing.Color.White;
            this.cboClass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboClass.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboClass.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboClass.ForeColor = System.Drawing.Color.FromArgb(83, 100, 122);
            this.cboClass.ItemHeight = 30;
            this.cboClass.Location = new System.Drawing.Point(14, 12);
            this.cboClass.Name = "cboClass";
            this.cboClass.Size = new System.Drawing.Size(266, 36);
            this.cboClass.TabIndex = 0;
            this.cboClass.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.Combo_DrawItem);
            this.cboClass.SelectedIndexChanged += new System.EventHandler(this.cboClass_SelectedIndexChanged);
            // 
            // cboSession
            // 
            this.cboSession.BackColor = System.Drawing.Color.White;
            this.cboSession.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboSession.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboSession.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSession.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboSession.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboSession.ForeColor = System.Drawing.Color.FromArgb(83, 100, 122);
            this.cboSession.ItemHeight = 30;
            this.cboSession.Location = new System.Drawing.Point(292, 12);
            this.cboSession.Name = "cboSession";
            this.cboSession.Size = new System.Drawing.Size(224, 36);
            this.cboSession.TabIndex = 1;
            this.cboSession.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.Combo_DrawItem);
            this.cboSession.SelectedIndexChanged += new System.EventHandler(this.cboSession_SelectedIndexChanged);
            // 
            // pnlTabs
            // 
            this.pnlTabs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTabs.BackColor = System.Drawing.Color.FromArgb(240, 243, 246);
            this.pnlTabs.Controls.Add(this.btnResults);
            this.pnlTabs.Controls.Add(this.btnAttendance);
            this.pnlTabs.Location = new System.Drawing.Point(782, 12);
            this.pnlTabs.Name = "pnlTabs";
            this.pnlTabs.Size = new System.Drawing.Size(258, 36);
            this.pnlTabs.TabIndex = 2;
            this.pnlTabs.Paint += new System.Windows.Forms.PaintEventHandler(this.Tabs_Paint);
            // 
            // btnAttendance
            // 
            this.btnAttendance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAttendance.FlatAppearance.BorderSize = 0;
            this.btnAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttendance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAttendance.ForeColor = System.Drawing.Color.FromArgb(40, 125, 198);
            this.btnAttendance.Location = new System.Drawing.Point(3, 3);
            this.btnAttendance.Name = "btnAttendance";
            this.btnAttendance.Size = new System.Drawing.Size(102, 30);
            this.btnAttendance.TabIndex = 0;
            this.btnAttendance.Text = "Điểm danh";
            this.btnAttendance.UseVisualStyleBackColor = false;
            this.btnAttendance.Click += new System.EventHandler(this.btnAttendance_Click);
            this.btnAttendance.Paint += new System.Windows.Forms.PaintEventHandler(this.Tab_Paint);
            // 
            // btnResults
            // 
            this.btnResults.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResults.FlatAppearance.BorderSize = 0;
            this.btnResults.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResults.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnResults.ForeColor = System.Drawing.Color.FromArgb(122, 137, 154);
            this.btnResults.Location = new System.Drawing.Point(108, 3);
            this.btnResults.Name = "btnResults";
            this.btnResults.Size = new System.Drawing.Size(147, 30);
            this.btnResults.TabIndex = 1;
            this.btnResults.Text = "Kết quả học tập";
            this.btnResults.UseVisualStyleBackColor = false;
            this.btnResults.Click += new System.EventHandler(this.btnResults_Click);
            this.btnResults.Paint += new System.Windows.Forms.PaintEventHandler(this.Tab_Paint);
            // 
            // pnlWarning
            // 
            this.pnlWarning.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlWarning.BackColor = System.Drawing.Color.FromArgb(255, 248, 242);
            this.pnlWarning.Controls.Add(this.btnReception);
            this.pnlWarning.Controls.Add(this.lblWarning);
            this.pnlWarning.Controls.Add(this.lblWarningIcon);
            this.pnlWarning.Location = new System.Drawing.Point(31, 188);
            this.pnlWarning.Name = "pnlWarning";
            this.pnlWarning.Size = new System.Drawing.Size(1054, 58);
            this.pnlWarning.TabIndex = 5;
            this.pnlWarning.Paint += new System.Windows.Forms.PaintEventHandler(this.Warning_Paint);
            // 
            // lblWarningIcon
            // 
            this.lblWarningIcon.Font = new System.Drawing.Font("Segoe MDL2 Assets", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWarningIcon.ForeColor = System.Drawing.Color.FromArgb(220, 124, 59);
            this.lblWarningIcon.Location = new System.Drawing.Point(14, 13);
            this.lblWarningIcon.Name = "lblWarningIcon";
            this.lblWarningIcon.Size = new System.Drawing.Size(30, 32);
            this.lblWarningIcon.TabIndex = 0;
            this.lblWarningIcon.Text = "\uE7BA";
            this.lblWarningIcon.Paint += new System.Windows.Forms.PaintEventHandler(this.WarningIcon_Paint);
            // 
            // lblWarning
            // 
            this.lblWarning.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWarning.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWarning.ForeColor = System.Drawing.Color.FromArgb(154, 91, 50);
            this.lblWarning.Location = new System.Drawing.Point(53, 10);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(861, 38);
            this.lblWarning.TabIndex = 1;
            this.lblWarning.Text = "3 học viên cần chú ý — vắng quá 3 buổi. Lễ tân cần liên hệ nhắc nhở.";
            this.lblWarning.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnReception
            // 
            this.btnReception.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReception.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReception.FlatAppearance.BorderSize = 0;
            this.btnReception.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReception.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReception.ForeColor = System.Drawing.Color.FromArgb(191, 105, 49);
            this.btnReception.Location = new System.Drawing.Point(930, 13);
            this.btnReception.Name = "btnReception";
            this.btnReception.Size = new System.Drawing.Size(110, 32);
            this.btnReception.TabIndex = 2;
            this.btnReception.Text = "Gửi lễ tân";
            this.btnReception.UseVisualStyleBackColor = false;
            this.btnReception.Click += new System.EventHandler(this.btnReception_Click);
            this.btnReception.Paint += new System.Windows.Forms.PaintEventHandler(this.Reception_Paint);
            // 
            // pnlTable
            // 
            this.pnlTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTable.BackColor = System.Drawing.Color.White;
            this.pnlTable.Controls.Add(this.dgvAttendance);
            this.pnlTable.Controls.Add(this.dgvScores);
            this.pnlTable.Controls.Add(this.pnlFooter);
            this.pnlTable.Location = new System.Drawing.Point(31, 260);
            this.pnlTable.Name = "pnlTable";
            this.pnlTable.Padding = new System.Windows.Forms.Padding(1);
            this.pnlTable.Size = new System.Drawing.Size(1054, 494);
            this.pnlTable.TabIndex = 6;
            this.pnlTable.Paint += new System.Windows.Forms.PaintEventHandler(this.Card_Paint);
            // 
            // dgvAttendance
            // 
            this.dgvAttendance.AllowUserToAddRows = false;
            this.dgvAttendance.AllowUserToDeleteRows = false;
            this.dgvAttendance.AllowUserToResizeColumns = false;
            this.dgvAttendance.AllowUserToResizeRows = false;
            this.dgvAttendance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAttendance.BackgroundColor = System.Drawing.Color.White;
            this.dgvAttendance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAttendance.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAttendance.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            attendanceHeaderStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            attendanceHeaderStyle.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            attendanceHeaderStyle.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            attendanceHeaderStyle.ForeColor = System.Drawing.Color.FromArgb(142, 154, 170);
            attendanceHeaderStyle.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            attendanceHeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            attendanceHeaderStyle.SelectionForeColor = System.Drawing.Color.FromArgb(142, 154, 170);
            attendanceHeaderStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAttendance.ColumnHeadersDefaultCellStyle = attendanceHeaderStyle;
            this.dgvAttendance.ColumnHeadersHeight = 39;
            this.dgvAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAttendance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colStudent,
            this.colPhone,
            this.colAttendance,
            this.colAbsent,
            this.colStatus});
            this.dgvAttendance.Cursor = System.Windows.Forms.Cursors.Hand;
            attendanceCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            attendanceCellStyle.BackColor = System.Drawing.Color.White;
            attendanceCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            attendanceCellStyle.ForeColor = System.Drawing.Color.FromArgb(101, 116, 137);
            attendanceCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(247, 251, 255);
            attendanceCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(101, 116, 137);
            attendanceCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAttendance.DefaultCellStyle = attendanceCellStyle;
            this.dgvAttendance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAttendance.EnableHeadersVisualStyles = false;
            this.dgvAttendance.GridColor = System.Drawing.Color.FromArgb(237, 240, 244);
            this.dgvAttendance.Location = new System.Drawing.Point(1, 1);
            this.dgvAttendance.MultiSelect = false;
            this.dgvAttendance.Name = "dgvAttendance";
            this.dgvAttendance.ReadOnly = true;
            this.dgvAttendance.RowHeadersVisible = false;
            this.dgvAttendance.RowTemplate.Height = 60;
            this.dgvAttendance.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvAttendance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAttendance.Size = new System.Drawing.Size(1052, 438);
            this.dgvAttendance.TabIndex = 0;
            this.dgvAttendance.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAttendance_CellClick);
            this.dgvAttendance.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvAttendance_CellPainting);
            this.dgvAttendance.SizeChanged += new System.EventHandler(this.Grid_SizeChanged);
            // 
            // colStudent
            // 
            this.colStudent.FillWeight = 300F;
            this.colStudent.HeaderText = "HỌC VIÊN";
            this.colStudent.Name = "colStudent";
            this.colStudent.ReadOnly = true;
            this.colStudent.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colPhone
            // 
            this.colPhone.FillWeight = 185F;
            this.colPhone.HeaderText = "SỐ ĐIỆN THOẠI";
            this.colPhone.Name = "colPhone";
            this.colPhone.ReadOnly = true;
            this.colPhone.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colAttendance
            // 
            this.colAttendance.FillWeight = 150F;
            this.colAttendance.HeaderText = "CHUYÊN CẦN";
            this.colAttendance.Name = "colAttendance";
            this.colAttendance.ReadOnly = true;
            this.colAttendance.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colAbsent
            // 
            this.colAbsent.FillWeight = 165F;
            this.colAbsent.HeaderText = "SỐ BUỔI VẮNG";
            this.colAbsent.Name = "colAbsent";
            this.colAbsent.ReadOnly = true;
            this.colAbsent.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colStatus
            // 
            this.colStatus.FillWeight = 252F;
            this.colStatus.HeaderText = "TRẠNG THÁI";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            this.colStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvScores
            // 
            this.dgvScores.AllowUserToAddRows = false;
            this.dgvScores.AllowUserToDeleteRows = false;
            this.dgvScores.AllowUserToResizeColumns = false;
            this.dgvScores.AllowUserToResizeRows = false;
            this.dgvScores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvScores.BackgroundColor = System.Drawing.Color.White;
            this.dgvScores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvScores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvScores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            scoreHeaderStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            scoreHeaderStyle.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            scoreHeaderStyle.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            scoreHeaderStyle.ForeColor = System.Drawing.Color.FromArgb(142, 154, 170);
            scoreHeaderStyle.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            scoreHeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            scoreHeaderStyle.SelectionForeColor = System.Drawing.Color.FromArgb(142, 154, 170);
            scoreHeaderStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvScores.ColumnHeadersDefaultCellStyle = scoreHeaderStyle;
            this.dgvScores.ColumnHeadersHeight = 39;
            this.dgvScores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvScores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colScoreStudent,
            this.colScoreAttendance,
            this.colMidterm,
            this.colFinal,
            this.colAverage,
            this.colResult,
            this.colCertificate});
            this.dgvScores.Cursor = System.Windows.Forms.Cursors.Hand;
            scoreCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            scoreCellStyle.BackColor = System.Drawing.Color.White;
            scoreCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            scoreCellStyle.ForeColor = System.Drawing.Color.FromArgb(101, 116, 137);
            scoreCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(247, 251, 255);
            scoreCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(101, 116, 137);
            scoreCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvScores.DefaultCellStyle = scoreCellStyle;
            this.dgvScores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvScores.EnableHeadersVisualStyles = false;
            this.dgvScores.GridColor = System.Drawing.Color.FromArgb(237, 240, 244);
            this.dgvScores.Location = new System.Drawing.Point(1, 1);
            this.dgvScores.MultiSelect = false;
            this.dgvScores.Name = "dgvScores";
            this.dgvScores.ReadOnly = false;
            this.dgvScores.RowHeadersVisible = false;
            this.dgvScores.RowTemplate.Height = 60;
            this.dgvScores.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvScores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvScores.Size = new System.Drawing.Size(1052, 438);
            this.dgvScores.TabIndex = 1;
            this.dgvScores.Visible = false;
            this.dgvScores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvScores_CellClick);
            this.dgvScores.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvScores_CellPainting);
            this.dgvScores.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvScores_CellValidating);
            this.dgvScores.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvScores_CellEndEdit);
            this.dgvScores.SizeChanged += new System.EventHandler(this.Grid_SizeChanged);
            // 
            // colScoreStudent
            // 
            this.colScoreStudent.FillWeight = 270F;
            this.colScoreStudent.HeaderText = "HỌC VIÊN";
            this.colScoreStudent.Name = "colScoreStudent";
            this.colScoreStudent.ReadOnly = true;
            this.colScoreStudent.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colScoreAttendance
            // 
            this.colScoreAttendance.FillWeight = 130F;
            this.colScoreAttendance.HeaderText = "CHUYÊN CẦN";
            this.colScoreAttendance.Name = "colScoreAttendance";
            this.colScoreAttendance.ReadOnly = true;
            this.colScoreAttendance.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colMidterm
            // 
            this.colMidterm.FillWeight = 105F;
            this.colMidterm.HeaderText = "GIỮA KỲ";
            this.colMidterm.Name = "colMidterm";
            this.colMidterm.ReadOnly = false;
            this.colMidterm.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colFinal
            // 
            this.colFinal.FillWeight = 105F;
            this.colFinal.HeaderText = "CUỐI KỲ";
            this.colFinal.Name = "colFinal";
            this.colFinal.ReadOnly = false;
            this.colFinal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colAverage
            // 
            this.colAverage.FillWeight = 125F;
            this.colAverage.HeaderText = "TRUNG BÌNH";
            this.colAverage.Name = "colAverage";
            this.colAverage.ReadOnly = true;
            this.colAverage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colResult
            // 
            this.colResult.FillWeight = 158F;
            this.colResult.HeaderText = "KẾT QUẢ";
            this.colResult.Name = "colResult";
            this.colResult.ReadOnly = true;
            this.colResult.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colCertificate
            // 
            this.colCertificate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colCertificate.HeaderText = "";
            this.colCertificate.Name = "colCertificate";
            this.colCertificate.ReadOnly = true;
            this.colCertificate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colCertificate.Width = 154;
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.White;
            this.pnlFooter.Controls.Add(this.btnNext);
            this.pnlFooter.Controls.Add(this.btnPage3);
            this.pnlFooter.Controls.Add(this.btnPage2);
            this.pnlFooter.Controls.Add(this.btnPage1);
            this.pnlFooter.Controls.Add(this.btnPrev);
            this.pnlFooter.Controls.Add(this.lblPageInfo);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(1, 439);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(1052, 54);
            this.pnlFooter.TabIndex = 2;
            this.pnlFooter.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlFooter_Paint);
            // 
            // lblPageInfo
            // 
            this.lblPageInfo.AutoSize = true;
            this.lblPageInfo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPageInfo.ForeColor = System.Drawing.Color.FromArgb(135, 147, 163);
            this.lblPageInfo.Location = new System.Drawing.Point(18, 20);
            this.lblPageInfo.Name = "lblPageInfo";
            this.lblPageInfo.Size = new System.Drawing.Size(170, 13);
            this.lblPageInfo.TabIndex = 0;
            this.lblPageInfo.Text = "Trang 1 / 1 · Hiển thị 0 kết quả";
            // 
            // btnPrev
            // 
            this.btnPrev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrev.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrev.FlatAppearance.BorderSize = 0;
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrev.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPrev.Location = new System.Drawing.Point(886, 13);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(28, 28);
            this.btnPrev.TabIndex = 1;
            this.btnPrev.Tag = "\uE76B";
            this.btnPrev.UseVisualStyleBackColor = false;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            this.btnPrev.Paint += new System.Windows.Forms.PaintEventHandler(this.Pager_Paint);
            // 
            // btnPage1
            // 
            this.btnPage1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPage1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPage1.FlatAppearance.BorderSize = 0;
            this.btnPage1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPage1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPage1.Location = new System.Drawing.Point(918, 13);
            this.btnPage1.Name = "btnPage1";
            this.btnPage1.Size = new System.Drawing.Size(28, 28);
            this.btnPage1.TabIndex = 2;
            this.btnPage1.Text = "1";
            this.btnPage1.UseVisualStyleBackColor = false;
            this.btnPage1.Click += new System.EventHandler(this.Page_Click);
            this.btnPage1.Paint += new System.Windows.Forms.PaintEventHandler(this.Pager_Paint);
            // 
            // btnPage2
            // 
            this.btnPage2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPage2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPage2.FlatAppearance.BorderSize = 0;
            this.btnPage2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPage2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPage2.Location = new System.Drawing.Point(950, 13);
            this.btnPage2.Name = "btnPage2";
            this.btnPage2.Size = new System.Drawing.Size(28, 28);
            this.btnPage2.TabIndex = 3;
            this.btnPage2.Text = "2";
            this.btnPage2.UseVisualStyleBackColor = false;
            this.btnPage2.Click += new System.EventHandler(this.Page_Click);
            this.btnPage2.Paint += new System.Windows.Forms.PaintEventHandler(this.Pager_Paint);
            // 
            // btnPage3
            // 
            this.btnPage3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPage3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPage3.FlatAppearance.BorderSize = 0;
            this.btnPage3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPage3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPage3.Location = new System.Drawing.Point(982, 13);
            this.btnPage3.Name = "btnPage3";
            this.btnPage3.Size = new System.Drawing.Size(28, 28);
            this.btnPage3.TabIndex = 4;
            this.btnPage3.Text = "3";
            this.btnPage3.UseVisualStyleBackColor = false;
            this.btnPage3.Click += new System.EventHandler(this.Page_Click);
            this.btnPage3.Paint += new System.Windows.Forms.PaintEventHandler(this.Pager_Paint);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNext.Location = new System.Drawing.Point(1014, 13);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(28, 28);
            this.btnNext.TabIndex = 5;
            this.btnNext.Tag = "\uE76C";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            this.btnNext.Paint += new System.Windows.Forms.PaintEventHandler(this.Pager_Paint);
            // 
            // FormAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(245, 247, 251);
            this.ClientSize = new System.Drawing.Size(1116, 790);
            this.Controls.Add(this.pnlTable);
            this.Controls.Add(this.pnlWarning);
            this.Controls.Add(this.pnlToolbar);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblEyebrow);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAttendance";
            this.Text = "Điểm danh & Kết quả";
            this.Load += new System.EventHandler(this.FormAttendance_Load);
            this.pnlToolbar.ResumeLayout(false);
            this.pnlTabs.ResumeLayout(false);
            this.pnlWarning.ResumeLayout(false);
            this.pnlTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScores)).EndInit();
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblEyebrow;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel pnlToolbar;
        private System.Windows.Forms.ComboBox cboClass;
        private System.Windows.Forms.ComboBox cboSession;
        private System.Windows.Forms.Panel pnlTabs;
        private System.Windows.Forms.Button btnAttendance;
        private System.Windows.Forms.Button btnResults;
        private System.Windows.Forms.Panel pnlWarning;
        private System.Windows.Forms.Label lblWarningIcon;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.Button btnReception;
        private System.Windows.Forms.Panel pnlTable;
        private System.Windows.Forms.DataGridView dgvAttendance;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAttendance;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAbsent;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridView dgvScores;
        private System.Windows.Forms.DataGridViewTextBoxColumn colScoreStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn colScoreAttendance;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMidterm;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAverage;
        private System.Windows.Forms.DataGridViewTextBoxColumn colResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCertificate;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Label lblPageInfo;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnPage1;
        private System.Windows.Forms.Button btnPage2;
        private System.Windows.Forms.Button btnPage3;
        private System.Windows.Forms.Button btnNext;
    }
}
