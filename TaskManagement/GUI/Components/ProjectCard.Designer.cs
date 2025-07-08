namespace TaskManagement
{
    partial class ProjectCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectCard));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblNumSprints = new System.Windows.Forms.Label();
            this.lblNumMembers = new System.Windows.Forms.Label();
            this.lblDept = new System.Windows.Forms.Label();
            this.lblTimeline = new System.Windows.Forms.Label();
            this.lblViewSprints = new System.Windows.Forms.Label();
            this.lblDetails = new System.Windows.Forms.Label();
            this.picDelete = new Guna.UI2.WinForms.Guna2PictureBox();
            this.picAddSprint = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAddSprint)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTitle.Location = new System.Drawing.Point(-3, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(283, 41);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Project Name";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNumSprints
            // 
            this.lblNumSprints.Location = new System.Drawing.Point(3, 50);
            this.lblNumSprints.Name = "lblNumSprints";
            this.lblNumSprints.Size = new System.Drawing.Size(137, 23);
            this.lblNumSprints.TabIndex = 1;
            this.lblNumSprints.Text = "Number of Sprints: ";
            // 
            // lblNumMembers
            // 
            this.lblNumMembers.Location = new System.Drawing.Point(3, 73);
            this.lblNumMembers.Name = "lblNumMembers";
            this.lblNumMembers.Size = new System.Drawing.Size(137, 23);
            this.lblNumMembers.TabIndex = 2;
            this.lblNumMembers.Text = "Members:";
            // 
            // lblDept
            // 
            this.lblDept.Location = new System.Drawing.Point(3, 96);
            this.lblDept.Name = "lblDept";
            this.lblDept.Size = new System.Drawing.Size(161, 23);
            this.lblDept.TabIndex = 3;
            this.lblDept.Text = "Department:";
            // 
            // lblTimeline
            // 
            this.lblTimeline.Location = new System.Drawing.Point(3, 119);
            this.lblTimeline.Name = "lblTimeline";
            this.lblTimeline.Size = new System.Drawing.Size(274, 23);
            this.lblTimeline.TabIndex = 4;
            this.lblTimeline.Text = "Timeline;";
            // 
            // lblViewSprints
            // 
            this.lblViewSprints.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblViewSprints.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewSprints.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblViewSprints.Location = new System.Drawing.Point(157, 167);
            this.lblViewSprints.Name = "lblViewSprints";
            this.lblViewSprints.Size = new System.Drawing.Size(120, 23);
            this.lblViewSprints.TabIndex = 5;
            this.lblViewSprints.Text = "View sprints >>>";
            // 
            // lblDetails
            // 
            this.lblDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblDetails.Location = new System.Drawing.Point(3, 167);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(60, 23);
            this.lblDetails.TabIndex = 6;
            this.lblDetails.Text = "Details";
            // 
            // picDelete
            // 
            this.picDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picDelete.Image = ((System.Drawing.Image)(resources.GetObject("picDelete.Image")));
            this.picDelete.ImageRotate = 0F;
            this.picDelete.Location = new System.Drawing.Point(234, 43);
            this.picDelete.Name = "picDelete";
            this.picDelete.Size = new System.Drawing.Size(30, 30);
            this.picDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDelete.TabIndex = 7;
            this.picDelete.TabStop = false;
            // 
            // picAddSprint
            // 
            this.picAddSprint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picAddSprint.Image = ((System.Drawing.Image)(resources.GetObject("picAddSprint.Image")));
            this.picAddSprint.ImageRotate = 0F;
            this.picAddSprint.Location = new System.Drawing.Point(198, 43);
            this.picAddSprint.Name = "picAddSprint";
            this.picAddSprint.Size = new System.Drawing.Size(30, 30);
            this.picAddSprint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAddSprint.TabIndex = 8;
            this.picAddSprint.TabStop = false;
            // 
            // ProjectCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.picAddSprint);
            this.Controls.Add(this.picDelete);
            this.Controls.Add(this.lblDetails);
            this.Controls.Add(this.lblViewSprints);
            this.Controls.Add(this.lblTimeline);
            this.Controls.Add(this.lblDept);
            this.Controls.Add(this.lblNumMembers);
            this.Controls.Add(this.lblNumSprints);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(50);
            this.Name = "ProjectCard";
            this.Size = new System.Drawing.Size(276, 196);
            ((System.ComponentModel.ISupportInitialize)(this.picDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAddSprint)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblNumSprints;
        private System.Windows.Forms.Label lblNumMembers;
        private System.Windows.Forms.Label lblDept;
        private System.Windows.Forms.Label lblTimeline;
        private System.Windows.Forms.Label lblViewSprints;
        private System.Windows.Forms.Label lblDetails;
        private Guna.UI2.WinForms.Guna2PictureBox picDelete;
        private Guna.UI2.WinForms.Guna2PictureBox picAddSprint;
    }
}
