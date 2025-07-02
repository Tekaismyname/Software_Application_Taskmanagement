namespace TaskManagement
{
    partial class ucProjectShowCoding
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
            this.pnlProjectShowCoding = new Guna.UI2.WinForms.Guna2Panel();
            this.adgvProjectShowCoding = new Zuby.ADGV.AdvancedDataGridView();
            this.pnlProjectShowCoding.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adgvProjectShowCoding)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlProjectShowCoding
            // 
            this.pnlProjectShowCoding.BackColor = System.Drawing.Color.White;
            this.pnlProjectShowCoding.Controls.Add(this.adgvProjectShowCoding);
            this.pnlProjectShowCoding.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlProjectShowCoding.Location = new System.Drawing.Point(0, 0);
            this.pnlProjectShowCoding.Name = "pnlProjectShowCoding";
            this.pnlProjectShowCoding.Size = new System.Drawing.Size(918, 585);
            this.pnlProjectShowCoding.TabIndex = 0;
            // 
            // adgvProjectShowCoding
            // 
            this.adgvProjectShowCoding.BackgroundColor = System.Drawing.Color.White;
            this.adgvProjectShowCoding.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adgvProjectShowCoding.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adgvProjectShowCoding.FilterAndSortEnabled = true;
            this.adgvProjectShowCoding.Location = new System.Drawing.Point(0, 0);
            this.adgvProjectShowCoding.Name = "adgvProjectShowCoding";
            this.adgvProjectShowCoding.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.adgvProjectShowCoding.RowHeadersWidth = 51;
            this.adgvProjectShowCoding.RowTemplate.Height = 24;
            this.adgvProjectShowCoding.Size = new System.Drawing.Size(918, 585);
            this.adgvProjectShowCoding.TabIndex = 1;
            // 
            // ucProjectShowCoding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlProjectShowCoding);
            this.Name = "ucProjectShowCoding";
            this.Size = new System.Drawing.Size(918, 585);
            this.Load += new System.EventHandler(this.ucProjectShowCoding_Load);
            this.pnlProjectShowCoding.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.adgvProjectShowCoding)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlProjectShowCoding;
        private Zuby.ADGV.AdvancedDataGridView adgvProjectShowCoding;
    }
}
