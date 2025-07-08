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
    public partial class SprintCard : UserControl
    {
        public Sprint Sprint { get; private set; }

        public event EventHandler ViewTasksClicked;
        public event EventHandler DetailsRequested;
        public event EventHandler EditRequested;
        public event EventHandler DeleteRequested;
        public event EventHandler AddTaskRequested;

        public SprintCard()
        {
            InitializeComponent();
            this.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            this.DoubleClick += (s, e) => EditRequested?.Invoke(this, EventArgs.Empty);
            lblViewTasks.Click += (s, e) => ViewTasksClicked?.Invoke(this, EventArgs.Empty);
            lblDetails.Click += (s, e) => DetailsRequested?.Invoke(this, EventArgs.Empty);
            picDelete.Click += (s, e) => DeleteRequested?.Invoke(this, EventArgs.Empty);
            picAddTask.Click += (s, e) => AddTaskRequested?.Invoke(this, EventArgs.Empty);

        }

        public void LoadData(Sprint sprint)
        {
            lblTitle.Text = sprint.SprintName.ToString();
            lblNumTasks.Text = $"Number of Tasks:  {sprint.NumTasks}";
            lblNumMembers.Text = $"{sprint.NumMembers} members";
            lblStatus.Text = sprint.Status;
            lblTimeline.Text = $"Timeline: {sprint.StartDate:dd/MM/yyyy} - {sprint.EndDate:dd/MM/yyyy}";
        }
    }
}
