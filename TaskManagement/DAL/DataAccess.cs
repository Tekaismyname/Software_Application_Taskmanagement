using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskManagement.DTO;


namespace TaskManagement
{
    internal class DataAccess
    {
        private readonly string connectionString = @"Data Source=LAPTOP-00K9ITBS\SQLEXPRESS;Initial Catalog=ProjectManagement;Integrated Security=True";
        // Get all projects with details
        public DataTable GetAllProjects()
        {
            string query = @"
        SELECT 
            P.ProjectID,
            P.ProjectName,
            P.Description AS Backlog,
            P.Status,
            STRING_AGG(U.FullName, ', ') AS AssignedTo,
            P.Revenue,
            D.DepartmentName,
            P.StartDate,
            P.DueDate
        FROM Projects P
        LEFT JOIN ProjectMembers PM ON P.ProjectID = PM.ProjectID
        LEFT JOIN Users U ON PM.UserID = U.UserID
        LEFT JOIN Departments D ON P.DepartmentID = D.DepartmentID
        GROUP BY 
            P.ProjectID, P.ProjectName, P.Description, P.Status, D.DepartmentName,
            P.Revenue, P.StartDate, P.DueDate";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        //Get projects by department name
        public DataTable GetProjectsByDepartment(string departmentName)
        {
            string query = @"
        SELECT 
            P.ProjectID,
            P.ProjectName,
            P.Description AS Backlog,
            P.Status,
            STRING_AGG(U.FullName, ', ') AS AssignedTo,
            P.Revenue,
            D.DepartmentName,
            P.StartDate,
            P.DueDate
        FROM Projects P
        LEFT JOIN ProjectMembers PM ON P.ProjectID = PM.ProjectID
        LEFT JOIN Users U ON PM.UserID = U.UserID
        LEFT JOIN Departments D ON P.DepartmentID = D.DepartmentID
        WHERE D.DepartmentName = @DepartmentName
        GROUP BY 
            P.ProjectID, P.ProjectName, P.Description, P.Status, D.DepartmentName,
            P.Revenue, P.StartDate, P.DueDate";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@DepartmentName", departmentName);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        public DataTable GetAllDepartments()
        {
            string query = "SELECT DepartmentID, DepartmentName FROM Departments";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
        //Dung cho ProjectForm
        public bool AddProject(Project p)
        {
            string query = @"INSERT INTO Projects (ProjectID, ProjectName, Description, Status, Revenue, StartDate, DueDate, DepartmentID)
                     VALUES (@ID, @Name, @Desc, @Status, @Revenue, @Start, @Due, @Dept)";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@ID", p.ProjectID);
                cmd.Parameters.AddWithValue("@Name", p.ProjectName);
                cmd.Parameters.AddWithValue("@Desc", p.Description);
                cmd.Parameters.AddWithValue("@Status", p.Status);
                cmd.Parameters.AddWithValue("@Revenue", p.Revenue);
                cmd.Parameters.AddWithValue("@Start", p.StartDate);
                cmd.Parameters.AddWithValue("@Due", p.DueDate);
                cmd.Parameters.AddWithValue("@Dept", p.DepartmentID);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool DeleteProject(int id)
        {
            string query = "DELETE FROM Projects WHERE ProjectID = @ID";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@ID", id);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
        public void DeleteUsersFromProject(int projectId)
        {
            string query = "DELETE FROM ProjectMembers WHERE ProjectID = @ProjectID";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@ProjectID", projectId);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }


        public bool UpdateProject(Project p)
        {
            string query = @"UPDATE Projects SET 
                     ProjectName=@Name, Description=@Desc, Status=@Status, Revenue=@Revenue,
                     StartDate=@Start, DueDate=@Due, DepartmentID=@Dept
                     WHERE ProjectID = @ID";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@ID", p.ProjectID);
                cmd.Parameters.AddWithValue("@Name", p.ProjectName);
                cmd.Parameters.AddWithValue("@Desc", p.Description);
                cmd.Parameters.AddWithValue("@Status", p.Status);
                cmd.Parameters.AddWithValue("@Revenue", p.Revenue);
                cmd.Parameters.AddWithValue("@Start", p.StartDate);
                cmd.Parameters.AddWithValue("@Due", p.DueDate);
                cmd.Parameters.AddWithValue("@Dept", p.DepartmentID);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
        //Truy van danh sach User do vao mang
        public List<User> GetAllUsers()
        {
            string query = "SELECT UserID, FullName FROM Users";
            List<User> users = new List<User>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        users.Add(new User
                        {
                            UserID = (int)reader["UserID"],
                            FullName = reader["FullName"].ToString()
                        });
                    }
                }
            }
            return users;
        }
        //Truy van them Users vao Project
        public void AssignUsersToProjects(int projectID, List<int> userIDs)
        {
            string query = "INSERT INTO ProjectMembers (ProjectID, UserID) VALUES (@ProjectID, @UserID)";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                foreach (int userID in userIDs)
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ProjectID", projectID);
                    cmd.Parameters.AddWithValue("@UserID", userID);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        //Return UserIDs list by ProjectID
        public List<int> GetUserIDsByProject(int projectId)
        {
            List<int> userIds = new List<int>();
            string query = "SELECT UserID FROM ProjectMembers WHERE ProjectID = @ProjectID";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@ProjectID", projectId);
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        userIds.Add(reader.GetInt32(0));
                    }
                }
            }
            return userIds;
        }

