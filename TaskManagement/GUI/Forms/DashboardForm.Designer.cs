using System.Drawing;

namespace TaskManagement
{
    partial class DashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            this.pnlSideBar = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblDashboard = new System.Windows.Forms.Label();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.btnUser = new Guna.UI2.WinForms.Guna2Button();
            this.btnDashboard = new Guna.UI2.WinForms.Guna2Button();
            this.picVertexLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pnlPlaceTime = new Guna.UI2.WinForms.Guna2Panel();
            this.gbRemote = new Guna.UI2.WinForms.Guna2GroupBox();
            this.flpRemote = new System.Windows.Forms.FlowLayoutPanel();
            this.picRemote = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblSelectedDateRemote = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.gbOnSite = new Guna.UI2.WinForms.Guna2GroupBox();
            this.flpOnsite = new System.Windows.Forms.FlowLayoutPanel();
            this.picOnSite = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblSelectedDateOnsite = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.calendarWorkingStatus = new System.Windows.Forms.MonthCalendar();
            this.pnlDashboard = new Guna.UI2.WinForms.Guna2Panel();
            this.ucUser1 = new TaskManagement.ucUser();
            this.ucDashboard1 = new TaskManagement.ucDashboard();
            this.pnlShowTheme = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlShow = new Guna.UI2.WinForms.Guna2Panel();
            this.ucProjectCardShow1 = new TaskManagement.ucProjectCardShow();
            this.ucSprintCardShow1 = new TaskManagement.ucSprintCardShow();
            this.pnlSideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picVertexLogo)).BeginInit();
            this.pnlPlaceTime.SuspendLayout();
            this.gbRemote.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRemote)).BeginInit();
            this.gbOnSite.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picOnSite)).BeginInit();
            this.pnlDashboard.SuspendLayout();
            this.pnlShowTheme.SuspendLayout();
            this.pnlShow.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSideBar
            // 
            this.pnlSideBar.AutoScroll = true;
            this.pnlSideBar.BackColor = System.Drawing.Color.Transparent;
            this.pnlSideBar.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.pnlSideBar.BorderRadius = 10;
            this.pnlSideBar.BorderThickness = 2;
            this.pnlSideBar.Controls.Add(this.lblUser);
            this.pnlSideBar.Controls.Add(this.lblDashboard);
            this.pnlSideBar.Controls.Add(this.btnLogout);
            this.pnlSideBar.Controls.Add(this.btnUser);
            this.pnlSideBar.Controls.Add(this.btnDashboard);
            this.pnlSideBar.Controls.Add(this.picVertexLogo);
            this.pnlSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSideBar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(142)))), ((int)(((byte)(194)))));
            this.pnlSideBar.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(142)))), ((int)(((byte)(194)))));
            this.pnlSideBar.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.pnlSideBar.Location = new System.Drawing.Point(0, 0);
            this.pnlSideBar.Name = "pnlSideBar";
            this.pnlSideBar.Size = new System.Drawing.Size(96, 732);
            this.pnlSideBar.TabIndex = 0;
            // 
            // lblUser
            // 
            this.lblUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(0, 416);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(96, 27);
            this.lblUser.TabIndex = 11;
            this.lblUser.Text = "User";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDashboard
            // 
            this.lblDashboard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDashboard.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashboard.Location = new System.Drawing.Point(0, 337);
            this.lblDashboard.Name = "lblDashboard";
            this.lblDashboard.Size = new System.Drawing.Size(96, 27);
            this.lblDashboard.TabIndex = 3;
            this.lblDashboard.Text = "Dashboard";
            this.lblDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLogout.BorderRadius = 10;
            this.btnLogout.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnLogout.CustomImages.CheckedImage = ((System.Drawing.Image)(resources.GetObject("resource.CheckedImage")));
            this.btnLogout.CustomImages.HoveredImage = ((System.Drawing.Image)(resources.GetObject("resource.HoveredImage")));
            this.btnLogout.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btnLogout.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnLogout.CustomImages.ImageSize = new System.Drawing.Size(30, 30);
            this.btnLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.btnLogout.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(29)))), ((int)(((byte)(97)))));
            this.btnLogout.HoverState.FillColor = System.Drawing.Color.White;
            this.btnLogout.ImageSize = new System.Drawing.Size(30, 30);
            this.btnLogout.Location = new System.Drawing.Point(3, 689);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(90, 46);
            this.btnLogout.TabIndex = 4;
            // 
            // btnUser
            // 
            this.btnUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUser.BorderRadius = 10;
            this.btnUser.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnUser.CustomImages.CheckedImage = ((System.Drawing.Image)(resources.GetObject("resource.CheckedImage1")));
            this.btnUser.CustomImages.HoveredImage = ((System.Drawing.Image)(resources.GetObject("resource.HoveredImage1")));
            this.btnUser.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.btnUser.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnUser.CustomImages.ImageSize = new System.Drawing.Size(30, 30);
            this.btnUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(142)))), ((int)(((byte)(194)))));
            this.btnUser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUser.ForeColor = System.Drawing.Color.White;
            this.btnUser.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.btnUser.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(29)))), ((int)(((byte)(97)))));
            this.btnUser.HoverState.FillColor = System.Drawing.Color.White;
            this.btnUser.ImageSize = new System.Drawing.Size(30, 30);
            this.btnUser.Location = new System.Drawing.Point(3, 369);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(90, 46);
            this.btnUser.TabIndex = 3;
            this.btnUser.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnUser_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDashboard.BorderRadius = 10;
            this.btnDashboard.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.btnDashboard.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnDashboard.CustomImages.CheckedImage = ((System.Drawing.Image)(resources.GetObject("resource.CheckedImage2")));
            this.btnDashboard.CustomImages.HoveredImage = ((System.Drawing.Image)(resources.GetObject("resource.HoveredImage2")));
            this.btnDashboard.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.btnDashboard.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDashboard.CustomImages.ImageSize = new System.Drawing.Size(30, 30);
            this.btnDashboard.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDashboard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDashboard.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDashboard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDashboard.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(142)))), ((int)(((byte)(194)))));
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDashboard.ForeColor = System.Drawing.Color.Black;
            this.btnDashboard.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.btnDashboard.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(29)))), ((int)(((byte)(97)))));
            this.btnDashboard.HoverState.FillColor = System.Drawing.Color.White;
            this.btnDashboard.ImageSize = new System.Drawing.Size(30, 30);
            this.btnDashboard.Location = new System.Drawing.Point(3, 292);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(90, 46);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            this.btnDashboard.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnDashboard_Click);
            // 
            // picVertexLogo
            // 
            this.picVertexLogo.BackColor = System.Drawing.Color.Transparent;
            this.picVertexLogo.BorderRadius = 10;
            this.picVertexLogo.FillColor = System.Drawing.Color.Transparent;
            this.picVertexLogo.Image = ((System.Drawing.Image)(resources.GetObject("picVertexLogo.Image")));
            this.picVertexLogo.ImageRotate = 0F;
            this.picVertexLogo.Location = new System.Drawing.Point(11, 12);
            this.picVertexLogo.Name = "picVertexLogo";
            this.picVertexLogo.Size = new System.Drawing.Size(73, 50);
            this.picVertexLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picVertexLogo.TabIndex = 1;
            this.picVertexLogo.TabStop = false;
            // 
            // pnlPlaceTime
            // 
            this.pnlPlaceTime.BorderColor = System.Drawing.Color.Silver;
            this.pnlPlaceTime.BorderRadius = 10;
            this.pnlPlaceTime.BorderThickness = 2;
            this.pnlPlaceTime.Controls.Add(this.gbRemote);
            this.pnlPlaceTime.Controls.Add(this.gbOnSite);
            this.pnlPlaceTime.Controls.Add(this.calendarWorkingStatus);
            this.pnlPlaceTime.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlPlaceTime.FillColor = System.Drawing.Color.White;
            this.pnlPlaceTime.Location = new System.Drawing.Point(1023, 0);
            this.pnlPlaceTime.Name = "pnlPlaceTime";
            this.pnlPlaceTime.Size = new System.Drawing.Size(242, 732);
            this.pnlPlaceTime.TabIndex = 1;
            // 
            // gbRemote
            // 
            this.gbRemote.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbRemote.BackColor = System.Drawing.Color.White;
            this.gbRemote.BorderRadius = 10;
            this.gbRemote.Controls.Add(this.flpRemote);
            this.gbRemote.Controls.Add(this.picRemote);
            this.gbRemote.Controls.Add(this.lblSelectedDateRemote);
            this.gbRemote.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRemote.ForeColor = System.Drawing.Color.Black;
            this.gbRemote.Location = new System.Drawing.Point(9, 279);
            this.gbRemote.Name = "gbRemote";
            this.gbRemote.Size = new System.Drawing.Size(224, 300);
            this.gbRemote.TabIndex = 2;
            this.gbRemote.Text = "Remote";
            this.gbRemote.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // flpRemote
            // 
            this.flpRemote.AutoScroll = true;
            this.flpRemote.BackColor = System.Drawing.Color.White;
            this.flpRemote.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpRemote.Location = new System.Drawing.Point(3, 90);
            this.flpRemote.Name = "flpRemote";
            this.flpRemote.Size = new System.Drawing.Size(218, 200);
            this.flpRemote.TabIndex = 3;
            // 
            // picRemote
            // 
            this.picRemote.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picRemote.BackColor = System.Drawing.Color.Gainsboro;
            this.picRemote.Image = ((System.Drawing.Image)(resources.GetObject("picRemote.Image")));
            this.picRemote.ImageRotate = 0F;
            this.picRemote.Location = new System.Drawing.Point(32, 1);
            this.picRemote.Name = "picRemote";
            this.picRemote.Size = new System.Drawing.Size(38, 42);
            this.picRemote.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRemote.TabIndex = 1;
            this.picRemote.TabStop = false;
            // 
            // lblSelectedDateRemote
            // 
            this.lblSelectedDateRemote.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSelectedDateRemote.AutoSize = false;
            this.lblSelectedDateRemote.BackColor = System.Drawing.Color.Turquoise;
            this.lblSelectedDateRemote.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedDateRemote.Location = new System.Drawing.Point(3, 49);
            this.lblSelectedDateRemote.Name = "lblSelectedDateRemote";
            this.lblSelectedDateRemote.Size = new System.Drawing.Size(218, 35);
            this.lblSelectedDateRemote.TabIndex = 0;
            this.lblSelectedDateRemote.Text = null;
            // 
            // gbOnSite
            // 
            this.gbOnSite.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbOnSite.BackColor = System.Drawing.Color.White;
            this.gbOnSite.BorderRadius = 10;
            this.gbOnSite.Controls.Add(this.flpOnsite);
            this.gbOnSite.Controls.Add(this.picOnSite);
            this.gbOnSite.Controls.Add(this.lblSelectedDateOnsite);
            this.gbOnSite.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOnSite.ForeColor = System.Drawing.Color.Black;
            this.gbOnSite.Location = new System.Drawing.Point(9, 12);
            this.gbOnSite.Name = "gbOnSite";
            this.gbOnSite.Size = new System.Drawing.Size(224, 300);
            this.gbOnSite.TabIndex = 1;
            this.gbOnSite.Text = "OnSite";
            this.gbOnSite.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // flpOnsite
            // 
            this.flpOnsite.AutoScroll = true;
            this.flpOnsite.BackColor = System.Drawing.Color.White;
            this.flpOnsite.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpOnsite.Location = new System.Drawing.Point(3, 92);
            this.flpOnsite.Name = "flpOnsite";
            this.flpOnsite.Size = new System.Drawing.Size(218, 200);
            this.flpOnsite.TabIndex = 2;
            // 
            // picOnSite
            // 
            this.picOnSite.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picOnSite.BackColor = System.Drawing.Color.Gainsboro;
            this.picOnSite.Image = ((System.Drawing.Image)(resources.GetObject("picOnSite.Image")));
            this.picOnSite.ImageRotate = 0F;
            this.picOnSite.Location = new System.Drawing.Point(35, 0);
            this.picOnSite.Name = "picOnSite";
            this.picOnSite.Size = new System.Drawing.Size(38, 42);
            this.picOnSite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOnSite.TabIndex = 1;
            this.picOnSite.TabStop = false;
            // 
            // lblSelectedDateOnsite
            // 
            this.lblSelectedDateOnsite.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSelectedDateOnsite.AutoSize = false;
            this.lblSelectedDateOnsite.BackColor = System.Drawing.Color.Turquoise;
            this.lblSelectedDateOnsite.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedDateOnsite.Location = new System.Drawing.Point(3, 48);
            this.lblSelectedDateOnsite.Name = "lblSelectedDateOnsite";
            this.lblSelectedDateOnsite.Size = new System.Drawing.Size(218, 38);
            this.lblSelectedDateOnsite.TabIndex = 0;
            this.lblSelectedDateOnsite.Text = null;
            // 
            // calendarWorkingStatus
            // 
            this.calendarWorkingStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.calendarWorkingStatus.Location = new System.Drawing.Point(9, 528);
            this.calendarWorkingStatus.Name = "calendarWorkingStatus";
            this.calendarWorkingStatus.TabIndex = 0;
            this.calendarWorkingStatus.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calendarWorkingStatus_DateChanged);
            // 
            // pnlDashboard
            // 
            this.pnlDashboard.BorderColor = System.Drawing.Color.White;
            this.pnlDashboard.BorderRadius = 10;
            this.pnlDashboard.BorderThickness = 2;
            this.pnlDashboard.Controls.Add(this.ucUser1);
            this.pnlDashboard.Controls.Add(this.ucDashboard1);
            this.pnlDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDashboard.FillColor = System.Drawing.Color.Silver;
            this.pnlDashboard.Location = new System.Drawing.Point(96, 0);
            this.pnlDashboard.Name = "pnlDashboard";
            this.pnlDashboard.Size = new System.Drawing.Size(927, 154);
            this.pnlDashboard.TabIndex = 2;
            // 
            // ucUser1
            // 
            this.ucUser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucUser1.Location = new System.Drawing.Point(0, 154);
            this.ucUser1.Name = "ucUser1";
            this.ucUser1.Size = new System.Drawing.Size(927, 0);
            this.ucUser1.TabIndex = 5;
            // 
            // ucDashboard1
            // 
            this.ucDashboard1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucDashboard1.Location = new System.Drawing.Point(0, 0);
            this.ucDashboard1.Name = "ucDashboard1";
            this.ucDashboard1.Size = new System.Drawing.Size(927, 154);
            this.ucDashboard1.TabIndex = 0;
            this.ucDashboard1.Load += new System.EventHandler(this.ucDashboard1_Load);
            // 
            // pnlShowTheme
            // 
            this.pnlShowTheme.BackColor = System.Drawing.Color.Silver;
            this.pnlShowTheme.BorderColor = System.Drawing.Color.White;
            this.pnlShowTheme.Controls.Add(this.pnlShow);
            this.pnlShowTheme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlShowTheme.Location = new System.Drawing.Point(96, 154);
            this.pnlShowTheme.Name = "pnlShowTheme";
            this.pnlShowTheme.Size = new System.Drawing.Size(927, 578);
            this.pnlShowTheme.TabIndex = 5;
            // 
            // pnlShow
            // 
            this.pnlShow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlShow.BackColor = System.Drawing.Color.White;
            this.pnlShow.BorderColor = System.Drawing.Color.Silver;
            this.pnlShow.BorderRadius = 10;
            this.pnlShow.BorderThickness = 1;
            this.pnlShow.Controls.Add(this.ucSprintCardShow1);
            this.pnlShow.Controls.Add(this.ucProjectCardShow1);
            this.pnlShow.Location = new System.Drawing.Point(6, 6);
            this.pnlShow.Name = "pnlShow";
            this.pnlShow.Size = new System.Drawing.Size(915, 560);
            this.pnlShow.TabIndex = 5;
            // 
            // ucProjectCardShow1
            // 
            this.ucProjectCardShow1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucProjectCardShow1.Location = new System.Drawing.Point(3, 3);
            this.ucProjectCardShow1.Name = "ucProjectCardShow1";
            this.ucProjectCardShow1.Size = new System.Drawing.Size(909, 554);
            this.ucProjectCardShow1.TabIndex = 0;
            // 
            // ucSprintCardShow1
            // 
            this.ucSprintCardShow1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucSprintCardShow1.Location = new System.Drawing.Point(0, 0);
            this.ucSprintCardShow1.Name = "ucSprintCardShow1";
            this.ucSprintCardShow1.Size = new System.Drawing.Size(915, 560);
            this.ucSprintCardShow1.TabIndex = 1;
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1265, 732);
            this.Controls.Add(this.pnlShowTheme);
            this.Controls.Add(this.pnlDashboard);
            this.Controls.Add(this.pnlPlaceTime);
            this.Controls.Add(this.pnlSideBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashboardForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            this.pnlSideBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picVertexLogo)).EndInit();
            this.pnlPlaceTime.ResumeLayout(false);
            this.gbRemote.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picRemote)).EndInit();
            this.gbOnSite.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picOnSite)).EndInit();
            this.pnlDashboard.ResumeLayout(false);
            this.pnlShowTheme.ResumeLayout(false);
            this.pnlShow.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel pnlSideBar;
        private Guna.UI2.WinForms.Guna2PictureBox picVertexLogo;
        private Guna.UI2.WinForms.Guna2Button btnDashboard;
        private Guna.UI2.WinForms.Guna2Button btnUser;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
        private Guna.UI2.WinForms.Guna2Panel pnlPlaceTime;
        private Guna.UI2.WinForms.Guna2Panel pnlDashboard;
        private System.Windows.Forms.MonthCalendar calendarWorkingStatus;
        public ucDashboard ucDashboard1;
        private System.Windows.Forms.Label lblDashboard;
        private System.Windows.Forms.Label lblUser;
        private ucUser ucUser1;
        private Guna.UI2.WinForms.Guna2GroupBox gbOnSite;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSelectedDateOnsite;
        private Guna.UI2.WinForms.Guna2PictureBox picOnSite;
        private Guna.UI2.WinForms.Guna2GroupBox gbRemote;
        private Guna.UI2.WinForms.Guna2PictureBox picRemote;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSelectedDateRemote;
        private System.Windows.Forms.FlowLayoutPanel flpOnsite;
        private System.Windows.Forms.FlowLayoutPanel flpRemote;
        private Guna.UI2.WinForms.Guna2Panel pnlShowTheme;
        public Guna.UI2.WinForms.Guna2Panel pnlShow;
        private ucProjectCardShow ucProjectCardShow1;
        private ucSprintCardShow ucSprintCardShow1;
    }
}