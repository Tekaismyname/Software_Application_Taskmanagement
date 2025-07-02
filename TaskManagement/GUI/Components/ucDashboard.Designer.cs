namespace TaskManagement
{
    partial class ucDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucDashboard));
            this.pnlUcDashboard = new Guna.UI2.WinForms.Guna2Panel();
            this.picAction = new Guna.UI2.WinForms.Guna2PictureBox();
            this.cboActionDashboard = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnReports = new Guna.UI2.WinForms.Guna2Button();
            this.btnSprints = new Guna.UI2.WinForms.Guna2Button();
            this.btnProjects = new Guna.UI2.WinForms.Guna2Button();
            this.picSprintAction = new Guna.UI2.WinForms.Guna2PictureBox();
            this.cboActionSprint = new Guna.UI2.WinForms.Guna2ComboBox();
            this.pnlUcDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSprintAction)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlUcDashboard
            // 
            this.pnlUcDashboard.BackColor = System.Drawing.Color.Silver;
            this.pnlUcDashboard.BorderColor = System.Drawing.Color.White;
            this.pnlUcDashboard.BorderRadius = 10;
            this.pnlUcDashboard.BorderThickness = 2;
            this.pnlUcDashboard.Controls.Add(this.picSprintAction);
            this.pnlUcDashboard.Controls.Add(this.cboActionSprint);
            this.pnlUcDashboard.Controls.Add(this.picAction);
            this.pnlUcDashboard.Controls.Add(this.cboActionDashboard);
            this.pnlUcDashboard.Controls.Add(this.label1);
            this.pnlUcDashboard.Controls.Add(this.guna2PictureBox1);
            this.pnlUcDashboard.Controls.Add(this.btnReports);
            this.pnlUcDashboard.Controls.Add(this.btnSprints);
            this.pnlUcDashboard.Controls.Add(this.btnProjects);
            this.pnlUcDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlUcDashboard.FillColor = System.Drawing.Color.White;
            this.pnlUcDashboard.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlUcDashboard.Location = new System.Drawing.Point(0, 0);
            this.pnlUcDashboard.Name = "pnlUcDashboard";
            this.pnlUcDashboard.Size = new System.Drawing.Size(950, 150);
            this.pnlUcDashboard.TabIndex = 0;
            // 
            // picAction
            // 
            this.picAction.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.picAction.BackColor = System.Drawing.Color.White;
            this.picAction.Image = ((System.Drawing.Image)(resources.GetObject("picAction.Image")));
            this.picAction.ImageRotate = 0F;
            this.picAction.Location = new System.Drawing.Point(726, 14);
            this.picAction.Name = "picAction";
            this.picAction.Size = new System.Drawing.Size(59, 45);
            this.picAction.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAction.TabIndex = 6;
            this.picAction.TabStop = false;
            // 
            // cboActionDashboard
            // 
            this.cboActionDashboard.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cboActionDashboard.BackColor = System.Drawing.Color.White;
            this.cboActionDashboard.BorderColor = System.Drawing.Color.Black;
            this.cboActionDashboard.BorderRadius = 10;
            this.cboActionDashboard.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboActionDashboard.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboActionDashboard.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboActionDashboard.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboActionDashboard.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboActionDashboard.ForeColor = System.Drawing.Color.Black;
            this.cboActionDashboard.ItemHeight = 30;
            this.cboActionDashboard.Items.AddRange(new object[] {
            "Add",
            "Edit",
            "Delete"});
            this.cboActionDashboard.Location = new System.Drawing.Point(791, 14);
            this.cboActionDashboard.Name = "cboActionDashboard";
            this.cboActionDashboard.Size = new System.Drawing.Size(140, 36);
            this.cboActionDashboard.TabIndex = 5;
            this.cboActionDashboard.SelectedIndexChanged += new System.EventHandler(this.cboActionDashboard_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Heavy", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(344, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "_Manage more, Balance better_";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guna2PictureBox1.BackColor = System.Drawing.Color.White;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.Black;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(449, 14);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(60, 50);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 3;
            this.guna2PictureBox1.TabStop = false;
            // 
            // btnReports
            // 
            this.btnReports.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReports.BackColor = System.Drawing.Color.White;
            this.btnReports.BorderRadius = 10;
            this.btnReports.CustomBorderColor = System.Drawing.Color.White;
            this.btnReports.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btnReports.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReports.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReports.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReports.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReports.FillColor = System.Drawing.Color.White;
            this.btnReports.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnReports.ForeColor = System.Drawing.Color.Gray;
            this.btnReports.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.btnReports.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.btnReports.HoverState.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnReports.Location = new System.Drawing.Point(676, 102);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(180, 45);
            this.btnReports.TabIndex = 2;
            this.btnReports.Text = "Reports";
            this.btnReports.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnReports_Click);
            // 
            // btnSprints
            // 
            this.btnSprints.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSprints.BackColor = System.Drawing.Color.White;
            this.btnSprints.BorderRadius = 10;
            this.btnSprints.CustomBorderColor = System.Drawing.Color.White;
            this.btnSprints.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btnSprints.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSprints.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSprints.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSprints.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSprints.FillColor = System.Drawing.Color.White;
            this.btnSprints.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnSprints.ForeColor = System.Drawing.Color.Gray;
            this.btnSprints.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.btnSprints.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.btnSprints.HoverState.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSprints.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnSprints.Location = new System.Drawing.Point(390, 102);
            this.btnSprints.Name = "btnSprints";
            this.btnSprints.Size = new System.Drawing.Size(180, 45);
            this.btnSprints.TabIndex = 1;
            this.btnSprints.Text = "Sprints";
            this.btnSprints.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnSprints_Click);
            // 
            // btnProjects
            // 
            this.btnProjects.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnProjects.BackColor = System.Drawing.Color.White;
            this.btnProjects.BorderRadius = 10;
            this.btnProjects.CustomBorderColor = System.Drawing.Color.White;
            this.btnProjects.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btnProjects.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnProjects.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnProjects.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnProjects.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnProjects.FillColor = System.Drawing.Color.White;
            this.btnProjects.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnProjects.ForeColor = System.Drawing.Color.Gray;
            this.btnProjects.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.btnProjects.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.btnProjects.HoverState.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProjects.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnProjects.Location = new System.Drawing.Point(104, 102);
            this.btnProjects.Name = "btnProjects";
            this.btnProjects.Size = new System.Drawing.Size(180, 45);
            this.btnProjects.TabIndex = 0;
            this.btnProjects.Text = "Projects";
            this.btnProjects.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnProjects_Click);
            // 
            // picSprintAction
            // 
            this.picSprintAction.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.picSprintAction.BackColor = System.Drawing.Color.White;
            this.picSprintAction.Image = ((System.Drawing.Image)(resources.GetObject("picSprintAction.Image")));
            this.picSprintAction.ImageRotate = 0F;
            this.picSprintAction.Location = new System.Drawing.Point(726, 14);
            this.picSprintAction.Name = "picSprintAction";
            this.picSprintAction.Size = new System.Drawing.Size(59, 45);
            this.picSprintAction.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSprintAction.TabIndex = 8;
            this.picSprintAction.TabStop = false;
            // 
            // cboActionSprint
            // 
            this.cboActionSprint.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cboActionSprint.BackColor = System.Drawing.Color.White;
            this.cboActionSprint.BorderColor = System.Drawing.Color.Black;
            this.cboActionSprint.BorderRadius = 10;
            this.cboActionSprint.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboActionSprint.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboActionSprint.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboActionSprint.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboActionSprint.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboActionSprint.ForeColor = System.Drawing.Color.Black;
            this.cboActionSprint.ItemHeight = 30;
            this.cboActionSprint.Items.AddRange(new object[] {
            "Add",
            "Edit",
            "Delete"});
            this.cboActionSprint.Location = new System.Drawing.Point(791, 14);
            this.cboActionSprint.Name = "cboActionSprint";
            this.cboActionSprint.Size = new System.Drawing.Size(140, 36);
            this.cboActionSprint.TabIndex = 7;
            this.cboActionSprint.SelectedIndexChanged += new System.EventHandler(this.cboActionSprint_SelectedIndexChanged);
            // 
            // ucDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlUcDashboard);
            this.Name = "ucDashboard";
            this.Size = new System.Drawing.Size(950, 150);
            this.Load += new System.EventHandler(this.ucDashboard_Load);
            this.pnlUcDashboard.ResumeLayout(false);
            this.pnlUcDashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSprintAction)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlUcDashboard;
        private Guna.UI2.WinForms.Guna2Button btnProjects;
        private Guna.UI2.WinForms.Guna2Button btnSprints;
        private Guna.UI2.WinForms.Guna2Button btnReports;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2ComboBox cboActionDashboard;
        private Guna.UI2.WinForms.Guna2PictureBox picAction;
        private Guna.UI2.WinForms.Guna2PictureBox picSprintAction;
        private Guna.UI2.WinForms.Guna2ComboBox cboActionSprint;
    }
}
