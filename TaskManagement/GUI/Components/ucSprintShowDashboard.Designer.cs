namespace TaskManagement
{
    partial class ucSprintShowDashboard
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
            this.pnlSprintShowDashboard = new Guna.UI2.WinForms.Guna2Panel();
            this.adgvSprintDashboard = new Zuby.ADGV.AdvancedDataGridView();
            this.pnlSprintShowDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adgvSprintDashboard)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSprintShowDashboard
            // 
            this.pnlSprintShowDashboard.BackColor = System.Drawing.Color.White;
            this.pnlSprintShowDashboard.Controls.Add(this.adgvSprintDashboard);
            this.pnlSprintShowDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSprintShowDashboard.Location = new System.Drawing.Point(0, 0);
            this.pnlSprintShowDashboard.Name = "pnlSprintShowDashboard";
            this.pnlSprintShowDashboard.Size = new System.Drawing.Size(918, 585);
            this.pnlSprintShowDashboard.TabIndex = 0;
            // 
            // adgvSprintDashboard
            // 
            this.adgvSprintDashboard.BackgroundColor = System.Drawing.Color.White;
            this.adgvSprintDashboard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adgvSprintDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adgvSprintDashboard.FilterAndSortEnabled = true;
            this.adgvSprintDashboard.Location = new System.Drawing.Point(0, 0);
            this.adgvSprintDashboard.Name = "adgvSprintDashboard";
            this.adgvSprintDashboard.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.adgvSprintDashboard.RowHeadersWidth = 51;
            this.adgvSprintDashboard.RowTemplate.Height = 24;
            this.adgvSprintDashboard.Size = new System.Drawing.Size(918, 585);
            this.adgvSprintDashboard.TabIndex = 0;
            // 
            // ucSprintShowDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlSprintShowDashboard);
            this.Name = "ucSprintShowDashboard";
            this.Size = new System.Drawing.Size(918, 585);
            this.pnlSprintShowDashboard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.adgvSprintDashboard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlSprintShowDashboard;
        private Zuby.ADGV.AdvancedDataGridView adgvSprintDashboard;
    }
}
