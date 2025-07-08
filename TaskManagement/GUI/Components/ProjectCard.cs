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
    public partial class ProjectCard : UserControl
    {
        public Project Project { get; private set; }

        public event EventHandler ViewSprintsClicked;
        public event EventHandler DetailsRequested;
        public event EventHandler EditRequested;
        public event EventHandler DeleteRequested;
        public event EventHandler AddSprintRequested;

        public ProjectCard()
        {
            InitializeComponent();

            this.DoubleClick += (s, e) => EditRequested?.Invoke(this, EventArgs.Empty);
            lblViewSprints.Click += (s, e) => ViewSprintsClicked?.Invoke(this, EventArgs.Empty);
            lblDetails.Click += (s, e) => DetailsRequested?.Invoke(this, EventArgs.Empty);
            picDelete.Click += (s, e) => DeleteRequested?.Invoke(this, EventArgs.Empty);
            picAddSprint.Click += (s, e) => AddSprintRequested?.Invoke(this, EventArgs.Empty);
        }

        public void LoadData(Project p)
        {
            this.Project = p;

            lblTitle.Text = p.ProjectName;
            lblNumSprints.Text = $"Number of Sprints: {p.NumSprints}";
            lblNumMembers.Text = $"Members: {p.NumMembers}";
            lblDept.Text = $"Department: {p.DepartmentName}";
            lblTimeline.Text = $"Timeline: {p.StartDate:dd/MM/yyyy} - {p.DueDate:dd/MM/yyyy}";
        }
    }
}

