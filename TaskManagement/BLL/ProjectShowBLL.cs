using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.DTO;

namespace TaskManagement
{
    internal class ProjectShowBLL
    {
        private DataAccess dal = new DataAccess();
        public bool AddProject(Project p) => dal.AddProject(p);
        public int AddProjectReturnId(Project p) => dal.AddProjectReturnId(p);
        public bool DeleteProject(int id) => dal.DeleteProject(id);
        
        public void DeleteUsersFromProjects(int projectID) => dal.DeleteUsersFromProject(projectID);
        public bool UpdateProject(Project p) => dal.UpdateProject(p);
        //Tra ve Project theo ID
        public Project GetProjectById(int id) => dal.GetProjectById(id);
        //Tra ve danh sach UserId theo ProjectID
        public List<int> GetUserIDsByProject(int projectId) => dal.GetUserIDsByProject(projectId);
        // Tra ve danh sach Project
        public DataTable getProjectList() => dal.GetAllProjects();
        public List<Project> GetProjectsWithStats() => dal.GetProjectsWithStats();
        //Tra ve mang danh sach User
        public List<User> GetAllUsers() => dal.GetAllUsers();
        //Tra ve tat ca phong ban
        public DataTable GetAllDepartments() => dal.GetAllDepartments();
        public void AssignUsersToProject(int projectID, List<int> userIDs) => dal.AssignUsersToProjects(projectID, userIDs);
        //Them Users vao Projects
        public DataTable getProjectsByDepartment(string departmentName) => dal.GetProjectsByDepartment(departmentName);
        //Dung cho pnlPlaceTime
        //Get all working status by date
        public DataTable GetWorkingStatusByDate(DateTime Date) => dal.GetWorkingStatusByDate(Date);

    }
}
