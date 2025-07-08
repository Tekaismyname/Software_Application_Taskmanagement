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
    public partial class SprintForm : Form
    {
        private string Mode;
        private Project currentProject;
        private int currentProjectID;

        private ProjectShowBLL bll = new ProjectShowBLL();
        private SprintShowBLL sprintbll = new SprintShowBLL();
        Project p = new Project();
        public ucProjectShowDashboard show = new ucProjectShowDashboard();

        public SprintForm()
        {
            InitializeComponent();
        }
        public SprintForm(string mode)
        {
            InitializeComponent();
            Mode = mode;
            ConfigureButtons();
        }

        private void ConfigureButtons()
        {
            btnSprintAdd.Enabled = false;
            btnSprintEdit.Enabled = false;
            btnSprintDelete.Enabled = false;
            switch (Mode)
            {
                case "Add":
                    btnSprintAdd.Enabled = true;
                    lblSpintID.Visible = false;    
                    btnSprintEdit.Visible = false;
                    btnSprintDelete.Visible = false;
                    break;
                case "Edit":
                    btnSprintEdit.Enabled = true;
                    txtSprintIdAdd.Visible = false;
                    lblSpintID.Visible = true;
                    btnSprintAdd.Visible = false;
                    btnSprintDelete.Visible = false;
                    break;
                case "Delete":
                    btnSprintDelete.Enabled = true;
                    txtSprintIdAdd.Visible = false;
                    btnSprintEdit.Visible = false;
                    btnSprintAdd.Visible = false;
                    break;
            }
        }

        public void SetAddMode(Project project)
        {
            Mode = "Add";
            currentProject = project;
            
            ConfigureButtons();

            lblProjectIDName.Text = $"{project.ProjectID} - {project.ProjectName}";
            lblProjectIDName.Visible = true;

            lblDept.Text = project.DepartmentName;
            //Range for Sprint Start and End Date
            dtpSprintStart.MinDate = project.StartDate;
            dtpSprintStart.MaxDate = project.DueDate;

            dtpSprintEnd.MinDate = project.StartDate;
            dtpSprintEnd.MaxDate = project.DueDate;
            //Load Project's Users list into CheckedListBox
            var userIds = bll.GetUserIDsByProject(project.ProjectID);
            var allUsers = bll.GetAllUsers();
            var projectUsers = allUsers.Where(u => userIds.Contains(u.UserID)).ToList();

            clbSprintUsers.Items.Clear();
            foreach (var user in projectUsers)
            {
                clbSprintUsers.Items.Add(user);
            }
        }

        public void SetEditMode(Sprint sprint)
        {
            Mode = "Edit";
            currentProject = bll.GetProjectById(sprint.ProjectID); 

            ConfigureButtons();

            lblProjectIDName.Text = $"{currentProject.ProjectID} - {currentProject.ProjectName}";
            lblProjectIDName.Visible = true;

            lblDept.Text = currentProject.DepartmentName;
            lblSpintID.Visible = true;
            lblSpintID.Text = $"{sprint.SprintID} - {sprint.SprintName}";
            txtSprintIdAdd.Visible = false;

            txtSprintName.Text = sprint.SprintName;
            txtSprintBacklog.Text = sprint.Description;
            dtpSprintStart.Value = sprint.StartDate;
            dtpSprintEnd.Value = sprint.EndDate;

            dtpSprintStart.MinDate = currentProject.StartDate;
            dtpSprintEnd.MaxDate = currentProject.DueDate;

            var userIdsInProject = bll.GetUserIDsByProject(currentProject.ProjectID);
            var allUsers = bll.GetAllUsers();
            var projectUsers = allUsers.Where(u => userIdsInProject.Contains(u.UserID)).ToList();

            var sprintUserIDs = sprintbll.GetUserIDsBySprint(sprint.SprintID, sprint.ProjectID);

            clbSprintUsers.Items.Clear();
            foreach (var user in projectUsers)
            {
                int index = clbSprintUsers.Items.Add(user);
                if (sprintUserIDs.Contains(user.UserID))
                {
                    clbSprintUsers.SetItemChecked(index, true);
                }
            }
        }

        public void SetDeleteMode(Sprint sprint)
        {
            Mode = "Delete";
            currentProject = bll.GetProjectById(sprint.ProjectID);

            ConfigureButtons();

            lblProjectIDName.Text = $"{currentProject.ProjectID} - {currentProject.ProjectName}";
            lblProjectIDName.Visible = true;

            lblDept.Text = currentProject.DepartmentName;

            lblSpintID.Visible = true;
            lblSpintID.Text = $"{sprint.SprintID} - {sprint.SprintName}";
            txtSprintIdAdd.Visible = false;

            txtSprintName.Text = sprint.SprintName;
            txtSprintBacklog.Text = sprint.Description;
            dtpSprintStart.Value = sprint.StartDate;
            dtpSprintEnd.Value = sprint.EndDate;

            txtSprintName.Enabled = false;
            txtSprintBacklog.Enabled = false;
            dtpSprintStart.Enabled = false;
            dtpSprintEnd.Enabled = false;

            var userIdsInProject = bll.GetUserIDsByProject(currentProject.ProjectID);
            var allUsers = bll.GetAllUsers();
            var projectUsers = allUsers.Where(u => userIdsInProject.Contains(u.UserID)).ToList();

            var sprintUserIDs = sprintbll.GetUserIDsBySprint(sprint.SprintID, sprint.ProjectID);

            clbSprintUsers.Items.Clear();
            foreach (var user in projectUsers)
            {
                int index = clbSprintUsers.Items.Add(user);
                if (sprintUserIDs.Contains(user.UserID))
                {
                    clbSprintUsers.SetItemChecked(index, true);
                }
            }

            clbSprintUsers.Enabled = false; 
        }



        private void btnSprintAdd_Click(object sender, EventArgs e)
        {
            Sprint s = new Sprint
            {
                SprintID = int.Parse(txtSprintIdAdd.Text),
                SprintName = txtSprintName.Text,
                Description = txtSprintBacklog.Text,
                StartDate = dtpSprintStart.Value,
                EndDate = dtpSprintEnd.Value,
                ProjectID = currentProject.ProjectID,
                Status = "Dang thuc hien"
            };

            bool result = sprintbll.AddSprint(s);

            if (result)
            {
                List<int> selectedUserIDs = new List<int>();

                foreach (var item in clbSprintUsers.CheckedItems)
                {
                    if (item is User user)
                    {
                        selectedUserIDs.Add(user.UserID);
                    }
                }

                sprintbll.AssignUsersToSprint(s.SprintID, currentProject.ProjectID, selectedUserIDs);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }

            if (currentProject.ProjectID == 0)
            {
                MessageBox.Show("Lỗi: Chưa gán Project hợp lệ cho Sprint!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (result)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Add failed!");
            }
        }

        private void btnSprintEdit_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(lblSpintID.Text.Split('-')[0].Trim(), out int sprintId))
            {
                MessageBox.Show("Không đọc được Sprint ID.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Sprint sprint = new Sprint
            {
                SprintID = sprintId,
                SprintName = txtSprintName.Text.Trim(),
                Description = txtSprintBacklog.Text.Trim(),
                StartDate = dtpSprintStart.Value,
                EndDate = dtpSprintEnd.Value,
                ProjectID = currentProject.ProjectID,
                Status = "Dang thuc hien"
            };

            bool result = sprintbll.UpdateSprint(sprint);
            if (!result)
            {
                MessageBox.Show("Cập nhật Sprint thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<int> selectedUserIDs = new List<int>();
            foreach (var item in clbSprintUsers.CheckedItems)
            {
                if (item is User user)
                {
                    selectedUserIDs.Add(user.UserID);
                }
            }

            sprintbll.AssignUsersToSprint(sprint.SprintID, currentProject.ProjectID, selectedUserIDs);

            MessageBox.Show("Cập nhật Sprint thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void btnSprintDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa Sprint này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result != DialogResult.Yes) return;

            if (!int.TryParse(lblSpintID.Text.Split('-')[0].Trim(), out int sprintId))
            {
                MessageBox.Show("Không xác định được Sprint ID.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int projectId = currentProject.ProjectID;

            bool success = sprintbll.DeleteSprint(sprintId, projectId);
            if (success)
            {
                MessageBox.Show("Đã xóa Sprint thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Xóa Sprint thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



    }
}
