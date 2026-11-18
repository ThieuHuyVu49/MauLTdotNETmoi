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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            lblEyebrow = new System.Windows.Forms.Label();
            lblTitle = new System.Windows.Forms.Label();
            lblDesc = new System.Windows.Forms.Label();
            btnSave = new System.Windows.Forms.Button();
            pnlToolbar = new System.Windows.Forms.Panel();
            pnlTabs = new System.Windows.Forms.Panel();
            btnResults = new System.Windows.Forms.Button();
            btnAttendance = new System.Windows.Forms.Button();
            cboSession = new System.Windows.Forms.ComboBox();
            cboClass = new System.Windows.Forms.ComboBox();
            pnlWarning = new System.Windows.Forms.Panel();
            btnReception = new System.Windows.Forms.Button();
            lblWarning = new System.Windows.Forms.Label();
            lblWarningIcon = new System.Windows.Forms.Label();
            pnlTable = new System.Windows.Forms.Panel();
            dgvAttendance = new System.Windows.Forms.DataGridView();
            colStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colAttendance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colAbsent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgvScores = new System.Windows.Forms.DataGridView();
            colScoreStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colScoreAttendance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colMidterm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colAverage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colCertificate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            pnlFooter = new System.Windows.Forms.Panel();
            btnNext = new System.Windows.Forms.Button();
            btnPage3 = new System.Windows.Forms.Button();
            btnPage2 = new System.Windows.Forms.Button();
            btnPage1 = new System.Windows.Forms.Button();
            btnPrev = new System.Windows.Forms.Button();
            lblPageInfo = new System.Windows.Forms.Label();
            pnlToolbar.SuspendLayout();
            pnlTabs.SuspendLayout();
            pnlWarning.SuspendLayout();
            pnlTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAttendance).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvScores).BeginInit();
            pnlFooter.SuspendLayout();
            SuspendLayout();
            // 
            // lblEyebrow
            // 
            lblEyebrow.AutoSize = true;
            lblEyebrow.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            lblEyebrow.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)131)), ((int)((byte)215)));
            lblEyebrow.Location = new System.Drawing.Point(35, 36);
            lblEyebrow.Name = "lblEyebrow";
            lblEyebrow.Size = new System.Drawing.Size(157, 17);
            lblEyebrow.TabIndex = 0;
            lblEyebrow.Text = "CHẤT LƯỢNG ĐÀO TẠO";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)23)), ((int)((byte)36)), ((int)((byte)61)));
            lblTitle.Location = new System.Drawing.Point(31, 56);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(320, 41);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Điểm danh & Kết quả";
            lblTitle.UseMnemonic = false;
            // 
            // lblDesc
            // 
            lblDesc.AutoSize = true;
            lblDesc.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblDesc.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)135)), ((int)((byte)147)), ((int)((byte)163)));
            lblDesc.Location = new System.Drawing.Point(35, 105);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new System.Drawing.Size(338, 20);
            lblDesc.TabIndex = 2;
            lblDesc.Text = "Theo dõi chuyên cần, điểm thi và cấp chứng nhận.";
            // 
            // btnSave
            // 
            btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            btnSave.ForeColor = System.Drawing.Color.White;
            btnSave.Location = new System.Drawing.Point(1065, 61);
            btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(175, 51);
            btnSave.TabIndex = 3;
            btnSave.Tag = "";
            btnSave.Text = "Lưu điểm danh";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            btnSave.Paint += Primary_Paint;
            // 
            // pnlToolbar
            // 
            pnlToolbar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            pnlToolbar.BackColor = System.Drawing.Color.White;
            pnlToolbar.Controls.Add(pnlTabs);
            pnlToolbar.Controls.Add(cboSession);
            pnlToolbar.Controls.Add(cboClass);
            pnlToolbar.Location = new System.Drawing.Point(35, 155);
            pnlToolbar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pnlToolbar.Name = "pnlToolbar";
            pnlToolbar.Size = new System.Drawing.Size(1205, 80);
            pnlToolbar.TabIndex = 4;
            pnlToolbar.Paint += Card_Paint;
            // 
            // pnlTabs
            // 
            pnlTabs.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            pnlTabs.BackColor = System.Drawing.Color.FromArgb(((int)((byte)240)), ((int)((byte)243)), ((int)((byte)246)));
            pnlTabs.Controls.Add(btnResults);
            pnlTabs.Controls.Add(btnAttendance);
            pnlTabs.Location = new System.Drawing.Point(894, 16);
            pnlTabs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pnlTabs.Name = "pnlTabs";
            pnlTabs.Size = new System.Drawing.Size(295, 48);
            pnlTabs.TabIndex = 2;
            pnlTabs.Paint += Tabs_Paint;
            // 
            // btnResults
            // 
            btnResults.Cursor = System.Windows.Forms.Cursors.Hand;
            btnResults.FlatAppearance.BorderSize = 0;
            btnResults.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnResults.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            btnResults.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)122)), ((int)((byte)137)), ((int)((byte)154)));
            btnResults.Location = new System.Drawing.Point(123, 4);
            btnResults.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnResults.Name = "btnResults";
            btnResults.Size = new System.Drawing.Size(168, 40);
            btnResults.TabIndex = 1;
            btnResults.Text = "Kết quả học tập";
            btnResults.UseVisualStyleBackColor = false;
            btnResults.Click += btnResults_Click;
            btnResults.Paint += Tab_Paint;
            // 
            // btnAttendance
            // 
            btnAttendance.Cursor = System.Windows.Forms.Cursors.Hand;
            btnAttendance.FlatAppearance.BorderSize = 0;
            btnAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAttendance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            btnAttendance.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)40)), ((int)((byte)125)), ((int)((byte)198)));
            btnAttendance.Location = new System.Drawing.Point(3, 4);
            btnAttendance.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnAttendance.Name = "btnAttendance";
            btnAttendance.Size = new System.Drawing.Size(117, 40);
            btnAttendance.TabIndex = 0;
            btnAttendance.Text = "Điểm danh";
            btnAttendance.UseVisualStyleBackColor = false;
            btnAttendance.Click += btnAttendance_Click;
            btnAttendance.Paint += Tab_Paint;
            // 
            // cboSession
            // 
            cboSession.BackColor = System.Drawing.Color.White;
            cboSession.Cursor = System.Windows.Forms.Cursors.Hand;
            cboSession.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            cboSession.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboSession.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboSession.Font = new System.Drawing.Font("Segoe UI", 9F);
            cboSession.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)83)), ((int)((byte)100)), ((int)((byte)122)));
            cboSession.ItemHeight = 30;
            cboSession.Location = new System.Drawing.Point(334, 16);
            cboSession.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cboSession.Name = "cboSession";
            cboSession.Size = new System.Drawing.Size(255, 36);
            cboSession.TabIndex = 1;
            cboSession.DrawItem += Combo_DrawItem;
            cboSession.SelectedIndexChanged += cboSession_SelectedIndexChanged;
            // 
            // cboClass
            // 
            cboClass.BackColor = System.Drawing.Color.White;
            cboClass.Cursor = System.Windows.Forms.Cursors.Hand;
            cboClass.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            cboClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboClass.Font = new System.Drawing.Font("Segoe UI", 9F);
            cboClass.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)83)), ((int)((byte)100)), ((int)((byte)122)));
            cboClass.ItemHeight = 30;
            cboClass.Location = new System.Drawing.Point(16, 16);
            cboClass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cboClass.Name = "cboClass";
            cboClass.Size = new System.Drawing.Size(303, 36);
            cboClass.TabIndex = 0;
            cboClass.DrawItem += Combo_DrawItem;
            cboClass.SelectedIndexChanged += cboClass_SelectedIndexChanged;
            // 
            // pnlWarning
            // 
            pnlWarning.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            pnlWarning.BackColor = System.Drawing.Color.FromArgb(((int)((byte)255)), ((int)((byte)248)), ((int)((byte)242)));
            pnlWarning.Controls.Add(btnReception);
            pnlWarning.Controls.Add(lblWarning);
            pnlWarning.Controls.Add(lblWarningIcon);
            pnlWarning.Location = new System.Drawing.Point(35, 251);
            pnlWarning.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pnlWarning.Name = "pnlWarning";
            pnlWarning.Size = new System.Drawing.Size(1205, 77);
            pnlWarning.TabIndex = 5;
            pnlWarning.Visible = false;
            pnlWarning.Paint += Warning_Paint;
            // 
            // btnReception
            // 
            btnReception.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            btnReception.Cursor = System.Windows.Forms.Cursors.Hand;
            btnReception.FlatAppearance.BorderSize = 0;
            btnReception.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnReception.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            btnReception.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)191)), ((int)((byte)105)), ((int)((byte)49)));
            btnReception.Location = new System.Drawing.Point(1063, 17);
            btnReception.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnReception.Name = "btnReception";
            btnReception.Size = new System.Drawing.Size(126, 43);
            btnReception.TabIndex = 2;
            btnReception.Text = "Gửi lễ tân";
            btnReception.UseVisualStyleBackColor = false;
            btnReception.Click += btnReception_Click;
            btnReception.Paint += Reception_Paint;
            // 
            // lblWarning
            // 
            lblWarning.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            lblWarning.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            lblWarning.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)154)), ((int)((byte)91)), ((int)((byte)50)));
            lblWarning.Location = new System.Drawing.Point(61, 13);
            lblWarning.Name = "lblWarning";
            lblWarning.Size = new System.Drawing.Size(984, 51);
            lblWarning.TabIndex = 1;
            lblWarning.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblWarningIcon
            // 
            lblWarningIcon.Font = new System.Drawing.Font("Segoe MDL2 Assets", 11F);
            lblWarningIcon.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)220)), ((int)((byte)124)), ((int)((byte)59)));
            lblWarningIcon.Location = new System.Drawing.Point(16, 17);
            lblWarningIcon.Name = "lblWarningIcon";
            lblWarningIcon.Size = new System.Drawing.Size(34, 43);
            lblWarningIcon.TabIndex = 0;
            lblWarningIcon.Text = "";
            lblWarningIcon.Paint += WarningIcon_Paint;
            // 
            // pnlTable
            // 
            pnlTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            pnlTable.BackColor = System.Drawing.Color.White;
            pnlTable.Controls.Add(dgvAttendance);
            pnlTable.Controls.Add(dgvScores);
            pnlTable.Controls.Add(pnlFooter);
            pnlTable.Location = new System.Drawing.Point(35, 347);
            pnlTable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pnlTable.Name = "pnlTable";
            pnlTable.Padding = new System.Windows.Forms.Padding(1);
            pnlTable.Size = new System.Drawing.Size(1205, 659);
            pnlTable.TabIndex = 6;
            pnlTable.Paint += Card_Paint;
            // 
            // dgvAttendance
            // 
            dgvAttendance.AllowUserToAddRows = false;
            dgvAttendance.AllowUserToDeleteRows = false;
            dgvAttendance.AllowUserToResizeColumns = false;
            dgvAttendance.AllowUserToResizeRows = false;
            dgvAttendance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvAttendance.BackgroundColor = System.Drawing.Color.White;
            dgvAttendance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvAttendance.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dgvAttendance.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)142)), ((int)((byte)154)), ((int)((byte)170)));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)142)), ((int)((byte)154)), ((int)((byte)170)));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvAttendance.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvAttendance.ColumnHeadersHeight = 39;
            dgvAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvAttendance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colStudent, colPhone, colAttendance, colAbsent, colStatus });
            dgvAttendance.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)101)), ((int)((byte)116)), ((int)((byte)137)));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)247)), ((int)((byte)251)), ((int)((byte)255)));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)101)), ((int)((byte)116)), ((int)((byte)137)));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvAttendance.DefaultCellStyle = dataGridViewCellStyle2;
            dgvAttendance.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvAttendance.EnableHeadersVisualStyles = false;
            dgvAttendance.GridColor = System.Drawing.Color.FromArgb(((int)((byte)237)), ((int)((byte)240)), ((int)((byte)244)));
            dgvAttendance.Location = new System.Drawing.Point(1, 1);
            dgvAttendance.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dgvAttendance.MultiSelect = false;
            dgvAttendance.Name = "dgvAttendance";
            dgvAttendance.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvAttendance.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvAttendance.RowHeadersVisible = false;
            dgvAttendance.RowHeadersWidth = 51;
            dgvAttendance.RowTemplate.Height = 60;
            dgvAttendance.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            dgvAttendance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvAttendance.Size = new System.Drawing.Size(1203, 585);
            dgvAttendance.TabIndex = 0;
            dgvAttendance.CellClick += dgvAttendance_CellClick;
            dgvAttendance.CellPainting += dgvAttendance_CellPainting;
            dgvAttendance.SizeChanged += Grid_SizeChanged;
            // 
            // colStudent
            // 
            colStudent.FillWeight = 299.9891F;
            colStudent.HeaderText = "HỌC VIÊN";
            colStudent.MinimumWidth = 6;
            colStudent.Name = "colStudent";
            colStudent.ReadOnly = true;
            colStudent.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            colStudent.Width = 343;
            // 
            // colPhone
            // 
            colPhone.FillWeight = 184.53764F;
            colPhone.HeaderText = "SỐ ĐIỆN THOẠI";
            colPhone.MinimumWidth = 6;
            colPhone.Name = "colPhone";
            colPhone.ReadOnly = true;
            colPhone.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            colPhone.Width = 211;
            // 
            // colAttendance
            // 
            colAttendance.FillWeight = 150.42564F;
            colAttendance.HeaderText = "CHUYÊN CẦN";
            colAttendance.MinimumWidth = 6;
            colAttendance.Name = "colAttendance";
            colAttendance.ReadOnly = true;
            colAttendance.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            colAttendance.Width = 172;
            // 
            // colAbsent
            // 
            colAbsent.FillWeight = 165.31024F;
            colAbsent.HeaderText = "SỐ BUỔI VẮNG";
            colAbsent.MinimumWidth = 6;
            colAbsent.Name = "colAbsent";
            colAbsent.ReadOnly = true;
            colAbsent.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            colAbsent.Width = 189;
            // 
            // colStatus
            // 
            colStatus.FillWeight = 251.88573F;
            colStatus.HeaderText = "TRẠNG THÁI";
            colStatus.MinimumWidth = 6;
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            colStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            colStatus.Width = 288;
            // 
            // dgvScores
            // 
            dgvScores.AllowUserToAddRows = false;
            dgvScores.AllowUserToDeleteRows = false;
            dgvScores.AllowUserToResizeColumns = false;
            dgvScores.AllowUserToResizeRows = false;
            dgvScores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvScores.BackgroundColor = System.Drawing.Color.White;
            dgvScores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvScores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dgvScores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)142)), ((int)((byte)154)), ((int)((byte)170)));
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)142)), ((int)((byte)154)), ((int)((byte)170)));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvScores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvScores.ColumnHeadersHeight = 39;
            dgvScores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvScores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colScoreStudent, colScoreAttendance, colMidterm, colFinal, colAverage, colResult, colCertificate });
            dgvScores.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)101)), ((int)((byte)116)), ((int)((byte)137)));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)247)), ((int)((byte)251)), ((int)((byte)255)));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)101)), ((int)((byte)116)), ((int)((byte)137)));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvScores.DefaultCellStyle = dataGridViewCellStyle5;
            dgvScores.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvScores.EnableHeadersVisualStyles = false;
            dgvScores.GridColor = System.Drawing.Color.FromArgb(((int)((byte)237)), ((int)((byte)240)), ((int)((byte)244)));
            dgvScores.Location = new System.Drawing.Point(1, 1);
            dgvScores.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dgvScores.MultiSelect = false;
            dgvScores.Name = "dgvScores";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvScores.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvScores.RowHeadersVisible = false;
            dgvScores.RowHeadersWidth = 51;
            dgvScores.RowTemplate.Height = 60;
            dgvScores.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            dgvScores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvScores.Size = new System.Drawing.Size(1203, 585);
            dgvScores.TabIndex = 1;
            dgvScores.Visible = false;
            dgvScores.CellClick += dgvScores_CellClick;
            dgvScores.CellEndEdit += dgvScores_CellEndEdit;
            dgvScores.CellPainting += dgvScores_CellPainting;
            dgvScores.CellValidating += dgvScores_CellValidating;
            dgvScores.SizeChanged += Grid_SizeChanged;
            // 
            // colScoreStudent
            // 
            colScoreStudent.FillWeight = 269.8148F;
            colScoreStudent.HeaderText = "HỌC VIÊN";
            colScoreStudent.MinimumWidth = 6;
            colScoreStudent.Name = "colScoreStudent";
            colScoreStudent.ReadOnly = true;
            colScoreStudent.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            colScoreStudent.Width = 317;
            // 
            // colScoreAttendance
            // 
            colScoreAttendance.FillWeight = 130.22328F;
            colScoreAttendance.HeaderText = "CHUYÊN CẦN";
            colScoreAttendance.MinimumWidth = 6;
            colScoreAttendance.Name = "colScoreAttendance";
            colScoreAttendance.ReadOnly = true;
            colScoreAttendance.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            colScoreAttendance.Width = 153;
            // 
            // colMidterm
            // 
            colMidterm.FillWeight = 105.543304F;
            colMidterm.HeaderText = "GIỮA KỲ";
            colMidterm.MinimumWidth = 6;
            colMidterm.Name = "colMidterm";
            colMidterm.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            colMidterm.Width = 124;
            // 
            // colFinal
            // 
            colFinal.FillWeight = 104.69531F;
            colFinal.HeaderText = "CUỐI KỲ";
            colFinal.MinimumWidth = 6;
            colFinal.Name = "colFinal";
            colFinal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            colFinal.Width = 123;
            // 
            // colAverage
            // 
            colAverage.FillWeight = 125.11344F;
            colAverage.HeaderText = "TRUNG BÌNH";
            colAverage.MinimumWidth = 6;
            colAverage.Name = "colAverage";
            colAverage.ReadOnly = true;
            colAverage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            colAverage.Width = 147;
            // 
            // colResult
            // 
            colResult.FillWeight = 157.46704F;
            colResult.HeaderText = "KẾT QUẢ";
            colResult.MinimumWidth = 6;
            colResult.Name = "colResult";
            colResult.ReadOnly = true;
            colResult.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            colResult.Width = 185;
            // 
            // colCertificate
            // 
            colCertificate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            colCertificate.HeaderText = "";
            colCertificate.MinimumWidth = 6;
            colCertificate.Name = "colCertificate";
            colCertificate.ReadOnly = true;
            colCertificate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            colCertificate.Width = 154;
            // 
            // pnlFooter
            // 
            pnlFooter.BackColor = System.Drawing.Color.White;
            pnlFooter.Controls.Add(btnNext);
            pnlFooter.Controls.Add(btnPage3);
            pnlFooter.Controls.Add(btnPage2);
            pnlFooter.Controls.Add(btnPage1);
            pnlFooter.Controls.Add(btnPrev);
            pnlFooter.Controls.Add(lblPageInfo);
            pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            pnlFooter.Location = new System.Drawing.Point(1, 586);
            pnlFooter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pnlFooter.Name = "pnlFooter";
            pnlFooter.Size = new System.Drawing.Size(1203, 72);
            pnlFooter.TabIndex = 2;
            pnlFooter.Paint += pnlFooter_Paint;
            // 
            // btnNext
            // 
            btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            btnNext.FlatAppearance.BorderSize = 0;
            btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnNext.Font = new System.Drawing.Font("Segoe UI", 6F);
            btnNext.Location = new System.Drawing.Point(1160, 17);
            btnNext.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnNext.Name = "btnNext";
            btnNext.Size = new System.Drawing.Size(32, 37);
            btnNext.TabIndex = 5;
            btnNext.Tag = "";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            btnNext.Paint += Pager_Paint;
            // 
            // btnPage3
            // 
            btnPage3.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            btnPage3.Cursor = System.Windows.Forms.Cursors.Hand;
            btnPage3.FlatAppearance.BorderSize = 0;
            btnPage3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnPage3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            btnPage3.Location = new System.Drawing.Point(1123, 17);
            btnPage3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnPage3.Name = "btnPage3";
            btnPage3.Size = new System.Drawing.Size(32, 37);
            btnPage3.TabIndex = 4;
            btnPage3.Text = "3";
            btnPage3.UseVisualStyleBackColor = false;
            btnPage3.Click += Page_Click;
            btnPage3.Paint += Pager_Paint;
            // 
            // btnPage2
            // 
            btnPage2.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            btnPage2.Cursor = System.Windows.Forms.Cursors.Hand;
            btnPage2.FlatAppearance.BorderSize = 0;
            btnPage2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnPage2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            btnPage2.Location = new System.Drawing.Point(1087, 17);
            btnPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnPage2.Name = "btnPage2";
            btnPage2.Size = new System.Drawing.Size(32, 37);
            btnPage2.TabIndex = 3;
            btnPage2.Text = "2";
            btnPage2.UseVisualStyleBackColor = false;
            btnPage2.Click += Page_Click;
            btnPage2.Paint += Pager_Paint;
            // 
            // btnPage1
            // 
            btnPage1.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            btnPage1.Cursor = System.Windows.Forms.Cursors.Hand;
            btnPage1.FlatAppearance.BorderSize = 0;
            btnPage1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnPage1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            btnPage1.Location = new System.Drawing.Point(1050, 17);
            btnPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnPage1.Name = "btnPage1";
            btnPage1.Size = new System.Drawing.Size(32, 37);
            btnPage1.TabIndex = 2;
            btnPage1.Text = "1";
            btnPage1.UseVisualStyleBackColor = false;
            btnPage1.Click += Page_Click;
            btnPage1.Paint += Pager_Paint;
            // 
            // btnPrev
            // 
            btnPrev.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            btnPrev.Cursor = System.Windows.Forms.Cursors.Hand;
            btnPrev.FlatAppearance.BorderSize = 0;
            btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnPrev.Font = new System.Drawing.Font("Segoe UI", 6F);
            btnPrev.Location = new System.Drawing.Point(1014, 17);
            btnPrev.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new System.Drawing.Size(32, 37);
            btnPrev.TabIndex = 1;
            btnPrev.Tag = "";
            btnPrev.UseVisualStyleBackColor = false;
            btnPrev.Click += btnPrev_Click;
            btnPrev.Paint += Pager_Paint;
            // 
            // lblPageInfo
            // 
            lblPageInfo.AutoSize = true;
            lblPageInfo.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            lblPageInfo.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)135)), ((int)((byte)147)), ((int)((byte)163)));
            lblPageInfo.Location = new System.Drawing.Point(21, 27);
            lblPageInfo.Name = "lblPageInfo";
            lblPageInfo.Size = new System.Drawing.Size(0, 19);
            lblPageInfo.TabIndex = 0;
            // 
            // FormAttendance
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = System.Drawing.Color.FromArgb(((int)((byte)245)), ((int)((byte)247)), ((int)((byte)251)));
            ClientSize = new System.Drawing.Size(1275, 1053);
            Controls.Add(pnlTable);
            Controls.Add(pnlWarning);
            Controls.Add(pnlToolbar);
            Controls.Add(btnSave);
            Controls.Add(lblDesc);
            Controls.Add(lblTitle);
            Controls.Add(lblEyebrow);
            Font = new System.Drawing.Font("Segoe UI", 9F);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Location = new System.Drawing.Point(19, 19);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Text = "Điểm danh & Kết quả";
            Load += FormAttendance_Load;
            pnlToolbar.ResumeLayout(false);
            pnlTabs.ResumeLayout(false);
            pnlWarning.ResumeLayout(false);
            pnlTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAttendance).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvScores).EndInit();
            pnlFooter.ResumeLayout(false);
            pnlFooter.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.DataGridViewTextBoxColumn colCertificate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAverage;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMidterm;
        private System.Windows.Forms.DataGridViewTextBoxColumn colScoreAttendance;
        private System.Windows.Forms.DataGridViewTextBoxColumn colScoreStudent;
        private System.Windows.Forms.DataGridView dgvScores;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAbsent;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAttendance;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStudent;
        private System.Windows.Forms.DataGridView dgvAttendance;

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
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Label lblPageInfo;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnPage1;
        private System.Windows.Forms.Button btnPage2;
        private System.Windows.Forms.Button btnPage3;
        private System.Windows.Forms.Button btnNext;
    }
}
