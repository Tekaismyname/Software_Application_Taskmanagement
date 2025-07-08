namespace TaskManagement
{
    partial class ucTaskCardShow
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
            this.flpTaskCards = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flpTaskCards
            // 
            this.flpTaskCards.BackColor = System.Drawing.SystemColors.ControlDark;
            this.flpTaskCards.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpTaskCards.Location = new System.Drawing.Point(0, 0);
            this.flpTaskCards.Name = "flpTaskCards";
            this.flpTaskCards.Size = new System.Drawing.Size(906, 525);
            this.flpTaskCards.TabIndex = 0;
            // 
            // ucTaskCardShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flpTaskCards);
            this.Name = "ucTaskCardShow";
            this.Size = new System.Drawing.Size(906, 525);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpTaskCards;
    }
}
