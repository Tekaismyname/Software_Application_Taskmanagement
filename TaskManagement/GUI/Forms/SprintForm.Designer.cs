namespace TaskManagement
{
    partial class SprintForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SprintForm));
            this.pnlAddProject = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.lblDept = new System.Windows.Forms.Label();
            this.txtSprintIdAdd = new Guna.UI2.WinForms.Guna2TextBox();
            this.cboSprintID = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cboProjectIDName = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtSprintBacklog = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblSprintBacklog = new System.Windows.Forms.Label();
            this.cboDept = new Guna.UI2.WinForms.Guna2ComboBox();
            this.clbSprintUsers = new System.Windows.Forms.CheckedListBox();
            this.btnSprintDelete = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnSprintEdit = new Guna.UI2.WinForms.Guna2GradientButton();
            this.dtpSprintEnd = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpSprintStart = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtSprintName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSprintID = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSprintAdd = new Guna.UI2.WinForms.Guna2GradientButton();
            this.lblProjectID = new System.Windows.Forms.Label();
            this.lblSprintEnd = new System.Windows.Forms.Label();
            this.lblSprintStart = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblSprintAssigned = new System.Windows.Forms.Label();
            this.lblSprintName = new System.Windows.Forms.Label();
            this.lblSprintID = new System.Windows.Forms.Label();
            this.lblSprintTitle = new System.Windows.Forms.Label();
            this.chkSprinStatus = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.pnlAddProject.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAddProject
            // 
            this.pnlAddProject.Controls.Add(this.chkSprinStatus);
            this.pnlAddProject.Controls.Add(this.lblDept);
            this.pnlAddProject.Controls.Add(this.txtSprintIdAdd);
            this.pnlAddProject.Controls.Add(this.cboSprintID);
            this.pnlAddProject.Controls.Add(this.cboProjectIDName);
            this.pnlAddProject.Controls.Add(this.txtSprintBacklog);
            this.pnlAddProject.Controls.Add(this.lblSprintBacklog);
            this.pnlAddProject.Controls.Add(this.cboDept);
            this.pnlAddProject.Controls.Add(this.clbSprintUsers);
            this.pnlAddProject.Controls.Add(this.btnSprintDelete);
            this.pnlAddProject.Controls.Add(this.btnSprintEdit);
            this.pnlAddProject.Controls.Add(this.dtpSprintEnd);
            this.pnlAddProject.Controls.Add(this.dtpSprintStart);
            this.pnlAddProject.Controls.Add(this.txtSprintName);
            this.pnlAddProject.Controls.Add(this.txtSprintID);
            this.pnlAddProject.Controls.Add(this.btnSprintAdd);
            this.pnlAddProject.Controls.Add(this.lblProjectID);
            this.pnlAddProject.Controls.Add(this.lblSprintEnd);
            this.pnlAddProject.Controls.Add(this.lblSprintStart);
            this.pnlAddProject.Controls.Add(this.lblDepartment);
            this.pnlAddProject.Controls.Add(this.lblSprintAssigned);
            this.pnlAddProject.Controls.Add(this.lblSprintName);
            this.pnlAddProject.Controls.Add(this.lblSprintID);
            this.pnlAddProject.Controls.Add(this.lblSprintTitle);
            this.pnlAddProject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAddProject.FillColor = System.Drawing.Color.White;
            this.pnlAddProject.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlAddProject.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.pnlAddProject.Location = new System.Drawing.Point(0, 0);
            this.pnlAddProject.Name = "pnlAddProject";
            this.pnlAddProject.Size = new System.Drawing.Size(782, 853);
            this.pnlAddProject.TabIndex = 1;
            // 
            // lblDept
            // 
            this.lblDept.BackColor = System.Drawing.Color.White;
            this.lblDept.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDept.ForeColor = System.Drawing.Color.Black;
            this.lblDept.Location = new System.Drawing.Point(305, 582);
            this.lblDept.Name = "lblDept";
            this.lblDept.Size = new System.Drawing.Size(307, 36);
            this.lblDept.TabIndex = 34;
            this.lblDept.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSprintIdAdd
            // 
            this.txtSprintIdAdd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSprintIdAdd.DefaultText = "";
            this.txtSprintIdAdd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSprintIdAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSprintIdAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSprintIdAdd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSprintIdAdd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSprintIdAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSprintIdAdd.ForeColor = System.Drawing.Color.Black;
            this.txtSprintIdAdd.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSprintIdAdd.Location = new System.Drawing.Point(305, 196);
            this.txtSprintIdAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSprintIdAdd.Name = "txtSprintIdAdd";
            this.txtSprintIdAdd.PlaceholderText = "";
            this.txtSprintIdAdd.SelectedText = "";
            this.txtSprintIdAdd.Size = new System.Drawing.Size(307, 36);
            this.txtSprintIdAdd.TabIndex = 32;
            // 
            // cboSprintID
            // 
            this.cboSprintID.BackColor = System.Drawing.Color.Transparent;
            this.cboSprintID.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboSprintID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSprintID.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboSprintID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboSprintID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboSprintID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboSprintID.ItemHeight = 30;
            this.cboSprintID.Location = new System.Drawing.Point(305, 196);
            this.cboSprintID.Name = "cboSprintID";
            this.cboSprintID.Size = new System.Drawing.Size(307, 36);
            this.cboSprintID.TabIndex = 32;
            this.cboSprintID.SelectedIndexChanged += new System.EventHandler(this.cboSprintID_SelectedIndexChanged);
            // 
            // cboProjectIDName
            // 
            this.cboProjectIDName.BackColor = System.Drawing.Color.Transparent;
            this.cboProjectIDName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboProjectIDName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProjectIDName.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboProjectIDName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboProjectIDName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboProjectIDName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboProjectIDName.ItemHeight = 30;
            this.cboProjectIDName.Location = new System.Drawing.Point(305, 140);
            this.cboProjectIDName.Name = "cboProjectIDName";
            this.cboProjectIDName.Size = new System.Drawing.Size(307, 36);
            this.cboProjectIDName.TabIndex = 31;
            this.cboProjectIDName.SelectedIndexChanged += new System.EventHandler(this.cboProjectIDName_SelectedIndexChanged);
            // 
            // txtSprintBacklog
            // 
            this.txtSprintBacklog.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSprintBacklog.DefaultText = "";
            this.txtSprintBacklog.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSprintBacklog.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSprintBacklog.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSprintBacklog.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSprintBacklog.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSprintBacklog.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSprintBacklog.ForeColor = System.Drawing.Color.Black;
            this.txtSprintBacklog.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSprintBacklog.Location = new System.Drawing.Point(305, 320);
            this.txtSprintBacklog.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSprintBacklog.Name = "txtSprintBacklog";
            this.txtSprintBacklog.PlaceholderText = "";
            this.txtSprintBacklog.SelectedText = "";
            this.txtSprintBacklog.Size = new System.Drawing.Size(307, 36);
            this.txtSprintBacklog.TabIndex = 34;
            // 
            // lblSprintBacklog
            // 
            this.lblSprintBacklog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblSprintBacklog.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSprintBacklog.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSprintBacklog.Location = new System.Drawing.Point(150, 320);
            this.lblSprintBacklog.Name = "lblSprintBacklog";
            this.lblSprintBacklog.Size = new System.Drawing.Size(149, 36);
            this.lblSprintBacklog.TabIndex = 29;
            this.lblSprintBacklog.Text = "Backlog:";
            this.lblSprintBacklog.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboDept
            // 
            this.cboDept.BackColor = System.Drawing.Color.Transparent;
            this.cboDept.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDept.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboDept.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboDept.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboDept.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboDept.ItemHeight = 30;
            this.cboDept.Location = new System.Drawing.Point(305, 582);
            this.cboDept.Name = "cboDept";
            this.cboDept.Size = new System.Drawing.Size(307, 36);
            this.cboDept.TabIndex = 27;
            // 
            // clbSprintUsers
            // 
            this.clbSprintUsers.FormattingEnabled = true;
            this.clbSprintUsers.Location = new System.Drawing.Point(305, 385);
            this.clbSprintUsers.Name = "clbSprintUsers";
            this.clbSprintUsers.Size = new System.Drawing.Size(307, 174);
            this.clbSprintUsers.TabIndex = 26;
            // 
            // btnSprintDelete
            // 
            this.btnSprintDelete.BorderRadius = 10;
            this.btnSprintDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSprintDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSprintDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSprintDelete.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSprintDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSprintDelete.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.btnSprintDelete.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnSprintDelete.ForeColor = System.Drawing.Color.White;
            this.btnSprintDelete.Location = new System.Drawing.Point(519, 796);
            this.btnSprintDelete.Name = "btnSprintDelete";
            this.btnSprintDelete.Size = new System.Drawing.Size(180, 45);
            this.btnSprintDelete.TabIndex = 24;
            this.btnSprintDelete.Text = "Delete";
            // 
            // btnSprintEdit
            // 
            this.btnSprintEdit.BorderRadius = 10;
            this.btnSprintEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSprintEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSprintEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSprintEdit.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSprintEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSprintEdit.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.btnSprintEdit.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnSprintEdit.ForeColor = System.Drawing.Color.White;
            this.btnSprintEdit.Location = new System.Drawing.Point(305, 796);
            this.btnSprintEdit.Name = "btnSprintEdit";
            this.btnSprintEdit.Size = new System.Drawing.Size(180, 45);
            this.btnSprintEdit.TabIndex = 23;
            this.btnSprintEdit.Text = "Edit";
            this.btnSprintEdit.Click += new System.EventHandler(this.btnSprintEdit_Click);
            // 
            // dtpSprintEnd
            // 
            this.dtpSprintEnd.Checked = true;
            this.dtpSprintEnd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpSprintEnd.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpSprintEnd.Location = new System.Drawing.Point(305, 703);
            this.dtpSprintEnd.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpSprintEnd.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpSprintEnd.Name = "dtpSprintEnd";
            this.dtpSprintEnd.Size = new System.Drawing.Size(307, 36);
            this.dtpSprintEnd.TabIndex = 22;
            this.dtpSprintEnd.Value = new System.DateTime(2025, 6, 17, 20, 25, 55, 408);
            // 
            // dtpSprintStart
            // 
            this.dtpSprintStart.Checked = true;
            this.dtpSprintStart.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpSprintStart.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpSprintStart.Location = new System.Drawing.Point(305, 643);
            this.dtpSprintStart.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpSprintStart.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpSprintStart.Name = "dtpSprintStart";
            this.dtpSprintStart.Size = new System.Drawing.Size(307, 36);
            this.dtpSprintStart.TabIndex = 21;
            this.dtpSprintStart.Value = new System.DateTime(2025, 6, 17, 20, 25, 55, 408);
            // 
            // txtSprintName
            // 
            this.txtSprintName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSprintName.DefaultText = "";
            this.txtSprintName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSprintName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSprintName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSprintName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSprintName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSprintName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSprintName.ForeColor = System.Drawing.Color.Black;
            this.txtSprintName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSprintName.Location = new System.Drawing.Point(305, 257);
            this.txtSprintName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSprintName.Name = "txtSprintName";
            this.txtSprintName.PlaceholderText = "";
            this.txtSprintName.SelectedText = "";
            this.txtSprintName.Size = new System.Drawing.Size(307, 36);
            this.txtSprintName.TabIndex = 33;
            // 
            // txtSprintID
            // 
            this.txtSprintID.BorderRadius = 10;
            this.txtSprintID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSprintID.DefaultText = "";
            this.txtSprintID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSprintID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSprintID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSprintID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSprintID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSprintID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSprintID.ForeColor = System.Drawing.Color.Black;
            this.txtSprintID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSprintID.Location = new System.Drawing.Point(305, 196);
            this.txtSprintID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSprintID.Name = "txtSprintID";
            this.txtSprintID.PlaceholderText = "";
            this.txtSprintID.SelectedText = "";
            this.txtSprintID.Size = new System.Drawing.Size(307, 36);
            this.txtSprintID.TabIndex = 12;
            // 
            // btnSprintAdd
            // 
            this.btnSprintAdd.BorderRadius = 10;
            this.btnSprintAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSprintAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSprintAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSprintAdd.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSprintAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSprintAdd.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.btnSprintAdd.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnSprintAdd.ForeColor = System.Drawing.Color.White;
            this.btnSprintAdd.Location = new System.Drawing.Point(84, 796);
            this.btnSprintAdd.Name = "btnSprintAdd";
            this.btnSprintAdd.Size = new System.Drawing.Size(180, 45);
            this.btnSprintAdd.TabIndex = 10;
            this.btnSprintAdd.Text = "Add";
            this.btnSprintAdd.Click += new System.EventHandler(this.btnSprintAdd_Click);
            // 
            // lblProjectID
            // 
            this.lblProjectID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblProjectID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblProjectID.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectID.Location = new System.Drawing.Point(150, 140);
            this.lblProjectID.Name = "lblProjectID";
            this.lblProjectID.Size = new System.Drawing.Size(149, 36);
            this.lblProjectID.TabIndex = 9;
            this.lblProjectID.Text = "ProjectID:";
            this.lblProjectID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSprintEnd
            // 
            this.lblSprintEnd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblSprintEnd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSprintEnd.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSprintEnd.Location = new System.Drawing.Point(150, 703);
            this.lblSprintEnd.Name = "lblSprintEnd";
            this.lblSprintEnd.Size = new System.Drawing.Size(149, 36);
            this.lblSprintEnd.TabIndex = 8;
            this.lblSprintEnd.Text = "End:";
            this.lblSprintEnd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // lblDepartment
            // 
            this.lblDepartment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblDepartment.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDepartment.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartment.Location = new System.Drawing.Point(150, 582);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(149, 36);
            this.lblDepartment.TabIndex = 6;
            this.lblDepartment.Text = "Department:";
            this.lblDepartment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSprintAssigned
            // 
            this.lblSprintAssigned.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblSprintAssigned.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSprintAssigned.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSprintAssigned.Location = new System.Drawing.Point(150, 387);
            this.lblSprintAssigned.Name = "lblSprintAssigned";
            this.lblSprintAssigned.Size = new System.Drawing.Size(149, 36);
            this.lblSprintAssigned.TabIndex = 4;
            this.lblSprintAssigned.Text = "Assign to:";
            this.lblSprintAssigned.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSprintName
            // 
            this.lblSprintName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblSprintName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSprintName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSprintName.Location = new System.Drawing.Point(150, 257);
            this.lblSprintName.Name = "lblSprintName";
            this.lblSprintName.Size = new System.Drawing.Size(149, 36);
            this.lblSprintName.TabIndex = 3;
            this.lblSprintName.Text = "Sprint Name:";
            this.lblSprintName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSprintID
            // 
            this.lblSprintID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblSprintID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSprintID.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSprintID.Location = new System.Drawing.Point(150, 196);
            this.lblSprintID.Name = "lblSprintID";
            this.lblSprintID.Size = new System.Drawing.Size(149, 36);
            this.lblSprintID.TabIndex = 2;
            this.lblSprintID.Text = "SprintID:";
            this.lblSprintID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSprintTitle
            // 
            this.lblSprintTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSprintTitle.BackColor = System.Drawing.Color.White;
            this.lblSprintTitle.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSprintTitle.Location = new System.Drawing.Point(202, 52);
            this.lblSprintTitle.Name = "lblSprintTitle";
            this.lblSprintTitle.Size = new System.Drawing.Size(410, 60);
            this.lblSprintTitle.TabIndex = 0;
            this.lblSprintTitle.Text = "Sprints - Status:";
            this.lblSprintTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkSprinStatus
            // 
            this.chkSprinStatus.BackColor = System.Drawing.Color.White;
            this.chkSprinStatus.CheckedState.BorderColor = System.Drawing.Color.White;
            this.chkSprinStatus.CheckedState.BorderRadius = 10;
            this.chkSprinStatus.CheckedState.BorderThickness = 2;
            this.chkSprinStatus.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkSprinStatus.Location = new System.Drawing.Point(519, 65);
            this.chkSprinStatus.Name = "chkSprinStatus";
            this.chkSprinStatus.Size = new System.Drawing.Size(37, 29);
            this.chkSprinStatus.TabIndex = 35;
            this.chkSprinStatus.Text = "guna2CustomCheckBox1";
            this.chkSprinStatus.UncheckedState.BorderColor = System.Drawing.Color.White;
            this.chkSprinStatus.UncheckedState.BorderRadius = 10;
            this.chkSprinStatus.UncheckedState.BorderThickness = 2;
            this.chkSprinStatus.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // SprintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 853);
            this.Controls.Add(this.pnlAddProject);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SprintForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SprintForm";
            this.Load += new System.EventHandler(this.SprintForm_Load);
            this.pnlAddProject.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel pnlAddProject;
        private System.Windows.Forms.CheckedListBox clbSprintUsers;
        private Guna.UI2.WinForms.Guna2GradientButton btnSprintDelete;
        private Guna.UI2.WinForms.Guna2GradientButton btnSprintEdit;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpSprintEnd;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpSprintStart;
        private Guna.UI2.WinForms.Guna2TextBox txtSprintName;
        private Guna.UI2.WinForms.Guna2TextBox txtSprintID;
        private Guna.UI2.WinForms.Guna2GradientButton btnSprintAdd;
        private System.Windows.Forms.Label lblProjectID;
        private System.Windows.Forms.Label lblSprintEnd;
        private System.Windows.Forms.Label lblSprintStart;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblSprintAssigned;
        private System.Windows.Forms.Label lblSprintName;
        private System.Windows.Forms.Label lblSprintID;
        private System.Windows.Forms.Label lblSprintTitle;
        private Guna.UI2.WinForms.Guna2TextBox txtSprintBacklog;
        private System.Windows.Forms.Label lblSprintBacklog;
        private Guna.UI2.WinForms.Guna2ComboBox cboProjectIDName;
        private Guna.UI2.WinForms.Guna2ComboBox cboSprintID;
        private Guna.UI2.WinForms.Guna2ComboBox cboDept;
        private Guna.UI2.WinForms.Guna2TextBox txtSprintIdAdd;
        private System.Windows.Forms.Label lblDept;
        private Guna.UI2.WinForms.Guna2CustomCheckBox chkSprinStatus;
    }
}