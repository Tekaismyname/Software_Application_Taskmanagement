namespace TaskManagement
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.LogThemePanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.pnlPassword = new Guna.UI2.WinForms.Guna2Panel();
            this.picPassword = new Guna.UI2.WinForms.Guna2PictureBox();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.picUsername = new Guna.UI2.WinForms.Guna2PictureBox();
            this.txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnLogin = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.HSUlogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.TaskManagementPictureBox = new Guna.UI2.WinForms.Guna2PictureBox();
            this.LogThemePanel.SuspendLayout();
            this.pnlPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPassword)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HSUlogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TaskManagementPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // LogThemePanel
            // 
            this.LogThemePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogThemePanel.AutoSize = true;
            this.LogThemePanel.BackColor = System.Drawing.Color.Transparent;
            this.LogThemePanel.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LogThemePanel.Controls.Add(this.pnlPassword);
            this.LogThemePanel.Controls.Add(this.guna2Panel1);
            this.LogThemePanel.Controls.Add(this.btnLogin);
            this.LogThemePanel.Controls.Add(this.label1);
            this.LogThemePanel.Controls.Add(this.lblWelcome);
            this.LogThemePanel.Controls.Add(this.HSUlogo);
            this.LogThemePanel.FillColor = System.Drawing.Color.White;
            this.LogThemePanel.FillColor2 = System.Drawing.Color.White;
            this.LogThemePanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.LogThemePanel.Location = new System.Drawing.Point(650, 0);
            this.LogThemePanel.Name = "LogThemePanel";
            this.LogThemePanel.Size = new System.Drawing.Size(480, 553);
            this.LogThemePanel.TabIndex = 1;
            // 
            // pnlPassword
            // 
            this.pnlPassword.BorderRadius = 20;
            this.pnlPassword.Controls.Add(this.picPassword);
            this.pnlPassword.Controls.Add(this.txtPassword);
            this.pnlPassword.Location = new System.Drawing.Point(35, 312);
            this.pnlPassword.Name = "pnlPassword";
            this.pnlPassword.Size = new System.Drawing.Size(415, 56);
            this.pnlPassword.TabIndex = 8;
            // 
            // picPassword
            // 
            this.picPassword.Image = ((System.Drawing.Image)(resources.GetObject("picPassword.Image")));
            this.picPassword.ImageRotate = 0F;
            this.picPassword.Location = new System.Drawing.Point(3, 3);
            this.picPassword.Name = "picPassword";
            this.picPassword.Size = new System.Drawing.Size(54, 50);
            this.picPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPassword.TabIndex = 4;
            this.picPassword.TabStop = false;
            // 
            // txtPassword
            // 
            this.txtPassword.BorderColor = System.Drawing.Color.Black;
            this.txtPassword.BorderRadius = 20;
            this.txtPassword.BorderThickness = 0;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Location = new System.Drawing.Point(60, 0);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtPassword.PlaceholderText = "Enter your password";
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(355, 56);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged_1);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderRadius = 20;
            this.guna2Panel1.Controls.Add(this.picUsername);
            this.guna2Panel1.Controls.Add(this.txtUsername);
            this.guna2Panel1.Location = new System.Drawing.Point(35, 206);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(415, 56);
            this.guna2Panel1.TabIndex = 7;
            // 
            // picUsername
            // 
            this.picUsername.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.picUsername.Image = ((System.Drawing.Image)(resources.GetObject("picUsername.Image")));
            this.picUsername.ImageRotate = 0F;
            this.picUsername.Location = new System.Drawing.Point(3, 3);
            this.picUsername.Name = "picUsername";
            this.picUsername.Size = new System.Drawing.Size(54, 50);
            this.picUsername.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUsername.TabIndex = 3;
            this.picUsername.TabStop = false;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.Transparent;
            this.txtUsername.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtUsername.BorderRadius = 20;
            this.txtUsername.BorderThickness = 0;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.DefaultText = "";
            this.txtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.txtUsername.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUsername.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.Location = new System.Drawing.Point(60, 0);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtUsername.PlaceholderText = "Email or phone number";
            this.txtUsername.SelectedText = "";
            this.txtUsername.Size = new System.Drawing.Size(355, 56);
            this.txtUsername.TabIndex = 2;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.BorderColor = System.Drawing.Color.White;
            this.btnLogin.BorderRadius = 10;
            this.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogin.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogin.FillColor = System.Drawing.Color.Coral;
            this.btnLogin.FillColor2 = System.Drawing.Color.PeachPuff;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.HoverState.FillColor = System.Drawing.Color.Gray;
            this.btnLogin.Location = new System.Drawing.Point(150, 392);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(180, 45);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Login";
            this.btnLogin.Click += new System.EventHandler(this.guna2GradientButton1_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // lblWelcome
            // 
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(144, 136);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(222, 36);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "WELCOME BACK!";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblWelcome.Click += new System.EventHandler(this.lblWelcome_Click);
            // 
            // HSUlogo
            // 
            this.HSUlogo.Image = ((System.Drawing.Image)(resources.GetObject("HSUlogo.Image")));
            this.HSUlogo.ImageRotate = 0F;
            this.HSUlogo.Location = new System.Drawing.Point(203, 33);
            this.HSUlogo.Name = "HSUlogo";
            this.HSUlogo.Size = new System.Drawing.Size(100, 100);
            this.HSUlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HSUlogo.TabIndex = 0;
            this.HSUlogo.TabStop = false;
            // 
            // TaskManagementPictureBox
            // 
            this.TaskManagementPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TaskManagementPictureBox.BorderRadius = 100;
            this.TaskManagementPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("TaskManagementPictureBox.Image")));
            this.TaskManagementPictureBox.ImageRotate = 0F;
            this.TaskManagementPictureBox.Location = new System.Drawing.Point(-105, 0);
            this.TaskManagementPictureBox.Name = "TaskManagementPictureBox";
            this.TaskManagementPictureBox.Size = new System.Drawing.Size(678, 553);
            this.TaskManagementPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TaskManagementPictureBox.TabIndex = 0;
            this.TaskManagementPictureBox.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1182, 553);
            this.Controls.Add(this.LogThemePanel);
            this.Controls.Add(this.TaskManagementPictureBox);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.LogThemePanel.ResumeLayout(false);
            this.pnlPassword.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPassword)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HSUlogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TaskManagementPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2GradientPanel LogThemePanel;
        private Guna.UI2.WinForms.Guna2PictureBox HSUlogo;
        private System.Windows.Forms.Label lblWelcome;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtUsername;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2GradientButton btnLogin;
        private Guna.UI2.WinForms.Guna2PictureBox TaskManagementPictureBox;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2PictureBox picUsername;
        private Guna.UI2.WinForms.Guna2Panel pnlPassword;
        private Guna.UI2.WinForms.Guna2PictureBox picPassword;
    }
}