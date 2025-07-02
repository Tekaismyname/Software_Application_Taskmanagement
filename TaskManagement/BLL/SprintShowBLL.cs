using System;
using System.Collections.Generic;
using System.Data;
using TaskManagement.DAL;
using TaskManagement.DTO;

namespace TaskManagement.BLL
{
    public class SprintShowBLL
    {
        private SprintDAL dal = new SprintDAL();

        public DataTable GetAllSprints() => dal.GetAllSprints();

        public bool AddSprint(Sprint sprint) => dal.AddSprint(sprint);

        public bool DeleteSprint(int sprintId, int projectId)
        {
            dal.DeleteSprintMembers(sprintId, projectId);
            return dal.DeleteSprint(sprintId, projectId);
        }

        public bool UpdateSprint(Sprint sprint) => dal.UpdateSprint(sprint);

        public DataTable GetProjectIdAndName() => dal.GetProjectIdAndName();

        public DataTable GetSprintsByProject(int projectId) => dal.GetSprintsByProject(projectId);

        public Sprint GetSprintById(int sprintId, int projectId) => dal.GetSprintById(sprintId, projectId);

        public void AssignUsersToSprint(int sprintId, int projectId, List<int> userIds)
        {
            dal.DeleteSprintMembers(sprintId, projectId);
            dal.AssignUsersToSprint(sprintId, projectId, userIds);
        }

        public List<int> GetUserIDsBySprint(int sprintId, int projectId)
            => dal.GetUserIDsBySprint(sprintId, projectId);

        public int CountSprintsByProject(int projectId) => dal.CountSprintsByProject(projectId);
    }

}
