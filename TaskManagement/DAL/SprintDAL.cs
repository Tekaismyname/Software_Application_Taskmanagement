using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using TaskManagement.DTO;

namespace TaskManagement.DAL
{
    public class SprintDAL
    {
        private readonly string connectionString = @"Data Source=LAPTOP-00K9ITBS\SQLEXPRESS;Initial Catalog=ProjectManagement;Integrated Security=True";

        public DataTable GetAllSprints()
        {
            string query = @"
            SELECT 
                S.SprintID,
                S.SprintName,
                S.Description AS Backlog,
                S.Status,
                STRING_AGG(U.FullName, ', ') AS AssignedTo,
                P.ProjectID,
                P.ProjectName,
                D.DepartmentName,
                S.StartDate,
                S.EndDate
            FROM Sprints S
            LEFT JOIN Projects P ON S.ProjectID = P.ProjectID
            LEFT JOIN Departments D ON P.DepartmentID = D.DepartmentID
            LEFT JOIN SprintMembers SM ON S.SprintID = SM.SprintID
            LEFT JOIN Users U ON SM.UserID = U.UserID
            GROUP BY 
                S.SprintID, S.SprintName, S.Description, S.Status,
                P.ProjectID, P.ProjectName, D.DepartmentName,
                S.StartDate, S.EndDate";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public bool AddSprint(Sprint s)
        {
            string query = @"INSERT INTO Sprints (SprintID, SprintName, Description, Status, StartDate, EndDate, ProjectID)
                             VALUES (@ID, @Name, @Desc, @Status, @Start, @End, @ProjectID)";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@ID", s.SprintID);
                cmd.Parameters.AddWithValue("@Name", s.SprintName);
                cmd.Parameters.AddWithValue("@Desc", s.Description);
                cmd.Parameters.AddWithValue("@Status", s.Status);
                cmd.Parameters.AddWithValue("@Start", s.StartDate);
                cmd.Parameters.AddWithValue("@End", s.EndDate);
                cmd.Parameters.AddWithValue("@ProjectID", s.ProjectID);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool DeleteSprint(int sprintId, int projectId)
        {
            string query = "DELETE FROM Sprints WHERE SprintID = @SprintID AND ProjectID = @ProjectID";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@SprintID", sprintId);
                cmd.Parameters.AddWithValue("@ProjectID", projectId);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool UpdateSprint(Sprint s)
        {
            string query = @"UPDATE Sprints SET 
                    SprintName = @Name,
                    Description = @Desc,
                    Status = @Status,
                    StartDate = @Start,
                    EndDate = @End
                    WHERE SprintID = @ID AND ProjectID = @ProjectID"; 

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@ID", s.SprintID);
                cmd.Parameters.AddWithValue("@Name", s.SprintName);
                cmd.Parameters.AddWithValue("@Desc", s.Description);
                cmd.Parameters.AddWithValue("@Status", s.Status);
                cmd.Parameters.AddWithValue("@Start", s.StartDate);
                cmd.Parameters.AddWithValue("@End", s.EndDate);
                cmd.Parameters.AddWithValue("@ProjectID", s.ProjectID);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }


        public void DeleteSprintMembers(int sprintId, int projectId)
        {
            string query = "DELETE FROM SprintMembers WHERE SprintID = @SprintID AND ProjectID = @ProjectID";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@SprintID", sprintId);
                cmd.Parameters.AddWithValue("@ProjectID", projectId);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void AssignUsersToSprint(int sprintId, int projectId, List<int> userIds)
        {
            string query = "INSERT INTO SprintMembers (SprintID, ProjectID, UserID) VALUES (@SprintID, @ProjectID, @UserID)";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                foreach (int userId in userIds)
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@SprintID", sprintId);
                        cmd.Parameters.AddWithValue("@ProjectID", projectId);
                        cmd.Parameters.AddWithValue("@UserID", userId);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }


        public DataTable GetProjectIdAndName()
        {
            string query = "SELECT ProjectID, ProjectName FROM Projects";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
        public List<Sprint> GetSprintsByProject(int projectId)
        {
            List<Sprint> sprints = new List<Sprint>();
            string query = @"
        SELECT S.*, 
       STRING_AGG(U.FullName, ', ') AS AssignedTo,
       COUNT(SM.UserID) AS NumMembers
        FROM Sprints S
        LEFT JOIN SprintMembers SM ON S.SprintID = SM.SprintID AND S.ProjectID = SM.ProjectID
        LEFT JOIN Users U ON SM.UserID = U.UserID
        WHERE S.ProjectID = @ProjectID
        GROUP BY S.SprintID, S.ProjectID, S.SprintName, S.Description, S.Status, S.StartDate, S.EndDate";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@ProjectID", projectId);
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        sprints.Add(new Sprint
                        {
                            SprintID = reader.GetInt32(0),
                            ProjectID = reader.GetInt32(1),
                            SprintName = reader.GetString(2),
                            Description = reader.GetString(3),
                            Status = reader.GetString(4),
                            StartDate = reader.GetDateTime(5),
                            EndDate = reader.GetDateTime(6),
                            AssignedTo = reader.IsDBNull(7) ? "" : reader.GetString(7),
                            NumMembers = reader.IsDBNull(8) ? 0 : reader.GetInt32(8)

                        });
                    }
                }
            }

            return sprints;
        }




        public List<int> GetUserIDsBySprint(int sprintId, int projectId)
        {
            List<int> userIds = new List<int>();
            string query = "SELECT UserID FROM SprintMembers WHERE SprintID = @SprintID AND ProjectID = @ProjectID";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@SprintID", sprintId);
                cmd.Parameters.AddWithValue("@ProjectID", projectId);
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                        userIds.Add(reader.GetInt32(0));
                }
            }
            return userIds;
        }
        public Sprint GetSprintById(int sprintId, int projectId)
        {
            string query = "SELECT * FROM Sprints WHERE SprintID = @SprintID AND ProjectID = @ProjectID";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@SprintID", sprintId);
                cmd.Parameters.AddWithValue("@ProjectID", projectId);
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Sprint
                        {
                            SprintID = (int)reader["SprintID"],
                            ProjectID = (int)reader["ProjectID"],
                            SprintName = reader["SprintName"].ToString(),
                            Description = reader["Description"].ToString(),
                            Status = reader["Status"].ToString(),
                            StartDate = Convert.ToDateTime(reader["StartDate"]),
                            EndDate = Convert.ToDateTime(reader["EndDate"])
                        };
                    }
                }
            }
            return null;
        }

        public int CountSprintsByProject(int projectId)
        {
            string query = "SELECT COUNT(*) FROM Sprints WHERE ProjectID = @ProjectID";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@ProjectID", projectId);
                conn.Open();
                return (int)cmd.ExecuteScalar();
            }
        }
    }
}
