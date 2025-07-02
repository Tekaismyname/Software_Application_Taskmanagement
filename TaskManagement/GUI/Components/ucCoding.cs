using Guna.UI2.WinForms;
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
    public partial class ucCoding : UserControl
    {
        public ucCoding()
        {
            InitializeComponent();
        }
        private Guna2Button selectedButton = null;

        private void HandleButtonClick(Guna2Button btn)
        {
            if (selectedButton != null)
            {
                selectedButton.ForeColor = Color.Gray;
                selectedButton.FillColor = Color.White;
                selectedButton.CustomBorderColor = Color.White;
            }

            selectedButton = btn;
            selectedButton.FillColor = Color.White;
            selectedButton.ForeColor = Color.Black;
            selectedButton.CustomBorderColor = Color.FromArgb(27, 161, 226);
        }
        private void btnUcProjectsCoding_Click(object sender, MouseEventArgs e)
        {
            HandleButtonClick(btnUcProjectsCoding);
        }
        private void btnUcSprintsCoding_Click(object sender, MouseEventArgs e)
        {
            HandleButtonClick(btnUcSprintsCoding);
        }
        private void btnUcReportsCoding_Click(object sender, MouseEventArgs e)
        {
            HandleButtonClick(btnUcReportsCoding);
        }
        private void btnUcToDoCoding_Click(object sender, MouseEventArgs e)
        {
            HandleButtonClick(btnUcToDoCoding);
        }
        private void btnUcDiscussionCoding_Click(object sender, MouseEventArgs e)
        {
            HandleButtonClick(btnUcDiscussionCoding);
        }
    }
}
