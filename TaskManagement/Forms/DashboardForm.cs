using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;


namespace TaskManagement
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }




        private Guna2Button selectedButton = null; 

        private void HandleButtonClick(Guna2Button btn)
        {
            if (selectedButton != null)
            {
                selectedButton.FillColor = Color.FromArgb(23, 142, 194);
            }

            selectedButton = btn;
            selectedButton.FillColor = Color.White;
        }
        private void btnDashboard_Click(object sender, MouseEventArgs e)
        {
            HandleButtonClick(btnDashboard);
            this.pnlDashboard.Controls.Clear();
            this.pnlDashboard.Controls.Add(ucDashboard1);
        }
        private void btnMarketing_Click(object sender, MouseEventArgs e)
        {
            HandleButtonClick(btnMarketing);
            this.pnlDashboard.Controls.Clear();
            this.pnlDashboard.Controls.Add(ucMarketing1);
        }
        private void btnCoding_Click(object sender, MouseEventArgs e)
        {
            HandleButtonClick(btnCoding);
            this.pnlDashboard.Controls.Clear();
            this.pnlDashboard.Controls.Add(ucCoding1); 
        }
        private void btnRevenue_Click(object sender, MouseEventArgs e)
        {
           HandleButtonClick(btnRevenue);
           this.pnlDashboard.Controls.Clear();
           this.pnlDashboard.Controls.Add(ucRevenue1);
        }
        private void btnUser_Click(object sender, MouseEventArgs e)
        {
            HandleButtonClick(btnUser);
            this.pnlDashboard.Controls.Clear();
            this.pnlDashboard.Controls.Add(ucUser1);
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void ucDashboard1_Load(object sender, EventArgs e)
        {

        }
    }
}
