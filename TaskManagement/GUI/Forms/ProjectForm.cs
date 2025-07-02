using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskManagement.DTO;

namespace TaskManagement
{
    public partial class ProjectForm : Form
    {
        private string Mode;
        private Project currentProject;

        private ProjectShowBLL bll = new ProjectShowBLL();
        Project p = new Project();
        public ucProjectShowDashboard show = new ucProjectShowDashboard();

        public ProjectForm()
        {
            InitializeComponent();
        }
        public ProjectForm(string mode)
        {
            InitializeComponent();
            Mode = mode;
            ConfigureButtons();
        }

        private void ConfigureButtons()
        {
            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            switch (Mode)
            {
                case "Add":
                    btnAdd.Enabled = true;
                    btnCheckID.Visible = false;
                    break;
                case "Edit":
                    btnEdit.Enabled = true;
                    break;
                case "Delete":
                    btnDelete.Enabled = true;
                    btnCheckID.Visible = false;
                    break;
            }
        }

        private void ProjectForm_Load(object sender, EventArgs e)
        {
            LoadUserList();
            LoadDepartment();
        }
        //Load danh sach Projects
        //Load danh sach User vao CheckedListBox
        private void LoadUserList()
        {
            List<User> users = bll.GetAllUsers();
            if (users != null && users.Count > 0)
            {
                clbUsers.Items.Clear();
                List<User> userList = bll.GetAllUsers();
                foreach (var user in users)
                {
                    clbUsers.Items.Add(user.FullName, false);
                }
            }
            else
            {
                MessageBox.Show("No users found.");
            }
        }
        //Load danh sach phong ban vao ComboBox
        private void LoadDepartment()
        {
            DataTable dt = bll.GetAllDepartments();
            cboDept.DataSource = dt;
            cboDept.DisplayMember = "DepartmentName";
            cboDept.ValueMember = "DepartmentID";
            cboDept.SelectedIndex = -1; //Khong tu chon
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Project p = new Project
            {
                ProjectID = int.Parse(txtID.Text),
                ProjectName = txtProName.Text,
                Description = txtBacklog.Text,
                Status = "Đang thực hiện",
                Revenue = decimal.Parse(txtRevenue.Text),
                StartDate = dtpStart.Value,
                DueDate = dtpEnd.Value,
                DepartmentID = Convert.ToInt32(cboDept.SelectedValue)
            };
            int newProjectId = bll.AddProject(p);
            List<int> userIDs = new List<int>();
            foreach (var item in clbUsers.CheckedItems)
            {
                string fullName = item.ToString();
                var user = bll.GetAllUsers().FirstOrDefault(u => u.FullName == fullName);
                if (user != null)
                    userIDs.Add(user.UserID);
            }
            bll.AssignUsersToProject(newProjectId, userIDs);
            MessageBox.Show("Add project successfully!");
            bll.getProjectList();
            //Lam moi dashboard de load du lieu moi len
            ((DashboardForm)Application.OpenForms["DashboardForm"]).ucProjectShowDashboard1.LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int projectID = int.Parse(txtID.Text);
            bll.DeleteUsersFromProjects(projectID);
            bll.DeleteProject(projectID);
            MessageBox.Show("Delete project successfully!");
            ((DashboardForm)Application.OpenForms["DashboardForm"]).ucProjectShowDashboard1.LoadData();
            ClearForm();
        }
        private void ClearForm()
        {
            txtID.Clear();
            txtProName.Clear();
            txtBacklog.Clear();
            txtRevenue.Clear();
            cboDept.SelectedIndex = -1;
            dtpStart.Value = DateTime.Now;
            dtpEnd.Value = DateTime.Now;

            for (int i = 0; i < clbUsers.Items.Count; i++)
                clbUsers.SetItemChecked(i, false);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int projectID = int.Parse(txtID.Text);
            Project updated = new Project
            {
                ProjectID = projectID,
                ProjectName = txtProName.Text,
                Description = txtBacklog.Text,
                Status = "Đang thực hiện",
                Revenue = decimal.Parse(txtRevenue.Text),
                StartDate = dtpStart.Value,
                DueDate = dtpEnd.Value,
                DepartmentID = Convert.ToInt32(cboDept.SelectedValue)
            };
            bll.UpdateProject(updated);
            List<int> userIDs = new List<int>();
            foreach (var item in clbUsers.CheckedItems)
            {
                string fullName = item.ToString();
                var user = bll.GetAllUsers().FirstOrDefault(u => u.FullName == fullName);
                if (user != null)
                    userIDs.Add(user.UserID);
            }
            bll.DeleteUsersFromProjects(projectID);
            bll.AssignUsersToProject(projectID, userIDs);
            ((DashboardForm)Application.OpenForms["DashboardForm"]).ucProjectShowDashboard1.LoadData();
            MessageBox.Show("Update project successfully!");
        }

        private void btnCheckID_Click(object sender, EventArgs e)
        {
            int id;
            if (!int.TryParse(txtID.Text, out id))
            {
                MessageBox.Show("Please enter a valid Project ID.");
                return;
            }

            currentProject = bll.GetProjectById(id);
            if (currentProject == null) 
            {
                MessageBox.Show("Project not found. You can add a new project");
                return;
            }

            txtProName.Text = currentProject.ProjectName;
            txtBacklog.Text = currentProject.Description;
            txtRevenue.Text = currentProject.Revenue.ToString();
            dtpStart.Value = currentProject.StartDate;
            dtpEnd.Value = currentProject.DueDate;
            cboDept.SelectedValue = currentProject.DepartmentID;

            LoadCheckedUsersForProject(id);

            MessageBox.Show("Successfully upload the data from projectID: " + (id));
        }

        private void LoadCheckedUsersForProject(int projectID)
        {
            clbUsers.Items.Clear();
            List<User> allUsers = bll.GetAllUsers();
            List<int> assignedUserIDs = bll.GetUserIDsByProject(projectID); 

            foreach (User user in allUsers)
            {
                int index = clbUsers.Items.Add(user);
                if (assignedUserIDs.Contains(user.UserID))
                    clbUsers.SetItemChecked(index, true);
            }
        }

    }
}
