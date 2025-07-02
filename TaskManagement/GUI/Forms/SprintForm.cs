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

namespace TaskManagement
{
    public partial class SprintForm : Form
    {
        private string Mode;
        private Project currentProject;

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
                    cboSprintID.Visible = false;
                    cboDept.Visible = false;
                    break;
                case "Edit":
                    btnSprintEdit.Enabled = true;
                    txtSprintIdAdd.Visible = false;
                    break;
                case "Delete":
                    btnSprintDelete.Enabled = true;
                    txtSprintIdAdd.Visible = false;
                    break;
            }
        }

        private void SprintForm_Load(object sender, EventArgs e)
        {
            LoadUserList();
            LoadDepartment();
            LoadProjectComboBox();
        }
        //Load danh sach Projects
        //Load danh sach User vao CheckedListBox
        private void LoadUserList()
        {
            List<User> users = bll.GetAllUsers();
            if (users != null && users.Count > 0)
            {
                clbSprintUsers.Items.Clear();
                List<User> userList = bll.GetAllUsers();
                foreach (var user in users)
                {
                    clbSprintUsers.Items.Add(user.FullName, false);
                }
            }
            else
            {
                MessageBox.Show("No users found.");
            }
        }
        private void LoadDepartment()
        {
            DataTable dt = bll.GetAllDepartments();
            cboDept.DataSource = dt;
            cboDept.DisplayMember = "DepartmentName";
            cboDept.ValueMember = "DepartmentID";
            cboDept.SelectedIndex = -1; //Khong tu chon
        }
        private void LoadProjectComboBox()
        {

            DataTable dt = sprintbll.GetProjectIdAndName();

            dt.Columns.Add("Display", typeof(string));
            foreach (DataRow row in dt.Rows)
            {
                row["Display"] = row["ProjectID"] + " - " + row["ProjectName"];
            }

            cboProjectIDName.DataSource = dt;
            cboProjectIDName.DisplayMember = "Display";
            cboProjectIDName.ValueMember = "ProjectID";
            cboProjectIDName.SelectedIndex = -1;
        }

        private void cboProjectIDName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboProjectIDName.SelectedValue == null || cboProjectIDName.SelectedIndex == -1)
                return;

            try
            {
                if (cboProjectIDName.SelectedItem is DataRowView rowView)
                {
                    int projectID = Convert.ToInt32(rowView["ProjectID"]);

                    Project selectedProject = bll.GetProjectById(projectID);

                    if (selectedProject != null)
                    {
                        //Show the current Project Datetime
                        dtpSprintStart.Value = selectedProject.StartDate;
                        dtpSprintEnd.Value = selectedProject.DueDate;

                        lblDept.Text = selectedProject.DepartmentName;
                        if (Mode != "Add")
                        {
                            DataTable sprints = sprintbll.GetSprintsByProject(projectID);
                            sprints.Columns.Add("Display", typeof(string));
                            foreach (DataRow row in sprints.Rows)
                            {
                                row["Display"] = row["SprintID"] + " - " + row["SprintName"];
                            }

                            cboSprintID.DataSource = sprints;
                            cboSprintID.DisplayMember = "Display";
                            cboSprintID.ValueMember = "SprintID";
                            cboSprintID.SelectedIndex = -1;
                        }

                        List<int> assignedUserIDs = bll.GetUserIDsByProject(projectID);
                        List<User> allUsers = bll.GetAllUsers(); 

                        clbSprintUsers.Items.Clear();
                        foreach (User user in allUsers)
                        {
                            if (assignedUserIDs.Contains(user.UserID))
                            {
                                int index = clbSprintUsers.Items.Add(user.FullName);
                            }
                        }

                        int count = sprintbll.CountSprintsByProject(projectID);
                        txtSprintIdAdd.PlaceholderText = $"Sprints remained: {count}";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fail to choose project: " + ex.Message);
            }
        }

        private void btnSprintAdd_Click(object sender, EventArgs e)
        {
            int projectId = (cboProjectIDName.SelectedItem is DataRowView rowView)
            ? Convert.ToInt32(rowView["ProjectID"])
            : Convert.ToInt32(cboProjectIDName.SelectedValue);
            try
            {
                if (string.IsNullOrWhiteSpace(txtSprintIdAdd.Text) || !int.TryParse(txtSprintIdAdd.Text, out int sprintID))
                {
                    MessageBox.Show("ID must be Integer.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtSprintName.Text))
                {
                    MessageBox.Show("Please type in Sprint name.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtSprintBacklog.Text))
                {
                    MessageBox.Show("Please type in Backlog.");
                    return;
                }

                if (cboProjectIDName.SelectedIndex == -1)
                {
                    MessageBox.Show("Please choose a project.");
                    return;
                }

                if (dtpSprintEnd.Value < dtpSprintStart.Value)
                {
                    MessageBox.Show("End date should be larger than start date.");
                    return;
                }

                Sprint sprint = new Sprint
                {
                    SprintID = sprintID,
                    SprintName = txtSprintName.Text.Trim(),
                    Description = txtSprintBacklog.Text.Trim(),
                    Status = "Đang thực hiện",
                    StartDate = dtpSprintStart.Value,
                    EndDate = dtpSprintEnd.Value,
                    ProjectID = Convert.ToInt32(cboProjectIDName.SelectedValue)
                };

                bool success = sprintbll.AddSprint(sprint);
                if (!success)
                {
                    MessageBox.Show("Cannot add a Sprint where typed SprintID is already existed.");
                    return;
                }

                List<int> selectedUserIDs = new List<int>();
                foreach (var item in clbSprintUsers.CheckedItems)
                {
                    string fullName = item.ToString();
                    var user = bll.GetAllUsers().FirstOrDefault(u => u.FullName == fullName);
                    if (user != null)
                        selectedUserIDs.Add(user.UserID);
                }
             
                sprintbll.AssignUsersToSprint(sprint.SprintID, projectId, selectedUserIDs);
                MessageBox.Show("Successfully added sprint!");
                ((DashboardForm)Application.OpenForms["DashboardForm"]).ucSprintShowDashboard1.LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void cboSprintID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSprintID.SelectedIndex == -1 || cboProjectIDName.SelectedIndex == -1) return;

            int projectId = (cboProjectIDName.SelectedItem is DataRowView rowView)
           ? Convert.ToInt32(rowView["ProjectID"])
           : Convert.ToInt32(cboProjectIDName.SelectedValue);
            int sprintId = (cboSprintID.SelectedItem is DataRowView rowView1)
            ? Convert.ToInt32(rowView1["SprintID"])
            : Convert.ToInt32(cboSprintID.SelectedValue);

            Sprint selected = sprintbll.GetSprintById(sprintId, projectId);

            if (selected != null)
            {
                txtSprintName.Text = selected.SprintName;
                txtSprintBacklog.Text = selected.Description;
                dtpSprintStart.Value = selected.StartDate;
                dtpSprintEnd.Value = selected.EndDate;

                List<int> projectUserIds = bll.GetUserIDsByProject(projectId);
                List<User> allUsers = bll.GetAllUsers();

                // Lấy danh sách Users đang được gán cho Sprint
                List<int> sprintUserIds = sprintbll.GetUserIDsBySprint(sprintId, projectId);

                clbSprintUsers.Items.Clear();

                foreach (User user in allUsers)
                {
                    if (projectUserIds.Contains(user.UserID))
                    {
                        int index = clbSprintUsers.Items.Add(user.FullName);
                        if (sprintUserIds.Contains(user.UserID))
                        {
                            clbSprintUsers.SetItemChecked(index, true); // Check nếu đang có trong Sprint
                        }
                    }
                }
            }
        }


        private void btnSprintEdit_Click(object sender, EventArgs e)
        {
            int projectId = (cboProjectIDName.SelectedItem is DataRowView rowView)
            ? Convert.ToInt32(rowView["ProjectID"])
            : Convert.ToInt32(cboProjectIDName.SelectedValue);
            int sprintId = (cboSprintID.SelectedItem is DataRowView rowView1)
            ? Convert.ToInt32(rowView1["SprintID"])
            : Convert.ToInt32(cboSprintID.SelectedValue);
            try
            {
                if (cboSprintID.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng chọn một Sprint để chỉnh sửa.");
                    return;
                }

                Sprint updated = new Sprint
                {
                    SprintID = sprintId,
                    ProjectID = projectId,
                    SprintName = txtSprintName.Text,
                    Description = txtSprintBacklog.Text,
                    Status = "Đang thực hiện",
                    StartDate = dtpSprintStart.Value,
                    EndDate = dtpSprintEnd.Value
                };

                sprintbll.UpdateSprint(updated);

                // Cập nhật lại users
                List<int> userIDs = new List<int>();
                foreach (var item in clbSprintUsers.CheckedItems)
                {
                    string fullName = item.ToString();
                    var user = bll.GetAllUsers().FirstOrDefault(u => u.FullName == fullName);
                    if (user != null)
                        userIDs.Add(user.UserID);
                }

                sprintbll.AssignUsersToSprint(sprintId, projectId, userIDs);

                MessageBox.Show("Cập nhật Sprint thành công!");
                ((DashboardForm)Application.OpenForms["DashboardForm"]).ucSprintShowDashboard1.LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật Sprint: " + ex.Message);
            }
        }

    }
}
