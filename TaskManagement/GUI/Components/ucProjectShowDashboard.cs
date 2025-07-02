using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManagement
{
    public partial class ucProjectShowDashboard : UserControl
    {
        private ProjectShowBLL projectShowBLL = new ProjectShowBLL();

        public ucProjectShowDashboard()
        {
            InitializeComponent();
            this.Load += ucProjectShowDashboard_Load; // Attach the load event handler
        }

        private void ucProjectShowDashboard_Load(object sender, EventArgs e)
        {
            LoadData();
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
    }
}
