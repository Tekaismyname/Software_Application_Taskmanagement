namespace TaskManagement
{
    partial class DetailShow
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
            this.pnlProjectDetail = new Guna.UI2.WinForms.Guna2Panel();
            this.ucProjectShowDashboard1 = new TaskManagement.ucProjectShowDashboard();
            this.ucSprintShowDashboard1 = new TaskManagement.ucSprintShowDashboard();
            this.pnlProjectDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlProjectDetail
            // 
            this.pnlProjectDetail.Controls.Add(this.ucSprintShowDashboard1);
            this.pnlProjectDetail.Controls.Add(this.ucProjectShowDashboard1);
            this.pnlProjectDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlProjectDetail.Location = new System.Drawing.Point(0, 0);
            this.pnlProjectDetail.Name = "pnlProjectDetail";
            this.pnlProjectDetail.Size = new System.Drawing.Size(1662, 589);
            this.pnlProjectDetail.TabIndex = 0;
            // 
            // ucProjectShowDashboard1
            // 
            this.ucProjectShowDashboard1.BackColor = System.Drawing.Color.Gray;
            this.ucProjectShowDashboard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucProjectShowDashboard1.Location = new System.Drawing.Point(0, 0);
            this.ucProjectShowDashboard1.Name = "ucProjectShowDashboard1";
            this.ucProjectShowDashboard1.Size = new System.Drawing.Size(1662, 589);
            this.ucProjectShowDashboard1.TabIndex = 0;
            // 
            // ucSprintShowDashboard1
            // 
            this.ucSprintShowDashboard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucSprintShowDashboard1.Location = new System.Drawing.Point(0, 0);
            this.ucSprintShowDashboard1.Name = "ucSprintShowDashboard1";
            this.ucSprintShowDashboard1.Size = new System.Drawing.Size(1662, 589);
            this.ucSprintShowDashboard1.TabIndex = 1;
            // 
            // DetailShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1662, 589);
            this.Controls.Add(this.pnlProjectDetail);
            this.Name = "DetailShow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DetailedProjectForm";
            this.pnlProjectDetail.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlProjectDetail;
        private ucProjectShowDashboard ucProjectShowDashboard1;
        private ucSprintShowDashboard ucSprintShowDashboard1;
    }
}