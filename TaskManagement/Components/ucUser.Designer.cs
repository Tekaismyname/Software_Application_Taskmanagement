namespace TaskManagement
{
    partial class ucUser
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucUser));
            this.pnlUcUser = new Guna.UI2.WinForms.Guna2Panel();
            this.picUcRevenue = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblUcUserNotification = new System.Windows.Forms.Label();
            this.lblUcUser = new System.Windows.Forms.Label();
            this.pnlUcUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUcRevenue)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlUcUser
            // 
            this.pnlUcUser.BackColor = System.Drawing.Color.Silver;
            this.pnlUcUser.BorderColor = System.Drawing.Color.White;
            this.pnlUcUser.BorderRadius = 10;
            this.pnlUcUser.BorderThickness = 2;
            this.pnlUcUser.Controls.Add(this.picUcRevenue);
            this.pnlUcUser.Controls.Add(this.lblUcUserNotification);
            this.pnlUcUser.Controls.Add(this.lblUcUser);
            this.pnlUcUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlUcUser.FillColor = System.Drawing.Color.White;
            this.pnlUcUser.Location = new System.Drawing.Point(0, 0);
            this.pnlUcUser.Name = "pnlUcUser";
            this.pnlUcUser.Size = new System.Drawing.Size(927, 154);
            this.pnlUcUser.TabIndex = 3;
            // 
            // picUcRevenue
            // 
            this.picUcRevenue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picUcRevenue.BackColor = System.Drawing.Color.White;
            this.picUcRevenue.Image = ((System.Drawing.Image)(resources.GetObject("picUcRevenue.Image")));
            this.picUcRevenue.ImageRotate = 0F;
            this.picUcRevenue.Location = new System.Drawing.Point(266, 30);
            this.picUcRevenue.Name = "picUcRevenue";
            this.picUcRevenue.Size = new System.Drawing.Size(132, 95);
            this.picUcRevenue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUcRevenue.TabIndex = 3;
            this.picUcRevenue.TabStop = false;
            // 
            // lblUcUserNotification
            // 
            this.lblUcUserNotification.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUcUserNotification.AutoSize = true;
            this.lblUcUserNotification.BackColor = System.Drawing.Color.White;
            this.lblUcUserNotification.Font = new System.Drawing.Font("Calibri Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUcUserNotification.Location = new System.Drawing.Point(407, 81);
            this.lblUcUserNotification.Name = "lblUcUserNotification";
            this.lblUcUserNotification.Size = new System.Drawing.Size(293, 21);
            this.lblUcUserNotification.TabIndex = 2;
            this.lblUcUserNotification.Text = "Please view and check information below";
            // 
            // lblUcUser
            // 
            this.lblUcUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUcUser.AutoSize = true;
            this.lblUcUser.BackColor = System.Drawing.Color.White;
            this.lblUcUser.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUcUser.ForeColor = System.Drawing.Color.Blue;
            this.lblUcUser.Location = new System.Drawing.Point(404, 41);
            this.lblUcUser.Name = "lblUcUser";
            this.lblUcUser.Size = new System.Drawing.Size(169, 40);
            this.lblUcUser.TabIndex = 1;
            this.lblUcUser.Text = "Hello, ____";
            // 
            // ucUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlUcUser);
            this.Name = "ucUser";
            this.Size = new System.Drawing.Size(927, 154);
            this.pnlUcUser.ResumeLayout(false);
            this.pnlUcUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUcRevenue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlUcUser;
        private Guna.UI2.WinForms.Guna2PictureBox picUcRevenue;
        private System.Windows.Forms.Label lblUcUserNotification;
        private System.Windows.Forms.Label lblUcUser;
    }
}
