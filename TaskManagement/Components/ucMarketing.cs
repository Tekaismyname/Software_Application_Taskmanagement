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
    public partial class ucMarketing : UserControl
    {
        public ucMarketing()
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

        private void btnUcProjectsMarketing_Click(object sender, MouseEventArgs e)
        {
            HandleButtonClick(btnUcProjectsMarketing);
        }

        private void btnUcSprintsMarketing_MouseClick(object sender, MouseEventArgs e)
        {
            HandleButtonClick(btnUcSprintsMarketing);
        }

        private void btnUcToDoMarketing_MouseClick(object sender, MouseEventArgs e)
        {
            HandleButtonClick(btnUcToDoMarketing);
        }

        private void btnUcDiscussionMarketing_MouseClick(object sender, MouseEventArgs e)
        {
            HandleButtonClick(btnUcDiscussionMarketing);
        }

        private void btnUcReportsMarketing_MouseClick(object sender, MouseEventArgs e)
        {
            HandleButtonClick(btnUcReportsMarketing);
        }
    }
}
