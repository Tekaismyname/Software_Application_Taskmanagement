namespace TaskManagement
{
    partial class ucProjectCardShow
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
            this.flpProjectCards = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flpProjectCards
            // 
            this.flpProjectCards.AutoScroll = true;
            this.flpProjectCards.BackColor = System.Drawing.Color.White;
            this.flpProjectCards.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpProjectCards.Location = new System.Drawing.Point(0, 0);
            this.flpProjectCards.Name = "flpProjectCards";
            this.flpProjectCards.Size = new System.Drawing.Size(906, 525);
            this.flpProjectCards.TabIndex = 5;
            // 
            // ucProjectCardShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flpProjectCards);
            this.Name = "ucProjectCardShow";
            this.Size = new System.Drawing.Size(906, 525);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpProjectCards;
    }
}
