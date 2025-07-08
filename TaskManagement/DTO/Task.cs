using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement
{
    public class Task
    {
        public int TaskID { get; set; }
        public int SprintID { get; set; }
        public int ProjectID { get; set; }

        public string TaskName { get; set; }
        public string Description { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime DueDate { get; set; }

        public string Status { get; set; }
    }
}
