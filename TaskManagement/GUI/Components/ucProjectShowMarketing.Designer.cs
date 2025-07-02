namespace TaskManagement
{
    partial class ucProjectShowMarketing
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
            this.pnlProjectShowMarketing = new Guna.UI2.WinForms.Guna2Panel();
            this.adgvProjectShowMarketing = new Zuby.ADGV.AdvancedDataGridView();
            this.pnlProjectShowMarketing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adgvProjectShowMarketing)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlProjectShowMarketing
            // 
            this.pnlProjectShowMarketing.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlProjectShowMarketing.Controls.Add(this.adgvProjectShowMarketing);
            this.pnlProjectShowMarketing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlProjectShowMarketing.Location = new System.Drawing.Point(0, 0);
            this.pnlProjectShowMarketing.Name = "pnlProjectShowMarketing";
            this.pnlProjectShowMarketing.Size = new System.Drawing.Size(918, 585);
            this.pnlProjectShowMarketing.TabIndex = 0;
            // 
            // adgvProjectShowMarketing
            // 
            this.adgvProjectShowMarketing.BackgroundColor = System.Drawing.Color.White;
            this.adgvProjectShowMarketing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adgvProjectShowMarketing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adgvProjectShowMarketing.FilterAndSortEnabled = true;
            this.adgvProjectShowMarketing.Location = new System.Drawing.Point(0, 0);
            this.adgvProjectShowMarketing.Name = "adgvProjectShowMarketing";
            this.adgvProjectShowMarketing.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.adgvProjectShowMarketing.RowHeadersWidth = 51;
            this.adgvProjectShowMarketing.RowTemplate.Height = 24;
            this.adgvProjectShowMarketing.Size = new System.Drawing.Size(918, 585);
            this.adgvProjectShowMarketing.TabIndex = 0;
            // 
            // ucProjectShowMarketing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlProjectShowMarketing);
            this.Name = "ucProjectShowMarketing";
            this.Size = new System.Drawing.Size(918, 585);
            this.Load += new System.EventHandler(this.ucProjectShowMarketing_Load);
            this.pnlProjectShowMarketing.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.adgvProjectShowMarketing)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlProjectShowMarketing;
        private Zuby.ADGV.AdvancedDataGridView adgvProjectShowMarketing;
    }
}
