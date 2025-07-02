namespace TaskManagement
{
    partial class ucProjectShowDashboard
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
            this.pnlProjectShowDashboard = new Guna.UI2.WinForms.Guna2Panel();
            this.adgvProjectDashboard = new Zuby.ADGV.AdvancedDataGridView();
            this.pnlProjectShowDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adgvProjectDashboard)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlProjectShowDashboard
            // 
            this.pnlProjectShowDashboard.BackColor = System.Drawing.Color.White;
            this.pnlProjectShowDashboard.BorderColor = System.Drawing.Color.White;
            this.pnlProjectShowDashboard.BorderRadius = 10;
            this.pnlProjectShowDashboard.BorderThickness = 2;
            this.pnlProjectShowDashboard.Controls.Add(this.adgvProjectDashboard);
            this.pnlProjectShowDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlProjectShowDashboard.Location = new System.Drawing.Point(0, 0);
            this.pnlProjectShowDashboard.Name = "pnlProjectShowDashboard";
            this.pnlProjectShowDashboard.Size = new System.Drawing.Size(918, 585);
            this.pnlProjectShowDashboard.TabIndex = 0;
            // 
            // adgvProjectDashboard
            // 
            this.adgvProjectDashboard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.adgvProjectDashboard.BackgroundColor = System.Drawing.Color.White;
            this.adgvProjectDashboard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adgvProjectDashboard.FilterAndSortEnabled = true;
            this.adgvProjectDashboard.Location = new System.Drawing.Point(3, 3);
            this.adgvProjectDashboard.Name = "adgvProjectDashboard";
            this.adgvProjectDashboard.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.adgvProjectDashboard.RowHeadersWidth = 51;
            this.adgvProjectDashboard.RowTemplate.Height = 24;
            this.adgvProjectDashboard.Size = new System.Drawing.Size(908, 575);
            this.adgvProjectDashboard.TabIndex = 0;
            // 
            // ucProjectShowDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.pnlProjectShowDashboard);
            this.Name = "ucProjectShowDashboard";
            this.Size = new System.Drawing.Size(918, 585);
            this.pnlProjectShowDashboard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.adgvProjectDashboard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlProjectShowDashboard;
        private Zuby.ADGV.AdvancedDataGridView adgvProjectDashboard;
    }
}
