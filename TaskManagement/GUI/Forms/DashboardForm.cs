using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;


namespace TaskManagement
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
            btnDashboard_Click(btnDashboard, null);

            ucDashboard1.ProjectButtonClicked += (s, e) =>
            {
                this.pnlProjectShow.Controls.Clear();
                this.pnlProjectShow.Controls.Add(ucProjectShowDashboard1);
                ucProjectShowDashboard1.LoadData();
            };

            ucDashboard1.SprintButtonClicked += (s, e) =>
            {
                this.pnlProjectShow.Controls.Clear();
                this.pnlProjectShow.Controls.Add(ucSprintShowDashboard1);
                ucSprintShowDashboard1.LoadData();
            };
        }


        private ProjectShowBLL bll = new ProjectShowBLL();

        private Guna2Button selectedButton = null;

    private void HandleButtonClick(Guna2Button btn)
        {
            if (selectedButton != null)
            {
                selectedButton.FillColor = Color.FromArgb(23, 142, 194);
            }

            selectedButton = btn;
            selectedButton.FillColor = Color.White;
        }
        private void btnDashboard_Click(object sender, MouseEventArgs e)
        {
            HandleButtonClick(btnDashboard);
            this.pnlDashboard.Controls.Clear();
            this.pnlDashboard.Controls.Add(ucDashboard1);
            //this.pnlProjectShow.Controls.Clear();
            //this.pnlProjectShow.Controls.Add(ucProjectShowDashboard1);
        }
        private void btnMarketing_Click(object sender, MouseEventArgs e)
        {
            HandleButtonClick(btnMarketing);
            this.pnlDashboard.Controls.Clear();
            this.pnlDashboard.Controls.Add(ucMarketing1);
            this.pnlProjectShow.Controls.Clear();
            this.pnlProjectShow.Controls.Add(ucProjectShowMarketing1);
        }
        private void btnCoding_Click(object sender, MouseEventArgs e)
        {
            HandleButtonClick(btnCoding);
            this.pnlDashboard.Controls.Clear();
            this.pnlDashboard.Controls.Add(ucCoding1);
            this.pnlProjectShow.Controls.Clear();
            this.pnlProjectShow.Controls.Add(ucProjectShowCoding1);
        }
        private void btnRevenue_Click(object sender, MouseEventArgs e)
        {
           HandleButtonClick(btnRevenue);
           this.pnlDashboard.Controls.Clear();
           this.pnlDashboard.Controls.Add(ucRevenue1);
        }
        private void btnUser_Click(object sender, MouseEventArgs e)
        {
            HandleButtonClick(btnUser);
            this.pnlDashboard.Controls.Clear();
            this.pnlDashboard.Controls.Add(ucUser1);
        }


        private void LoadWorkingStatus(DateTime date)
        {
            DataTable dt = bll.GetWorkingStatusByDate(date);

            flpOnsite.Controls.Clear();
            flpRemote.Controls.Clear();

            foreach (DataRow row in dt.Rows)
            {
                string fullName = row["FullName"].ToString();
                string status = row["Status"].ToString();

                Label lbl = new Label();
                lbl.Text = "• " + fullName;
                lbl.Font = new Font("Segoe UI", 10);
                lbl.AutoSize = true;
                lbl.Margin = new Padding(3);

                if (status == "On-site")
                    flpOnsite.Controls.Add(lbl);
                else if (status == "Remote")
                    flpRemote.Controls.Add(lbl);
            }
        }
        private void calendarWorkingStatus_DateChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = calendarWorkingStatus.SelectionStart;
            lblSelectedDateOnsite.Text = "Date: " + selectedDate.ToString("dd/MM/yyyy");
            lblSelectedDateRemote.Text = "Date: " + selectedDate.ToString("dd/MM/yyyy");
            LoadWorkingStatus(selectedDate);
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void ucDashboard1_Load(object sender, EventArgs e)
        {

        }

        private void lblSelectedDateOnsite_Click(object sender, EventArgs e)
        {

        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            DateTime today = calendarWorkingStatus.SelectionStart;
            lblSelectedDateOnsite.Text = "Date: " + today.ToString("dd/MM/yyyy");
            lblSelectedDateRemote.Text = "Date: " + today.ToString("dd/MM/yyyy");
            LoadWorkingStatus(DateTime.Today);
        }
    }
}
