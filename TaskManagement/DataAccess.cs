using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace TaskManagement
{
    internal class DataAccess
    {
        private readonly string connectionString = @"Data Source=LAPTOP-00K9ITBS\SQLEXPRESS;Initial Catalog=ProjectManagement;Integrated Security=True";

        public bool TestConnection()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối: " + ex.Message);
                    return false;
                }
            }
        }
    }
}
