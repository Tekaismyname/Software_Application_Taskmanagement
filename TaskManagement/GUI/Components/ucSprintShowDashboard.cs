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
    }
}
