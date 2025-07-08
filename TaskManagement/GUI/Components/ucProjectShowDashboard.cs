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
    public partial class ucProjectShowDashboard : UserControl
    {
        private ProjectShowBLL projectShowBLL = new ProjectShowBLL();

        public ucProjectShowDashboard()
        {
            InitializeComponent();
            //this.Load += ucProjectShowDashboard_Load; // Attach the load event handler
        }

        private void ucProjectShowDashboard_Load(object sender, EventArgs e)
        {
            //LoadData();
        }

        public void LoadData()
        {
            DataTable dt = projectShowBLL.getProjectList();
            adgvProjectDashboard.AutoGenerateColumns = true;
            adgvProjectDashboard.DataSource = dt;

            adgvProjectDashboard.Columns["Backlog"].Width = 218;
            adgvProjectDashboard.Columns["AssignedTo"].Width = 200;
            adgvProjectDashboard.Columns["ProjectID"].Width = 100;
            adgvProjectDashboard.Columns["ProjectName"].Width = 200;
            //agdvProjectDashboard.Columns["DepartmentName"].Width = 50;
            //agdvProjectDashboard.Columns["Status"].Width = 50;
            adgvProjectDashboard.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            adgvProjectDashboard.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }
        public void ShowSingleProject(Project p)
        {
            try
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("ProjectID");
                dt.Columns.Add("ProjectName");
                dt.Columns.Add("Backlog");
                dt.Columns.Add("Status");
                dt.Columns.Add("Revenue");
                dt.Columns.Add("Department");
                dt.Columns.Add("AssignedTo");
                dt.Columns.Add("StartDate");
                dt.Columns.Add("DueDate");

                dt.Rows.Add(p.ProjectID, p.ProjectName, p.Description, p.Status, p.Revenue,
                            p.DepartmentName, p.AssignedTo,
                            p.StartDate.ToShortDateString(), p.DueDate.ToShortDateString());

                adgvProjectDashboard.DataSource = dt;
                adgvProjectDashboard.Visible = true;

                // Thiết lập độ rộng
                adgvProjectDashboard.Columns["ProjectName"].Width = 150; 
                adgvProjectDashboard.Columns["Backlog"].Width = 150;
                adgvProjectDashboard.Columns["AssignedTo"].Width = 200;
                adgvProjectDashboard.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                adgvProjectDashboard.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi hiển thị project:\n" + ex.Message,
                                "Lỗi",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }


    }
}
