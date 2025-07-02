using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement.DTO
{
    public class Project
    {
        public int ProjectID { get; set; }
        public string ProjectName { get; set; }
        public string Description { get; set; }
        public string Status { get; set; } = "Đang thực hiện";
        public decimal Revenue { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime DueDate { get; set; }
        public int DepartmentID { get; set; }
        public string DepartmentName { get; set; }

    }
}

