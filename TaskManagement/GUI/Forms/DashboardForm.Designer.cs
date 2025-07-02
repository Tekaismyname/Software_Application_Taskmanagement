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
            this.lblRevenue = new System.Windows.Forms.Label();
            this.lblCoding = new System.Windows.Forms.Label();
            this.lblMarketing = new System.Windows.Forms.Label();
            this.lblDashboard = new System.Windows.Forms.Label();
            this.btnCoding = new Guna.UI2.WinForms.Guna2Button();
            this.btnMarketing = new Guna.UI2.WinForms.Guna2Button();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.btnUser = new Guna.UI2.WinForms.Guna2Button();
            this.btnRevenue = new Guna.UI2.WinForms.Guna2Button();
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
            this.ucRevenue1 = new TaskManagement.ucRevenue();
            this.ucCoding1 = new TaskManagement.ucCoding();
            this.ucDashboard1 = new TaskManagement.ucDashboard();
            this.ucMarketing1 = new TaskManagement.ucMarketing();
            this.pnlProjectShow = new Guna.UI2.WinForms.Guna2Panel();
            this.ucSprintShowDashboard1 = new TaskManagement.ucSprintShowDashboard();
            this.ucProjectShowCoding1 = new TaskManagement.ucProjectShowCoding();
            this.ucProjectShowDashboard1 = new TaskManagement.ucProjectShowDashboard();
            this.ucProjectShowMarketing1 = new TaskManagement.ucProjectShowMarketing();
            this.pnlSideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picVertexLogo)).BeginInit();
            this.pnlPlaceTime.SuspendLayout();
            this.gbRemote.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRemote)).BeginInit();
            this.gbOnSite.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picOnSite)).BeginInit();
            this.pnlDashboard.SuspendLayout();
            this.pnlProjectShow.SuspendLayout();
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
            this.pnlSideBar.Controls.Add(this.lblRevenue);
            this.pnlSideBar.Controls.Add(this.lblCoding);
            this.pnlSideBar.Controls.Add(this.lblMarketing);
            this.pnlSideBar.Controls.Add(this.lblDashboard);
            this.pnlSideBar.Controls.Add(this.btnCoding);
            this.pnlSideBar.Controls.Add(this.btnMarketing);
            this.pnlSideBar.Controls.Add(this.btnLogout);
            this.pnlSideBar.Controls.Add(this.btnUser);
            this.pnlSideBar.Controls.Add(this.btnRevenue);
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
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(0, 537);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(96, 27);
            this.lblUser.TabIndex = 11;
            this.lblUser.Text = "User";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRevenue
            // 
            this.lblRevenue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRevenue.Location = new System.Drawing.Point(0, 447);
            this.lblRevenue.Name = "lblRevenue";
            this.lblRevenue.Size = new System.Drawing.Size(96, 27);
            this.lblRevenue.TabIndex = 10;
            this.lblRevenue.Text = "Revenue";
            this.lblRevenue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCoding
            // 
            this.lblCoding.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoding.Location = new System.Drawing.Point(0, 357);
            this.lblCoding.Name = "lblCoding";
            this.lblCoding.Size = new System.Drawing.Size(96, 27);
            this.lblCoding.TabIndex = 9;
            this.lblCoding.Text = "Coding";
            this.lblCoding.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMarketing
            // 
            this.lblMarketing.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarketing.Location = new System.Drawing.Point(0, 267);
            this.lblMarketing.Name = "lblMarketing";
            this.lblMarketing.Size = new System.Drawing.Size(96, 27);
            this.lblMarketing.TabIndex = 8;
            this.lblMarketing.Text = "Marketing";
            this.lblMarketing.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDashboard
            // 
            this.lblDashboard.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashboard.Location = new System.Drawing.Point(0, 177);
            this.lblDashboard.Name = "lblDashboard";
            this.lblDashboard.Size = new System.Drawing.Size(96, 27);
            this.lblDashboard.TabIndex = 3;
            this.lblDashboard.Text = "Dashboard";
            this.lblDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCoding
            // 
            this.btnCoding.BorderRadius = 10;
            this.btnCoding.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.btnCoding.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnCoding.CustomImages.CheckedImage = ((System.Drawing.Image)(resources.GetObject("resource.CheckedImage")));
            this.btnCoding.CustomImages.HoveredImage = ((System.Drawing.Image)(resources.GetObject("resource.HoveredImage")));
            this.btnCoding.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btnCoding.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCoding.CustomImages.ImageSize = new System.Drawing.Size(30, 30);
            this.btnCoding.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCoding.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCoding.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCoding.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCoding.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(142)))), ((int)(((byte)(194)))));
            this.btnCoding.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCoding.ForeColor = System.Drawing.Color.White;
            this.btnCoding.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.btnCoding.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(29)))), ((int)(((byte)(97)))));
            this.btnCoding.HoverState.FillColor = System.Drawing.Color.White;
            this.btnCoding.ImageSize = new System.Drawing.Size(30, 30);
            this.btnCoding.Location = new System.Drawing.Point(3, 312);
            this.btnCoding.Name = "btnCoding";
            this.btnCoding.Size = new System.Drawing.Size(90, 46);
            this.btnCoding.TabIndex = 7;
            this.btnCoding.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnCoding_Click);
            // 
            // btnMarketing
            // 
            this.btnMarketing.BorderRadius = 10;
            this.btnMarketing.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.btnMarketing.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnMarketing.CustomImages.CheckedImage = ((System.Drawing.Image)(resources.GetObject("resource.CheckedImage1")));
            this.btnMarketing.CustomImages.HoveredImage = ((System.Drawing.Image)(resources.GetObject("resource.HoveredImage1")));
            this.btnMarketing.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.btnMarketing.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnMarketing.CustomImages.ImageSize = new System.Drawing.Size(30, 30);
            this.btnMarketing.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMarketing.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMarketing.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMarketing.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMarketing.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(142)))), ((int)(((byte)(194)))));
            this.btnMarketing.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMarketing.ForeColor = System.Drawing.Color.White;
            this.btnMarketing.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.btnMarketing.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(29)))), ((int)(((byte)(97)))));
            this.btnMarketing.HoverState.FillColor = System.Drawing.Color.White;
            this.btnMarketing.ImageSize = new System.Drawing.Size(30, 30);
            this.btnMarketing.Location = new System.Drawing.Point(3, 222);
            this.btnMarketing.Name = "btnMarketing";
            this.btnMarketing.Size = new System.Drawing.Size(90, 46);
            this.btnMarketing.TabIndex = 6;
            this.btnMarketing.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnMarketing_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLogout.BorderRadius = 10;
            this.btnLogout.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnLogout.CustomImages.CheckedImage = ((System.Drawing.Image)(resources.GetObject("resource.CheckedImage2")));
            this.btnLogout.CustomImages.HoveredImage = ((System.Drawing.Image)(resources.GetObject("resource.HoveredImage2")));
            this.btnLogout.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
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
            this.btnLogout.Location = new System.Drawing.Point(3, 675);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(90, 46);
            this.btnLogout.TabIndex = 4;
            // 
            // btnUser
            // 
            this.btnUser.BorderRadius = 10;
            this.btnUser.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnUser.CustomImages.CheckedImage = ((System.Drawing.Image)(resources.GetObject("resource.CheckedImage3")));
            this.btnUser.CustomImages.HoveredImage = ((System.Drawing.Image)(resources.GetObject("resource.HoveredImage3")));
            this.btnUser.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
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
            this.btnUser.Location = new System.Drawing.Point(3, 490);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(90, 46);
            this.btnUser.TabIndex = 3;
            this.btnUser.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnUser_Click);
            // 
            // btnRevenue
            // 
            this.btnRevenue.BorderRadius = 10;
            this.btnRevenue.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnRevenue.CustomImages.CheckedImage = ((System.Drawing.Image)(resources.GetObject("resource.CheckedImage4")));
            this.btnRevenue.CustomImages.HoveredImage = ((System.Drawing.Image)(resources.GetObject("resource.HoveredImage4")));
            this.btnRevenue.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image4")));
            this.btnRevenue.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnRevenue.CustomImages.ImageSize = new System.Drawing.Size(30, 30);
            this.btnRevenue.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRevenue.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRevenue.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRevenue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRevenue.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(142)))), ((int)(((byte)(194)))));
            this.btnRevenue.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRevenue.ForeColor = System.Drawing.Color.White;
            this.btnRevenue.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.btnRevenue.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(29)))), ((int)(((byte)(97)))));
            this.btnRevenue.HoverState.FillColor = System.Drawing.Color.White;
            this.btnRevenue.ImageSize = new System.Drawing.Size(30, 30);
            this.btnRevenue.Location = new System.Drawing.Point(3, 402);
            this.btnRevenue.Name = "btnRevenue";
            this.btnRevenue.Size = new System.Drawing.Size(90, 46);
            this.btnRevenue.TabIndex = 2;
            this.btnRevenue.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnRevenue_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BorderRadius = 10;
            this.btnDashboard.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.btnDashboard.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnDashboard.CustomImages.CheckedImage = ((System.Drawing.Image)(resources.GetObject("resource.CheckedImage5")));
            this.btnDashboard.CustomImages.HoveredImage = ((System.Drawing.Image)(resources.GetObject("resource.HoveredImage5")));
            this.btnDashboard.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image5")));
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
            this.btnDashboard.Location = new System.Drawing.Point(3, 132);
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
            this.gbRemote.Location = new System.Drawing.Point(9, 268);
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
            this.calendarWorkingStatus.Location = new System.Drawing.Point(9, 507);
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
            this.pnlDashboard.Controls.Add(this.ucRevenue1);
            this.pnlDashboard.Controls.Add(this.ucCoding1);
            this.pnlDashboard.Controls.Add(this.ucDashboard1);
            this.pnlDashboard.Controls.Add(this.ucMarketing1);
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
            // ucRevenue1
            // 
            this.ucRevenue1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucRevenue1.Location = new System.Drawing.Point(0, 154);
            this.ucRevenue1.Name = "ucRevenue1";
            this.ucRevenue1.Size = new System.Drawing.Size(927, 0);
            this.ucRevenue1.TabIndex = 4;
            // 
            // ucCoding1
            // 
            this.ucCoding1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucCoding1.Location = new System.Drawing.Point(0, 154);
            this.ucCoding1.Name = "ucCoding1";
            this.ucCoding1.Size = new System.Drawing.Size(927, 0);
            this.ucCoding1.TabIndex = 3;
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
            // ucMarketing1
            // 
            this.ucMarketing1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucMarketing1.Location = new System.Drawing.Point(0, 0);
            this.ucMarketing1.Name = "ucMarketing1";
            this.ucMarketing1.Size = new System.Drawing.Size(927, 154);
            this.ucMarketing1.TabIndex = 3;
            // 
            // pnlProjectShow
            // 
            this.pnlProjectShow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlProjectShow.BackColor = System.Drawing.Color.White;
            this.pnlProjectShow.BorderColor = System.Drawing.Color.White;
            this.pnlProjectShow.BorderRadius = 10;
            this.pnlProjectShow.BorderThickness = 5;
            this.pnlProjectShow.Controls.Add(this.ucSprintShowDashboard1);
            this.pnlProjectShow.Controls.Add(this.ucProjectShowCoding1);
            this.pnlProjectShow.Controls.Add(this.ucProjectShowDashboard1);
            this.pnlProjectShow.Controls.Add(this.ucProjectShowMarketing1);
            this.pnlProjectShow.Location = new System.Drawing.Point(102, 160);
            this.pnlProjectShow.Name = "pnlProjectShow";
            this.pnlProjectShow.Size = new System.Drawing.Size(918, 566);
            this.pnlProjectShow.TabIndex = 3;
            // 
            // ucSprintShowDashboard1
            // 
            this.ucSprintShowDashboard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucSprintShowDashboard1.Location = new System.Drawing.Point(0, 0);
            this.ucSprintShowDashboard1.Name = "ucSprintShowDashboard1";
            this.ucSprintShowDashboard1.Size = new System.Drawing.Size(918, 566);
            this.ucSprintShowDashboard1.TabIndex = 3;
            // 
            // ucProjectShowCoding1
            // 
            this.ucProjectShowCoding1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucProjectShowCoding1.Location = new System.Drawing.Point(0, 0);
            this.ucProjectShowCoding1.Name = "ucProjectShowCoding1";
            this.ucProjectShowCoding1.Size = new System.Drawing.Size(918, 566);
            this.ucProjectShowCoding1.TabIndex = 2;
            // 
            // ucProjectShowDashboard1
            // 
            this.ucProjectShowDashboard1.BackColor = System.Drawing.Color.Gray;
            this.ucProjectShowDashboard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucProjectShowDashboard1.Location = new System.Drawing.Point(0, 0);
            this.ucProjectShowDashboard1.Name = "ucProjectShowDashboard1";
            this.ucProjectShowDashboard1.Size = new System.Drawing.Size(918, 566);
            this.ucProjectShowDashboard1.TabIndex = 0;
            // 
            // ucProjectShowMarketing1
            // 
            this.ucProjectShowMarketing1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucProjectShowMarketing1.Location = new System.Drawing.Point(0, 0);
            this.ucProjectShowMarketing1.Name = "ucProjectShowMarketing1";
            this.ucProjectShowMarketing1.Size = new System.Drawing.Size(918, 566);
            this.ucProjectShowMarketing1.TabIndex = 1;
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1265, 732);
            this.Controls.Add(this.pnlProjectShow);
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
            this.pnlProjectShow.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel pnlSideBar;
        private Guna.UI2.WinForms.Guna2PictureBox picVertexLogo;
        private Guna.UI2.WinForms.Guna2Button btnDashboard;
        private Guna.UI2.WinForms.Guna2Button btnRevenue;
        private Guna.UI2.WinForms.Guna2Button btnUser;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
        private Guna.UI2.WinForms.Guna2Button btnCoding;
        private Guna.UI2.WinForms.Guna2Button btnMarketing;
        private Guna.UI2.WinForms.Guna2Panel pnlPlaceTime;
        private Guna.UI2.WinForms.Guna2Panel pnlDashboard;
        private System.Windows.Forms.MonthCalendar calendarWorkingStatus;
        private ucDashboard ucDashboard1;
        private System.Windows.Forms.Label lblDashboard;
        private System.Windows.Forms.Label lblMarketing;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblRevenue;
        private System.Windows.Forms.Label lblCoding;
        private ucMarketing ucMarketing1;
        private ucCoding ucCoding1;
        private ucRevenue ucRevenue1;
        private ucUser ucUser1;
        private Guna.UI2.WinForms.Guna2Panel pnlProjectShow;
        public ucProjectShowDashboard ucProjectShowDashboard1;
        private ucProjectShowMarketing ucProjectShowMarketing1;
        private ucProjectShowCoding ucProjectShowCoding1;
        private Guna.UI2.WinForms.Guna2GroupBox gbOnSite;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSelectedDateOnsite;
        private Guna.UI2.WinForms.Guna2PictureBox picOnSite;
        private Guna.UI2.WinForms.Guna2GroupBox gbRemote;
        private Guna.UI2.WinForms.Guna2PictureBox picRemote;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSelectedDateRemote;
        private System.Windows.Forms.FlowLayoutPanel flpOnsite;
        private System.Windows.Forms.FlowLayoutPanel flpRemote;
        public ucSprintShowDashboard ucSprintShowDashboard1;
    }
}