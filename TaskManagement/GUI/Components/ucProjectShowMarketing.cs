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
    public partial class ucProjectShowMarketing : UserControl
    {
        private ProjectShowBLL bll = new ProjectShowBLL();

        public ucProjectShowMarketing()
        {
            InitializeComponent();
        }

        private void LoadMarketingProjects()
        {
            ProjectShowBLL bll = new ProjectShowBLL();
            DataTable dt = bll.getProjectsByDepartment("Marketing");
            adgvProjectShowMarketing.DataSource = dt;
            adgvProjectShowMarketing.Columns["Backlog"].Width = 218;
            adgvProjectShowMarketing.Columns["AssignedTo"].Width = 200;
            adgvProjectShowMarketing.Columns["ProjectID"].Width = 100;
            adgvProjectShowMarketing.Columns["ProjectName"].Width = 200;
            //agdvProjectDashboard.Columns["DepartmentName"].Width = 50;
            //agdvProjectDashboard.Columns["Status"].Width = 50;
            adgvProjectShowMarketing.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            adgvProjectShowMarketing.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void ucProjectShowMarketing_Load(object sender, EventArgs e)
        {
            LoadMarketingProjects();
        }


    }
}
