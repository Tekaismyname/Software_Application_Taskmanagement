using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement
{
    public class User
    {
        public int UserID { get; set; }
        public string FullName { get; set; }
        public override string ToString()
        {
            return FullName;
        }
    }
}
