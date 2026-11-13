namespace EnglishCenterManagement.Forms
{
    partial class FormLogin
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
            this.btnBack = new System.Windows.Forms.Button();
            this.pnlCard = new System.Windows.Forms.Panel();
            this.flpForm = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlGroupName = new System.Windows.Forms.Panel();
            this.pnlNameInput = new System.Windows.Forms.Panel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblNameIcon = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.pnlGroupEmail = new System.Windows.Forms.Panel();
            this.pnlEmailInput = new System.Windows.Forms.Panel();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmailIcon = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.pnlGroupPassword = new System.Windows.Forms.Panel();
            this.pnlPasswordInput = new System.Windows.Forms.Panel();
            this.lblShowPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPasswordIcon = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.pnlGroupConfirm = new System.Windows.Forms.Panel();
            this.pnlConfirmInput = new System.Windows.Forms.Panel();
            this.txtConfirm = new System.Windows.Forms.TextBox();
            this.lblConfirmIcon = new System.Windows.Forms.Label();
            this.lblConfirm = new System.Windows.Forms.Label();
            this.pnlOptions = new System.Windows.Forms.Panel();
            this.lblForgot = new System.Windows.Forms.Label();
            this.chkRemember = new System.Windows.Forms.CheckBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblDemo = new System.Windows.Forms.Label();
            this.pnlTabs = new System.Windows.Forms.Panel();
            this.btnTabRegister = new System.Windows.Forms.Button();
            this.btnTabLogin = new System.Windows.Forms.Button();
            this.lblIntro = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblRoleIcon = new System.Windows.Forms.Label();
            this.lblBrandSub = new System.Windows.Forms.Label();
            this.lblBrandName = new System.Windows.Forms.Label();
            this.pnlBrandMark = new System.Windows.Forms.Panel();
            this.pnlCard.SuspendLayout();
            this.flpForm.SuspendLayout();
            this.pnlGroupName.SuspendLayout();
            this.pnlNameInput.SuspendLayout();
            this.pnlGroupEmail.SuspendLayout();
            this.pnlEmailInput.SuspendLayout();
            this.pnlGroupPassword.SuspendLayout();
            this.pnlPasswordInput.SuspendLayout();
            this.pnlGroupConfirm.SuspendLayout();
            this.pnlConfirmInput.SuspendLayout();
            this.pnlOptions.SuspendLayout();
            this.pnlTabs.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(82, 97, 118);
            this.btnBack.Location = new System.Drawing.Point(32, 28);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(190, 36);
            this.btnBack.TabIndex = 1;
            this.btnBack.Tag = "\uE76B";
            this.btnBack.Text = "Quay lại chọn vai trò";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            this.btnBack.Paint += new System.Windows.Forms.PaintEventHandler(this.btnBack_Paint);
            // 
            // pnlCard
            // 
            this.pnlCard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlCard.BackColor = System.Drawing.Color.White;
            this.pnlCard.Controls.Add(this.flpForm);
            this.pnlCard.Controls.Add(this.pnlTabs);
            this.pnlCard.Controls.Add(this.lblIntro);
            this.pnlCard.Controls.Add(this.lblTitle);
            this.pnlCard.Controls.Add(this.lblRoleIcon);
            this.pnlCard.Controls.Add(this.lblBrandSub);
            this.pnlCard.Controls.Add(this.lblBrandName);
            this.pnlCard.Controls.Add(this.pnlBrandMark);
            this.pnlCard.Location = new System.Drawing.Point(465, 96);
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.Size = new System.Drawing.Size(430, 668);
            this.pnlCard.TabIndex = 0;
            this.pnlCard.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCard_Paint);
            // 
            // pnlBrandMark
            // 
            this.pnlBrandMark.BackColor = System.Drawing.Color.White;
            this.pnlBrandMark.Location = new System.Drawing.Point(36, 34);
            this.pnlBrandMark.Name = "pnlBrandMark";
            this.pnlBrandMark.Size = new System.Drawing.Size(34, 34);
            this.pnlBrandMark.TabIndex = 0;
            this.pnlBrandMark.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBrandMark_Paint);
            // 
            // lblBrandName
            // 
            this.lblBrandName.AutoSize = true;
            this.lblBrandName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBrandName.ForeColor = System.Drawing.Color.FromArgb(23, 36, 61);
            this.lblBrandName.Location = new System.Drawing.Point(77, 33);
            this.lblBrandName.Name = "lblBrandName";
            this.lblBrandName.Size = new System.Drawing.Size(84, 20);
            this.lblBrandName.TabIndex = 1;
            this.lblBrandName.Text = "EduCenter";
            // 
            // lblBrandSub
            // 
            this.lblBrandSub.AutoSize = true;
            this.lblBrandSub.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBrandSub.ForeColor = System.Drawing.Color.FromArgb(143, 155, 172);
            this.lblBrandSub.Location = new System.Drawing.Point(79, 55);
            this.lblBrandSub.Name = "lblBrandSub";
            this.lblBrandSub.Size = new System.Drawing.Size(111, 12);
            this.lblBrandSub.TabIndex = 2;
            this.lblBrandSub.Text = "ENGLISH MANAGEMENT";
            // 
            // lblRoleIcon
            // 
            this.lblRoleIcon.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRoleIcon.ForeColor = System.Drawing.Color.FromArgb(38, 124, 199);
            this.lblRoleIcon.Location = new System.Drawing.Point(36, 94);
            this.lblRoleIcon.Name = "lblRoleIcon";
            this.lblRoleIcon.Size = new System.Drawing.Size(44, 44);
            this.lblRoleIcon.TabIndex = 3;
            this.lblRoleIcon.Tag = "#e8f4ff";
            this.lblRoleIcon.Text = "\uE7EF";
            this.lblRoleIcon.Paint += new System.Windows.Forms.PaintEventHandler(this.lblRoleIcon_Paint);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(23, 36, 61);
            this.lblTitle.Location = new System.Drawing.Point(32, 148);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(244, 28);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Đăng nhập Quản trị viên";
            // 
            // lblIntro
            // 
            this.lblIntro.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIntro.ForeColor = System.Drawing.Color.FromArgb(135, 147, 163);
            this.lblIntro.Location = new System.Drawing.Point(36, 182);
            this.lblIntro.Name = "lblIntro";
            this.lblIntro.Size = new System.Drawing.Size(358, 36);
            this.lblIntro.TabIndex = 5;
            this.lblIntro.Text = "Quản lý toàn bộ hoạt động đào tạo, học viên và tài chính của trung tâm.";
            // 
            // pnlTabs
            // 
            this.pnlTabs.BackColor = System.Drawing.Color.FromArgb(240, 243, 246);
            this.pnlTabs.Controls.Add(this.btnTabRegister);
            this.pnlTabs.Controls.Add(this.btnTabLogin);
            this.pnlTabs.Location = new System.Drawing.Point(36, 226);
            this.pnlTabs.Name = "pnlTabs";
            this.pnlTabs.Size = new System.Drawing.Size(358, 40);
            this.pnlTabs.TabIndex = 6;
            this.pnlTabs.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTabs_Paint);
            // 
            // btnTabLogin
            // 
            this.btnTabLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTabLogin.FlatAppearance.BorderSize = 0;
            this.btnTabLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTabLogin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTabLogin.Location = new System.Drawing.Point(4, 4);
            this.btnTabLogin.Name = "btnTabLogin";
            this.btnTabLogin.Size = new System.Drawing.Size(174, 32);
            this.btnTabLogin.TabIndex = 0;
            this.btnTabLogin.TabStop = false;
            this.btnTabLogin.Text = "Đăng nhập";
            this.btnTabLogin.UseVisualStyleBackColor = false;
            this.btnTabLogin.Click += new System.EventHandler(this.btnTabLogin_Click);
            this.btnTabLogin.Paint += new System.Windows.Forms.PaintEventHandler(this.Tab_Paint);
            // 
            // btnTabRegister
            // 
            this.btnTabRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTabRegister.FlatAppearance.BorderSize = 0;
            this.btnTabRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTabRegister.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTabRegister.Location = new System.Drawing.Point(180, 4);
            this.btnTabRegister.Name = "btnTabRegister";
            this.btnTabRegister.Size = new System.Drawing.Size(174, 32);
            this.btnTabRegister.TabIndex = 1;
            this.btnTabRegister.TabStop = false;
            this.btnTabRegister.Text = "Đăng ký";
            this.btnTabRegister.UseVisualStyleBackColor = false;
            this.btnTabRegister.Click += new System.EventHandler(this.btnTabRegister_Click);
            this.btnTabRegister.Paint += new System.Windows.Forms.PaintEventHandler(this.Tab_Paint);
            // 
            // flpForm
            // 
            this.flpForm.Controls.Add(this.pnlGroupName);
            this.flpForm.Controls.Add(this.pnlGroupEmail);
            this.flpForm.Controls.Add(this.pnlGroupPassword);
            this.flpForm.Controls.Add(this.pnlGroupConfirm);
            this.flpForm.Controls.Add(this.pnlOptions);
            this.flpForm.Controls.Add(this.btnSubmit);
            this.flpForm.Controls.Add(this.lblDemo);
            this.flpForm.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpForm.Location = new System.Drawing.Point(36, 282);
            this.flpForm.Name = "flpForm";
            this.flpForm.Size = new System.Drawing.Size(360, 374);
            this.flpForm.TabIndex = 7;
            this.flpForm.WrapContents = false;
            // 
            // pnlGroupName
            // 
            this.pnlGroupName.Controls.Add(this.pnlNameInput);
            this.pnlGroupName.Controls.Add(this.lblName);
            this.pnlGroupName.Location = new System.Drawing.Point(0, 0);
            this.pnlGroupName.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.pnlGroupName.Name = "pnlGroupName";
            this.pnlGroupName.Size = new System.Drawing.Size(358, 62);
            this.pnlGroupName.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(82, 97, 118);
            this.lblName.Location = new System.Drawing.Point(0, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(58, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Họ và tên";
            // 
            // pnlNameInput
            // 
            this.pnlNameInput.BackColor = System.Drawing.Color.FromArgb(250, 251, 252);
            this.pnlNameInput.Controls.Add(this.txtName);
            this.pnlNameInput.Controls.Add(this.lblNameIcon);
            this.pnlNameInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pnlNameInput.Location = new System.Drawing.Point(0, 20);
            this.pnlNameInput.Name = "pnlNameInput";
            this.pnlNameInput.Size = new System.Drawing.Size(358, 40);
            this.pnlNameInput.TabIndex = 1;
            this.pnlNameInput.Click += new System.EventHandler(this.Input_Click);
            this.pnlNameInput.Paint += new System.Windows.Forms.PaintEventHandler(this.Input_Paint);
            // 
            // lblNameIcon
            // 
            this.lblNameIcon.Font = new System.Drawing.Font("Segoe MDL2 Assets", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNameIcon.ForeColor = System.Drawing.Color.FromArgb(152, 162, 176);
            this.lblNameIcon.Location = new System.Drawing.Point(10, 2);
            this.lblNameIcon.Name = "lblNameIcon";
            this.lblNameIcon.Size = new System.Drawing.Size(24, 36);
            this.lblNameIcon.TabIndex = 0;
            this.lblNameIcon.Text = "\uE77B";
            this.lblNameIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(250, 251, 252);
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(31, 45, 68);
            this.txtName.Location = new System.Drawing.Point(40, 11);
            this.txtName.Name = "txtName";
            this.txtName.PlaceholderText = "Nguyễn Văn An";
            this.txtName.Size = new System.Drawing.Size(306, 18);
            this.txtName.TabIndex = 1;
            // 
            // pnlGroupEmail
            // 
            this.pnlGroupEmail.Controls.Add(this.pnlEmailInput);
            this.pnlGroupEmail.Controls.Add(this.lblEmail);
            this.pnlGroupEmail.Location = new System.Drawing.Point(0, 70);
            this.pnlGroupEmail.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.pnlGroupEmail.Name = "pnlGroupEmail";
            this.pnlGroupEmail.Size = new System.Drawing.Size(358, 62);
            this.pnlGroupEmail.TabIndex = 1;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(82, 97, 118);
            this.lblEmail.Location = new System.Drawing.Point(0, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(34, 13);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email";
            // 
            // pnlEmailInput
            // 
            this.pnlEmailInput.BackColor = System.Drawing.Color.FromArgb(250, 251, 252);
            this.pnlEmailInput.Controls.Add(this.txtEmail);
            this.pnlEmailInput.Controls.Add(this.lblEmailIcon);
            this.pnlEmailInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pnlEmailInput.Location = new System.Drawing.Point(0, 20);
            this.pnlEmailInput.Name = "pnlEmailInput";
            this.pnlEmailInput.Size = new System.Drawing.Size(358, 40);
            this.pnlEmailInput.TabIndex = 1;
            this.pnlEmailInput.Click += new System.EventHandler(this.Input_Click);
            this.pnlEmailInput.Paint += new System.Windows.Forms.PaintEventHandler(this.Input_Paint);
            // 
            // lblEmailIcon
            // 
            this.lblEmailIcon.Font = new System.Drawing.Font("Segoe MDL2 Assets", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmailIcon.ForeColor = System.Drawing.Color.FromArgb(152, 162, 176);
            this.lblEmailIcon.Location = new System.Drawing.Point(10, 2);
            this.lblEmailIcon.Name = "lblEmailIcon";
            this.lblEmailIcon.Size = new System.Drawing.Size(24, 36);
            this.lblEmailIcon.TabIndex = 0;
            this.lblEmailIcon.Text = "\uE715";
            this.lblEmailIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(250, 251, 252);
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(31, 45, 68);
            this.txtEmail.Location = new System.Drawing.Point(40, 11);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PlaceholderText = "ten@northstar.vn";
            this.txtEmail.Size = new System.Drawing.Size(306, 18);
            this.txtEmail.TabIndex = 1;
            // 
            // pnlGroupPassword
            // 
            this.pnlGroupPassword.Controls.Add(this.pnlPasswordInput);
            this.pnlGroupPassword.Controls.Add(this.lblPassword);
            this.pnlGroupPassword.Location = new System.Drawing.Point(0, 140);
            this.pnlGroupPassword.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.pnlGroupPassword.Name = "pnlGroupPassword";
            this.pnlGroupPassword.Size = new System.Drawing.Size(358, 62);
            this.pnlGroupPassword.TabIndex = 2;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(82, 97, 118);
            this.lblPassword.Location = new System.Drawing.Point(0, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(55, 13);
            this.lblPassword.TabIndex = 0;
            this.lblPassword.Text = "Mật khẩu";
            // 
            // pnlPasswordInput
            // 
            this.pnlPasswordInput.BackColor = System.Drawing.Color.FromArgb(250, 251, 252);
            this.pnlPasswordInput.Controls.Add(this.lblShowPassword);
            this.pnlPasswordInput.Controls.Add(this.txtPassword);
            this.pnlPasswordInput.Controls.Add(this.lblPasswordIcon);
            this.pnlPasswordInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pnlPasswordInput.Location = new System.Drawing.Point(0, 20);
            this.pnlPasswordInput.Name = "pnlPasswordInput";
            this.pnlPasswordInput.Size = new System.Drawing.Size(358, 40);
            this.pnlPasswordInput.TabIndex = 1;
            this.pnlPasswordInput.Click += new System.EventHandler(this.Input_Click);
            this.pnlPasswordInput.Paint += new System.Windows.Forms.PaintEventHandler(this.Input_Paint);
            // 
            // lblPasswordIcon
            // 
            this.lblPasswordIcon.Font = new System.Drawing.Font("Segoe MDL2 Assets", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPasswordIcon.ForeColor = System.Drawing.Color.FromArgb(152, 162, 176);
            this.lblPasswordIcon.Location = new System.Drawing.Point(10, 2);
            this.lblPasswordIcon.Name = "lblPasswordIcon";
            this.lblPasswordIcon.Size = new System.Drawing.Size(24, 36);
            this.lblPasswordIcon.TabIndex = 0;
            this.lblPasswordIcon.Text = "\uE72E";
            this.lblPasswordIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(250, 251, 252);
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(31, 45, 68);
            this.txtPassword.Location = new System.Drawing.Point(40, 11);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PlaceholderText = "Tối thiểu 8 ký tự";
            this.txtPassword.Size = new System.Drawing.Size(262, 18);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lblShowPassword
            // 
            this.lblShowPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblShowPassword.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblShowPassword.ForeColor = System.Drawing.Color.FromArgb(39, 125, 198);
            this.lblShowPassword.Location = new System.Drawing.Point(306, 2);
            this.lblShowPassword.Name = "lblShowPassword";
            this.lblShowPassword.Size = new System.Drawing.Size(44, 36);
            this.lblShowPassword.TabIndex = 2;
            this.lblShowPassword.Text = "Hiện";
            this.lblShowPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblShowPassword.Click += new System.EventHandler(this.lblShowPassword_Click);
            // 
            // pnlGroupConfirm
            // 
            this.pnlGroupConfirm.Controls.Add(this.pnlConfirmInput);
            this.pnlGroupConfirm.Controls.Add(this.lblConfirm);
            this.pnlGroupConfirm.Location = new System.Drawing.Point(0, 210);
            this.pnlGroupConfirm.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.pnlGroupConfirm.Name = "pnlGroupConfirm";
            this.pnlGroupConfirm.Size = new System.Drawing.Size(358, 62);
            this.pnlGroupConfirm.TabIndex = 3;
            // 
            // lblConfirm
            // 
            this.lblConfirm.AutoSize = true;
            this.lblConfirm.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblConfirm.ForeColor = System.Drawing.Color.FromArgb(82, 97, 118);
            this.lblConfirm.Location = new System.Drawing.Point(0, 0);
            this.lblConfirm.Name = "lblConfirm";
            this.lblConfirm.Size = new System.Drawing.Size(107, 13);
            this.lblConfirm.TabIndex = 0;
            this.lblConfirm.Text = "Xác nhận mật khẩu";
            // 
            // pnlConfirmInput
            // 
            this.pnlConfirmInput.BackColor = System.Drawing.Color.FromArgb(250, 251, 252);
            this.pnlConfirmInput.Controls.Add(this.txtConfirm);
            this.pnlConfirmInput.Controls.Add(this.lblConfirmIcon);
            this.pnlConfirmInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pnlConfirmInput.Location = new System.Drawing.Point(0, 20);
            this.pnlConfirmInput.Name = "pnlConfirmInput";
            this.pnlConfirmInput.Size = new System.Drawing.Size(358, 40);
            this.pnlConfirmInput.TabIndex = 1;
            this.pnlConfirmInput.Click += new System.EventHandler(this.Input_Click);
            this.pnlConfirmInput.Paint += new System.Windows.Forms.PaintEventHandler(this.Input_Paint);
            // 
            // lblConfirmIcon
            // 
            this.lblConfirmIcon.Font = new System.Drawing.Font("Segoe MDL2 Assets", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblConfirmIcon.ForeColor = System.Drawing.Color.FromArgb(152, 162, 176);
            this.lblConfirmIcon.Location = new System.Drawing.Point(10, 2);
            this.lblConfirmIcon.Name = "lblConfirmIcon";
            this.lblConfirmIcon.Size = new System.Drawing.Size(24, 36);
            this.lblConfirmIcon.TabIndex = 0;
            this.lblConfirmIcon.Text = "\uE72E";
            this.lblConfirmIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtConfirm
            // 
            this.txtConfirm.BackColor = System.Drawing.Color.FromArgb(250, 251, 252);
            this.txtConfirm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfirm.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtConfirm.ForeColor = System.Drawing.Color.FromArgb(31, 45, 68);
            this.txtConfirm.Location = new System.Drawing.Point(40, 11);
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.PlaceholderText = "Nhập lại mật khẩu";
            this.txtConfirm.Size = new System.Drawing.Size(306, 18);
            this.txtConfirm.TabIndex = 1;
            this.txtConfirm.UseSystemPasswordChar = true;
            // 
            // pnlOptions
            // 
            this.pnlOptions.Controls.Add(this.lblForgot);
            this.pnlOptions.Controls.Add(this.chkRemember);
            this.pnlOptions.Location = new System.Drawing.Point(0, 280);
            this.pnlOptions.Margin = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.pnlOptions.Name = "pnlOptions";
            this.pnlOptions.Size = new System.Drawing.Size(358, 28);
            this.pnlOptions.TabIndex = 4;
            // 
            // chkRemember
            // 
            this.chkRemember.AutoSize = true;
            this.chkRemember.Checked = true;
            this.chkRemember.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRemember.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkRemember.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkRemember.ForeColor = System.Drawing.Color.FromArgb(82, 97, 118);
            this.chkRemember.Location = new System.Drawing.Point(0, 5);
            this.chkRemember.Name = "chkRemember";
            this.chkRemember.Size = new System.Drawing.Size(124, 17);
            this.chkRemember.TabIndex = 0;
            this.chkRemember.Text = "Ghi nhớ đăng nhập";
            this.chkRemember.UseVisualStyleBackColor = true;
            // 
            // lblForgot
            // 
            this.lblForgot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblForgot.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblForgot.ForeColor = System.Drawing.Color.FromArgb(39, 125, 198);
            this.lblForgot.Location = new System.Drawing.Point(238, 4);
            this.lblForgot.Name = "lblForgot";
            this.lblForgot.Size = new System.Drawing.Size(120, 20);
            this.lblForgot.TabIndex = 1;
            this.lblForgot.Text = "Quên mật khẩu?";
            this.lblForgot.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblForgot.Click += new System.EventHandler(this.lblForgot_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(0, 320);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(0, 6, 0, 12);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(358, 42);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Đăng nhập  →";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            this.btnSubmit.Paint += new System.Windows.Forms.PaintEventHandler(this.btnSubmit_Paint);
            // 
            // lblDemo
            // 
            this.lblDemo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDemo.ForeColor = System.Drawing.Color.FromArgb(82, 97, 118);
            this.lblDemo.Location = new System.Drawing.Point(0, 374);
            this.lblDemo.Margin = new System.Windows.Forms.Padding(0);
            this.lblDemo.Name = "lblDemo";
            this.lblDemo.Size = new System.Drawing.Size(358, 46);
            this.lblDemo.TabIndex = 6;
            this.lblDemo.Text = "Tài khoản demo: admin@northstar.vn · Mật khẩu: 12345678";
            this.lblDemo.Paint += new System.Windows.Forms.PaintEventHandler(this.lblDemo_Paint);
            // 
            // FormLogin
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(247, 249, 252);
            this.ClientSize = new System.Drawing.Size(1360, 860);
            this.Controls.Add(this.pnlCard);
            this.Controls.Add(this.btnBack);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MinimumSize = new System.Drawing.Size(900, 760);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EduCenter — Đăng nhập";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormLogin_Paint);
            this.Resize += new System.EventHandler(this.FormLogin_Resize);
            this.pnlCard.ResumeLayout(false);
            this.pnlCard.PerformLayout();
            this.flpForm.ResumeLayout(false);
            this.pnlGroupName.ResumeLayout(false);
            this.pnlGroupName.PerformLayout();
            this.pnlNameInput.ResumeLayout(false);
            this.pnlNameInput.PerformLayout();
            this.pnlGroupEmail.ResumeLayout(false);
            this.pnlGroupEmail.PerformLayout();
            this.pnlEmailInput.ResumeLayout(false);
            this.pnlEmailInput.PerformLayout();
            this.pnlGroupPassword.ResumeLayout(false);
            this.pnlGroupPassword.PerformLayout();
            this.pnlPasswordInput.ResumeLayout(false);
            this.pnlPasswordInput.PerformLayout();
            this.pnlGroupConfirm.ResumeLayout(false);
            this.pnlGroupConfirm.PerformLayout();
            this.pnlConfirmInput.ResumeLayout(false);
            this.pnlConfirmInput.PerformLayout();
            this.pnlOptions.ResumeLayout(false);
            this.pnlOptions.PerformLayout();
            this.pnlTabs.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.Panel pnlBrandMark;
        private System.Windows.Forms.Label lblBrandName;
        private System.Windows.Forms.Label lblBrandSub;
        private System.Windows.Forms.Label lblRoleIcon;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblIntro;
        private System.Windows.Forms.Panel pnlTabs;
        private System.Windows.Forms.Button btnTabLogin;
        private System.Windows.Forms.Button btnTabRegister;
        private System.Windows.Forms.FlowLayoutPanel flpForm;
        private System.Windows.Forms.Panel pnlGroupName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel pnlNameInput;
        private System.Windows.Forms.Label lblNameIcon;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Panel pnlGroupEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Panel pnlEmailInput;
        private System.Windows.Forms.Label lblEmailIcon;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Panel pnlGroupPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Panel pnlPasswordInput;
        private System.Windows.Forms.Label lblPasswordIcon;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblShowPassword;
        private System.Windows.Forms.Panel pnlGroupConfirm;
        private System.Windows.Forms.Label lblConfirm;
        private System.Windows.Forms.Panel pnlConfirmInput;
        private System.Windows.Forms.Label lblConfirmIcon;
        private System.Windows.Forms.TextBox txtConfirm;
        private System.Windows.Forms.Panel pnlOptions;
        private System.Windows.Forms.CheckBox chkRemember;
        private System.Windows.Forms.Label lblForgot;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblDemo;
    }
}
