namespace TaskManagement
{
    partial class ucRevenue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucRevenue));
            this.pnlUcRevenue = new Guna.UI2.WinForms.Guna2Panel();
            this.picUcRevenue = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblUcSloganRevenue = new System.Windows.Forms.Label();
            this.lblRevenue = new System.Windows.Forms.Label();
            this.pnlUcRevenue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUcRevenue)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlUcRevenue
            // 
            this.pnlUcRevenue.BackColor = System.Drawing.Color.Silver;
            this.pnlUcRevenue.BorderColor = System.Drawing.Color.White;
            this.pnlUcRevenue.BorderRadius = 10;
            this.pnlUcRevenue.BorderThickness = 2;
            this.pnlUcRevenue.Controls.Add(this.picUcRevenue);
            this.pnlUcRevenue.Controls.Add(this.lblUcSloganRevenue);
            this.pnlUcRevenue.Controls.Add(this.lblRevenue);
            this.pnlUcRevenue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlUcRevenue.FillColor = System.Drawing.Color.White;
            this.pnlUcRevenue.Location = new System.Drawing.Point(0, 0);
            this.pnlUcRevenue.Name = "pnlUcRevenue";
            this.pnlUcRevenue.Size = new System.Drawing.Size(927, 154);
            this.pnlUcRevenue.TabIndex = 2;
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
            // lblUcSloganRevenue
            // 
            this.lblUcSloganRevenue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUcSloganRevenue.AutoSize = true;
            this.lblUcSloganRevenue.BackColor = System.Drawing.Color.White;
            this.lblUcSloganRevenue.Font = new System.Drawing.Font("Calibri Light", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUcSloganRevenue.Location = new System.Drawing.Point(459, 81);
            this.lblUcSloganRevenue.Name = "lblUcSloganRevenue";
            this.lblUcSloganRevenue.Size = new System.Drawing.Size(171, 21);
            this.lblUcSloganRevenue.TabIndex = 2;
            this.lblUcSloganRevenue.Text = "_Strength in Numbers_";
            // 
            // lblRevenue
            // 
            this.lblRevenue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRevenue.AutoSize = true;
            this.lblRevenue.BackColor = System.Drawing.Color.White;
            this.lblRevenue.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRevenue.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblRevenue.Location = new System.Drawing.Point(404, 41);
            this.lblRevenue.Name = "lblRevenue";
            this.lblRevenue.Size = new System.Drawing.Size(280, 40);
            this.lblRevenue.TabIndex = 1;
            this.lblRevenue.Text = "Company\'s Finance";
            this.lblRevenue.Click += new System.EventHandler(this.lblRevenue_Click);
            // 
            // ucRevenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlUcRevenue);
            this.Name = "ucRevenue";
            this.Size = new System.Drawing.Size(927, 154);
            this.pnlUcRevenue.ResumeLayout(false);
            this.pnlUcRevenue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUcRevenue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlUcRevenue;
        private Guna.UI2.WinForms.Guna2PictureBox picUcRevenue;
        private System.Windows.Forms.Label lblUcSloganRevenue;
        private System.Windows.Forms.Label lblRevenue;
    }
}
