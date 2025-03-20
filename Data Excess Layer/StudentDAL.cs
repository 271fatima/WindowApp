using System.Data;
using System.Data.SqlClient;

namespace Data_Excess_Layer
{
    public class StudentDAL
    {
        private string connectionString = "Server=YOUR_SERVER_NAME;Database=YOUR_DATABASE_NAME;Integrated Security=True;";

        public DataTable GetStudents()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Students";  // Fetching existing table data
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public DataTable GetAllStudents()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM student_data";  // Fetching existing table data
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;

            }
        }
    }
}
