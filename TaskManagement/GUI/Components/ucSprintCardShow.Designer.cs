namespace TaskManagement
{
    partial class ucSprintCardShow
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
            this.flpSprintCards = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flpSprintCards
            // 
            this.flpSprintCards.AutoScroll = true;
            this.flpSprintCards.BackColor = System.Drawing.Color.White;
            this.flpSprintCards.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpSprintCards.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpSprintCards.Location = new System.Drawing.Point(0, 0);
            this.flpSprintCards.Name = "flpSprintCards";
            this.flpSprintCards.Size = new System.Drawing.Size(906, 525);
            this.flpSprintCards.TabIndex = 6;
            this.flpSprintCards.WrapContents = false;
            // 
            // ucSprintCardShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flpSprintCards);
            this.Name = "ucSprintCardShow";
            this.Size = new System.Drawing.Size(906, 525);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpSprintCards;
    }
}
