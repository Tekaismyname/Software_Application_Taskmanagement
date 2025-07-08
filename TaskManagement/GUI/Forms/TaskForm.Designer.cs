namespace TaskManagement
{
    partial class TaskForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlCrudTask = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.chkTaskStatus = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.lblTaskStatus = new System.Windows.Forms.Label();
            this.lblSprintIDName = new System.Windows.Forms.Label();
            this.lblTaskID = new System.Windows.Forms.Label();
            this.txtTaskId = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTaskBacklog = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTaskBacklog = new System.Windows.Forms.Label();
            this.clbTaskUsers = new System.Windows.Forms.CheckedListBox();
            this.btnEditTask = new Guna.UI2.WinForms.Guna2GradientButton();
            this.dtpTaskEnd = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpTaskStart = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtTaskName = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAddTask = new Guna.UI2.WinForms.Guna2GradientButton();
            this.lblSprintID = new System.Windows.Forms.Label();
            this.lnlTaskEnd = new System.Windows.Forms.Label();
            this.lblSprintStart = new System.Windows.Forms.Label();
            this.lblTaskAssigned = new System.Windows.Forms.Label();
            this.lblTaskName = new System.Windows.Forms.Label();
            this.lblTaskIdTheme = new System.Windows.Forms.Label();
            this.lblTaskTitle = new System.Windows.Forms.Label();
            this.pnlCrudTask.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCrudTask
            // 
            this.pnlCrudTask.Controls.Add(this.chkTaskStatus);
            this.pnlCrudTask.Controls.Add(this.lblTaskStatus);
            this.pnlCrudTask.Controls.Add(this.lblSprintIDName);
            this.pnlCrudTask.Controls.Add(this.lblTaskID);
            this.pnlCrudTask.Controls.Add(this.txtTaskId);
            this.pnlCrudTask.Controls.Add(this.txtTaskBacklog);
            this.pnlCrudTask.Controls.Add(this.lblTaskBacklog);
            this.pnlCrudTask.Controls.Add(this.clbTaskUsers);
            this.pnlCrudTask.Controls.Add(this.btnEditTask);
            this.pnlCrudTask.Controls.Add(this.dtpTaskEnd);
            this.pnlCrudTask.Controls.Add(this.dtpTaskStart);
            this.pnlCrudTask.Controls.Add(this.txtTaskName);
            this.pnlCrudTask.Controls.Add(this.btnAddTask);
            this.pnlCrudTask.Controls.Add(this.lblSprintID);
            this.pnlCrudTask.Controls.Add(this.lnlTaskEnd);
            this.pnlCrudTask.Controls.Add(this.lblSprintStart);
            this.pnlCrudTask.Controls.Add(this.lblTaskAssigned);
            this.pnlCrudTask.Controls.Add(this.lblTaskName);
            this.pnlCrudTask.Controls.Add(this.lblTaskIdTheme);
            this.pnlCrudTask.Controls.Add(this.lblTaskTitle);
            this.pnlCrudTask.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCrudTask.FillColor = System.Drawing.Color.White;
            this.pnlCrudTask.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlCrudTask.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.pnlCrudTask.Location = new System.Drawing.Point(0, 0);
            this.pnlCrudTask.Name = "pnlCrudTask";
            this.pnlCrudTask.Size = new System.Drawing.Size(782, 853);
            this.pnlCrudTask.TabIndex = 2;
            // 
            // chkTaskStatus
            // 
            this.chkTaskStatus.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkTaskStatus.CheckedState.BorderRadius = 2;
            this.chkTaskStatus.CheckedState.BorderThickness = 0;
            this.chkTaskStatus.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkTaskStatus.Location = new System.Drawing.Point(305, 382);
            this.chkTaskStatus.Name = "chkTaskStatus";
            this.chkTaskStatus.Size = new System.Drawing.Size(36, 36);
            this.chkTaskStatus.TabIndex = 39;
            this.chkTaskStatus.Text = "guna2CustomCheckBox1";
            this.chkTaskStatus.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkTaskStatus.UncheckedState.BorderRadius = 2;
            this.chkTaskStatus.UncheckedState.BorderThickness = 0;
            this.chkTaskStatus.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // lblTaskStatus
            // 
            this.lblTaskStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblTaskStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTaskStatus.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskStatus.Location = new System.Drawing.Point(150, 382);
            this.lblTaskStatus.Name = "lblTaskStatus";
            this.lblTaskStatus.Size = new System.Drawing.Size(149, 36);
            this.lblTaskStatus.TabIndex = 38;
            this.lblTaskStatus.Text = "Status:";
            this.lblTaskStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSprintIDName
            // 
            this.lblSprintIDName.BackColor = System.Drawing.Color.White;
            this.lblSprintIDName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSprintIDName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSprintIDName.ForeColor = System.Drawing.Color.Black;
            this.lblSprintIDName.Location = new System.Drawing.Point(305, 140);
            this.lblSprintIDName.Name = "lblSprintIDName";
            this.lblSprintIDName.Size = new System.Drawing.Size(307, 36);
            this.lblSprintIDName.TabIndex = 37;
            this.lblSprintIDName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTaskID
            // 
            this.lblTaskID.BackColor = System.Drawing.Color.White;
            this.lblTaskID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTaskID.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskID.ForeColor = System.Drawing.Color.Black;
            this.lblTaskID.Location = new System.Drawing.Point(305, 196);
            this.lblTaskID.Name = "lblTaskID";
            this.lblTaskID.Size = new System.Drawing.Size(307, 36);
            this.lblTaskID.TabIndex = 36;
            this.lblTaskID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTaskId
            // 
            this.txtTaskId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtTaskId.BorderRadius = 10;
            this.txtTaskId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTaskId.DefaultText = "";
            this.txtTaskId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTaskId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTaskId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTaskId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTaskId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTaskId.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTaskId.ForeColor = System.Drawing.Color.Black;
            this.txtTaskId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTaskId.Location = new System.Drawing.Point(305, 196);
            this.txtTaskId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTaskId.Name = "txtTaskId";
            this.txtTaskId.PlaceholderText = "";
            this.txtTaskId.SelectedText = "";
            this.txtTaskId.Size = new System.Drawing.Size(307, 36);
            this.txtTaskId.TabIndex = 32;
            // 
            // txtTaskBacklog
            // 
            this.txtTaskBacklog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtTaskBacklog.BorderRadius = 10;
            this.txtTaskBacklog.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTaskBacklog.DefaultText = "";
            this.txtTaskBacklog.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTaskBacklog.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTaskBacklog.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTaskBacklog.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTaskBacklog.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTaskBacklog.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTaskBacklog.ForeColor = System.Drawing.Color.Black;
            this.txtTaskBacklog.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTaskBacklog.Location = new System.Drawing.Point(305, 320);
            this.txtTaskBacklog.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTaskBacklog.Name = "txtTaskBacklog";
            this.txtTaskBacklog.PlaceholderText = "";
            this.txtTaskBacklog.SelectedText = "";
            this.txtTaskBacklog.Size = new System.Drawing.Size(307, 36);
            this.txtTaskBacklog.TabIndex = 34;
            // 
            // lblTaskBacklog
            // 
            this.lblTaskBacklog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblTaskBacklog.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTaskBacklog.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskBacklog.Location = new System.Drawing.Point(150, 320);
            this.lblTaskBacklog.Name = "lblTaskBacklog";
            this.lblTaskBacklog.Size = new System.Drawing.Size(149, 36);
            this.lblTaskBacklog.TabIndex = 29;
            this.lblTaskBacklog.Text = "Backlog:";
            this.lblTaskBacklog.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clbTaskUsers
            // 
            this.clbTaskUsers.FormattingEnabled = true;
            this.clbTaskUsers.Location = new System.Drawing.Point(305, 454);
            this.clbTaskUsers.Name = "clbTaskUsers";
            this.clbTaskUsers.Size = new System.Drawing.Size(307, 174);
            this.clbTaskUsers.TabIndex = 26;
            // 
            // btnEditTask
            // 
            this.btnEditTask.BorderRadius = 10;
            this.btnEditTask.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEditTask.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEditTask.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEditTask.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEditTask.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEditTask.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.btnEditTask.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnEditTask.ForeColor = System.Drawing.Color.White;
            this.btnEditTask.Location = new System.Drawing.Point(305, 796);
            this.btnEditTask.Name = "btnEditTask";
            this.btnEditTask.Size = new System.Drawing.Size(180, 45);
            this.btnEditTask.TabIndex = 23;
            this.btnEditTask.Text = "Edit";
            // 
            // dtpTaskEnd
            // 
            this.dtpTaskEnd.Checked = true;
            this.dtpTaskEnd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpTaskEnd.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpTaskEnd.Location = new System.Drawing.Point(305, 703);
            this.dtpTaskEnd.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpTaskEnd.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpTaskEnd.Name = "dtpTaskEnd";
            this.dtpTaskEnd.Size = new System.Drawing.Size(307, 36);
            this.dtpTaskEnd.TabIndex = 22;
            this.dtpTaskEnd.Value = new System.DateTime(2025, 6, 17, 20, 25, 55, 408);
            // 
            // dtpTaskStart
            // 
            this.dtpTaskStart.Checked = true;
            this.dtpTaskStart.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpTaskStart.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpTaskStart.Location = new System.Drawing.Point(305, 643);
            this.dtpTaskStart.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpTaskStart.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpTaskStart.Name = "dtpTaskStart";
            this.dtpTaskStart.Size = new System.Drawing.Size(307, 36);
            this.dtpTaskStart.TabIndex = 21;
            this.dtpTaskStart.Value = new System.DateTime(2025, 6, 17, 20, 25, 55, 408);
            // 
            // txtTaskName
            // 
            this.txtTaskName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtTaskName.BorderRadius = 10;
            this.txtTaskName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTaskName.DefaultText = "";
            this.txtTaskName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTaskName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTaskName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTaskName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTaskName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTaskName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTaskName.ForeColor = System.Drawing.Color.Black;
            this.txtTaskName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTaskName.Location = new System.Drawing.Point(305, 257);
            this.txtTaskName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTaskName.Name = "txtTaskName";
            this.txtTaskName.PlaceholderText = "";
            this.txtTaskName.SelectedText = "";
            this.txtTaskName.Size = new System.Drawing.Size(307, 36);
            this.txtTaskName.TabIndex = 33;
            // 
            // btnAddTask
            // 
            this.btnAddTask.BorderRadius = 10;
            this.btnAddTask.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddTask.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddTask.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddTask.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddTask.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddTask.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.btnAddTask.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnAddTask.ForeColor = System.Drawing.Color.White;
            this.btnAddTask.Location = new System.Drawing.Point(305, 796);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(180, 45);
            this.btnAddTask.TabIndex = 10;
            this.btnAddTask.Text = "Add";
            // 
            // lblSprintID
            // 
            this.lblSprintID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblSprintID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSprintID.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSprintID.Location = new System.Drawing.Point(150, 140);
            this.lblSprintID.Name = "lblSprintID";
            this.lblSprintID.Size = new System.Drawing.Size(149, 36);
            this.lblSprintID.TabIndex = 9;
            this.lblSprintID.Text = "SprintID:";
            this.lblSprintID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lnlTaskEnd
            // 
            this.lnlTaskEnd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lnlTaskEnd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lnlTaskEnd.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnlTaskEnd.Location = new System.Drawing.Point(150, 703);
            this.lnlTaskEnd.Name = "lnlTaskEnd";
            this.lnlTaskEnd.Size = new System.Drawing.Size(149, 36);
            this.lnlTaskEnd.TabIndex = 8;
            this.lnlTaskEnd.Text = "End:";
            this.lnlTaskEnd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSprintStart
            // 
            this.lblSprintStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblSprintStart.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSprintStart.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSprintStart.Location = new System.Drawing.Point(150, 643);
            this.lblSprintStart.Name = "lblSprintStart";
            this.lblSprintStart.Size = new System.Drawing.Size(149, 36);
            this.lblSprintStart.TabIndex = 7;
            this.lblSprintStart.Text = "Start:";
            this.lblSprintStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTaskAssigned
            // 
            this.lblTaskAssigned.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblTaskAssigned.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTaskAssigned.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskAssigned.Location = new System.Drawing.Point(150, 456);
            this.lblTaskAssigned.Name = "lblTaskAssigned";
            this.lblTaskAssigned.Size = new System.Drawing.Size(149, 36);
            this.lblTaskAssigned.TabIndex = 4;
            this.lblTaskAssigned.Text = "Assign to:";
            this.lblTaskAssigned.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTaskName
            // 
            this.lblTaskName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblTaskName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTaskName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskName.Location = new System.Drawing.Point(150, 257);
            this.lblTaskName.Name = "lblTaskName";
            this.lblTaskName.Size = new System.Drawing.Size(149, 36);
            this.lblTaskName.TabIndex = 3;
            this.lblTaskName.Text = "Task Name:";
            this.lblTaskName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTaskIdTheme
            // 
            this.lblTaskIdTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblTaskIdTheme.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTaskIdTheme.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskIdTheme.Location = new System.Drawing.Point(150, 196);
            this.lblTaskIdTheme.Name = "lblTaskIdTheme";
            this.lblTaskIdTheme.Size = new System.Drawing.Size(149, 36);
            this.lblTaskIdTheme.TabIndex = 2;
            this.lblTaskIdTheme.Text = "TaskID:";
            this.lblTaskIdTheme.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTaskTitle
            // 
            this.lblTaskTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTaskTitle.BackColor = System.Drawing.Color.White;
            this.lblTaskTitle.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskTitle.Location = new System.Drawing.Point(202, 52);
            this.lblTaskTitle.Name = "lblTaskTitle";
            this.lblTaskTitle.Size = new System.Drawing.Size(410, 60);
            this.lblTaskTitle.TabIndex = 0;
            this.lblTaskTitle.Text = "Tasks";
            this.lblTaskTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 853);
            this.Controls.Add(this.pnlCrudTask);
            this.Name = "TaskForm";
            this.Text = "TaskForm";
            this.pnlCrudTask.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel pnlCrudTask;
        private System.Windows.Forms.Label lblSprintIDName;
        private System.Windows.Forms.Label lblTaskID;
        private Guna.UI2.WinForms.Guna2TextBox txtTaskId;
        private Guna.UI2.WinForms.Guna2TextBox txtTaskBacklog;
        private System.Windows.Forms.Label lblTaskBacklog;
        private System.Windows.Forms.CheckedListBox clbTaskUsers;
        private Guna.UI2.WinForms.Guna2GradientButton btnEditTask;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpTaskEnd;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpTaskStart;
        private Guna.UI2.WinForms.Guna2TextBox txtTaskName;
        private Guna.UI2.WinForms.Guna2GradientButton btnAddTask;
        private System.Windows.Forms.Label lblSprintID;
        private System.Windows.Forms.Label lnlTaskEnd;
        private System.Windows.Forms.Label lblSprintStart;
        private System.Windows.Forms.Label lblTaskAssigned;
        private System.Windows.Forms.Label lblTaskName;
        private System.Windows.Forms.Label lblTaskIdTheme;
        private System.Windows.Forms.Label lblTaskTitle;
        private Guna.UI2.WinForms.Guna2CustomCheckBox chkTaskStatus;
        private System.Windows.Forms.Label lblTaskStatus;
    }
}