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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlSidebar = new System.Windows.Forms.Panel();
            pnlUser = new System.Windows.Forms.Panel();
            btnSideLogout = new System.Windows.Forms.Button();
            lblUserRole = new System.Windows.Forms.Label();
            lblUserName = new System.Windows.Forms.Label();
            pnlUserAvatar = new System.Windows.Forms.Panel();
            pnlUpgrade = new System.Windows.Forms.Panel();
            lblUpgradeLink = new System.Windows.Forms.Label();
            lblUpgradeText = new System.Windows.Forms.Label();
            lblUpgradeTitle = new System.Windows.Forms.Label();
            lblUpgradeIcon = new System.Windows.Forms.Label();
            pnlActiveIndicator = new System.Windows.Forms.Panel();
            btnNavSettings = new System.Windows.Forms.Button();
            lblNavSystem = new System.Windows.Forms.Label();
            btnNavAttendance = new System.Windows.Forms.Button();
            btnNavFinance = new System.Windows.Forms.Button();
            btnNavSchedule = new System.Windows.Forms.Button();
            btnNavTeachers = new System.Windows.Forms.Button();
            btnNavClasses = new System.Windows.Forms.Button();
            btnNavCourses = new System.Windows.Forms.Button();
            btnNavStudents = new System.Windows.Forms.Button();
            btnNavDashboard = new System.Windows.Forms.Button();
            lblNavManage = new System.Windows.Forms.Label();
            lblBrandSub = new System.Windows.Forms.Label();
            lblBrandName = new System.Windows.Forms.Label();
            pnlBrandMark = new System.Windows.Forms.Panel();
            pnlTopbar = new System.Windows.Forms.Panel();
            btnTopLogout = new System.Windows.Forms.Button();
            pnlProfile = new System.Windows.Forms.Panel();
            pnlDate = new System.Windows.Forms.Panel();
            lblToday = new System.Windows.Forms.Label();
            lblTodayCaption = new System.Windows.Forms.Label();
            btnNotify = new System.Windows.Forms.Button();
            pnlSearch = new System.Windows.Forms.Panel();
            lblKbd = new System.Windows.Forms.Label();
            txtSearch = new System.Windows.Forms.TextBox();
            lblSearchIcon = new System.Windows.Forms.Label();
            pnlContent = new System.Windows.Forms.Panel();
            pnlSidebar.SuspendLayout();
            pnlUser.SuspendLayout();
            pnlUpgrade.SuspendLayout();
            pnlTopbar.SuspendLayout();
            pnlDate.SuspendLayout();
            pnlSearch.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)((byte)19)), ((int)((byte)43)), ((int)((byte)72)));
            pnlSidebar.Controls.Add(pnlUser);
            pnlSidebar.Controls.Add(pnlUpgrade);
            pnlSidebar.Controls.Add(pnlActiveIndicator);
            pnlSidebar.Controls.Add(btnNavSettings);
            pnlSidebar.Controls.Add(lblNavSystem);
            pnlSidebar.Controls.Add(btnNavAttendance);
            pnlSidebar.Controls.Add(btnNavFinance);
            pnlSidebar.Controls.Add(btnNavSchedule);
            pnlSidebar.Controls.Add(btnNavTeachers);
            pnlSidebar.Controls.Add(btnNavClasses);
            pnlSidebar.Controls.Add(btnNavCourses);
            pnlSidebar.Controls.Add(btnNavStudents);
            pnlSidebar.Controls.Add(btnNavDashboard);
            pnlSidebar.Controls.Add(lblNavManage);
            pnlSidebar.Controls.Add(lblBrandSub);
            pnlSidebar.Controls.Add(lblBrandName);
            pnlSidebar.Controls.Add(pnlBrandMark);
            pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            pnlSidebar.Location = new System.Drawing.Point(0, 0);
            pnlSidebar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new System.Drawing.Size(279, 1055);
            pnlSidebar.TabIndex = 0;
            pnlSidebar.Resize += pnlSidebar_Resize;
            // 
            // pnlUser
            // 
            pnlUser.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left));
            pnlUser.BackColor = System.Drawing.Color.FromArgb(((int)((byte)19)), ((int)((byte)43)), ((int)((byte)72)));
            pnlUser.Controls.Add(btnSideLogout);
            pnlUser.Controls.Add(lblUserRole);
            pnlUser.Controls.Add(lblUserName);
            pnlUser.Controls.Add(pnlUserAvatar);
            pnlUser.Location = new System.Drawing.Point(18, 967);
            pnlUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pnlUser.Name = "pnlUser";
            pnlUser.Size = new System.Drawing.Size(242, 69);
            pnlUser.TabIndex = 16;
            pnlUser.Paint += pnlUser_Paint;
            // 
            // btnSideLogout
            // 
            btnSideLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            btnSideLogout.FlatAppearance.BorderSize = 0;
            btnSideLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSideLogout.Font = new System.Drawing.Font("Segoe UI", 9F);
            btnSideLogout.Location = new System.Drawing.Point(201, 17);
            btnSideLogout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnSideLogout.Name = "btnSideLogout";
            btnSideLogout.Size = new System.Drawing.Size(37, 43);
            btnSideLogout.TabIndex = 3;
            btnSideLogout.Tag = "";
            btnSideLogout.UseVisualStyleBackColor = true;
            btnSideLogout.Click += Logout_Click;
            btnSideLogout.Paint += btnSideLogout_Paint;
            // 
            // lblUserRole
            // 
            lblUserRole.Font = new System.Drawing.Font("Segoe UI", 7.25F);
            lblUserRole.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)128)), ((int)((byte)149)), ((int)((byte)172)));
            lblUserRole.Location = new System.Drawing.Point(50, 40);
            lblUserRole.Name = "lblUserRole";
            lblUserRole.Size = new System.Drawing.Size(139, 20);
            lblUserRole.TabIndex = 2;
            lblUserRole.Text = "Quản trị viên";
            // 
            // lblUserName
            // 
            lblUserName.AutoEllipsis = true;
            lblUserName.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            lblUserName.ForeColor = System.Drawing.Color.White;
            lblUserName.Location = new System.Drawing.Point(50, 16);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new System.Drawing.Size(139, 23);
            lblUserName.TabIndex = 1;
            lblUserName.Text = "Thu Hà";
            // 
            // pnlUserAvatar
            // 
            pnlUserAvatar.Cursor = System.Windows.Forms.Cursors.Hand;
            pnlUserAvatar.Location = new System.Drawing.Point(2, 16);
            pnlUserAvatar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pnlUserAvatar.Name = "pnlUserAvatar";
            pnlUserAvatar.Size = new System.Drawing.Size(39, 45);
            pnlUserAvatar.TabIndex = 0;
            pnlUserAvatar.Click += Profile_Click;
            pnlUserAvatar.Paint += pnlUserAvatar_Paint;
            // 
            // pnlUpgrade
            // 
            pnlUpgrade.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left));
            pnlUpgrade.BackColor = System.Drawing.Color.FromArgb(((int)((byte)33)), ((int)((byte)56)), ((int)((byte)83)));
            pnlUpgrade.Controls.Add(lblUpgradeLink);
            pnlUpgrade.Controls.Add(lblUpgradeText);
            pnlUpgrade.Controls.Add(lblUpgradeTitle);
            pnlUpgrade.Controls.Add(lblUpgradeIcon);
            pnlUpgrade.Location = new System.Drawing.Point(18, 775);
            pnlUpgrade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pnlUpgrade.Name = "pnlUpgrade";
            pnlUpgrade.Size = new System.Drawing.Size(242, 176);
            pnlUpgrade.TabIndex = 15;
            pnlUpgrade.Paint += pnlUpgrade_Paint;
            // 
            // lblUpgradeLink
            // 
            lblUpgradeLink.AutoSize = true;
            lblUpgradeLink.BackColor = System.Drawing.Color.FromArgb(((int)((byte)33)), ((int)((byte)56)), ((int)((byte)83)));
            lblUpgradeLink.Cursor = System.Windows.Forms.Cursors.Hand;
            lblUpgradeLink.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            lblUpgradeLink.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)118)), ((int)((byte)187)), ((int)((byte)255)));
            lblUpgradeLink.Location = new System.Drawing.Point(15, 141);
            lblUpgradeLink.Name = "lblUpgradeLink";
            lblUpgradeLink.Size = new System.Drawing.Size(124, 19);
            lblUpgradeLink.TabIndex = 3;
            lblUpgradeLink.Text = "Tìm hiểu thêm  →";
            lblUpgradeLink.Click += lblUpgradeLink_Click;
            // 
            // lblUpgradeText
            // 
            lblUpgradeText.BackColor = System.Drawing.Color.FromArgb(((int)((byte)33)), ((int)((byte)56)), ((int)((byte)83)));
            lblUpgradeText.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            lblUpgradeText.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)159)), ((int)((byte)176)), ((int)((byte)196)));
            lblUpgradeText.Location = new System.Drawing.Point(15, 96);
            lblUpgradeText.Name = "lblUpgradeText";
            lblUpgradeText.Size = new System.Drawing.Size(213, 40);
            lblUpgradeText.TabIndex = 2;
            lblUpgradeText.Text = "Mở khóa báo cáo nâng cao và nhiều tính năng hơn.";
            // 
            // lblUpgradeTitle
            // 
            lblUpgradeTitle.AutoSize = true;
            lblUpgradeTitle.BackColor = System.Drawing.Color.FromArgb(((int)((byte)33)), ((int)((byte)56)), ((int)((byte)83)));
            lblUpgradeTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            lblUpgradeTitle.ForeColor = System.Drawing.Color.White;
            lblUpgradeTitle.Location = new System.Drawing.Point(15, 69);
            lblUpgradeTitle.Name = "lblUpgradeTitle";
            lblUpgradeTitle.Size = new System.Drawing.Size(184, 20);
            lblUpgradeTitle.TabIndex = 1;
            lblUpgradeTitle.Text = "Khám phá EduCenter Pro";
            // 
            // lblUpgradeIcon
            // 
            lblUpgradeIcon.BackColor = System.Drawing.Color.FromArgb(((int)((byte)33)), ((int)((byte)56)), ((int)((byte)83)));
            lblUpgradeIcon.Font = new System.Drawing.Font("Segoe MDL2 Assets", 11F);
            lblUpgradeIcon.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)118)), ((int)((byte)187)), ((int)((byte)255)));
            lblUpgradeIcon.Location = new System.Drawing.Point(16, 19);
            lblUpgradeIcon.Name = "lblUpgradeIcon";
            lblUpgradeIcon.Size = new System.Drawing.Size(34, 40);
            lblUpgradeIcon.TabIndex = 0;
            lblUpgradeIcon.Text = "";
            lblUpgradeIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lblUpgradeIcon.Paint += lblUpgradeIcon_Paint;
            // 
            // pnlActiveIndicator
            // 
            pnlActiveIndicator.BackColor = System.Drawing.Color.FromArgb(((int)((byte)98)), ((int)((byte)178)), ((int)((byte)255)));
            pnlActiveIndicator.Location = new System.Drawing.Point(275, 167);
            pnlActiveIndicator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pnlActiveIndicator.Name = "pnlActiveIndicator";
            pnlActiveIndicator.Size = new System.Drawing.Size(3, 28);
            pnlActiveIndicator.TabIndex = 14;
            // 
            // btnNavSettings
            // 
            btnNavSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            btnNavSettings.FlatAppearance.BorderSize = 0;
            btnNavSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnNavSettings.Font = new System.Drawing.Font("Segoe UI", 9F);
            btnNavSettings.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)169)), ((int)((byte)183)), ((int)((byte)200)));
            btnNavSettings.Location = new System.Drawing.Point(18, 680);
            btnNavSettings.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnNavSettings.Name = "btnNavSettings";
            btnNavSettings.Size = new System.Drawing.Size(242, 57);
            btnNavSettings.TabIndex = 13;
            btnNavSettings.Tag = "";
            btnNavSettings.Text = "Cài đặt";
            btnNavSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnNavSettings.UseVisualStyleBackColor = false;
            btnNavSettings.Click += Nav_Click;
            btnNavSettings.Paint += Nav_Paint;
            // 
            // lblNavSystem
            // 
            lblNavSystem.AutoSize = true;
            lblNavSystem.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            lblNavSystem.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)101)), ((int)((byte)125)), ((int)((byte)152)));
            lblNavSystem.Location = new System.Drawing.Point(32, 653);
            lblNavSystem.Name = "lblNavSystem";
            lblNavSystem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblNavSystem.Size = new System.Drawing.Size(68, 15);
            lblNavSystem.TabIndex = 12;
            lblNavSystem.Text = "HỆ THỐNG";
            // 
            // btnNavAttendance
            // 
            btnNavAttendance.Cursor = System.Windows.Forms.Cursors.Hand;
            btnNavAttendance.FlatAppearance.BorderSize = 0;
            btnNavAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnNavAttendance.Font = new System.Drawing.Font("Segoe UI", 9F);
            btnNavAttendance.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)169)), ((int)((byte)183)), ((int)((byte)200)));
            btnNavAttendance.Location = new System.Drawing.Point(18, 572);
            btnNavAttendance.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnNavAttendance.Name = "btnNavAttendance";
            btnNavAttendance.Size = new System.Drawing.Size(242, 57);
            btnNavAttendance.TabIndex = 11;
            btnNavAttendance.Tag = "";
            btnNavAttendance.Text = "Điểm danh & Kết quả";
            btnNavAttendance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnNavAttendance.UseMnemonic = false;
            btnNavAttendance.UseVisualStyleBackColor = false;
            btnNavAttendance.Click += Nav_Click;
            btnNavAttendance.Paint += Nav_Paint;
            // 
            // btnNavFinance
            // 
            btnNavFinance.Cursor = System.Windows.Forms.Cursors.Hand;
            btnNavFinance.FlatAppearance.BorderSize = 0;
            btnNavFinance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnNavFinance.Font = new System.Drawing.Font("Segoe UI", 9F);
            btnNavFinance.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)169)), ((int)((byte)183)), ((int)((byte)200)));
            btnNavFinance.Location = new System.Drawing.Point(18, 512);
            btnNavFinance.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnNavFinance.Name = "btnNavFinance";
            btnNavFinance.Size = new System.Drawing.Size(242, 57);
            btnNavFinance.TabIndex = 10;
            btnNavFinance.Tag = "";
            btnNavFinance.Text = "Tài chính";
            btnNavFinance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnNavFinance.UseVisualStyleBackColor = false;
            btnNavFinance.Click += Nav_Click;
            btnNavFinance.Paint += Nav_Paint;
            // 
            // btnNavSchedule
            // 
            btnNavSchedule.Cursor = System.Windows.Forms.Cursors.Hand;
            btnNavSchedule.FlatAppearance.BorderSize = 0;
            btnNavSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnNavSchedule.Font = new System.Drawing.Font("Segoe UI", 9F);
            btnNavSchedule.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)169)), ((int)((byte)183)), ((int)((byte)200)));
            btnNavSchedule.Location = new System.Drawing.Point(18, 452);
            btnNavSchedule.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnNavSchedule.Name = "btnNavSchedule";
            btnNavSchedule.Size = new System.Drawing.Size(242, 57);
            btnNavSchedule.TabIndex = 9;
            btnNavSchedule.Tag = "";
            btnNavSchedule.Text = "Lịch học";
            btnNavSchedule.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnNavSchedule.UseVisualStyleBackColor = false;
            btnNavSchedule.Click += Nav_Click;
            btnNavSchedule.Paint += Nav_Paint;
            // 
            // btnNavTeachers
            // 
            btnNavTeachers.Cursor = System.Windows.Forms.Cursors.Hand;
            btnNavTeachers.FlatAppearance.BorderSize = 0;
            btnNavTeachers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnNavTeachers.Font = new System.Drawing.Font("Segoe UI", 9F);
            btnNavTeachers.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)169)), ((int)((byte)183)), ((int)((byte)200)));
            btnNavTeachers.Location = new System.Drawing.Point(18, 392);
            btnNavTeachers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnNavTeachers.Name = "btnNavTeachers";
            btnNavTeachers.Size = new System.Drawing.Size(242, 57);
            btnNavTeachers.TabIndex = 8;
            btnNavTeachers.Tag = "";
            btnNavTeachers.Text = "Giảng viên";
            btnNavTeachers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnNavTeachers.UseVisualStyleBackColor = false;
            btnNavTeachers.Click += Nav_Click;
            btnNavTeachers.Paint += Nav_Paint;
            // 
            // btnNavClasses
            // 
            btnNavClasses.Cursor = System.Windows.Forms.Cursors.Hand;
            btnNavClasses.FlatAppearance.BorderSize = 0;
            btnNavClasses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnNavClasses.Font = new System.Drawing.Font("Segoe UI", 9F);
            btnNavClasses.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)169)), ((int)((byte)183)), ((int)((byte)200)));
            btnNavClasses.Location = new System.Drawing.Point(18, 332);
            btnNavClasses.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnNavClasses.Name = "btnNavClasses";
            btnNavClasses.Size = new System.Drawing.Size(242, 57);
            btnNavClasses.TabIndex = 7;
            btnNavClasses.Tag = "";
            btnNavClasses.Text = "Lớp học";
            btnNavClasses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnNavClasses.UseVisualStyleBackColor = false;
            btnNavClasses.Click += Nav_Click;
            btnNavClasses.Paint += Nav_Paint;
            // 
            // btnNavCourses
            // 
            btnNavCourses.Cursor = System.Windows.Forms.Cursors.Hand;
            btnNavCourses.FlatAppearance.BorderSize = 0;
            btnNavCourses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnNavCourses.Font = new System.Drawing.Font("Segoe UI", 9F);
            btnNavCourses.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)169)), ((int)((byte)183)), ((int)((byte)200)));
            btnNavCourses.Location = new System.Drawing.Point(18, 272);
            btnNavCourses.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnNavCourses.Name = "btnNavCourses";
            btnNavCourses.Size = new System.Drawing.Size(242, 57);
            btnNavCourses.TabIndex = 6;
            btnNavCourses.Tag = "";
            btnNavCourses.Text = "Khóa học";
            btnNavCourses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnNavCourses.UseVisualStyleBackColor = false;
            btnNavCourses.Click += Nav_Click;
            btnNavCourses.Paint += Nav_Paint;
            // 
            // btnNavStudents
            // 
            btnNavStudents.Cursor = System.Windows.Forms.Cursors.Hand;
            btnNavStudents.FlatAppearance.BorderSize = 0;
            btnNavStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnNavStudents.Font = new System.Drawing.Font("Segoe UI", 9F);
            btnNavStudents.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)169)), ((int)((byte)183)), ((int)((byte)200)));
            btnNavStudents.Location = new System.Drawing.Point(18, 212);
            btnNavStudents.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnNavStudents.Name = "btnNavStudents";
            btnNavStudents.Size = new System.Drawing.Size(242, 57);
            btnNavStudents.TabIndex = 5;
            btnNavStudents.Tag = "";
            btnNavStudents.Text = "Học viên";
            btnNavStudents.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnNavStudents.UseVisualStyleBackColor = false;
            btnNavStudents.Click += Nav_Click;
            btnNavStudents.Paint += Nav_Paint;
            // 
            // btnNavDashboard
            // 
            btnNavDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            btnNavDashboard.FlatAppearance.BorderSize = 0;
            btnNavDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnNavDashboard.Font = new System.Drawing.Font("Segoe UI", 9F);
            btnNavDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)169)), ((int)((byte)183)), ((int)((byte)200)));
            btnNavDashboard.Location = new System.Drawing.Point(18, 152);
            btnNavDashboard.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnNavDashboard.Name = "btnNavDashboard";
            btnNavDashboard.Size = new System.Drawing.Size(242, 57);
            btnNavDashboard.TabIndex = 4;
            btnNavDashboard.Tag = "";
            btnNavDashboard.Text = "Tổng quan";
            btnNavDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnNavDashboard.UseVisualStyleBackColor = false;
            btnNavDashboard.Click += Nav_Click;
            btnNavDashboard.Paint += Nav_Paint;
            // 
            // lblNavManage
            // 
            lblNavManage.AutoSize = true;
            lblNavManage.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            lblNavManage.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)101)), ((int)((byte)125)), ((int)((byte)152)));
            lblNavManage.Location = new System.Drawing.Point(32, 125);
            lblNavManage.Name = "lblNavManage";
            lblNavManage.Size = new System.Drawing.Size(57, 15);
            lblNavManage.TabIndex = 3;
            lblNavManage.Text = "QUẢN LÝ";
            // 
            // lblBrandSub
            // 
            lblBrandSub.AutoSize = true;
            lblBrandSub.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Bold);
            lblBrandSub.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)143)), ((int)((byte)163)), ((int)((byte)186)));
            lblBrandSub.Location = new System.Drawing.Point(85, 63);
            lblBrandSub.Name = "lblBrandSub";
            lblBrandSub.Size = new System.Drawing.Size(144, 15);
            lblBrandSub.TabIndex = 2;
            lblBrandSub.Text = "ENGLISH MANAGEMENT";
            // 
            // lblBrandName
            // 
            lblBrandName.AutoSize = true;
            lblBrandName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            lblBrandName.ForeColor = System.Drawing.Color.White;
            lblBrandName.Location = new System.Drawing.Point(82, 31);
            lblBrandName.Name = "lblBrandName";
            lblBrandName.Size = new System.Drawing.Size(109, 28);
            lblBrandName.TabIndex = 1;
            lblBrandName.Text = "EduCenter";
            // 
            // pnlBrandMark
            // 
            pnlBrandMark.BackColor = System.Drawing.Color.FromArgb(((int)((byte)19)), ((int)((byte)43)), ((int)((byte)72)));
            pnlBrandMark.Location = new System.Drawing.Point(29, 33);
            pnlBrandMark.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pnlBrandMark.Name = "pnlBrandMark";
            pnlBrandMark.Size = new System.Drawing.Size(45, 52);
            pnlBrandMark.TabIndex = 0;
            pnlBrandMark.Paint += pnlBrandMark_Paint;
            // 
            // pnlTopbar
            // 
            pnlTopbar.BackColor = System.Drawing.Color.White;
            pnlTopbar.Controls.Add(btnTopLogout);
            pnlTopbar.Controls.Add(pnlProfile);
            pnlTopbar.Controls.Add(pnlDate);
            pnlTopbar.Controls.Add(btnNotify);
            pnlTopbar.Controls.Add(pnlSearch);
            pnlTopbar.Dock = System.Windows.Forms.DockStyle.Top;
            pnlTopbar.Location = new System.Drawing.Point(279, 0);
            pnlTopbar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pnlTopbar.Name = "pnlTopbar";
            pnlTopbar.Size = new System.Drawing.Size(1275, 93);
            pnlTopbar.TabIndex = 1;
            pnlTopbar.Paint += pnlTopbar_Paint;
            // 
            // btnTopLogout
            // 
            btnTopLogout.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            btnTopLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            btnTopLogout.FlatAppearance.BorderSize = 0;
            btnTopLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnTopLogout.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            btnTopLogout.Location = new System.Drawing.Point(1143, 24);
            btnTopLogout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnTopLogout.Name = "btnTopLogout";
            btnTopLogout.Size = new System.Drawing.Size(97, 45);
            btnTopLogout.TabIndex = 4;
            btnTopLogout.Tag = "";
            btnTopLogout.Text = "Đăng xuất";
            btnTopLogout.UseVisualStyleBackColor = true;
            btnTopLogout.Click += Logout_Click;
            btnTopLogout.Paint += btnTopLogout_Paint;
            // 
            // pnlProfile
            // 
            pnlProfile.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            pnlProfile.BackColor = System.Drawing.Color.White;
            pnlProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            pnlProfile.Location = new System.Drawing.Point(1064, 21);
            pnlProfile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pnlProfile.Name = "pnlProfile";
            pnlProfile.Size = new System.Drawing.Size(66, 51);
            pnlProfile.TabIndex = 3;
            pnlProfile.Click += Profile_Click;
            pnlProfile.Paint += pnlProfile_Paint;
            // 
            // pnlDate
            // 
            pnlDate.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            pnlDate.BackColor = System.Drawing.Color.White;
            pnlDate.Controls.Add(lblToday);
            pnlDate.Controls.Add(lblTodayCaption);
            pnlDate.Location = new System.Drawing.Point(858, 21);
            pnlDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pnlDate.Name = "pnlDate";
            pnlDate.Size = new System.Drawing.Size(194, 51);
            pnlDate.TabIndex = 2;
            pnlDate.Paint += pnlDate_Paint;
            // 
            // lblToday
            // 
            lblToday.AutoSize = true;
            lblToday.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            lblToday.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)58)), ((int)((byte)73)), ((int)((byte)96)));
            lblToday.Location = new System.Drawing.Point(17, 24);
            lblToday.Name = "lblToday";
            lblToday.Size = new System.Drawing.Size(158, 20);
            lblToday.TabIndex = 1;
            lblToday.Text = "Thứ Hai, 24/11/2025";
            // 
            // lblTodayCaption
            // 
            lblTodayCaption.AutoSize = true;
            lblTodayCaption.Font = new System.Drawing.Font("Segoe UI", 7.25F);
            lblTodayCaption.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)143)), ((int)((byte)155)), ((int)((byte)170)));
            lblTodayCaption.Location = new System.Drawing.Point(17, 3);
            lblTodayCaption.Name = "lblTodayCaption";
            lblTodayCaption.Size = new System.Drawing.Size(60, 17);
            lblTodayCaption.TabIndex = 0;
            lblTodayCaption.Text = "Hôm nay";
            // 
            // btnNotify
            // 
            btnNotify.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            btnNotify.Cursor = System.Windows.Forms.Cursors.Hand;
            btnNotify.FlatAppearance.BorderSize = 0;
            btnNotify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnNotify.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            btnNotify.Location = new System.Drawing.Point(797, 23);
            btnNotify.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnNotify.Name = "btnNotify";
            btnNotify.Size = new System.Drawing.Size(43, 51);
            btnNotify.TabIndex = 1;
            btnNotify.Tag = "";
            btnNotify.UseVisualStyleBackColor = true;
            btnNotify.Click += btnNotify_Click;
            btnNotify.Paint += btnNotify_Paint;
            // 
            // pnlSearch
            // 
            pnlSearch.BackColor = System.Drawing.Color.FromArgb(((int)((byte)247)), ((int)((byte)248)), ((int)((byte)250)));
            pnlSearch.Controls.Add(lblKbd);
            pnlSearch.Controls.Add(txtSearch);
            pnlSearch.Controls.Add(lblSearchIcon);
            pnlSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            pnlSearch.Location = new System.Drawing.Point(82, 21);
            pnlSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pnlSearch.Name = "pnlSearch";
            pnlSearch.Size = new System.Drawing.Size(450, 49);
            pnlSearch.TabIndex = 0;
            pnlSearch.Click += pnlSearch_Click;
            pnlSearch.Paint += pnlSearch_Paint;
            // 
            // lblKbd
            // 
            lblKbd.BackColor = System.Drawing.Color.FromArgb(((int)((byte)247)), ((int)((byte)248)), ((int)((byte)250)));
            lblKbd.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            lblKbd.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)143)), ((int)((byte)155)), ((int)((byte)170)));
            lblKbd.Location = new System.Drawing.Point(384, 11);
            lblKbd.Name = "lblKbd";
            lblKbd.Size = new System.Drawing.Size(55, 28);
            lblKbd.TabIndex = 2;
            lblKbd.Text = "Ctrl K";
            lblKbd.Paint += lblKbd_Paint;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)((byte)247)), ((int)((byte)248)), ((int)((byte)250)));
            txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)36)), ((int)((byte)50)), ((int)((byte)73)));
            txtSearch.Location = new System.Drawing.Point(43, 13);
            txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Tìm học viên, khóa học, lớp học...";
            txtSearch.Size = new System.Drawing.Size(331, 20);
            txtSearch.TabIndex = 1;
            txtSearch.KeyDown += txtSearch_KeyDown;
            // 
            // lblSearchIcon
            // 
            lblSearchIcon.BackColor = System.Drawing.Color.FromArgb(((int)((byte)247)), ((int)((byte)248)), ((int)((byte)250)));
            lblSearchIcon.Font = new System.Drawing.Font("Segoe MDL2 Assets", 9.75F);
            lblSearchIcon.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)143)), ((int)((byte)155)), ((int)((byte)170)));
            lblSearchIcon.Location = new System.Drawing.Point(11, 11);
            lblSearchIcon.Name = "lblSearchIcon";
            lblSearchIcon.Size = new System.Drawing.Size(25, 28);
            lblSearchIcon.TabIndex = 0;
            lblSearchIcon.Text = "";
            lblSearchIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lblSearchIcon.Click += pnlSearch_Click;
            // 
            // pnlContent
            // 
            pnlContent.BackColor = System.Drawing.Color.FromArgb(((int)((byte)245)), ((int)((byte)247)), ((int)((byte)251)));
            pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlContent.Location = new System.Drawing.Point(279, 93);
            pnlContent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new System.Drawing.Size(1275, 962);
            pnlContent.TabIndex = 2;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(((int)((byte)245)), ((int)((byte)247)), ((int)((byte)251)));
            ClientSize = new System.Drawing.Size(1554, 1055);
            Controls.Add(pnlContent);
            Controls.Add(pnlTopbar);
            Controls.Add(pnlSidebar);
            Font = new System.Drawing.Font("Segoe UI", 9F);
            KeyPreview = true;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            MinimumSize = new System.Drawing.Size(1346, 944);
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "EduCenter — Northstar English Center";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            Load += FormMain_Load;
            KeyDown += FormMain_KeyDown;
            pnlSidebar.ResumeLayout(false);
            pnlSidebar.PerformLayout();
            pnlUser.ResumeLayout(false);
            pnlUpgrade.ResumeLayout(false);
            pnlUpgrade.PerformLayout();
            pnlTopbar.ResumeLayout(false);
            pnlDate.ResumeLayout(false);
            pnlDate.PerformLayout();
            pnlSearch.ResumeLayout(false);
            pnlSearch.PerformLayout();
            ResumeLayout(false);
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
