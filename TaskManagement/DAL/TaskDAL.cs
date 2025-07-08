using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement
{
    public class TaskDAL
    {
        private readonly string connectionString = @"Data Source=LAPTOP-00K9ITBS\SQLEXPRESS;Initial Catalog=ProjectManagement;Integrated Security=True";

        public bool AddTask(Task task)
        {
            string query = @"INSERT INTO Tasks (TaskID, TaskName, Description, Status, StartDate, EndDate, SprintID, ProjectID)
                         VALUES (@id, @name, @desc, @status, @start, @end, @sprint, @project)";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@id", task.TaskID);
                cmd.Parameters.AddWithValue("@name", task.TaskName);
                cmd.Parameters.AddWithValue("@desc", task.Description);
                cmd.Parameters.AddWithValue("@status", task.Status);
                cmd.Parameters.AddWithValue("@start", task.StartDate);
                cmd.Parameters.AddWithValue("@end", task.DueDate);
                cmd.Parameters.AddWithValue("@sprint", task.SprintID);
                cmd.Parameters.AddWithValue("@project", task.ProjectID);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool AssignUsersToTask(Task task, List<int> userIds)
        {
            string query = @"INSERT INTO TaskMembers (TaskID, SprintID, ProjectID, UserID)
                         VALUES (@taskId, @sprintId, @projectId, @userId)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                foreach (int userId in userIds)
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@taskId", task.TaskID);
                        cmd.Parameters.AddWithValue("@sprintId", task.SprintID);
                        cmd.Parameters.AddWithValue("@projectId", task.ProjectID);
                        cmd.Parameters.AddWithValue("@userId", userId);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            return true;
        }

        public List<Task> GetTasksBySprint(int sprintId, int projectId)
        {
            var list = new List<Task>();
            string query = @"SELECT * FROM Tasks WHERE SprintID = @sprintId AND ProjectID = @projectId";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@sprintId", sprintId);
                cmd.Parameters.AddWithValue("@projectId", projectId);
                conn.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new Task
                    {
                        TaskID = (int)reader["TaskID"],
                        TaskName = reader["TaskName"].ToString(),
                        Description = reader["Description"].ToString(),
                        Status = reader["Status"].ToString(),
                        StartDate = (DateTime)reader["StartDate"],
                        DueDate = (DateTime)reader["EndDate"],
                        SprintID = (int)reader["SprintID"],
                        ProjectID = (int)reader["ProjectID"]
                    });
                }
            }
            return list;
        }

        public List<int> GetUserIDsByTask(int taskId, int sprintId, int projectId)
        {
            var list = new List<int>();
            string query = @"SELECT UserID FROM TaskMembers 
                         WHERE TaskID = @taskId AND SprintID = @sprintId AND ProjectID = @projectId";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@taskId", taskId);
                cmd.Parameters.AddWithValue("@sprintId", sprintId);
                cmd.Parameters.AddWithValue("@projectId", projectId);
                conn.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add((int)reader["UserID"]);
                }
            }
            return list;
        }
    }

}
