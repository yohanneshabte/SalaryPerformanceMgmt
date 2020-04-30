using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace salaryMgmt.Config.Gateway
{
    public class DatabaseGateway
    {
        private string connectionString = "Server=tcp:salary-mgmt-app.database.windows.net,1433;Database=IT380SalaryAppV2;User ID=Salaryapp380;Password=Salary380Burke;Trusted_Connection=False;Encrypt=True;";
        public SqlConnection connection;
        public DatabaseGateway()
        {
            connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                Debug.WriteLine("database connected");

            }
            catch
            {
                Debug.WriteLine("");
            }
            finally
            {
                
            }
        }

        public void CloseConnection()
        {
            connection.Close();
        }

        public SqlDataReader GetEmployee(int id)
        {
            SqlDataReader dr;
            SqlCommand cmd = new SqlCommand("GetEmployeeByID", this.connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@emp_id", SqlDbType.Int).Value = id;

            dr = cmd.ExecuteReader();
            return dr;
        }

        public SqlDataReader GetAllEmployees(int id)
        {
            SqlDataReader dr;
            SqlCommand cmd = new SqlCommand("GetEmployeesByID", this.connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@emp_id", SqlDbType.Int).Value = id;

            dr = cmd.ExecuteReader();
            return dr;
        }

        ~DatabaseGateway()
        {
            connection.Close();
        }
    }
}
