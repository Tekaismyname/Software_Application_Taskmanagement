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
    public partial class ucProjectShowCoding : UserControl
    {
        public ucProjectShowCoding()
        {
            InitializeComponent();
        }

        private void LoadCodingProjects()
        {
            ProjectShowBLL bll = new ProjectShowBLL();
            DataTable dt = bll.getProjectsByDepartment("Coding");
            adgvProjectShowCoding.DataSource = dt;
            adgvProjectShowCoding.Columns["Backlog"].Width = 218;
            adgvProjectShowCoding.Columns["AssignedTo"].Width = 200;
            adgvProjectShowCoding.Columns["ProjectID"].Width = 100;
            adgvProjectShowCoding.Columns["ProjectName"].Width = 200;
            //agdvProjectDashboard.Columns["DepartmentName"].Width = 50;
            //agdvProjectDashboard.Columns["Status"].Width = 50;
            adgvProjectShowCoding.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            adgvProjectShowCoding.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void ucProjectShowCoding_Load(object sender, EventArgs e)
        {
            LoadCodingProjects();
        }
    }
}
