namespace TaskManagement
{
    partial class ProjectForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectForm));
            this.pnlAddProject = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.btnCheckID = new Guna.UI2.WinForms.Guna2Button();
            this.cboDept = new Guna.UI2.WinForms.Guna2ComboBox();
            this.clbUsers = new System.Windows.Forms.CheckedListBox();
            this.btnDelete = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnEdit = new Guna.UI2.WinForms.Guna2GradientButton();
            this.dtpEnd = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpStart = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtRevenue = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtBacklog = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtProName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtID = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAdd = new Guna.UI2.WinForms.Guna2GradientButton();
            this.lblID = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblRevenue = new System.Windows.Forms.Label();
            this.lblAssigned = new System.Windows.Forms.Label();
            this.lblBacklog = new System.Windows.Forms.Label();
            this.lblProName = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlAddProject.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAddProject
            // 
            this.pnlAddProject.Controls.Add(this.btnCheckID);
            this.pnlAddProject.Controls.Add(this.cboDept);
            this.pnlAddProject.Controls.Add(this.clbUsers);
            this.pnlAddProject.Controls.Add(this.btnDelete);
            this.pnlAddProject.Controls.Add(this.btnEdit);
            this.pnlAddProject.Controls.Add(this.dtpEnd);
            this.pnlAddProject.Controls.Add(this.dtpStart);
            this.pnlAddProject.Controls.Add(this.txtRevenue);
            this.pnlAddProject.Controls.Add(this.txtBacklog);
            this.pnlAddProject.Controls.Add(this.txtProName);
            this.pnlAddProject.Controls.Add(this.txtID);
            this.pnlAddProject.Controls.Add(this.btnAdd);
            this.pnlAddProject.Controls.Add(this.lblID);
            this.pnlAddProject.Controls.Add(this.lblEnd);
            this.pnlAddProject.Controls.Add(this.lblStart);
            this.pnlAddProject.Controls.Add(this.lblDepartment);
            this.pnlAddProject.Controls.Add(this.lblRevenue);
            this.pnlAddProject.Controls.Add(this.lblAssigned);
            this.pnlAddProject.Controls.Add(this.lblBacklog);
            this.pnlAddProject.Controls.Add(this.lblProName);
            this.pnlAddProject.Controls.Add(this.lblTitle);
            this.pnlAddProject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAddProject.FillColor = System.Drawing.Color.White;
            this.pnlAddProject.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlAddProject.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.pnlAddProject.Location = new System.Drawing.Point(0, 0);
            this.pnlAddProject.Name = "pnlAddProject";
            this.pnlAddProject.Size = new System.Drawing.Size(782, 853);
            this.pnlAddProject.TabIndex = 0;
            // 
            // btnCheckID
            // 
            this.btnCheckID.BorderColor = System.Drawing.Color.Silver;
            this.btnCheckID.BorderRadius = 10;
            this.btnCheckID.BorderThickness = 2;
            this.btnCheckID.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCheckID.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCheckID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCheckID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCheckID.FillColor = System.Drawing.Color.White;
            this.btnCheckID.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.btnCheckID.ForeColor = System.Drawing.Color.Black;
            this.btnCheckID.Image = ((System.Drawing.Image)(resources.GetObject("btnCheckID.Image")));
            this.btnCheckID.Location = new System.Drawing.Point(618, 137);
            this.btnCheckID.Name = "btnCheckID";
            this.btnCheckID.Size = new System.Drawing.Size(50, 36);
            this.btnCheckID.TabIndex = 28;
            this.btnCheckID.Text = " ";
            this.btnCheckID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnCheckID.Click += new System.EventHandler(this.btnCheckID_Click);
            // 
            // cboDept
            // 
            this.cboDept.BackColor = System.Drawing.Color.Transparent;
            this.cboDept.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDept.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboDept.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboDept.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboDept.ForeColor = System.Drawing.Color.Black;
            this.cboDept.ItemHeight = 30;
            this.cboDept.Location = new System.Drawing.Point(305, 582);
            this.cboDept.Name = "cboDept";
            this.cboDept.Size = new System.Drawing.Size(307, 36);
            this.cboDept.TabIndex = 27;
            // 
            // clbUsers
            // 
            this.clbUsers.FormattingEnabled = true;
            this.clbUsers.Location = new System.Drawing.Point(305, 317);
            this.clbUsers.Name = "clbUsers";
            this.clbUsers.Size = new System.Drawing.Size(307, 174);
            this.clbUsers.TabIndex = 26;
            // 
            // btnDelete
            // 
            this.btnDelete.BorderRadius = 10;
            this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(519, 796);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(180, 45);
            this.btnDelete.TabIndex = 24;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BorderRadius = 10;
            this.btnEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEdit.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEdit.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(305, 796);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(180, 45);
            this.btnEdit.TabIndex = 23;
            this.btnEdit.Text = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // dtpEnd
            // 
            this.dtpEnd.Checked = true;
            this.dtpEnd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpEnd.Location = new System.Drawing.Point(305, 703);
            this.dtpEnd.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpEnd.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(307, 36);
            this.dtpEnd.TabIndex = 22;
            this.dtpEnd.Value = new System.DateTime(2025, 6, 17, 20, 25, 55, 408);
            // 
            // dtpStart
            // 
            this.dtpStart.Checked = true;
            this.dtpStart.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpStart.Location = new System.Drawing.Point(305, 643);
            this.dtpStart.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpStart.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(307, 36);
            this.dtpStart.TabIndex = 21;
            this.dtpStart.Value = new System.DateTime(2025, 6, 17, 20, 25, 55, 408);
            // 
            // txtRevenue
            // 
            this.txtRevenue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRevenue.DefaultText = "";
            this.txtRevenue.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRevenue.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRevenue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRevenue.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRevenue.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRevenue.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtRevenue.ForeColor = System.Drawing.Color.Black;
            this.txtRevenue.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRevenue.Location = new System.Drawing.Point(305, 521);
            this.txtRevenue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRevenue.Name = "txtRevenue";
            this.txtRevenue.PlaceholderText = "";
            this.txtRevenue.SelectedText = "";
            this.txtRevenue.Size = new System.Drawing.Size(307, 36);
            this.txtRevenue.TabIndex = 15;
            // 
            // txtBacklog
            // 
            this.txtBacklog.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBacklog.DefaultText = "";
            this.txtBacklog.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBacklog.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBacklog.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBacklog.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBacklog.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBacklog.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBacklog.ForeColor = System.Drawing.Color.Black;
            this.txtBacklog.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBacklog.Location = new System.Drawing.Point(305, 254);
            this.txtBacklog.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBacklog.Name = "txtBacklog";
            this.txtBacklog.PlaceholderText = "";
            this.txtBacklog.SelectedText = "";
            this.txtBacklog.Size = new System.Drawing.Size(307, 36);
            this.txtBacklog.TabIndex = 13;
            // 
            // txtProName
            // 
            this.txtProName.BorderRadius = 10;
            this.txtProName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProName.DefaultText = "";
            this.txtProName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtProName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtProName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtProName.ForeColor = System.Drawing.Color.Black;
            this.txtProName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProName.Location = new System.Drawing.Point(305, 193);
            this.txtProName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProName.Name = "txtProName";
            this.txtProName.PlaceholderText = "";
            this.txtProName.SelectedText = "";
            this.txtProName.Size = new System.Drawing.Size(307, 36);
            this.txtProName.TabIndex = 12;
            // 
            // txtID
            // 
            this.txtID.BorderRadius = 10;
            this.txtID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtID.DefaultText = "";
            this.txtID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtID.ForeColor = System.Drawing.Color.Black;
            this.txtID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtID.Location = new System.Drawing.Point(305, 137);
            this.txtID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtID.Name = "txtID";
            this.txtID.PlaceholderText = "";
            this.txtID.SelectedText = "";
            this.txtID.Size = new System.Drawing.Size(307, 36);
            this.txtID.TabIndex = 11;
            // 
            // btnAdd
            // 
            this.btnAdd.BorderRadius = 10;
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(84, 796);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(180, 45);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblID
            // 
            this.lblID.BackColor = System.Drawing.Color.White;
            this.lblID.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(150, 137);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(149, 36);
            this.lblID.TabIndex = 9;
            this.lblID.Text = "ID:";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEnd
            // 
            this.lblEnd.BackColor = System.Drawing.Color.White;
            this.lblEnd.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnd.Location = new System.Drawing.Point(150, 703);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(149, 36);
            this.lblEnd.TabIndex = 8;
            this.lblEnd.Text = "End:";
            this.lblEnd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStart
            // 
            this.lblStart.BackColor = System.Drawing.Color.White;
            this.lblStart.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStart.Location = new System.Drawing.Point(150, 643);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(149, 36);
            this.lblStart.TabIndex = 7;
            this.lblStart.Text = "Start:";
            this.lblStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDepartment
            // 
            this.lblDepartment.BackColor = System.Drawing.Color.White;
            this.lblDepartment.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartment.Location = new System.Drawing.Point(150, 582);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(149, 36);
            this.lblDepartment.TabIndex = 6;
            this.lblDepartment.Text = "Department:";
            this.lblDepartment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRevenue
            // 
            this.lblRevenue.BackColor = System.Drawing.Color.White;
            this.lblRevenue.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRevenue.Location = new System.Drawing.Point(150, 521);
            this.lblRevenue.Name = "lblRevenue";
            this.lblRevenue.Size = new System.Drawing.Size(149, 36);
            this.lblRevenue.TabIndex = 5;
            this.lblRevenue.Text = "Revenue:";
            this.lblRevenue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAssigned
            // 
            this.lblAssigned.BackColor = System.Drawing.Color.White;
            this.lblAssigned.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssigned.Location = new System.Drawing.Point(150, 319);
            this.lblAssigned.Name = "lblAssigned";
            this.lblAssigned.Size = new System.Drawing.Size(149, 36);
            this.lblAssigned.TabIndex = 4;
            this.lblAssigned.Text = "Assign to:";
            this.lblAssigned.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBacklog
            // 
            this.lblBacklog.BackColor = System.Drawing.Color.White;
            this.lblBacklog.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBacklog.Location = new System.Drawing.Point(150, 254);
            this.lblBacklog.Name = "lblBacklog";
            this.lblBacklog.Size = new System.Drawing.Size(149, 36);
            this.lblBacklog.TabIndex = 3;
            this.lblBacklog.Text = "Backlog:";
            this.lblBacklog.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProName
            // 
            this.lblProName.BackColor = System.Drawing.Color.White;
            this.lblProName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProName.Location = new System.Drawing.Point(150, 193);
            this.lblProName.Name = "lblProName";
            this.lblProName.Size = new System.Drawing.Size(149, 36);
            this.lblProName.TabIndex = 2;
            this.lblProName.Text = "Project name:";
            this.lblProName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.White;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(341, 44);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(144, 60);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Projects";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(782, 853);
            this.Controls.Add(this.pnlAddProject);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProjectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProjectForm";
            this.Load += new System.EventHandler(this.ProjectForm_Load);
            this.pnlAddProject.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel pnlAddProject;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblProName;
        private System.Windows.Forms.Label lblBacklog;
        private System.Windows.Forms.Label lblRevenue;
        private System.Windows.Forms.Label lblAssigned;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblDepartment;
        private Guna.UI2.WinForms.Guna2TextBox txtRevenue;
        private Guna.UI2.WinForms.Guna2TextBox txtBacklog;
        private Guna.UI2.WinForms.Guna2TextBox txtProName;
        private Guna.UI2.WinForms.Guna2TextBox txtID;
        private Guna.UI2.WinForms.Guna2GradientButton btnAdd;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpEnd;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpStart;
        private Guna.UI2.WinForms.Guna2GradientButton btnEdit;
        private Guna.UI2.WinForms.Guna2GradientButton btnDelete;
        private System.Windows.Forms.CheckedListBox clbUsers;
        private Guna.UI2.WinForms.Guna2ComboBox cboDept;
        private Guna.UI2.WinForms.Guna2Button btnCheckID;
    }
}