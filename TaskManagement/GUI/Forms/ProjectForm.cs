using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using TaskManagement.BLL;
using TaskManagement.DAL;
using TaskManagement.DTO;

namespace TaskManagement
{
    public partial class ProjectForm : Form
    {
        private string Mode;
        private Project editingProject;

        private Project currentProject;

        private SprintShowBLL sprintbll = new SprintShowBLL();  
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
            switch (Mode)
            {
                case "Add":
                    btnAdd.Enabled = true;
                    btnEdit.Visible = false;
                    btnEdit.Enabled = false;
                    txtID.Visible = true;
                    cboProjectIDName.Visible = false;
                    break;
                case "Edit":
                    btnEdit.Enabled = true;
                    txtID.Visible = false;
                    btnAdd.Visible = false;
                    break;
            }
        }

        private void ProjectForm_Load(object sender, EventArgs e)
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

        public void SetAddMode()
        {
            editingProject = null;
            this.Text = "Add Project";

            // Hiển thị nút Add, ẩn nút Edit/Delete
            btnAdd.Visible = true;
            btnEdit.Visible = false;
            cboProjectIDName.Visible = false;

            // Xoá dữ liệu cũ trong các field
            txtProName.Text = "";
            txtBacklog.Text = "";
            txtRevenue.Text = "0";
            cboDept.SelectedIndex = -1;
            dtpStart.Value = DateTime.Today;
            dtpEnd.Value = DateTime.Today.AddDays(7);

            clbUsers.Items.Clear();
            var users = new ProjectShowBLL().GetAllUsers();
            foreach (var u in users)
            {
                clbUsers.Items.Add(u.FullName, false);
            }
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
            ProjectShowBLL bll = new ProjectShowBLL();
            bool added = bll.AddProject(p);

            if (!added)
            {
                MessageBox.Show("Thêm project thất bại!");
                return;
            }

            // Gán user vào project
            List<int> userIDs = new List<int>();
            List<User> allUsers = bll.GetAllUsers();
            for (int i = 0; i < clbUsers.Items.Count; i++)
            {
                if (clbUsers.GetItemChecked(i))
                {
                    string name = clbUsers.Items[i].ToString();
                    var user = allUsers.FirstOrDefault(u => u.FullName == name);
                    if (user != null) userIDs.Add(user.UserID);
                }
            }

            bll.AssignUsersToProject(p.ProjectID, userIDs);

            MessageBox.Show("Thêm project thành công!");
            this.DialogResult = DialogResult.OK;
            this.Close();
            //((DashboardForm)Application.OpenForms["DashboardForm"]).LoadProjectCardsToPanel();
        }
        public void SetEditMode(int projectId)
        {
            Mode = "Edit";
            this.Text = "Edit Project";

            ProjectShowBLL bll = new ProjectShowBLL();
            editingProject = bll.GetProjectById(projectId);

            if (editingProject != null)
            {
                // gán giá trị lên các control form
                txtProName.Text = editingProject.ProjectName;
                txtBacklog.Text = editingProject.Description;
                dtpStart.Value = editingProject.StartDate;
                dtpEnd.Value = editingProject.DueDate;
                cboDept.SelectedValue = editingProject.DepartmentID;
                txtRevenue.Text = editingProject.Revenue.ToString();
            }

            btnAdd.Visible = false;
            btnEdit.Visible = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (editingProject == null) return;
            editingProject.ProjectName = txtProName.Text;
            editingProject.Description = txtBacklog.Text;
            editingProject.StartDate = dtpStart.Value;
            editingProject.DueDate = dtpEnd.Value;
            editingProject.DepartmentID = (int)cboDept.SelectedValue;
            editingProject.Revenue = decimal.Parse(txtRevenue.Text);

            ProjectShowBLL bll = new ProjectShowBLL();
            bool success = bll.UpdateProject(editingProject);

            if (success)
            {
                // 1. Lấy danh sách người dùng được chọn
                List<int> selectedUserIDs = new List<int>();
                List<User> allUsers = bll.GetAllUsers();
                for (int i = 0; i < clbUsers.Items.Count; i++)
                {
                    if (clbUsers.GetItemChecked(i))
                    {
                        string name = clbUsers.Items[i].ToString();
                        var user = allUsers.FirstOrDefault(u => u.FullName == name);
                        if (user != null) selectedUserIDs.Add(user.UserID);
                    }
                }

                // 2. Cập nhật lại bảng ProjectMembers
                bll.DeleteUsersFromProjects(editingProject.ProjectID);
                bll.AssignUsersToProject(editingProject.ProjectID, selectedUserIDs);

                MessageBox.Show("Cập nhật thành công.");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Update failed!");
            }
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
                int projectID = Convert.ToInt32(cboProjectIDName.SelectedValue);
                Project p = bll.GetProjectById(projectID);

                if (p != null)
                {
                    txtProName.Text = p.ProjectName;
                    txtBacklog.Text = p.Description;
                    txtRevenue.Text = p.Revenue.ToString();
                    dtpStart.Value = p.StartDate;
                    dtpEnd.Value = p.DueDate;
                    cboDept.SelectedValue = p.DepartmentID;

                    // Nếu có clbProjectUsers:
                    List<int> assignedUserIDs = bll.GetUserIDsByProject(projectID);
                    List<User> allUsers = bll.GetAllUsers();

                    clbUsers.Items.Clear();
                    foreach (User user in allUsers)
                    {
                        int idx = clbUsers.Items.Add(user.FullName);
                        if (assignedUserIDs.Contains(user.UserID))
                            clbUsers.SetItemChecked(idx, true);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fail to load project: " + ex.Message);
            }
        }
    }
}
