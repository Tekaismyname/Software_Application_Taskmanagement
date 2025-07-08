namespace TaskManagement
{
    partial class TaskCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskCard));
            this.picDelete = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblTimeline = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblNumMembers = new System.Windows.Forms.Label();
            this.lblTaskSprint = new System.Windows.Forms.Label();
            this.lblTaskproject = new System.Windows.Forms.Label();
            this.lblDetails = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // picDelete
            // 
            this.picDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picDelete.Image = ((System.Drawing.Image)(resources.GetObject("picDelete.Image")));
            this.picDelete.ImageRotate = 0F;
            this.picDelete.Location = new System.Drawing.Point(377, 44);
            this.picDelete.Name = "picDelete";
            this.picDelete.Size = new System.Drawing.Size(30, 30);
            this.picDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDelete.TabIndex = 16;
            this.picDelete.TabStop = false;
            // 
            // lblTimeline
            // 
            this.lblTimeline.Location = new System.Drawing.Point(3, 263);
            this.lblTimeline.Name = "lblTimeline";
            this.lblTimeline.Size = new System.Drawing.Size(264, 23);
            this.lblTimeline.TabIndex = 13;
            this.lblTimeline.Text = "Timeline;";
            // 
            // lblDescription
            // 
            this.lblDescription.Location = new System.Drawing.Point(3, 97);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(238, 134);
            this.lblDescription.TabIndex = 12;
            this.lblDescription.Text = "Description:";
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(-3, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(422, 41);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "Task Name";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNumMembers
            // 
            this.lblNumMembers.Location = new System.Drawing.Point(3, 240);
            this.lblNumMembers.Name = "lblNumMembers";
            this.lblNumMembers.Size = new System.Drawing.Size(274, 23);
            this.lblNumMembers.TabIndex = 17;
            this.lblNumMembers.Text = "Members:";
            // 
            // lblTaskSprint
            // 
            this.lblTaskSprint.Location = new System.Drawing.Point(3, 74);
            this.lblTaskSprint.Name = "lblTaskSprint";
            this.lblTaskSprint.Size = new System.Drawing.Size(80, 23);
            this.lblTaskSprint.TabIndex = 18;
            this.lblTaskSprint.Text = "Sprint: ";
            // 
            // lblTaskproject
            // 
            this.lblTaskproject.Location = new System.Drawing.Point(3, 51);
            this.lblTaskproject.Name = "lblTaskproject";
            this.lblTaskproject.Size = new System.Drawing.Size(80, 23);
            this.lblTaskproject.TabIndex = 19;
            this.lblTaskproject.Text = "Project:";
            this.lblTaskproject.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblDetails
            // 
            this.lblDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblDetails.Location = new System.Drawing.Point(3, 299);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(60, 23);
            this.lblDetails.TabIndex = 20;
            this.lblDetails.Text = "Details";
            // 
            // TaskCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblDetails);
            this.Controls.Add(this.lblTaskproject);
            this.Controls.Add(this.lblTaskSprint);
            this.Controls.Add(this.lblNumMembers);
            this.Controls.Add(this.picDelete);
            this.Controls.Add(this.lblTimeline);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblTitle);
            this.Name = "TaskCard";
            this.Size = new System.Drawing.Size(420, 330);
            ((System.ComponentModel.ISupportInitialize)(this.picDelete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2PictureBox picDelete;
        private System.Windows.Forms.Label lblTimeline;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblNumMembers;
        private System.Windows.Forms.Label lblTaskSprint;
        private System.Windows.Forms.Label lblTaskproject;
        private System.Windows.Forms.Label lblDetails;
    }
}
