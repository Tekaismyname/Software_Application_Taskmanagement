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
using TaskManagement.DTO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TaskManagement
{
    public partial class TaskForm : Form
    {
        private string Mode;
        private Project currentProject;
        private Sprint currentSprint;

        private TaskShowBLL taskbll = new TaskShowBLL();
        private SprintShowBLL sprintbll = new SprintShowBLL();
        private ProjectShowBLL projectbll = new ProjectShowBLL();
        public TaskForm()
        {
            InitializeComponent();
        }
        public TaskForm(string mode)
        {
            InitializeComponent();
            Mode = mode;
            ConfigureButtons();
        }

        private void ConfigureButtons()
        {
            btnAddTask.Enabled = false;
            btnEditTask.Enabled = false;
            switch (Mode)
            {
                case "Add":
                    btnAddTask.Enabled = true;
                    btnEditTask.Visible = false;
                    break;
                case "Edit":
                    btnEditTask.Enabled = true;
                    btnAddTask.Visible = false;
                    break;
            }
        }

        public void SetAddMode(Sprint sprint, Project project)
        {
            Mode = "Add";
            currentSprint = sprint;
            currentProject = project;

            lblSprintIDName.Text = $"{sprint.SprintID} - {sprint.SprintName}";

            // Không cho người dùng chỉnh ngày task – phải theo sprint
            dtpTaskStart.Value = sprint.StartDate;
            dtpTaskEnd.Value = sprint.EndDate;
            dtpTaskStart.Enabled = false;
            dtpTaskEnd.Enabled = false;

            chkTaskStatus.Checked = false;
            chkTaskStatus.Enabled = false;

            // Load user thuộc sprint
            var sprintUserIDs = sprintbll.GetUserIDsBySprint(sprint.SprintID, sprint.ProjectID);
            var allUsers = projectbll.GetAllUsers();
            var sprintUsers = allUsers.Where(u => sprintUserIDs.Contains(u.UserID)).ToList();

            clbTaskUsers.Items.Clear();
            foreach (var user in sprintUsers)
            {
                clbTaskUsers.Items.Add(user);
            }
        }

    }
}
