using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskManagement.BLL;
using TaskManagement.DAL;
using TaskManagement.DTO;

namespace TaskManagement
{
    public partial class ucSprintCardShow : UserControl
    {
        private Project currentProject;
        private SprintShowBLL sprintBLL = new SprintShowBLL();
        public ucSprintCardShow()
        {
            InitializeComponent();
        }
        public void LoadByProject(Project p)
        {
            flpSprintCards.Controls.Clear();


            List<Sprint> sprints = sprintBLL.GetSprintsByProject(p.ProjectID);
            if (sprints == null || sprints.Count == 0)
            {
                Label empty = new Label
                {
                    Text = "No sprint!",
                    AutoSize = true,
                    ForeColor = Color.Gray,
                    Font = new Font("Segoe UI", 10, FontStyle.Italic),
                    Margin = new Padding(10)
                };
                flpSprintCards.Controls.Add(empty);
                return;
            }

            foreach (var sprint in sprints)
            {
                SprintCard card = new SprintCard();
                card.LoadData(sprint);

                card.EditRequested += (s, e) =>
                {
                    SprintForm form = new SprintForm();
                    form.SetEditMode(sprint);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        LoadByProject(p); // reload sprint cards
                    }
                };

                card.DeleteRequested += (s, e) =>
                {
                    SprintForm form = new SprintForm("Delete");
                    form.SetDeleteMode(sprint);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        LoadByProject(p); // reload lại
                    }
                };

                flpSprintCards.Controls.Add(card);
            }

        }
        public void LoadDefault()
        {
            //flpSprintCards.Controls.Clear();

            Label lbl = new Label
            {
                Text = "Vui lòng chọn một dự án để xem Sprint.",
                AutoSize = true,
                Font = new Font("Segoe UI", 10, FontStyle.Italic),
                ForeColor = Color.Gray,
                Margin = new Padding(10)
            };

            flpSprintCards.Controls.Add(lbl);
        }
    }
}
