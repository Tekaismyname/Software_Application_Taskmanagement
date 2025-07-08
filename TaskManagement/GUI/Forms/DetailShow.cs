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
    public partial class DetailShow : Form
    {
        public DetailShow(Project p)
        {
            InitializeComponent();
            this.pnlProjectDetail.Controls.Add(ucProjectShowDashboard1);
            ucProjectShowDashboard1.Visible = true;
            ucSprintShowDashboard1.Visible = false;
            ucProjectShowDashboard1.ShowSingleProject(p);
        }
        public DetailShow(Sprint s)
        {
            InitializeComponent();
            this.pnlProjectDetail.Controls.Add(ucSprintShowDashboard1);
            ucProjectShowDashboard1.Visible = false;
            ucSprintShowDashboard1.Visible = true;
            ucSprintShowDashboard1.ShowSingleSprint(s);
        }
    }
}
