using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskManagement.BLL;
using TaskManagement.DAL;
using TaskManagement.DTO;


namespace TaskManagement
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
            btnDashboard_Click(btnDashboard, null);
            ucDashboard1.AddProjectRequested += (s, e) =>
            {
                ProjectForm form = new ProjectForm();
                form.SetAddMode();
                if (form.ShowDialog() == DialogResult.OK)
                {
                    // Sau khi thêm thành công, nếu ucProjectCardShow đang hiện → reload
                    if (pnlShow.Controls.Count > 0 && pnlShow.Controls[0] is ucProjectCardShow projectUC)
                    {
                        projectUC.LoadProjectCardsToPanel();
                    }
                }
            };
            ucDashboard1.ProjectButtonClicked += (s, e) =>
            {
                ShowProjectView();
            };

            ucDashboard1.SprintButtonClicked += (s, e) =>
            {
                ShowSprintView();
            };
        }

        private ProjectShowBLL bll = new ProjectShowBLL();
        private SprintShowBLL sprintbll = new SprintShowBLL();
        private ucProjectCardShow projectUC;
        private ucSprintCardShow sprintUC;
        private Project currentProject;

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


        public void ShowSprintFromProject(Project p)
        {
            ucDashboard1.HandleButtonClick(ucDashboard1.btnSprints);
            if (sprintUC == null)
            {
                sprintUC = new ucSprintCardShow();
                sprintUC.Dock = DockStyle.Fill;
            }

            // Chỉ clear nếu uc khác đang nằm trong pnlShow
            if (!(pnlShow.Controls.Count > 0 && pnlShow.Controls[0] == sprintUC))
            {
                pnlShow.Controls.Clear();
                pnlShow.Controls.Add(sprintUC);
                sprintUC.BringToFront();
            }

            sprintUC.LoadByProject(p); // luôn load lại đúng project
        }


        public void ShowProjectView()
        {
            if (projectUC == null)
            {
                projectUC = new ucProjectCardShow();
                projectUC.Dock = DockStyle.Fill;
            }

            if (!(pnlShow.Controls.Count > 0 && pnlShow.Controls[0] == projectUC))
            {
                pnlShow.Controls.Clear();
                pnlShow.Controls.Add(projectUC);
            }
        }
        public void ShowSprintView()
        {
            if (sprintUC == null)
            {
                sprintUC = new ucSprintCardShow();
                sprintUC.Dock = DockStyle.Fill;
            }

            if (!(pnlShow.Controls.Count > 0 && pnlShow.Controls[0] == sprintUC))
            {
                pnlShow.Controls.Clear();
                pnlShow.Controls.Add(sprintUC);
            }
        }
        private void ucDashboard1_Load(object sender, EventArgs e)
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