        //
        public int AddProjectReturnId(Project p)
        {
            string query = @"INSERT INTO Projects 
             (ProjectID, ProjectName, Description, Status, Revenue, StartDate, DueDate, DepartmentID)
             OUTPUT INSERTED.ProjectID
             VALUES (@ID, @Name, @Desc, @Status, @Revenue, @Start, @Due, @Dept)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@ID", p.ProjectID);
                cmd.Parameters.AddWithValue("@Name", p.ProjectName);
                cmd.Parameters.AddWithValue("@Desc", p.Description);
                cmd.Parameters.AddWithValue("@Status", p.Status);
                cmd.Parameters.AddWithValue("@Revenue", p.Revenue);
                cmd.Parameters.AddWithValue("@Start", p.StartDate);
                cmd.Parameters.AddWithValue("@Due", p.DueDate);
                cmd.Parameters.AddWithValue("@Dept", p.DepartmentID);

                conn.Open();
                cmd.ExecuteNonQuery();
                return p.ProjectID;
            }
        }

        //Lay du lieu Project theo ID
        public Project GetProjectById(int id)
        {
            string query = @"
            SELECT P.*, D.DepartmentName 
            FROM Projects P 
            LEFT JOIN Departments D ON P.DepartmentID = D.DepartmentID
            WHERE P.ProjectID = @ID";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@ID", id);
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Project
                        {
                            ProjectID = (int)reader["ProjectID"],
                            ProjectName = reader["ProjectName"].ToString(),
                            Description = reader["Description"].ToString(),
                            Status = reader["Status"].ToString(),
                            Revenue = Convert.ToDecimal(reader["Revenue"]),
                            StartDate = Convert.ToDateTime(reader["StartDate"]),
                            DueDate = Convert.ToDateTime(reader["DueDate"]),
                            DepartmentID = (int)reader["DepartmentID"],
                            DepartmentName = reader["DepartmentName"].ToString()
                        };
                    }
                }
            }
            return null;
        }
        //Dung cho pnlPlaceTime
        //Get all working status by date    
        public DataTable GetWorkingStatusByDate(DateTime date)
        {
            string query = @"
        SELECT U.FullName, W.Status
        FROM WorkingStatus W
        JOIN Users U ON W.UserID = U.UserID
        WHERE W.WorkDate = @WorkDate";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@WorkDate", date);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }


    }
}
