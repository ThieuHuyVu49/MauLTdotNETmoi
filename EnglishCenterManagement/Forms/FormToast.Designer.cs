namespace EnglishCenterManagement.Forms
{
    partial class FormToast
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
            this.lblIcon = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblIcon
            // 
            this.lblIcon.BackColor = System.Drawing.Color.White;
            this.lblIcon.Font = new System.Drawing.Font("Segoe MDL2 Assets", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIcon.ForeColor = System.Drawing.Color.White;
            this.lblIcon.Location = new System.Drawing.Point(16, 16);
            this.lblIcon.Name = "lblIcon";
            this.lblIcon.Size = new System.Drawing.Size(26, 26);
            this.lblIcon.TabIndex = 0;
            this.lblIcon.Paint += new System.Windows.Forms.PaintEventHandler(this.lblIcon_Paint);
            // 
            // lblMessage
            // 
            this.lblMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMessage.BackColor = System.Drawing.Color.White;
            this.lblMessage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMessage.ForeColor = System.Drawing.Color.FromArgb(36, 50, 73);
            this.lblMessage.Location = new System.Drawing.Point(52, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(258, 58);
            this.lblMessage.TabIndex = 1;
            this.lblMessage.Text = "Đã lưu thay đổi";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMessage.UseMnemonic = false;
            // 
            // FormToast
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(320, 58);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblIcon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormToast";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Thông báo";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormToast_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormToast_Paint);
            this.Click += new System.EventHandler(this.FormToast_Click);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblIcon;
        private System.Windows.Forms.Label lblMessage;
    }
}
