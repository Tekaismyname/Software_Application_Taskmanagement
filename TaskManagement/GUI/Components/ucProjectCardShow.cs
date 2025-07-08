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
    public partial class ucProjectCardShow : UserControl
    {
        private ProjectShowBLL bll = new ProjectShowBLL();
        public ucProjectCardShow()
        {
            InitializeComponent();
            LoadProjectCardsToPanel();
        }

        public void LoadProjectCardsToPanel()
        {
            flpProjectCards.Controls.Clear();
            ProjectShowBLL bll = new ProjectShowBLL();
            List<Project> projects = bll.GetProjectsWithStats();

            foreach (var p in projects)
            {
                var card = new ProjectCard();
                card.LoadData(p);

                card.DetailsRequested += (s, e) =>
                {
                    var form = new DetailShow(p);
                    form.ShowDialog();
                };
                //card.EditRequested += (s, e) => OpenProjectForm("Edit", p.ProjectID);
                card.DeleteRequested += (s, e) =>
                {
                    DialogResult result = MessageBox.Show(
                    "Are you sure deleting this project?",
                    "Delete Confirmation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                    );
                    if (result == DialogResult.Yes)
                    {
                        bll.DeleteUsersFromProjects(p.ProjectID);
                        bool success = bll.DeleteProject(p.ProjectID);
                        if (success)
                        {
                            MessageBox.Show("Successfully deleted", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadProjectCardsToPanel();
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete project!", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                };
                card.EditRequested += (s, e) =>
                {
                    ProjectForm form = new ProjectForm();
                    form.SetEditMode(p.ProjectID);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        LoadProjectCardsToPanel();
                    }
                };
                card.AddSprintRequested += (s, e) =>
                {
                    SprintForm form = new SprintForm();
                    form.SetAddMode(p); // p là Project của card hiện tại
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        MessageBox.Show("Sprint successfully added.");
                        LoadProjectCardsToPanel();
                    }
                };


                card.ViewSprintsClicked += (s, e) =>
                {
                    var dashboard = this.FindForm() as DashboardForm;
                    if (dashboard != null)
                    {
                        dashboard.ShowSprintFromProject(p);
                    }
                };



                flpProjectCards.Controls.Add(card);
            }
        }
    }
}
