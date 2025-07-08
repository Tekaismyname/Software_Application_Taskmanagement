namespace TaskManagement
{
    partial class SprintCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SprintCard));
            this.picAddTask = new Guna.UI2.WinForms.Guna2PictureBox();
            this.picDelete = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblDetails = new System.Windows.Forms.Label();
            this.lblViewTasks = new System.Windows.Forms.Label();
            this.lblTimeline = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblNumMembers = new System.Windows.Forms.Label();
            this.lblNumTasks = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picAddTask)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // picAddTask
            // 
            this.picAddTask.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picAddTask.Image = ((System.Drawing.Image)(resources.GetObject("picAddTask.Image")));
            this.picAddTask.ImageRotate = 0F;
            this.picAddTask.Location = new System.Drawing.Point(1572, 44);
            this.picAddTask.Name = "picAddTask";
            this.picAddTask.Size = new System.Drawing.Size(30, 30);
            this.picAddTask.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAddTask.TabIndex = 17;
            this.picAddTask.TabStop = false;
            // 
            // picDelete
            // 
            this.picDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picDelete.Image = ((System.Drawing.Image)(resources.GetObject("picDelete.Image")));
            this.picDelete.ImageRotate = 0F;
            this.picDelete.Location = new System.Drawing.Point(1608, 44);
            this.picDelete.Name = "picDelete";
            this.picDelete.Size = new System.Drawing.Size(30, 30);
            this.picDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDelete.TabIndex = 16;
            this.picDelete.TabStop = false;
            // 
            // lblDetails
            // 
            this.lblDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblDetails.Location = new System.Drawing.Point(5, 195);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(60, 23);
            this.lblDetails.TabIndex = 15;
            this.lblDetails.Text = "Details";
            // 
            // lblViewTasks
            // 
            this.lblViewTasks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblViewTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewTasks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblViewTasks.Location = new System.Drawing.Point(1545, 197);
            this.lblViewTasks.Name = "lblViewTasks";
            this.lblViewTasks.Size = new System.Drawing.Size(120, 23);
            this.lblViewTasks.TabIndex = 14;
            this.lblViewTasks.Text = "View tasks >>>";
            // 
            // lblTimeline
            // 
            this.lblTimeline.Location = new System.Drawing.Point(5, 124);
            this.lblTimeline.Name = "lblTimeline";
            this.lblTimeline.Size = new System.Drawing.Size(274, 23);
            this.lblTimeline.TabIndex = 13;
            this.lblTimeline.Text = "Timeline;";
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(5, 101);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(161, 23);
            this.lblStatus.TabIndex = 12;
            this.lblStatus.Text = "Status:";
            // 
            // lblNumMembers
            // 
            this.lblNumMembers.Location = new System.Drawing.Point(5, 78);
            this.lblNumMembers.Name = "lblNumMembers";
            this.lblNumMembers.Size = new System.Drawing.Size(137, 23);
            this.lblNumMembers.TabIndex = 11;
            this.lblNumMembers.Text = "Fuck:";
            // 
            // lblNumTasks
            // 
            this.lblNumTasks.Location = new System.Drawing.Point(5, 55);
            this.lblNumTasks.Name = "lblNumTasks";
            this.lblNumTasks.Size = new System.Drawing.Size(137, 23);
            this.lblNumTasks.TabIndex = 10;
            this.lblNumTasks.Text = "Number of Tasks: ";
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(-3, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1655, 41);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "Sprint Name";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SprintCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.picAddTask);
            this.Controls.Add(this.picDelete);
            this.Controls.Add(this.lblDetails);
            this.Controls.Add(this.lblViewTasks);
            this.Controls.Add(this.lblTimeline);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblNumMembers);
            this.Controls.Add(this.lblNumTasks);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(20);
            this.Name = "SprintCard";
            this.Size = new System.Drawing.Size(1650, 218);
            ((System.ComponentModel.ISupportInitialize)(this.picAddTask)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDelete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox picAddTask;
        private Guna.UI2.WinForms.Guna2PictureBox picDelete;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.Label lblViewTasks;
        private System.Windows.Forms.Label lblTimeline;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblNumMembers;
        private System.Windows.Forms.Label lblNumTasks;
        private System.Windows.Forms.Label lblTitle;
    }
}
