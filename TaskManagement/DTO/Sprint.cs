using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement
{
    public class Sprint
    {
        public int SprintID { get; set; }
        public int ProjectID { get; set; }
        public string SprintName { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Status { get; set; }

        public override string ToString()
        {
            return $"{SprintName} (ID: {SprintID})";
        }
    }

}
