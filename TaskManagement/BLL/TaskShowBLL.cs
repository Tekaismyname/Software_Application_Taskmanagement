using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement
{
    public class TaskShowBLL
    {
        private TaskDAL dal = new TaskDAL();

        public bool AddTask(Task task) => dal.AddTask(task);

        public bool AssignUsersToTask(Task task, List<int> userIds) => dal.AssignUsersToTask(task, userIds);

        public List<Task> GetTasksBySprint(int sprintId, int projectId) => dal.GetTasksBySprint(sprintId, projectId);

        public List<int> GetUserIDsByTask(int taskId, int sprintId, int projectId) => dal.GetUserIDsByTask(taskId, sprintId, projectId);
    }

}
