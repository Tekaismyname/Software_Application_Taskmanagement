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
    public partial class TaskCard : UserControl
    {
        public Task Task { get; private set; }

        public event EventHandler EditRequested;
        public event EventHandler DeleteRequested;

        public TaskCard()
        {
            InitializeComponent();

            this.DoubleClick += (s, e) => EditRequested?.Invoke(this, EventArgs.Empty);
            picDelete.Click += (s, e) => DeleteRequested?.Invoke(this, EventArgs.Empty);
        }

        public void LoadData(Task t)
        {
            this.Task = t;
            lblTitle.Text = t.TaskName;
            lblTimeline.Text = $"Timeline: {t.StartDate:dd/MM/yyyy} - {t.DueDate:dd/MM/yyyy}";
            lblDescription.Text = t.Description;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

