using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskManagement.DTO;


namespace TaskManagement
{
    public partial class ucDashboard : UserControl
    {
        public event EventHandler AddProjectRequested;
        public event Action<List<Project>> RequestShowProjectCards;
        public event Action<Project> RequestShowProjectDetails;
        public event EventHandler ProjectButtonClicked;
        public event EventHandler SprintButtonClicked;
        ProjectShowBLL bll = new ProjectShowBLL();
        public event EventHandler ProjectDataChanged;
        public ucDashboard()
        {
            InitializeComponent();
        }

        public void LoadDefaultView()
        {
            btnProjects_Click(btnProjects, null);
        }
        private Guna2Button selectedButton = null;

        public void HandleButtonClick(Guna2Button btn)
        {
            if (selectedButton != null)
            {
                selectedButton.ForeColor = Color.Gray;
                selectedButton.FillColor = Color.White;
                selectedButton.CustomBorderColor = Color.White;
            }

            selectedButton = btn;
            selectedButton.FillColor = Color.White;
            selectedButton.ForeColor = Color.Black;
            selectedButton.CustomBorderColor = Color.FromArgb(27, 161, 226);

        }
        private void btnProjects_Click(object sender, MouseEventArgs e)
        {
            HandleButtonClick(btnProjects);
            picAction.Visible = true;
            cboActionDashboard.Visible = true;
            cboActionSprint.Visible = false;
            btnAddProject.Visible = true;
            ProjectButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        private void btnSprints_Click(object sender, MouseEventArgs e)
        {
            HandleButtonClick(btnSprints);
            picAction.Visible = false;
            cboActionDashboard.Visible = false;
            btnAddProject.Visible = false;

            SprintButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        private void btnReports_Click(object sender, MouseEventArgs e)
        {
            HandleButtonClick(btnReports);
            picAction.Visible = false;
            cboActionDashboard.Visible = false;
           
        }

        private void ucDashboard_Load(object sender, EventArgs e)
        {
            btnProjects_Click(btnProjects, null);
        }


        private void cboActionDashboard_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedAction = cboActionDashboard.SelectedItem.ToString();
            ProjectForm projectForm = new ProjectForm(selectedAction);
            projectForm.ShowDialog();
            ProjectDataChanged?.Invoke(this, EventArgs.Empty);
        }
        private void cboActionSprint_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboActionSprint.SelectedItem == null) return;

            string selectedAction = cboActionSprint.SelectedItem.ToString();
            SprintForm sprintForm = new SprintForm(selectedAction);
            sprintForm.ShowDialog();

            // Nếu cần load lại dữ liệu, bạn khai báo event tương tự Project:
            //SprintDataChanged?.Invoke(this, EventArgs.Empty);
        }

        private void btnAddProject_Click(object sender, EventArgs e)
        {
            AddProjectRequested?.Invoke(this, EventArgs.Empty);

        }
    }
}
