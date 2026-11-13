namespace EnglishCenterManagement.Forms
{
    partial class FormStudentDetail
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
            System.Windows.Forms.DataGridViewCellStyle enrollmentHeaderStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle enrollmentCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle paymentHeaderStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle paymentCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlAvatar = new System.Windows.Forms.Panel();
            this.lblHeaderTitle = new System.Windows.Forms.Label();
            this.lblHeaderSub = new System.Windows.Forms.Label();
            this.pnlStatus = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblBirth = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblEnrollments = new System.Windows.Forms.Label();
            this.lblEnrollmentHint = new System.Windows.Forms.Label();
            this.pnlEnrollments = new System.Windows.Forms.Panel();
            this.lblEnrollmentEmpty = new System.Windows.Forms.Label();
            this.dgvEnrollments = new System.Windows.Forms.DataGridView();
            this.colClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPolicy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPayments = new System.Windows.Forms.Label();
            this.lblPaymentHint = new System.Windows.Forms.Label();
            this.pnlPayments = new System.Windows.Forms.Panel();
            this.lblPaymentEmpty = new System.Windows.Forms.Label();
            this.dgvPayments = new System.Windows.Forms.DataGridView();
            this.colTerm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPaymentStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPaymentAction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlInfo.SuspendLayout();
            this.pnlEnrollments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnrollments)).BeginInit();
            this.pnlPayments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).BeginInit();
            this.pnlFooter.SuspendLayout();
            this.SuspendLayout();
            // pnlAvatar
            this.pnlAvatar.BackColor = System.Drawing.Color.White;
            this.pnlAvatar.Location = new System.Drawing.Point(24, 16);
            this.pnlAvatar.Name = "pnlAvatar";
            this.pnlAvatar.Size = new System.Drawing.Size(48, 48);
            this.pnlAvatar.TabIndex = 0;
            this.pnlAvatar.Paint += new System.Windows.Forms.PaintEventHandler(this.Avatar_Paint);
            // lblHeaderTitle
            this.lblHeaderTitle.AutoEllipsis = true;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeaderTitle.ForeColor = System.Drawing.Color.FromArgb(23, 36, 61);
            this.lblHeaderTitle.Location = new System.Drawing.Point(85, 17);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(446, 24);
            this.lblHeaderTitle.TabIndex = 1;
            this.lblHeaderTitle.Text = "Chi tiết học viên";
            // lblHeaderSub
            this.lblHeaderSub.AutoEllipsis = true;
            this.lblHeaderSub.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHeaderSub.ForeColor = System.Drawing.Color.FromArgb(135, 147, 163);
            this.lblHeaderSub.Location = new System.Drawing.Point(86, 43);
            this.lblHeaderSub.Name = "lblHeaderSub";
            this.lblHeaderSub.Size = new System.Drawing.Size(445, 18);
            this.lblHeaderSub.TabIndex = 2;
            this.lblHeaderSub.Text = "Hồ sơ và tình trạng học phí";
            // pnlStatus
            this.pnlStatus.BackColor = System.Drawing.Color.White;
            this.pnlStatus.Location = new System.Drawing.Point(548, 28);
            this.pnlStatus.Name = "pnlStatus";
            this.pnlStatus.Size = new System.Drawing.Size(143, 26);
            this.pnlStatus.TabIndex = 3;
            this.pnlStatus.Paint += new System.Windows.Forms.PaintEventHandler(this.Status_Paint);
            // btnClose
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClose.Location = new System.Drawing.Point(706, 24);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 20;
            this.btnClose.TabStop = false;
            this.btnClose.Tag = "\uE711";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnCancel_Click);
            this.btnClose.Paint += new System.Windows.Forms.PaintEventHandler(this.Soft_Paint);
            // pnlInfo
            this.pnlInfo.BackColor = System.Drawing.Color.FromArgb(250, 251, 252);
            this.pnlInfo.Controls.Add(this.lblAddress);
            this.pnlInfo.Controls.Add(this.lblBirth);
            this.pnlInfo.Controls.Add(this.lblContact);
            this.pnlInfo.Location = new System.Drawing.Point(24, 96);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(712, 48);
            this.pnlInfo.TabIndex = 4;
            this.pnlInfo.Paint += new System.Windows.Forms.PaintEventHandler(this.Card_Paint);
            // lblContact
            this.lblContact.AutoEllipsis = true;
            this.lblContact.BackColor = System.Drawing.Color.FromArgb(250, 251, 252);
            this.lblContact.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblContact.ForeColor = System.Drawing.Color.FromArgb(101, 116, 137);
            this.lblContact.Location = new System.Drawing.Point(12, 7);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(450, 17);
            this.lblContact.TabIndex = 0;
            this.lblContact.Text = "Điện thoại: — · Email: —";
            // lblBirth
            this.lblBirth.AutoEllipsis = true;
            this.lblBirth.BackColor = System.Drawing.Color.FromArgb(250, 251, 252);
            this.lblBirth.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBirth.ForeColor = System.Drawing.Color.FromArgb(101, 116, 137);
            this.lblBirth.Location = new System.Drawing.Point(476, 7);
            this.lblBirth.Name = "lblBirth";
            this.lblBirth.Size = new System.Drawing.Size(224, 17);
            this.lblBirth.TabIndex = 1;
            this.lblBirth.Text = "Ngày sinh: —";
            // lblAddress
            this.lblAddress.AutoEllipsis = true;
            this.lblAddress.BackColor = System.Drawing.Color.FromArgb(250, 251, 252);
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAddress.ForeColor = System.Drawing.Color.FromArgb(135, 147, 163);
            this.lblAddress.Location = new System.Drawing.Point(12, 27);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(688, 17);
            this.lblAddress.TabIndex = 2;
            this.lblAddress.Text = "Địa chỉ: —";
            // lblEnrollments
            this.lblEnrollments.AutoSize = true;
            this.lblEnrollments.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEnrollments.ForeColor = System.Drawing.Color.FromArgb(36, 50, 73);
            this.lblEnrollments.Location = new System.Drawing.Point(24, 157);
            this.lblEnrollments.Name = "lblEnrollments";
            this.lblEnrollments.Size = new System.Drawing.Size(97, 15);
            this.lblEnrollments.TabIndex = 5;
            this.lblEnrollments.Text = "Các lớp đăng ký";
            // lblEnrollmentHint
            this.lblEnrollmentHint.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEnrollmentHint.ForeColor = System.Drawing.Color.FromArgb(135, 147, 163);
            this.lblEnrollmentHint.Location = new System.Drawing.Point(398, 156);
            this.lblEnrollmentHint.Name = "lblEnrollmentHint";
            this.lblEnrollmentHint.Size = new System.Drawing.Size(338, 18);
            this.lblEnrollmentHint.TabIndex = 6;
            this.lblEnrollmentHint.Text = "Chọn lớp để xem các kỳ thanh toán";
            this.lblEnrollmentHint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // pnlEnrollments
            this.pnlEnrollments.BackColor = System.Drawing.Color.White;
            this.pnlEnrollments.Controls.Add(this.lblEnrollmentEmpty);
            this.pnlEnrollments.Controls.Add(this.dgvEnrollments);
            this.pnlEnrollments.Location = new System.Drawing.Point(24, 180);
            this.pnlEnrollments.Name = "pnlEnrollments";
            this.pnlEnrollments.Padding = new System.Windows.Forms.Padding(1);
            this.pnlEnrollments.Size = new System.Drawing.Size(712, 175);
            this.pnlEnrollments.TabIndex = 7;
            this.pnlEnrollments.Paint += new System.Windows.Forms.PaintEventHandler(this.Card_Paint);
            // lblEnrollmentEmpty
            this.lblEnrollmentEmpty.BackColor = System.Drawing.Color.White;
            this.lblEnrollmentEmpty.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEnrollmentEmpty.ForeColor = System.Drawing.Color.FromArgb(135, 147, 163);
            this.lblEnrollmentEmpty.Location = new System.Drawing.Point(16, 80);
            this.lblEnrollmentEmpty.Name = "lblEnrollmentEmpty";
            this.lblEnrollmentEmpty.Size = new System.Drawing.Size(680, 35);
            this.lblEnrollmentEmpty.TabIndex = 1;
            this.lblEnrollmentEmpty.Text = "Học viên chưa đăng ký lớp học.";
            this.lblEnrollmentEmpty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEnrollmentEmpty.Visible = false;
            // dgvEnrollments
            this.dgvEnrollments.AllowUserToAddRows = false;
            this.dgvEnrollments.AllowUserToDeleteRows = false;
            this.dgvEnrollments.AllowUserToResizeColumns = false;
            this.dgvEnrollments.AllowUserToResizeRows = false;
            this.dgvEnrollments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEnrollments.BackgroundColor = System.Drawing.Color.White;
            this.dgvEnrollments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEnrollments.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvEnrollments.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            enrollmentHeaderStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            enrollmentHeaderStyle.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            enrollmentHeaderStyle.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            enrollmentHeaderStyle.ForeColor = System.Drawing.Color.FromArgb(142, 154, 170);
            enrollmentHeaderStyle.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            enrollmentHeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            enrollmentHeaderStyle.SelectionForeColor = System.Drawing.Color.FromArgb(142, 154, 170);
            enrollmentHeaderStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEnrollments.ColumnHeadersDefaultCellStyle = enrollmentHeaderStyle;
            this.dgvEnrollments.ColumnHeadersHeight = 39;
            this.dgvEnrollments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvEnrollments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colClass,
            this.colFee,
            this.colPolicy,
            this.colPlan,
            this.colBalance});
            this.dgvEnrollments.Cursor = System.Windows.Forms.Cursors.Hand;
            enrollmentCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            enrollmentCellStyle.BackColor = System.Drawing.Color.White;
            enrollmentCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            enrollmentCellStyle.ForeColor = System.Drawing.Color.FromArgb(101, 116, 137);
            enrollmentCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(247, 251, 255);
            enrollmentCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(101, 116, 137);
            enrollmentCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEnrollments.DefaultCellStyle = enrollmentCellStyle;
            this.dgvEnrollments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEnrollments.EnableHeadersVisualStyles = false;
            this.dgvEnrollments.GridColor = System.Drawing.Color.FromArgb(237, 240, 244);
            this.dgvEnrollments.Location = new System.Drawing.Point(1, 1);
            this.dgvEnrollments.MultiSelect = false;
            this.dgvEnrollments.Name = "dgvEnrollments";
            this.dgvEnrollments.ReadOnly = true;
            this.dgvEnrollments.RowHeadersVisible = false;
            this.dgvEnrollments.RowTemplate.Height = 60;
            this.dgvEnrollments.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvEnrollments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEnrollments.Size = new System.Drawing.Size(710, 173);
            this.dgvEnrollments.TabIndex = 0;
            this.dgvEnrollments.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvEnrollments_CellPainting);
            this.dgvEnrollments.SelectionChanged += new System.EventHandler(this.dgvEnrollments_SelectionChanged);
            this.dgvEnrollments.SizeChanged += new System.EventHandler(this.Grid_SizeChanged);
            // colClass
            this.colClass.FillWeight = 165F;
            this.colClass.HeaderText = "LỚP";
            this.colClass.Name = "colClass";
            this.colClass.ReadOnly = true;
            this.colClass.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // colFee
            this.colFee.FillWeight = 120F;
            this.colFee.HeaderText = "HỌC PHÍ";
            this.colFee.Name = "colFee";
            this.colFee.ReadOnly = true;
            this.colFee.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // colPolicy
            this.colPolicy.FillWeight = 145F;
            this.colPolicy.HeaderText = "ƯU ĐÃI";
            this.colPolicy.Name = "colPolicy";
            this.colPolicy.ReadOnly = true;
            this.colPolicy.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // colPlan
            this.colPlan.FillWeight = 110F;
            this.colPlan.HeaderText = "PHƯƠNG THỨC";
            this.colPlan.Name = "colPlan";
            this.colPlan.ReadOnly = true;
            this.colPlan.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // colBalance
            this.colBalance.FillWeight = 170F;
            this.colBalance.HeaderText = "ĐÃ THU / CÒN LẠI";
            this.colBalance.Name = "colBalance";
            this.colBalance.ReadOnly = true;
            this.colBalance.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // lblPayments
            this.lblPayments.AutoEllipsis = true;
            this.lblPayments.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPayments.ForeColor = System.Drawing.Color.FromArgb(36, 50, 73);
            this.lblPayments.Location = new System.Drawing.Point(24, 372);
            this.lblPayments.Name = "lblPayments";
            this.lblPayments.Size = new System.Drawing.Size(465, 19);
            this.lblPayments.TabIndex = 8;
            this.lblPayments.Text = "Các kỳ thanh toán";
            // lblPaymentHint
            this.lblPaymentHint.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPaymentHint.ForeColor = System.Drawing.Color.FromArgb(135, 147, 163);
            this.lblPaymentHint.Location = new System.Drawing.Point(496, 372);
            this.lblPaymentHint.Name = "lblPaymentHint";
            this.lblPaymentHint.Size = new System.Drawing.Size(240, 19);
            this.lblPaymentHint.TabIndex = 9;
            this.lblPaymentHint.Text = "Thu tiền theo thứ tự từng kỳ";
            this.lblPaymentHint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // pnlPayments
            this.pnlPayments.BackColor = System.Drawing.Color.White;
            this.pnlPayments.Controls.Add(this.lblPaymentEmpty);
            this.pnlPayments.Controls.Add(this.dgvPayments);
            this.pnlPayments.Location = new System.Drawing.Point(24, 398);
            this.pnlPayments.Name = "pnlPayments";
            this.pnlPayments.Padding = new System.Windows.Forms.Padding(1);
            this.pnlPayments.Size = new System.Drawing.Size(712, 162);
            this.pnlPayments.TabIndex = 10;
            this.pnlPayments.Paint += new System.Windows.Forms.PaintEventHandler(this.Card_Paint);
            // lblPaymentEmpty
            this.lblPaymentEmpty.BackColor = System.Drawing.Color.White;
            this.lblPaymentEmpty.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPaymentEmpty.ForeColor = System.Drawing.Color.FromArgb(135, 147, 163);
            this.lblPaymentEmpty.Location = new System.Drawing.Point(16, 70);
            this.lblPaymentEmpty.Name = "lblPaymentEmpty";
            this.lblPaymentEmpty.Size = new System.Drawing.Size(680, 35);
            this.lblPaymentEmpty.TabIndex = 1;
            this.lblPaymentEmpty.Text = "Chọn lớp để xem các kỳ thanh toán.";
            this.lblPaymentEmpty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPaymentEmpty.Visible = false;
            // dgvPayments
            this.dgvPayments.AllowUserToAddRows = false;
            this.dgvPayments.AllowUserToDeleteRows = false;
            this.dgvPayments.AllowUserToResizeColumns = false;
            this.dgvPayments.AllowUserToResizeRows = false;
            this.dgvPayments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPayments.BackgroundColor = System.Drawing.Color.White;
            this.dgvPayments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPayments.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPayments.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            paymentHeaderStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            paymentHeaderStyle.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            paymentHeaderStyle.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            paymentHeaderStyle.ForeColor = System.Drawing.Color.FromArgb(142, 154, 170);
            paymentHeaderStyle.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            paymentHeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            paymentHeaderStyle.SelectionForeColor = System.Drawing.Color.FromArgb(142, 154, 170);
            paymentHeaderStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPayments.ColumnHeadersDefaultCellStyle = paymentHeaderStyle;
            this.dgvPayments.ColumnHeadersHeight = 39;
            this.dgvPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPayments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTerm,
            this.colDue,
            this.colAmount,
            this.colPaymentStatus,
            this.colPaymentAction});
            this.dgvPayments.Cursor = System.Windows.Forms.Cursors.Hand;
            paymentCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            paymentCellStyle.BackColor = System.Drawing.Color.White;
            paymentCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            paymentCellStyle.ForeColor = System.Drawing.Color.FromArgb(101, 116, 137);
            paymentCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(247, 251, 255);
            paymentCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(101, 116, 137);
            paymentCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPayments.DefaultCellStyle = paymentCellStyle;
            this.dgvPayments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPayments.EnableHeadersVisualStyles = false;
            this.dgvPayments.GridColor = System.Drawing.Color.FromArgb(237, 240, 244);
            this.dgvPayments.Location = new System.Drawing.Point(1, 1);
            this.dgvPayments.MultiSelect = false;
            this.dgvPayments.Name = "dgvPayments";
            this.dgvPayments.ReadOnly = true;
            this.dgvPayments.RowHeadersVisible = false;
            this.dgvPayments.RowTemplate.Height = 60;
            this.dgvPayments.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvPayments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPayments.Size = new System.Drawing.Size(710, 160);
            this.dgvPayments.TabIndex = 0;
            this.dgvPayments.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPayments_CellClick);
            this.dgvPayments.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvPayments_CellPainting);
            this.dgvPayments.SizeChanged += new System.EventHandler(this.Grid_SizeChanged);
            // colTerm
            this.colTerm.FillWeight = 80F;
            this.colTerm.HeaderText = "KỲ";
            this.colTerm.Name = "colTerm";
            this.colTerm.ReadOnly = true;
            this.colTerm.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // colDue
            this.colDue.FillWeight = 130F;
            this.colDue.HeaderText = "HẠN";
            this.colDue.Name = "colDue";
            this.colDue.ReadOnly = true;
            this.colDue.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // colAmount
            this.colAmount.FillWeight = 165F;
            this.colAmount.HeaderText = "SỐ TIỀN";
            this.colAmount.Name = "colAmount";
            this.colAmount.ReadOnly = true;
            this.colAmount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // colPaymentStatus
            this.colPaymentStatus.FillWeight = 150F;
            this.colPaymentStatus.HeaderText = "TRẠNG THÁI";
            this.colPaymentStatus.Name = "colPaymentStatus";
            this.colPaymentStatus.ReadOnly = true;
            this.colPaymentStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // colPaymentAction
            this.colPaymentAction.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colPaymentAction.HeaderText = "";
            this.colPaymentAction.Name = "colPaymentAction";
            this.colPaymentAction.ReadOnly = true;
            this.colPaymentAction.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colPaymentAction.Width = 164;
            // pnlFooter
            this.pnlFooter.BackColor = System.Drawing.Color.FromArgb(250, 251, 252);
            this.pnlFooter.Controls.Add(this.btnEdit);
            this.pnlFooter.Controls.Add(this.btnCancel);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 564);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(760, 68);
            this.pnlFooter.TabIndex = 11;
            this.pnlFooter.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlFooter_Paint);
            // btnEdit
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEdit.Location = new System.Drawing.Point(24, 16);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(134, 36);
            this.btnEdit.TabIndex = 0;
            this.btnEdit.Tag = "\uE70F";
            this.btnEdit.Text = "Sửa hồ sơ";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            this.btnEdit.Paint += new System.Windows.Forms.PaintEventHandler(this.Outline_Paint);
            // btnCancel
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(652, 16);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(84, 36);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Đóng";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            this.btnCancel.Paint += new System.Windows.Forms.PaintEventHandler(this.Accent_Paint);
            // FormStudentDetail
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(760, 632);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlPayments);
            this.Controls.Add(this.lblPaymentHint);
            this.Controls.Add(this.lblPayments);
            this.Controls.Add(this.pnlEnrollments);
            this.Controls.Add(this.lblEnrollmentHint);
            this.Controls.Add(this.lblEnrollments);
            this.Controls.Add(this.pnlInfo);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pnlStatus);
            this.Controls.Add(this.lblHeaderSub);
            this.Controls.Add(this.lblHeaderTitle);
            this.Controls.Add(this.pnlAvatar);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormStudentDetail";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chi tiết học viên";
            this.Load += new System.EventHandler(this.FormStudentDetail_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Dialog_Paint);
            this.pnlInfo.ResumeLayout(false);
            this.pnlEnrollments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnrollments)).EndInit();
            this.pnlPayments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).EndInit();
            this.pnlFooter.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel pnlAvatar;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Label lblHeaderSub;
        private System.Windows.Forms.Panel pnlStatus;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblBirth;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblEnrollments;
        private System.Windows.Forms.Label lblEnrollmentHint;
        private System.Windows.Forms.Panel pnlEnrollments;
        private System.Windows.Forms.Label lblEnrollmentEmpty;
        private System.Windows.Forms.DataGridView dgvEnrollments;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFee;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPolicy;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBalance;
        private System.Windows.Forms.Label lblPayments;
        private System.Windows.Forms.Label lblPaymentHint;
        private System.Windows.Forms.Panel pnlPayments;
        private System.Windows.Forms.Label lblPaymentEmpty;
        private System.Windows.Forms.DataGridView dgvPayments;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTerm;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPaymentStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPaymentAction;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnCancel;
    }
}
