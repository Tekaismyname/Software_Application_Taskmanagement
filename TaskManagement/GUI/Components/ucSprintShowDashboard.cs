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
    public partial class ucSprintShowDashboard : UserControl
    {
        private SprintShowBLL bll = new SprintShowBLL();

        public ucSprintShowDashboard()
        {
            InitializeComponent();
            this.Load += ucSprintShowDashboard_Load; // Attach the load event handler
        }

        private void ucSprintShowDashboard_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            DataTable dt = bll.GetAllSprints();
            adgvSprintDashboard.AutoGenerateColumns = true;
            adgvSprintDashboard.DataSource = dt;

            adgvSprintDashboard.Columns["ProjectID"].DisplayIndex = 0;
            adgvSprintDashboard.Columns["ProjectName"].DisplayIndex = 1;

            adgvSprintDashboard.Columns["Backlog"].Width = 218;
            adgvSprintDashboard.Columns["AssignedTo"].Width = 200;
            adgvSprintDashboard.Columns["ProjectID"].Width = 75; 
            adgvSprintDashboard.Columns["SprintID"].Width = 75;
            adgvSprintDashboard.Columns["ProjectName"].Width = 155;
            //agdvProjectDashboard.Columns["DepartmentName"].Width = 50;
            //agdvProjectDashboard.Columns["Status"].Width = 50;
            adgvSprintDashboard.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            adgvSprintDashboard.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }
        public void ShowSingleSprint(Sprint s)
        {
            try
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("ProjectID");
                dt.Columns.Add("SprintID");
                dt.Columns.Add("SprintName");
                dt.Columns.Add("Backlog");
                dt.Columns.Add("Status");
                dt.Columns.Add("Revenue");
                dt.Columns.Add("AssignedTo");
                dt.Columns.Add("StartDate");
                dt.Columns.Add("DueDate");

                dt.Rows.Add(s.ProjectID, s.SprintID, s.SprintName, s.Description, s.Status,
                            s.AssignedTo,
                            s.StartDate.ToShortDateString(), s.EndDate.ToShortDateString());

                adgvSprintDashboard.DataSource = dt;
                adgvSprintDashboard.Visible = true;

                // Thiết lập độ rộng
                adgvSprintDashboard.Columns["ProjectName"].Width = 150;
                adgvSprintDashboard.Columns["Backlog"].Width = 150;
                adgvSprintDashboard.Columns["AssignedTo"].Width = 200;
                adgvSprintDashboard.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                adgvSprintDashboard.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
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
