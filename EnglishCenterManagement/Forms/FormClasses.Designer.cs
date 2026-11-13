namespace EnglishCenterManagement.Forms
{
    partial class FormClasses
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
            System.Windows.Forms.DataGridViewCellStyle headerStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle cellStyle = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblEyebrow = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pnlToolbar = new System.Windows.Forms.Panel();
            this.btnExport = new System.Windows.Forms.Button();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.pnlSearchBox = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearchIcon = new System.Windows.Forms.Label();
            this.pnlTable = new System.Windows.Forms.Panel();
            this.dgvClasses = new System.Windows.Forms.DataGridView();
            this.colClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSchedule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTeacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPage3 = new System.Windows.Forms.Button();
            this.btnPage2 = new System.Windows.Forms.Button();
            this.btnPage1 = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.lblPageInfo = new System.Windows.Forms.Label();
            this.pnlToolbar.SuspendLayout();
            this.pnlSearchBox.SuspendLayout();
            this.pnlTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClasses)).BeginInit();
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
            this.lblEyebrow.Size = new System.Drawing.Size(103, 12);
            this.lblEyebrow.TabIndex = 0;
            this.lblEyebrow.Text = "VẬN HÀNH LỚP HỌC";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(23, 36, 61);
            this.lblTitle.Location = new System.Drawing.Point(27, 42);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(219, 32);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Danh sách lớp học";
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
            this.lblDesc.Text = "Quản lý phòng, giáo viên phụ trách và sĩ số từng lớp.";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(945, 46);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(140, 38);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Tag = "\uE710";
            this.btnAdd.Text = "Thêm lớp học";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnAdd.Paint += new System.Windows.Forms.PaintEventHandler(this.Primary_Paint);
            // 
            // pnlToolbar
            // 
            this.pnlToolbar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlToolbar.BackColor = System.Drawing.Color.White;
            this.pnlToolbar.Controls.Add(this.btnExport);
            this.pnlToolbar.Controls.Add(this.cboStatus);
            this.pnlToolbar.Controls.Add(this.pnlSearchBox);
            this.pnlToolbar.Location = new System.Drawing.Point(31, 116);
            this.pnlToolbar.Name = "pnlToolbar";
            this.pnlToolbar.Size = new System.Drawing.Size(1054, 58);
            this.pnlToolbar.TabIndex = 4;
            this.pnlToolbar.Paint += new System.Windows.Forms.PaintEventHandler(this.Card_Paint);
            // 
            // pnlSearchBox
            // 
            this.pnlSearchBox.BackColor = System.Drawing.Color.FromArgb(249, 250, 251);
            this.pnlSearchBox.Controls.Add(this.txtSearch);
            this.pnlSearchBox.Controls.Add(this.lblSearchIcon);
            this.pnlSearchBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pnlSearchBox.Location = new System.Drawing.Point(14, 11);
            this.pnlSearchBox.Name = "pnlSearchBox";
            this.pnlSearchBox.Size = new System.Drawing.Size(300, 36);
            this.pnlSearchBox.TabIndex = 0;
            this.pnlSearchBox.Click += new System.EventHandler(this.pnlSearchBox_Click);
            this.pnlSearchBox.Paint += new System.Windows.Forms.PaintEventHandler(this.SearchBox_Paint);
            // 
            // lblSearchIcon
            // 
            this.lblSearchIcon.Font = new System.Drawing.Font("Segoe MDL2 Assets", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSearchIcon.ForeColor = System.Drawing.Color.FromArgb(152, 162, 176);
            this.lblSearchIcon.Location = new System.Drawing.Point(8, 2);
            this.lblSearchIcon.Name = "lblSearchIcon";
            this.lblSearchIcon.Size = new System.Drawing.Size(24, 32);
            this.lblSearchIcon.TabIndex = 0;
            this.lblSearchIcon.Text = "\uE721";
            this.lblSearchIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(249, 250, 251);
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(31, 45, 68);
            this.txtSearch.Location = new System.Drawing.Point(36, 10);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "Tìm kiếm lớp học...";
            this.txtSearch.Size = new System.Drawing.Size(254, 16);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // cboStatus
            // 
            this.cboStatus.BackColor = System.Drawing.Color.White;
            this.cboStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboStatus.ForeColor = System.Drawing.Color.FromArgb(43, 58, 82);
            this.cboStatus.ItemHeight = 30;
            this.cboStatus.Items.AddRange(new object[] {
            "Tất cả trạng thái",
            "Đang học",
            "Đã kết thúc"});
            this.cboStatus.Location = new System.Drawing.Point(326, 11);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(170, 36);
            this.cboStatus.TabIndex = 1;
            this.cboStatus.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.Combo_DrawItem);
            this.cboStatus.SelectedIndexChanged += new System.EventHandler(this.cboStatus_SelectedIndexChanged);
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExport.ForeColor = System.Drawing.Color.FromArgb(58, 73, 96);
            this.btnExport.Location = new System.Drawing.Point(898, 11);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(142, 36);
            this.btnExport.TabIndex = 2;
            this.btnExport.Tag = "\uE896";
            this.btnExport.Text = "Xuất báo cáo";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            this.btnExport.Paint += new System.Windows.Forms.PaintEventHandler(this.Outline_Paint);
            // 
            // pnlTable
            // 
            this.pnlTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTable.BackColor = System.Drawing.Color.White;
            this.pnlTable.Controls.Add(this.dgvClasses);
            this.pnlTable.Controls.Add(this.pnlFooter);
            this.pnlTable.Location = new System.Drawing.Point(31, 188);
            this.pnlTable.Name = "pnlTable";
            this.pnlTable.Padding = new System.Windows.Forms.Padding(1);
            this.pnlTable.Size = new System.Drawing.Size(1054, 566);
            this.pnlTable.TabIndex = 5;
            this.pnlTable.Paint += new System.Windows.Forms.PaintEventHandler(this.Card_Paint);
            // 
            // dgvClasses
            // 
            this.dgvClasses.AllowUserToAddRows = false;
            this.dgvClasses.AllowUserToDeleteRows = false;
            this.dgvClasses.AllowUserToResizeColumns = false;
            this.dgvClasses.AllowUserToResizeRows = false;
            this.dgvClasses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClasses.BackgroundColor = System.Drawing.Color.White;
            this.dgvClasses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvClasses.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvClasses.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            headerStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            headerStyle.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            headerStyle.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            headerStyle.ForeColor = System.Drawing.Color.FromArgb(142, 154, 170);
            headerStyle.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            headerStyle.SelectionBackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            headerStyle.SelectionForeColor = System.Drawing.Color.FromArgb(142, 154, 170);
            headerStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClasses.ColumnHeadersDefaultCellStyle = headerStyle;
            this.dgvClasses.ColumnHeadersHeight = 39;
            this.dgvClasses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvClasses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colClass,
            this.colSchedule,
            this.colTeacher,
            this.colSize,
            this.colStatus,
            this.colAction});
            this.dgvClasses.Cursor = System.Windows.Forms.Cursors.Hand;
            cellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            cellStyle.BackColor = System.Drawing.Color.White;
            cellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cellStyle.ForeColor = System.Drawing.Color.FromArgb(101, 116, 137);
            cellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(247, 251, 255);
            cellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(101, 116, 137);
            cellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClasses.DefaultCellStyle = cellStyle;
            this.dgvClasses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvClasses.EnableHeadersVisualStyles = false;
            this.dgvClasses.GridColor = System.Drawing.Color.FromArgb(237, 240, 244);
            this.dgvClasses.Location = new System.Drawing.Point(1, 1);
            this.dgvClasses.MultiSelect = false;
            this.dgvClasses.Name = "dgvClasses";
            this.dgvClasses.ReadOnly = true;
            this.dgvClasses.RowHeadersVisible = false;
            this.dgvClasses.RowTemplate.Height = 60;
            this.dgvClasses.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvClasses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClasses.Size = new System.Drawing.Size(1052, 510);
            this.dgvClasses.TabIndex = 0;
            this.dgvClasses.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClasses_CellClick);
            this.dgvClasses.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClasses_CellDoubleClick);
            this.dgvClasses.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvClasses_CellPainting);
            this.dgvClasses.SizeChanged += new System.EventHandler(this.Grid_SizeChanged);
            // 
            // colClass
            // 
            this.colClass.FillWeight = 240F;
            this.colClass.HeaderText = "LỚP HỌC";
            this.colClass.Name = "colClass";
            this.colClass.ReadOnly = true;
            this.colClass.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colSchedule
            // 
            this.colSchedule.FillWeight = 150F;
            this.colSchedule.HeaderText = "LỊCH HỌC";
            this.colSchedule.Name = "colSchedule";
            this.colSchedule.ReadOnly = true;
            this.colSchedule.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colTeacher
            // 
            this.colTeacher.FillWeight = 150F;
            this.colTeacher.HeaderText = "GIÁO VIÊN";
            this.colTeacher.Name = "colTeacher";
            this.colTeacher.ReadOnly = true;
            this.colTeacher.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colSize
            // 
            this.colSize.FillWeight = 140F;
            this.colSize.HeaderText = "SĨ SỐ";
            this.colSize.Name = "colSize";
            this.colSize.ReadOnly = true;
            this.colSize.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colStatus
            // 
            this.colStatus.FillWeight = 120F;
            this.colStatus.HeaderText = "TRẠNG THÁI";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            this.colStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colAction
            // 
            this.colAction.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colAction.HeaderText = "";
            this.colAction.Name = "colAction";
            this.colAction.ReadOnly = true;
            this.colAction.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colAction.Width = 64;
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
            this.pnlFooter.Location = new System.Drawing.Point(1, 511);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(1052, 54);
            this.pnlFooter.TabIndex = 1;
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
            // FormClasses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(245, 247, 251);
            this.ClientSize = new System.Drawing.Size(1116, 790);
            this.Controls.Add(this.pnlTable);
            this.Controls.Add(this.pnlToolbar);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblEyebrow);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormClasses";
            this.Text = "Lớp học";
            this.Load += new System.EventHandler(this.FormClasses_Load);
            this.pnlToolbar.ResumeLayout(false);
            this.pnlSearchBox.ResumeLayout(false);
            this.pnlSearchBox.PerformLayout();
            this.pnlTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClasses)).EndInit();
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblEyebrow;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel pnlToolbar;
        private System.Windows.Forms.Panel pnlSearchBox;
        private System.Windows.Forms.Label lblSearchIcon;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Panel pnlTable;
        private System.Windows.Forms.DataGridView dgvClasses;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSchedule;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTeacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAction;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Label lblPageInfo;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnPage1;
        private System.Windows.Forms.Button btnPage2;
        private System.Windows.Forms.Button btnPage3;
        private System.Windows.Forms.Button btnNext;
    }
}
