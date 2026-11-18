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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnBack = new System.Windows.Forms.Button();
            pnlCard = new System.Windows.Forms.Panel();
            pnlGroupName = new System.Windows.Forms.Panel();
            pnlNameInput = new System.Windows.Forms.Panel();
            txtName = new System.Windows.Forms.TextBox();
            lblNameIcon = new System.Windows.Forms.Label();
            lblName = new System.Windows.Forms.Label();
            pnlForm = new System.Windows.Forms.Panel();
            pnlGroupEmail = new System.Windows.Forms.Panel();
            pnlEmailInput = new System.Windows.Forms.Panel();
            txtEmail = new System.Windows.Forms.TextBox();
            lblEmailIcon = new System.Windows.Forms.Label();
            lblEmail = new System.Windows.Forms.Label();
            pnlGroupPassword = new System.Windows.Forms.Panel();
            pnlPasswordInput = new System.Windows.Forms.Panel();
            lblShowPassword = new System.Windows.Forms.Label();
            txtPassword = new System.Windows.Forms.TextBox();
            lblPasswordIcon = new System.Windows.Forms.Label();
            lblPassword = new System.Windows.Forms.Label();
            pnlGroupConfirm = new System.Windows.Forms.Panel();
            pnlConfirmInput = new System.Windows.Forms.Panel();
            txtConfirm = new System.Windows.Forms.TextBox();
            lblConfirmIcon = new System.Windows.Forms.Label();
            lblConfirm = new System.Windows.Forms.Label();
            pnlOptions = new System.Windows.Forms.Panel();
            lblForgot = new System.Windows.Forms.Label();
            chkRemember = new System.Windows.Forms.CheckBox();
            btnSubmit = new System.Windows.Forms.Button();
            lblDemo = new System.Windows.Forms.Label();
            pnlTabs = new System.Windows.Forms.Panel();
            btnTabRegister = new System.Windows.Forms.Button();
            btnTabLogin = new System.Windows.Forms.Button();
            lblIntro = new System.Windows.Forms.Label();
            lblTitle = new System.Windows.Forms.Label();
            lblRoleIcon = new System.Windows.Forms.Label();
            lblBrandSub = new System.Windows.Forms.Label();
            lblBrandName = new System.Windows.Forms.Label();
            pnlBrandMark = new System.Windows.Forms.Panel();
            pnlCard.SuspendLayout();
            pnlGroupName.SuspendLayout();
            pnlNameInput.SuspendLayout();
            pnlForm.SuspendLayout();
            pnlGroupEmail.SuspendLayout();
            pnlEmailInput.SuspendLayout();
            pnlGroupPassword.SuspendLayout();
            pnlPasswordInput.SuspendLayout();
            pnlGroupConfirm.SuspendLayout();
            pnlConfirmInput.SuspendLayout();
            pnlOptions.SuspendLayout();
            pnlTabs.SuspendLayout();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnBack.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F);
            btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)82)), ((int)((byte)97)), ((int)((byte)118)));
            btnBack.Location = new System.Drawing.Point(37, 37);
            btnBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new System.Drawing.Size(217, 48);
            btnBack.TabIndex = 1;
            btnBack.Tag = "";
            btnBack.Text = "Quay lại chọn vai trò";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            btnBack.Paint += btnBack_Paint;
            // 
            // pnlCard
            // 
            pnlCard.Anchor = System.Windows.Forms.AnchorStyles.None;
            pnlCard.BackColor = System.Drawing.Color.White;
            pnlCard.Controls.Add(pnlGroupName);
            pnlCard.Controls.Add(pnlForm);
            pnlCard.Controls.Add(pnlTabs);
            pnlCard.Controls.Add(lblIntro);
            pnlCard.Controls.Add(lblTitle);
            pnlCard.Controls.Add(lblRoleIcon);
            pnlCard.Controls.Add(lblBrandSub);
            pnlCard.Controls.Add(lblBrandName);
            pnlCard.Controls.Add(pnlBrandMark);
            pnlCard.Location = new System.Drawing.Point(531, 128);
            pnlCard.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pnlCard.Name = "pnlCard";
            pnlCard.Size = new System.Drawing.Size(491, 891);
            pnlCard.TabIndex = 0;
            pnlCard.Paint += pnlCard_Paint;
            // 
            // pnlGroupName
            // 
            pnlGroupName.Controls.Add(pnlNameInput);
            pnlGroupName.Controls.Add(lblName);
            pnlGroupName.Location = new System.Drawing.Point(44, 376);
            pnlGroupName.Margin = new System.Windows.Forms.Padding(0, 0, 0, 11);
            pnlGroupName.Name = "pnlGroupName";
            pnlGroupName.Size = new System.Drawing.Size(409, 83);
            pnlGroupName.TabIndex = 0;
            // 
            // pnlNameInput
            // 
            pnlNameInput.BackColor = System.Drawing.Color.FromArgb(((int)((byte)250)), ((int)((byte)251)), ((int)((byte)252)));
            pnlNameInput.Controls.Add(txtName);
            pnlNameInput.Controls.Add(lblNameIcon);
            pnlNameInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            pnlNameInput.Location = new System.Drawing.Point(0, 27);
            pnlNameInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pnlNameInput.Name = "pnlNameInput";
            pnlNameInput.Size = new System.Drawing.Size(409, 53);
            pnlNameInput.TabIndex = 1;
            pnlNameInput.Click += Input_Click;
            pnlNameInput.Paint += Input_Paint;
            // 
            // txtName
            // 
            txtName.BackColor = System.Drawing.Color.FromArgb(((int)((byte)250)), ((int)((byte)251)), ((int)((byte)252)));
            txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtName.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            txtName.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)31)), ((int)((byte)45)), ((int)((byte)68)));
            txtName.Location = new System.Drawing.Point(47, 18);
            txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Nguyễn Văn An";
            txtName.Size = new System.Drawing.Size(350, 22);
            txtName.TabIndex = 1;
            // 
            // lblNameIcon
            // 
            lblNameIcon.Font = new System.Drawing.Font("Segoe MDL2 Assets", 9.75F);
            lblNameIcon.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)152)), ((int)((byte)162)), ((int)((byte)176)));
            lblNameIcon.Location = new System.Drawing.Point(11, 3);
            lblNameIcon.Name = "lblNameIcon";
            lblNameIcon.Size = new System.Drawing.Size(27, 48);
            lblNameIcon.TabIndex = 0;
            lblNameIcon.Text = "";
            lblNameIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F);
            lblName.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)82)), ((int)((byte)97)), ((int)((byte)118)));
            lblName.Location = new System.Drawing.Point(0, 0);
            lblName.Name = "lblName";
            lblName.Size = new System.Drawing.Size(69, 19);
            lblName.TabIndex = 0;
            lblName.Text = "Họ và tên";
            // 
            // pnlForm
            // 
            pnlForm.Controls.Add(pnlGroupEmail);
            pnlForm.Controls.Add(pnlGroupPassword);
            pnlForm.Controls.Add(pnlGroupConfirm);
            pnlForm.Controls.Add(pnlOptions);
            pnlForm.Controls.Add(btnSubmit);
            pnlForm.Controls.Add(lblDemo);
            pnlForm.Location = new System.Drawing.Point(41, 376);
            pnlForm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pnlForm.Name = "pnlForm";
            pnlForm.Size = new System.Drawing.Size(411, 499);
            pnlForm.TabIndex = 7;
            // 
            // pnlGroupEmail
            // 
            pnlGroupEmail.Controls.Add(pnlEmailInput);
            pnlGroupEmail.Controls.Add(lblEmail);
            pnlGroupEmail.Location = new System.Drawing.Point(0, 94);
            pnlGroupEmail.Margin = new System.Windows.Forms.Padding(0, 0, 0, 11);
            pnlGroupEmail.Name = "pnlGroupEmail";
            pnlGroupEmail.Size = new System.Drawing.Size(409, 83);
            pnlGroupEmail.TabIndex = 1;
            // 
            // pnlEmailInput
            // 
            pnlEmailInput.BackColor = System.Drawing.Color.FromArgb(((int)((byte)250)), ((int)((byte)251)), ((int)((byte)252)));
            pnlEmailInput.Controls.Add(txtEmail);
            pnlEmailInput.Controls.Add(lblEmailIcon);
            pnlEmailInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            pnlEmailInput.Location = new System.Drawing.Point(0, 27);
            pnlEmailInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pnlEmailInput.Name = "pnlEmailInput";
            pnlEmailInput.Size = new System.Drawing.Size(409, 53);
            pnlEmailInput.TabIndex = 1;
            pnlEmailInput.Click += Input_Click;
            pnlEmailInput.Paint += Input_Paint;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)((byte)250)), ((int)((byte)251)), ((int)((byte)252)));
            txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)31)), ((int)((byte)45)), ((int)((byte)68)));
            txtEmail.Location = new System.Drawing.Point(46, 15);
            txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "ten@northstar.vn";
            txtEmail.Size = new System.Drawing.Size(350, 22);
            txtEmail.TabIndex = 1;
            // 
            // lblEmailIcon
            // 
            lblEmailIcon.Font = new System.Drawing.Font("Segoe MDL2 Assets", 9.75F);
            lblEmailIcon.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)152)), ((int)((byte)162)), ((int)((byte)176)));
            lblEmailIcon.Location = new System.Drawing.Point(11, 3);
            lblEmailIcon.Name = "lblEmailIcon";
            lblEmailIcon.Size = new System.Drawing.Size(27, 48);
            lblEmailIcon.TabIndex = 0;
            lblEmailIcon.Text = "";
            lblEmailIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F);
            lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)82)), ((int)((byte)97)), ((int)((byte)118)));
            lblEmail.Location = new System.Drawing.Point(0, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new System.Drawing.Size(43, 19);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "Email";
            // 
            // pnlGroupPassword
            // 
            pnlGroupPassword.Controls.Add(pnlPasswordInput);
            pnlGroupPassword.Controls.Add(lblPassword);
            pnlGroupPassword.Location = new System.Drawing.Point(0, 188);
            pnlGroupPassword.Margin = new System.Windows.Forms.Padding(0, 0, 0, 11);
            pnlGroupPassword.Name = "pnlGroupPassword";
            pnlGroupPassword.Size = new System.Drawing.Size(409, 83);
            pnlGroupPassword.TabIndex = 2;
            // 
            // pnlPasswordInput
            // 
            pnlPasswordInput.BackColor = System.Drawing.Color.FromArgb(((int)((byte)250)), ((int)((byte)251)), ((int)((byte)252)));
            pnlPasswordInput.Controls.Add(lblShowPassword);
            pnlPasswordInput.Controls.Add(txtPassword);
            pnlPasswordInput.Controls.Add(lblPasswordIcon);
            pnlPasswordInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            pnlPasswordInput.Location = new System.Drawing.Point(0, 27);
            pnlPasswordInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pnlPasswordInput.Name = "pnlPasswordInput";
            pnlPasswordInput.Size = new System.Drawing.Size(409, 53);
            pnlPasswordInput.TabIndex = 1;
            pnlPasswordInput.Click += Input_Click;
            pnlPasswordInput.Paint += Input_Paint;
            // 
            // lblShowPassword
            // 
            lblShowPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            lblShowPassword.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            lblShowPassword.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)39)), ((int)((byte)125)), ((int)((byte)198)));
            lblShowPassword.Location = new System.Drawing.Point(350, 3);
            lblShowPassword.Name = "lblShowPassword";
            lblShowPassword.Size = new System.Drawing.Size(50, 48);
            lblShowPassword.TabIndex = 2;
            lblShowPassword.Text = "Hiện";
            lblShowPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lblShowPassword.Click += lblShowPassword_Click;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)((byte)250)), ((int)((byte)251)), ((int)((byte)252)));
            txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtPassword.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)31)), ((int)((byte)45)), ((int)((byte)68)));
            txtPassword.Location = new System.Drawing.Point(46, 15);
            txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Tối thiểu 8 ký tự";
            txtPassword.Size = new System.Drawing.Size(299, 22);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblPasswordIcon
            // 
            lblPasswordIcon.Font = new System.Drawing.Font("Segoe MDL2 Assets", 9.75F);
            lblPasswordIcon.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)152)), ((int)((byte)162)), ((int)((byte)176)));
            lblPasswordIcon.Location = new System.Drawing.Point(11, 3);
            lblPasswordIcon.Name = "lblPasswordIcon";
            lblPasswordIcon.Size = new System.Drawing.Size(27, 48);
            lblPasswordIcon.TabIndex = 0;
            lblPasswordIcon.Text = "";
            lblPasswordIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F);
            lblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)82)), ((int)((byte)97)), ((int)((byte)118)));
            lblPassword.Location = new System.Drawing.Point(0, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new System.Drawing.Size(68, 19);
            lblPassword.TabIndex = 0;
            lblPassword.Text = "Mật khẩu";
            // 
            // pnlGroupConfirm
            // 
            pnlGroupConfirm.Controls.Add(pnlConfirmInput);
            pnlGroupConfirm.Controls.Add(lblConfirm);
            pnlGroupConfirm.Location = new System.Drawing.Point(0, 282);
            pnlGroupConfirm.Margin = new System.Windows.Forms.Padding(0, 0, 0, 11);
            pnlGroupConfirm.Name = "pnlGroupConfirm";
            pnlGroupConfirm.Size = new System.Drawing.Size(409, 83);
            pnlGroupConfirm.TabIndex = 3;
            // 
            // pnlConfirmInput
            // 
            pnlConfirmInput.BackColor = System.Drawing.Color.FromArgb(((int)((byte)250)), ((int)((byte)251)), ((int)((byte)252)));
            pnlConfirmInput.Controls.Add(txtConfirm);
            pnlConfirmInput.Controls.Add(lblConfirmIcon);
            pnlConfirmInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            pnlConfirmInput.Location = new System.Drawing.Point(0, 27);
            pnlConfirmInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pnlConfirmInput.Name = "pnlConfirmInput";
            pnlConfirmInput.Size = new System.Drawing.Size(409, 53);
            pnlConfirmInput.TabIndex = 1;
            pnlConfirmInput.Click += Input_Click;
            pnlConfirmInput.Paint += Input_Paint;
            // 
            // txtConfirm
            // 
            txtConfirm.BackColor = System.Drawing.Color.FromArgb(((int)((byte)250)), ((int)((byte)251)), ((int)((byte)252)));
            txtConfirm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtConfirm.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            txtConfirm.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)31)), ((int)((byte)45)), ((int)((byte)68)));
            txtConfirm.Location = new System.Drawing.Point(46, 15);
            txtConfirm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtConfirm.Name = "txtConfirm";
            txtConfirm.PlaceholderText = "Nhập lại mật khẩu";
            txtConfirm.Size = new System.Drawing.Size(350, 22);
            txtConfirm.TabIndex = 1;
            txtConfirm.UseSystemPasswordChar = true;
            // 
            // lblConfirmIcon
            // 
            lblConfirmIcon.Font = new System.Drawing.Font("Segoe MDL2 Assets", 9.75F);
            lblConfirmIcon.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)152)), ((int)((byte)162)), ((int)((byte)176)));
            lblConfirmIcon.Location = new System.Drawing.Point(11, 3);
            lblConfirmIcon.Name = "lblConfirmIcon";
            lblConfirmIcon.Size = new System.Drawing.Size(27, 48);
            lblConfirmIcon.TabIndex = 0;
            lblConfirmIcon.Text = "";
            lblConfirmIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblConfirm
            // 
            lblConfirm.AutoSize = true;
            lblConfirm.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F);
            lblConfirm.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)82)), ((int)((byte)97)), ((int)((byte)118)));
            lblConfirm.Location = new System.Drawing.Point(0, 0);
            lblConfirm.Name = "lblConfirm";
            lblConfirm.Size = new System.Drawing.Size(129, 19);
            lblConfirm.TabIndex = 0;
            lblConfirm.Text = "Xác nhận mật khẩu";
            // 
            // pnlOptions
            // 
            pnlOptions.Controls.Add(lblForgot);
            pnlOptions.Controls.Add(chkRemember);
            pnlOptions.Location = new System.Drawing.Point(0, 376);
            pnlOptions.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            pnlOptions.Name = "pnlOptions";
            pnlOptions.Size = new System.Drawing.Size(409, 37);
            pnlOptions.TabIndex = 4;
            // 
            // lblForgot
            // 
            lblForgot.Cursor = System.Windows.Forms.Cursors.Hand;
            lblForgot.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            lblForgot.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)39)), ((int)((byte)125)), ((int)((byte)198)));
            lblForgot.Location = new System.Drawing.Point(272, 5);
            lblForgot.Name = "lblForgot";
            lblForgot.Size = new System.Drawing.Size(137, 27);
            lblForgot.TabIndex = 1;
            lblForgot.Text = "Quên mật khẩu?";
            lblForgot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lblForgot.Click += lblForgot_Click;
            // 
            // chkRemember
            // 
            chkRemember.AutoSize = true;
            chkRemember.Checked = true;
            chkRemember.CheckState = System.Windows.Forms.CheckState.Checked;
            chkRemember.Cursor = System.Windows.Forms.Cursors.Hand;
            chkRemember.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            chkRemember.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)82)), ((int)((byte)97)), ((int)((byte)118)));
            chkRemember.Location = new System.Drawing.Point(0, 7);
            chkRemember.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            chkRemember.Name = "chkRemember";
            chkRemember.Size = new System.Drawing.Size(150, 23);
            chkRemember.TabIndex = 0;
            chkRemember.Text = "Ghi nhớ đăng nhập";
            chkRemember.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            btnSubmit.FlatAppearance.BorderSize = 0;
            btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSubmit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            btnSubmit.ForeColor = System.Drawing.Color.White;
            btnSubmit.Location = new System.Drawing.Point(0, 429);
            btnSubmit.Margin = new System.Windows.Forms.Padding(0, 8, 0, 16);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new System.Drawing.Size(409, 56);
            btnSubmit.TabIndex = 5;
            btnSubmit.Text = "Đăng nhập  →";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            btnSubmit.Paint += btnSubmit_Paint;
            // 
            // lblDemo
            // 
            lblDemo.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            lblDemo.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)82)), ((int)((byte)97)), ((int)((byte)118)));
            lblDemo.Location = new System.Drawing.Point(0, 501);
            lblDemo.Margin = new System.Windows.Forms.Padding(0);
            lblDemo.Name = "lblDemo";
            lblDemo.Size = new System.Drawing.Size(409, 61);
            lblDemo.TabIndex = 6;
            lblDemo.Text = "Tài khoản demo: admin@northstar.vn · Mật khẩu: 12345678";
            lblDemo.Paint += lblDemo_Paint;
            // 
            // pnlTabs
            // 
            pnlTabs.BackColor = System.Drawing.Color.FromArgb(((int)((byte)240)), ((int)((byte)243)), ((int)((byte)246)));
            pnlTabs.Controls.Add(btnTabRegister);
            pnlTabs.Controls.Add(btnTabLogin);
            pnlTabs.Location = new System.Drawing.Point(41, 301);
            pnlTabs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pnlTabs.Name = "pnlTabs";
            pnlTabs.Size = new System.Drawing.Size(409, 53);
            pnlTabs.TabIndex = 6;
            pnlTabs.Paint += pnlTabs_Paint;
            // 
            // btnTabRegister
            // 
            btnTabRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            btnTabRegister.FlatAppearance.BorderSize = 0;
            btnTabRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnTabRegister.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            btnTabRegister.Location = new System.Drawing.Point(206, 5);
            btnTabRegister.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnTabRegister.Name = "btnTabRegister";
            btnTabRegister.Size = new System.Drawing.Size(199, 43);
            btnTabRegister.TabIndex = 1;
            btnTabRegister.TabStop = false;
            btnTabRegister.Text = "Đăng ký";
            btnTabRegister.UseVisualStyleBackColor = false;
            btnTabRegister.Click += btnTabRegister_Click;
            btnTabRegister.Paint += Tab_Paint;
            // 
            // btnTabLogin
            // 
            btnTabLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            btnTabLogin.FlatAppearance.BorderSize = 0;
            btnTabLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnTabLogin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            btnTabLogin.Location = new System.Drawing.Point(3, 6);
            btnTabLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnTabLogin.Name = "btnTabLogin";
            btnTabLogin.Size = new System.Drawing.Size(199, 43);
            btnTabLogin.TabIndex = 0;
            btnTabLogin.TabStop = false;
            btnTabLogin.Text = "Đăng nhập";
            btnTabLogin.UseVisualStyleBackColor = false;
            btnTabLogin.Click += btnTabLogin_Click;
            btnTabLogin.Paint += Tab_Paint;
            // 
            // lblIntro
            // 
            lblIntro.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblIntro.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)135)), ((int)((byte)147)), ((int)((byte)163)));
            lblIntro.Location = new System.Drawing.Point(41, 243);
            lblIntro.Name = "lblIntro";
            lblIntro.Size = new System.Drawing.Size(409, 48);
            lblIntro.TabIndex = 5;
            lblIntro.Text = "Quản lý toàn bộ hoạt động đào tạo, học viên và tài chính của trung tâm.";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)23)), ((int)((byte)36)), ((int)((byte)61)));
            lblTitle.Location = new System.Drawing.Point(37, 197);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(302, 35);
            lblTitle.TabIndex = 4;
            lblTitle.Text = "Đăng nhập Quản trị viên";
            // 
            // lblRoleIcon
            // 
            lblRoleIcon.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14F);
            lblRoleIcon.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)38)), ((int)((byte)124)), ((int)((byte)199)));
            lblRoleIcon.Location = new System.Drawing.Point(41, 125);
            lblRoleIcon.Name = "lblRoleIcon";
            lblRoleIcon.Size = new System.Drawing.Size(50, 59);
            lblRoleIcon.TabIndex = 3;
            lblRoleIcon.Tag = "#e8f4ff";
            lblRoleIcon.Text = "";
            lblRoleIcon.Paint += lblRoleIcon_Paint;
            // 
            // lblBrandSub
            // 
            lblBrandSub.AutoSize = true;
            lblBrandSub.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Bold);
            lblBrandSub.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)143)), ((int)((byte)155)), ((int)((byte)172)));
            lblBrandSub.Location = new System.Drawing.Point(90, 73);
            lblBrandSub.Name = "lblBrandSub";
            lblBrandSub.Size = new System.Drawing.Size(144, 15);
            lblBrandSub.TabIndex = 2;
            lblBrandSub.Text = "ENGLISH MANAGEMENT";
            // 
            // lblBrandName
            // 
            lblBrandName.AutoSize = true;
            lblBrandName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            lblBrandName.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)23)), ((int)((byte)36)), ((int)((byte)61)));
            lblBrandName.Location = new System.Drawing.Point(88, 44);
            lblBrandName.Name = "lblBrandName";
            lblBrandName.Size = new System.Drawing.Size(105, 25);
            lblBrandName.TabIndex = 1;
            lblBrandName.Text = "EduCenter";
            // 
            // pnlBrandMark
            // 
            pnlBrandMark.BackColor = System.Drawing.Color.White;
            pnlBrandMark.Location = new System.Drawing.Point(41, 45);
            pnlBrandMark.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pnlBrandMark.Name = "pnlBrandMark";
            pnlBrandMark.Size = new System.Drawing.Size(39, 45);
            pnlBrandMark.TabIndex = 0;
            pnlBrandMark.Paint += pnlBrandMark_Paint;
            // 
            // FormLogin
            // 
            AcceptButton = btnSubmit;
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(((int)((byte)247)), ((int)((byte)249)), ((int)((byte)252)));
            ClientSize = new System.Drawing.Size(1554, 1055);
            Controls.Add(pnlCard);
            Controls.Add(btnBack);
            Font = new System.Drawing.Font("Segoe UI", 9F);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            MinimumSize = new System.Drawing.Size(1026, 998);
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "EduCenter — Đăng nhập";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            Load += FormLogin_Load;
            Paint += FormLogin_Paint;
            Resize += FormLogin_Resize;
            pnlCard.ResumeLayout(false);
            pnlCard.PerformLayout();
            pnlGroupName.ResumeLayout(false);
            pnlGroupName.PerformLayout();
            pnlNameInput.ResumeLayout(false);
            pnlNameInput.PerformLayout();
            pnlForm.ResumeLayout(false);
            pnlGroupEmail.ResumeLayout(false);
            pnlGroupEmail.PerformLayout();
            pnlEmailInput.ResumeLayout(false);
            pnlEmailInput.PerformLayout();
            pnlGroupPassword.ResumeLayout(false);
            pnlGroupPassword.PerformLayout();
            pnlPasswordInput.ResumeLayout(false);
            pnlPasswordInput.PerformLayout();
            pnlGroupConfirm.ResumeLayout(false);
            pnlGroupConfirm.PerformLayout();
            pnlConfirmInput.ResumeLayout(false);
            pnlConfirmInput.PerformLayout();
            pnlOptions.ResumeLayout(false);
            pnlOptions.PerformLayout();
            pnlTabs.ResumeLayout(false);
            ResumeLayout(false);
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
        private System.Windows.Forms.Panel pnlForm;
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
