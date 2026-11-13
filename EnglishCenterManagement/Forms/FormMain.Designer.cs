namespace EnglishCenterManagement.Forms
{
    partial class FormMain
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
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.pnlUser = new System.Windows.Forms.Panel();
            this.btnSideLogout = new System.Windows.Forms.Button();
            this.lblUserRole = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.pnlUserAvatar = new System.Windows.Forms.Panel();
            this.pnlUpgrade = new System.Windows.Forms.Panel();
            this.lblUpgradeLink = new System.Windows.Forms.Label();
            this.lblUpgradeText = new System.Windows.Forms.Label();
            this.lblUpgradeTitle = new System.Windows.Forms.Label();
            this.lblUpgradeIcon = new System.Windows.Forms.Label();
            this.pnlActiveIndicator = new System.Windows.Forms.Panel();
            this.btnNavSettings = new System.Windows.Forms.Button();
            this.lblNavSystem = new System.Windows.Forms.Label();
            this.btnNavAttendance = new System.Windows.Forms.Button();
            this.btnNavFinance = new System.Windows.Forms.Button();
            this.btnNavSchedule = new System.Windows.Forms.Button();
            this.btnNavTeachers = new System.Windows.Forms.Button();
            this.btnNavClasses = new System.Windows.Forms.Button();
            this.btnNavCourses = new System.Windows.Forms.Button();
            this.btnNavStudents = new System.Windows.Forms.Button();
            this.btnNavDashboard = new System.Windows.Forms.Button();
            this.lblNavManage = new System.Windows.Forms.Label();
            this.lblBrandSub = new System.Windows.Forms.Label();
            this.lblBrandName = new System.Windows.Forms.Label();
            this.pnlBrandMark = new System.Windows.Forms.Panel();
            this.pnlTopbar = new System.Windows.Forms.Panel();
            this.btnTopLogout = new System.Windows.Forms.Button();
            this.pnlProfile = new System.Windows.Forms.Panel();
            this.pnlDate = new System.Windows.Forms.Panel();
            this.lblToday = new System.Windows.Forms.Label();
            this.lblTodayCaption = new System.Windows.Forms.Label();
            this.btnNotify = new System.Windows.Forms.Button();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.lblKbd = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearchIcon = new System.Windows.Forms.Label();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlSidebar.SuspendLayout();
            this.pnlUser.SuspendLayout();
            this.pnlUpgrade.SuspendLayout();
            this.pnlTopbar.SuspendLayout();
            this.pnlDate.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(19, 43, 72);
            this.pnlSidebar.Controls.Add(this.pnlUser);
            this.pnlSidebar.Controls.Add(this.pnlUpgrade);
            this.pnlSidebar.Controls.Add(this.pnlActiveIndicator);
            this.pnlSidebar.Controls.Add(this.btnNavSettings);
            this.pnlSidebar.Controls.Add(this.lblNavSystem);
            this.pnlSidebar.Controls.Add(this.btnNavAttendance);
            this.pnlSidebar.Controls.Add(this.btnNavFinance);
            this.pnlSidebar.Controls.Add(this.btnNavSchedule);
            this.pnlSidebar.Controls.Add(this.btnNavTeachers);
            this.pnlSidebar.Controls.Add(this.btnNavClasses);
            this.pnlSidebar.Controls.Add(this.btnNavCourses);
            this.pnlSidebar.Controls.Add(this.btnNavStudents);
            this.pnlSidebar.Controls.Add(this.btnNavDashboard);
            this.pnlSidebar.Controls.Add(this.lblNavManage);
            this.pnlSidebar.Controls.Add(this.lblBrandSub);
            this.pnlSidebar.Controls.Add(this.lblBrandName);
            this.pnlSidebar.Controls.Add(this.pnlBrandMark);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(244, 860);
            this.pnlSidebar.TabIndex = 0;
            this.pnlSidebar.Resize += new System.EventHandler(this.pnlSidebar_Resize);
            // 
            // pnlBrandMark
            // 
            this.pnlBrandMark.BackColor = System.Drawing.Color.FromArgb(19, 43, 72);
            this.pnlBrandMark.Location = new System.Drawing.Point(25, 25);
            this.pnlBrandMark.Name = "pnlBrandMark";
            this.pnlBrandMark.Size = new System.Drawing.Size(39, 39);
            this.pnlBrandMark.TabIndex = 0;
            this.pnlBrandMark.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBrandMark_Paint);
            // 
            // lblBrandName
            // 
            this.lblBrandName.AutoSize = true;
            this.lblBrandName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBrandName.ForeColor = System.Drawing.Color.White;
            this.lblBrandName.Location = new System.Drawing.Point(72, 23);
            this.lblBrandName.Name = "lblBrandName";
            this.lblBrandName.Size = new System.Drawing.Size(93, 21);
            this.lblBrandName.TabIndex = 1;
            this.lblBrandName.Text = "EduCenter";
            // 
            // lblBrandSub
            // 
            this.lblBrandSub.AutoSize = true;
            this.lblBrandSub.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBrandSub.ForeColor = System.Drawing.Color.FromArgb(143, 163, 186);
            this.lblBrandSub.Location = new System.Drawing.Point(74, 47);
            this.lblBrandSub.Name = "lblBrandSub";
            this.lblBrandSub.Size = new System.Drawing.Size(111, 12);
            this.lblBrandSub.TabIndex = 2;
            this.lblBrandSub.Text = "ENGLISH MANAGEMENT";
            // 
            // lblNavManage
            // 
            this.lblNavManage.AutoSize = true;
            this.lblNavManage.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNavManage.ForeColor = System.Drawing.Color.FromArgb(101, 125, 152);
            this.lblNavManage.Location = new System.Drawing.Point(28, 94);
            this.lblNavManage.Name = "lblNavManage";
            this.lblNavManage.Size = new System.Drawing.Size(48, 12);
            this.lblNavManage.TabIndex = 3;
            this.lblNavManage.Text = "QUẢN LÝ";
            // 
            // btnNavDashboard
            // 
            this.btnNavDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavDashboard.FlatAppearance.BorderSize = 0;
            this.btnNavDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavDashboard.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNavDashboard.ForeColor = System.Drawing.Color.FromArgb(169, 183, 200);
            this.btnNavDashboard.Location = new System.Drawing.Point(16, 114);
            this.btnNavDashboard.Name = "btnNavDashboard";
            this.btnNavDashboard.Size = new System.Drawing.Size(212, 43);
            this.btnNavDashboard.TabIndex = 4;
            this.btnNavDashboard.Tag = "\uE80F";
            this.btnNavDashboard.Text = "Tổng quan";
            this.btnNavDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavDashboard.UseVisualStyleBackColor = false;
            this.btnNavDashboard.Click += new System.EventHandler(this.Nav_Click);
            this.btnNavDashboard.Paint += new System.Windows.Forms.PaintEventHandler(this.Nav_Paint);
            // 
            // btnNavStudents
            // 
            this.btnNavStudents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavStudents.FlatAppearance.BorderSize = 0;
            this.btnNavStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavStudents.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNavStudents.ForeColor = System.Drawing.Color.FromArgb(169, 183, 200);
            this.btnNavStudents.Location = new System.Drawing.Point(16, 159);
            this.btnNavStudents.Name = "btnNavStudents";
            this.btnNavStudents.Size = new System.Drawing.Size(212, 43);
            this.btnNavStudents.TabIndex = 5;
            this.btnNavStudents.Tag = "\uE716";
            this.btnNavStudents.Text = "Học viên";
            this.btnNavStudents.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavStudents.UseVisualStyleBackColor = false;
            this.btnNavStudents.Click += new System.EventHandler(this.Nav_Click);
            this.btnNavStudents.Paint += new System.Windows.Forms.PaintEventHandler(this.Nav_Paint);
            // 
            // btnNavCourses
            // 
            this.btnNavCourses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavCourses.FlatAppearance.BorderSize = 0;
            this.btnNavCourses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavCourses.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNavCourses.ForeColor = System.Drawing.Color.FromArgb(169, 183, 200);
            this.btnNavCourses.Location = new System.Drawing.Point(16, 204);
            this.btnNavCourses.Name = "btnNavCourses";
            this.btnNavCourses.Size = new System.Drawing.Size(212, 43);
            this.btnNavCourses.TabIndex = 6;
            this.btnNavCourses.Tag = "\uE8F1";
            this.btnNavCourses.Text = "Khóa học";
            this.btnNavCourses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavCourses.UseVisualStyleBackColor = false;
            this.btnNavCourses.Click += new System.EventHandler(this.Nav_Click);
            this.btnNavCourses.Paint += new System.Windows.Forms.PaintEventHandler(this.Nav_Paint);
            // 
            // btnNavClasses
            // 
            this.btnNavClasses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavClasses.FlatAppearance.BorderSize = 0;
            this.btnNavClasses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavClasses.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNavClasses.ForeColor = System.Drawing.Color.FromArgb(169, 183, 200);
            this.btnNavClasses.Location = new System.Drawing.Point(16, 249);
            this.btnNavClasses.Name = "btnNavClasses";
            this.btnNavClasses.Size = new System.Drawing.Size(212, 43);
            this.btnNavClasses.TabIndex = 7;
            this.btnNavClasses.Tag = "\uE7BE";
            this.btnNavClasses.Text = "Lớp học";
            this.btnNavClasses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavClasses.UseVisualStyleBackColor = false;
            this.btnNavClasses.Click += new System.EventHandler(this.Nav_Click);
            this.btnNavClasses.Paint += new System.Windows.Forms.PaintEventHandler(this.Nav_Paint);
            // 
            // btnNavTeachers
            // 
            this.btnNavTeachers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavTeachers.FlatAppearance.BorderSize = 0;
            this.btnNavTeachers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavTeachers.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNavTeachers.ForeColor = System.Drawing.Color.FromArgb(169, 183, 200);
            this.btnNavTeachers.Location = new System.Drawing.Point(16, 294);
            this.btnNavTeachers.Name = "btnNavTeachers";
            this.btnNavTeachers.Size = new System.Drawing.Size(212, 43);
            this.btnNavTeachers.TabIndex = 8;
            this.btnNavTeachers.Tag = "\uE77B";
            this.btnNavTeachers.Text = "Giảng viên";
            this.btnNavTeachers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavTeachers.UseVisualStyleBackColor = false;
            this.btnNavTeachers.Click += new System.EventHandler(this.Nav_Click);
            this.btnNavTeachers.Paint += new System.Windows.Forms.PaintEventHandler(this.Nav_Paint);
            // 
            // btnNavSchedule
            // 
            this.btnNavSchedule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavSchedule.FlatAppearance.BorderSize = 0;
            this.btnNavSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavSchedule.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNavSchedule.ForeColor = System.Drawing.Color.FromArgb(169, 183, 200);
            this.btnNavSchedule.Location = new System.Drawing.Point(16, 339);
            this.btnNavSchedule.Name = "btnNavSchedule";
            this.btnNavSchedule.Size = new System.Drawing.Size(212, 43);
            this.btnNavSchedule.TabIndex = 9;
            this.btnNavSchedule.Tag = "\uE787";
            this.btnNavSchedule.Text = "Lịch học";
            this.btnNavSchedule.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavSchedule.UseVisualStyleBackColor = false;
            this.btnNavSchedule.Click += new System.EventHandler(this.Nav_Click);
            this.btnNavSchedule.Paint += new System.Windows.Forms.PaintEventHandler(this.Nav_Paint);
            // 
            // btnNavFinance
            // 
            this.btnNavFinance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavFinance.FlatAppearance.BorderSize = 0;
            this.btnNavFinance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavFinance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNavFinance.ForeColor = System.Drawing.Color.FromArgb(169, 183, 200);
            this.btnNavFinance.Location = new System.Drawing.Point(16, 384);
            this.btnNavFinance.Name = "btnNavFinance";
            this.btnNavFinance.Size = new System.Drawing.Size(212, 43);
            this.btnNavFinance.TabIndex = 10;
            this.btnNavFinance.Tag = "\uE8C7";
            this.btnNavFinance.Text = "Tài chính";
            this.btnNavFinance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavFinance.UseVisualStyleBackColor = false;
            this.btnNavFinance.Click += new System.EventHandler(this.Nav_Click);
            this.btnNavFinance.Paint += new System.Windows.Forms.PaintEventHandler(this.Nav_Paint);
            // 
            // btnNavAttendance
            // 
            this.btnNavAttendance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavAttendance.FlatAppearance.BorderSize = 0;
            this.btnNavAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavAttendance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNavAttendance.ForeColor = System.Drawing.Color.FromArgb(169, 183, 200);
            this.btnNavAttendance.Location = new System.Drawing.Point(16, 429);
            this.btnNavAttendance.Name = "btnNavAttendance";
            this.btnNavAttendance.Size = new System.Drawing.Size(212, 43);
            this.btnNavAttendance.TabIndex = 11;
            this.btnNavAttendance.Tag = "\uE73A";
            this.btnNavAttendance.Text = "Điểm danh & Kết quả";
            this.btnNavAttendance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavAttendance.UseMnemonic = false;
            this.btnNavAttendance.UseVisualStyleBackColor = false;
            this.btnNavAttendance.Click += new System.EventHandler(this.Nav_Click);
            this.btnNavAttendance.Paint += new System.Windows.Forms.PaintEventHandler(this.Nav_Paint);
            // 
            // lblNavSystem
            // 
            this.lblNavSystem.AutoSize = true;
            this.lblNavSystem.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNavSystem.ForeColor = System.Drawing.Color.FromArgb(101, 125, 152);
            this.lblNavSystem.Location = new System.Drawing.Point(28, 490);
            this.lblNavSystem.Name = "lblNavSystem";
            this.lblNavSystem.Size = new System.Drawing.Size(58, 12);
            this.lblNavSystem.TabIndex = 12;
            this.lblNavSystem.Text = "HỆ THỐNG";
            // 
            // btnNavSettings
            // 
            this.btnNavSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavSettings.FlatAppearance.BorderSize = 0;
            this.btnNavSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavSettings.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNavSettings.ForeColor = System.Drawing.Color.FromArgb(169, 183, 200);
            this.btnNavSettings.Location = new System.Drawing.Point(16, 510);
            this.btnNavSettings.Name = "btnNavSettings";
            this.btnNavSettings.Size = new System.Drawing.Size(212, 43);
            this.btnNavSettings.TabIndex = 13;
            this.btnNavSettings.Tag = "\uE713";
            this.btnNavSettings.Text = "Cài đặt";
            this.btnNavSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavSettings.UseVisualStyleBackColor = false;
            this.btnNavSettings.Click += new System.EventHandler(this.Nav_Click);
            this.btnNavSettings.Paint += new System.Windows.Forms.PaintEventHandler(this.Nav_Paint);
            // 
            // pnlActiveIndicator
            // 
            this.pnlActiveIndicator.BackColor = System.Drawing.Color.FromArgb(98, 178, 255);
            this.pnlActiveIndicator.Location = new System.Drawing.Point(241, 125);
            this.pnlActiveIndicator.Name = "pnlActiveIndicator";
            this.pnlActiveIndicator.Size = new System.Drawing.Size(3, 21);
            this.pnlActiveIndicator.TabIndex = 14;
            // 
            // pnlUpgrade
            // 
            this.pnlUpgrade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlUpgrade.BackColor = System.Drawing.Color.FromArgb(33, 56, 83);
            this.pnlUpgrade.Controls.Add(this.lblUpgradeLink);
            this.pnlUpgrade.Controls.Add(this.lblUpgradeText);
            this.pnlUpgrade.Controls.Add(this.lblUpgradeTitle);
            this.pnlUpgrade.Controls.Add(this.lblUpgradeIcon);
            this.pnlUpgrade.Location = new System.Drawing.Point(16, 650);
            this.pnlUpgrade.Name = "pnlUpgrade";
            this.pnlUpgrade.Size = new System.Drawing.Size(212, 132);
            this.pnlUpgrade.TabIndex = 15;
            this.pnlUpgrade.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlUpgrade_Paint);
            // 
            // lblUpgradeIcon
            // 
            this.lblUpgradeIcon.BackColor = System.Drawing.Color.FromArgb(33, 56, 83);
            this.lblUpgradeIcon.Font = new System.Drawing.Font("Segoe MDL2 Assets", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUpgradeIcon.ForeColor = System.Drawing.Color.FromArgb(118, 187, 255);
            this.lblUpgradeIcon.Location = new System.Drawing.Point(14, 14);
            this.lblUpgradeIcon.Name = "lblUpgradeIcon";
            this.lblUpgradeIcon.Size = new System.Drawing.Size(30, 30);
            this.lblUpgradeIcon.TabIndex = 0;
            this.lblUpgradeIcon.Text = "\uE734";
            this.lblUpgradeIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblUpgradeIcon.Paint += new System.Windows.Forms.PaintEventHandler(this.lblUpgradeIcon_Paint);
            // 
            // lblUpgradeTitle
            // 
            this.lblUpgradeTitle.AutoSize = true;
            this.lblUpgradeTitle.BackColor = System.Drawing.Color.FromArgb(33, 56, 83);
            this.lblUpgradeTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUpgradeTitle.ForeColor = System.Drawing.Color.White;
            this.lblUpgradeTitle.Location = new System.Drawing.Point(13, 52);
            this.lblUpgradeTitle.Name = "lblUpgradeTitle";
            this.lblUpgradeTitle.Size = new System.Drawing.Size(140, 15);
            this.lblUpgradeTitle.TabIndex = 1;
            this.lblUpgradeTitle.Text = "Khám phá EduCenter Pro";
            // 
            // lblUpgradeText
            // 
            this.lblUpgradeText.BackColor = System.Drawing.Color.FromArgb(33, 56, 83);
            this.lblUpgradeText.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUpgradeText.ForeColor = System.Drawing.Color.FromArgb(159, 176, 196);
            this.lblUpgradeText.Location = new System.Drawing.Point(13, 72);
            this.lblUpgradeText.Name = "lblUpgradeText";
            this.lblUpgradeText.Size = new System.Drawing.Size(186, 30);
            this.lblUpgradeText.TabIndex = 2;
            this.lblUpgradeText.Text = "Mở khóa báo cáo nâng cao và nhiều tính năng hơn.";
            // 
            // lblUpgradeLink
            // 
            this.lblUpgradeLink.AutoSize = true;
            this.lblUpgradeLink.BackColor = System.Drawing.Color.FromArgb(33, 56, 83);
            this.lblUpgradeLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblUpgradeLink.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUpgradeLink.ForeColor = System.Drawing.Color.FromArgb(118, 187, 255);
            this.lblUpgradeLink.Location = new System.Drawing.Point(13, 106);
            this.lblUpgradeLink.Name = "lblUpgradeLink";
            this.lblUpgradeLink.Size = new System.Drawing.Size(95, 13);
            this.lblUpgradeLink.TabIndex = 3;
            this.lblUpgradeLink.Text = "Tìm hiểu thêm  →";
            this.lblUpgradeLink.Click += new System.EventHandler(this.lblUpgradeLink_Click);
            // 
            // pnlUser
            // 
            this.pnlUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlUser.BackColor = System.Drawing.Color.FromArgb(19, 43, 72);
            this.pnlUser.Controls.Add(this.btnSideLogout);
            this.pnlUser.Controls.Add(this.lblUserRole);
            this.pnlUser.Controls.Add(this.lblUserName);
            this.pnlUser.Controls.Add(this.pnlUserAvatar);
            this.pnlUser.Location = new System.Drawing.Point(16, 794);
            this.pnlUser.Name = "pnlUser";
            this.pnlUser.Size = new System.Drawing.Size(212, 52);
            this.pnlUser.TabIndex = 16;
            this.pnlUser.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlUser_Paint);
            // 
            // pnlUserAvatar
            // 
            this.pnlUserAvatar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlUserAvatar.Location = new System.Drawing.Point(2, 12);
            this.pnlUserAvatar.Name = "pnlUserAvatar";
            this.pnlUserAvatar.Size = new System.Drawing.Size(34, 34);
            this.pnlUserAvatar.TabIndex = 0;
            this.pnlUserAvatar.Click += new System.EventHandler(this.Profile_Click);
            this.pnlUserAvatar.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlUserAvatar_Paint);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoEllipsis = true;
            this.lblUserName.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUserName.ForeColor = System.Drawing.Color.White;
            this.lblUserName.Location = new System.Drawing.Point(44, 12);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(122, 17);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "Thu Hà";
            // 
            // lblUserRole
            // 
            this.lblUserRole.Font = new System.Drawing.Font("Segoe UI", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUserRole.ForeColor = System.Drawing.Color.FromArgb(128, 149, 172);
            this.lblUserRole.Location = new System.Drawing.Point(44, 30);
            this.lblUserRole.Name = "lblUserRole";
            this.lblUserRole.Size = new System.Drawing.Size(122, 15);
            this.lblUserRole.TabIndex = 2;
            this.lblUserRole.Text = "Quản trị viên";
            // 
            // btnSideLogout
            // 
            this.btnSideLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSideLogout.FlatAppearance.BorderSize = 0;
            this.btnSideLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSideLogout.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSideLogout.Location = new System.Drawing.Point(176, 13);
            this.btnSideLogout.Name = "btnSideLogout";
            this.btnSideLogout.Size = new System.Drawing.Size(32, 32);
            this.btnSideLogout.TabIndex = 3;
            this.btnSideLogout.Tag = "\uE7E8";
            this.btnSideLogout.UseVisualStyleBackColor = true;
            this.btnSideLogout.Click += new System.EventHandler(this.Logout_Click);
            this.btnSideLogout.Paint += new System.Windows.Forms.PaintEventHandler(this.btnSideLogout_Paint);
            // 
            // pnlTopbar
            // 
            this.pnlTopbar.BackColor = System.Drawing.Color.White;
            this.pnlTopbar.Controls.Add(this.btnTopLogout);
            this.pnlTopbar.Controls.Add(this.pnlProfile);
            this.pnlTopbar.Controls.Add(this.pnlDate);
            this.pnlTopbar.Controls.Add(this.btnNotify);
            this.pnlTopbar.Controls.Add(this.pnlSearch);
            this.pnlTopbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopbar.Location = new System.Drawing.Point(244, 0);
            this.pnlTopbar.Name = "pnlTopbar";
            this.pnlTopbar.Size = new System.Drawing.Size(1116, 70);
            this.pnlTopbar.TabIndex = 1;
            this.pnlTopbar.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTopbar_Paint);
            // 
            // pnlSearch
            // 
            this.pnlSearch.BackColor = System.Drawing.Color.FromArgb(247, 248, 250);
            this.pnlSearch.Controls.Add(this.lblKbd);
            this.pnlSearch.Controls.Add(this.txtSearch);
            this.pnlSearch.Controls.Add(this.lblSearchIcon);
            this.pnlSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pnlSearch.Location = new System.Drawing.Point(31, 17);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(394, 37);
            this.pnlSearch.TabIndex = 0;
            this.pnlSearch.Click += new System.EventHandler(this.pnlSearch_Click);
            this.pnlSearch.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlSearch_Paint);
            // 
            // lblSearchIcon
            // 
            this.lblSearchIcon.BackColor = System.Drawing.Color.FromArgb(247, 248, 250);
            this.lblSearchIcon.Font = new System.Drawing.Font("Segoe MDL2 Assets", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSearchIcon.ForeColor = System.Drawing.Color.FromArgb(143, 155, 170);
            this.lblSearchIcon.Location = new System.Drawing.Point(10, 8);
            this.lblSearchIcon.Name = "lblSearchIcon";
            this.lblSearchIcon.Size = new System.Drawing.Size(22, 21);
            this.lblSearchIcon.TabIndex = 0;
            this.lblSearchIcon.Text = "\uE721";
            this.lblSearchIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSearchIcon.Click += new System.EventHandler(this.pnlSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(247, 248, 250);
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(36, 50, 73);
            this.txtSearch.Location = new System.Drawing.Point(38, 10);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "Tìm học viên, khóa học, lớp học...";
            this.txtSearch.Size = new System.Drawing.Size(290, 16);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // lblKbd
            // 
            this.lblKbd.BackColor = System.Drawing.Color.FromArgb(247, 248, 250);
            this.lblKbd.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblKbd.ForeColor = System.Drawing.Color.FromArgb(143, 155, 170);
            this.lblKbd.Location = new System.Drawing.Point(336, 8);
            this.lblKbd.Name = "lblKbd";
            this.lblKbd.Size = new System.Drawing.Size(48, 21);
            this.lblKbd.TabIndex = 2;
            this.lblKbd.Text = "Ctrl K";
            this.lblKbd.Paint += new System.Windows.Forms.PaintEventHandler(this.lblKbd_Paint);
            // 
            // btnNotify
            // 
            this.btnNotify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNotify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNotify.FlatAppearance.BorderSize = 0;
            this.btnNotify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotify.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNotify.Location = new System.Drawing.Point(697, 17);
            this.btnNotify.Name = "btnNotify";
            this.btnNotify.Size = new System.Drawing.Size(38, 38);
            this.btnNotify.TabIndex = 1;
            this.btnNotify.Tag = "\uEA8F";
            this.btnNotify.UseVisualStyleBackColor = true;
            this.btnNotify.Click += new System.EventHandler(this.btnNotify_Click);
            this.btnNotify.Paint += new System.Windows.Forms.PaintEventHandler(this.btnNotify_Paint);
            // 
            // pnlDate
            // 
            this.pnlDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDate.BackColor = System.Drawing.Color.White;
            this.pnlDate.Controls.Add(this.lblToday);
            this.pnlDate.Controls.Add(this.lblTodayCaption);
            this.pnlDate.Location = new System.Drawing.Point(751, 16);
            this.pnlDate.Name = "pnlDate";
            this.pnlDate.Size = new System.Drawing.Size(170, 38);
            this.pnlDate.TabIndex = 2;
            this.pnlDate.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDate_Paint);
            // 
            // lblTodayCaption
            // 
            this.lblTodayCaption.AutoSize = true;
            this.lblTodayCaption.Font = new System.Drawing.Font("Segoe UI", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTodayCaption.ForeColor = System.Drawing.Color.FromArgb(143, 155, 170);
            this.lblTodayCaption.Location = new System.Drawing.Point(15, 2);
            this.lblTodayCaption.Name = "lblTodayCaption";
            this.lblTodayCaption.Size = new System.Drawing.Size(48, 13);
            this.lblTodayCaption.TabIndex = 0;
            this.lblTodayCaption.Text = "Hôm nay";
            // 
            // lblToday
            // 
            this.lblToday.AutoSize = true;
            this.lblToday.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblToday.ForeColor = System.Drawing.Color.FromArgb(58, 73, 96);
            this.lblToday.Location = new System.Drawing.Point(15, 18);
            this.lblToday.Name = "lblToday";
            this.lblToday.Size = new System.Drawing.Size(118, 15);
            this.lblToday.TabIndex = 1;
            this.lblToday.Text = "Thứ Hai, 24/11/2025";
            // 
            // pnlProfile
            // 
            this.pnlProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlProfile.BackColor = System.Drawing.Color.White;
            this.pnlProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlProfile.Location = new System.Drawing.Point(931, 16);
            this.pnlProfile.Name = "pnlProfile";
            this.pnlProfile.Size = new System.Drawing.Size(58, 38);
            this.pnlProfile.TabIndex = 3;
            this.pnlProfile.Click += new System.EventHandler(this.Profile_Click);
            this.pnlProfile.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlProfile_Paint);
            // 
            // btnTopLogout
            // 
            this.btnTopLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTopLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTopLogout.FlatAppearance.BorderSize = 0;
            this.btnTopLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTopLogout.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTopLogout.Location = new System.Drawing.Point(1000, 18);
            this.btnTopLogout.Name = "btnTopLogout";
            this.btnTopLogout.Size = new System.Drawing.Size(85, 34);
            this.btnTopLogout.TabIndex = 4;
            this.btnTopLogout.Tag = "\uE7E8";
            this.btnTopLogout.Text = "Đăng xuất";
            this.btnTopLogout.UseVisualStyleBackColor = true;
            this.btnTopLogout.Click += new System.EventHandler(this.Logout_Click);
            this.btnTopLogout.Paint += new System.Windows.Forms.PaintEventHandler(this.btnTopLogout_Paint);
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(245, 247, 251);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(244, 70);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1116, 790);
            this.pnlContent.TabIndex = 2;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(245, 247, 251);
            this.ClientSize = new System.Drawing.Size(1360, 860);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlTopbar);
            this.Controls.Add(this.pnlSidebar);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(1180, 720);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EduCenter — Northstar English Center";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormMain_KeyDown);
            this.pnlSidebar.ResumeLayout(false);
            this.pnlSidebar.PerformLayout();
            this.pnlUser.ResumeLayout(false);
            this.pnlUpgrade.ResumeLayout(false);
            this.pnlUpgrade.PerformLayout();
            this.pnlTopbar.ResumeLayout(false);
            this.pnlDate.ResumeLayout(false);
            this.pnlDate.PerformLayout();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlBrandMark;
        private System.Windows.Forms.Label lblBrandName;
        private System.Windows.Forms.Label lblBrandSub;
        private System.Windows.Forms.Label lblNavManage;
        private System.Windows.Forms.Button btnNavDashboard;
        private System.Windows.Forms.Button btnNavStudents;
        private System.Windows.Forms.Button btnNavCourses;
        private System.Windows.Forms.Button btnNavClasses;
        private System.Windows.Forms.Button btnNavTeachers;
        private System.Windows.Forms.Button btnNavSchedule;
        private System.Windows.Forms.Button btnNavFinance;
        private System.Windows.Forms.Button btnNavAttendance;
        private System.Windows.Forms.Label lblNavSystem;
        private System.Windows.Forms.Button btnNavSettings;
        private System.Windows.Forms.Panel pnlActiveIndicator;
        private System.Windows.Forms.Panel pnlUpgrade;
        private System.Windows.Forms.Label lblUpgradeIcon;
        private System.Windows.Forms.Label lblUpgradeTitle;
        private System.Windows.Forms.Label lblUpgradeText;
        private System.Windows.Forms.Label lblUpgradeLink;
        private System.Windows.Forms.Panel pnlUser;
        private System.Windows.Forms.Panel pnlUserAvatar;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblUserRole;
        private System.Windows.Forms.Button btnSideLogout;
        private System.Windows.Forms.Panel pnlTopbar;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Label lblSearchIcon;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblKbd;
        private System.Windows.Forms.Button btnNotify;
        private System.Windows.Forms.Panel pnlDate;
        private System.Windows.Forms.Label lblTodayCaption;
        private System.Windows.Forms.Label lblToday;
        private System.Windows.Forms.Panel pnlProfile;
        private System.Windows.Forms.Button btnTopLogout;
        private System.Windows.Forms.Panel pnlContent;
    }
}
