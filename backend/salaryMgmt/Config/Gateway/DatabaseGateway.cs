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

        //employee
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



        //salary
        public SqlDataReader GetSalary(int id)
        {
            SqlDataReader dr;
            SqlCommand cmd = new SqlCommand("EmployeeSalaryByID", this.connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@emp_id", SqlDbType.Int).Value = id;

            dr = cmd.ExecuteReader();
            return dr;
        }
        public SqlDataReader GetAllSalary(int id)
        {
            SqlDataReader dr;
            SqlCommand cmd = new SqlCommand("EmployeeSalaryBySupID", this.connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@emp_id", SqlDbType.Int).Value = id;

            dr = cmd.ExecuteReader();
            return dr;
        }


        //PR
        public SqlDataReader GetPR(int id)
        {
            SqlDataReader dr;
            SqlCommand cmd = new SqlCommand("EmployeePRByID", this.connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@emp_id", SqlDbType.Int).Value = id;

            dr = cmd.ExecuteReader();
            return dr;
        }
        public SqlDataReader GetAllPR(int id)
        {
            SqlDataReader dr;
            SqlCommand cmd = new SqlCommand("EmployeePRBySupID", this.connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@emp_id", SqlDbType.Int).Value = id;

            dr = cmd.ExecuteReader();
            return dr;
        }
        public SqlDataReader GetPRDetail(int id)
        {
            SqlDataReader dr;
            SqlCommand cmd = new SqlCommand("EmployeePRDetailByID", this.connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@per_rev_id", SqlDbType.Int).Value = id;

            dr = cmd.ExecuteReader();
            return dr;
        }


        //PP
        public SqlDataReader GetPP(int id)
        {
            SqlDataReader dr;
            SqlCommand cmd = new SqlCommand("EmployeePPByID", this.connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@emp_id", SqlDbType.Int).Value = id;

            dr = cmd.ExecuteReader();
            return dr;
        }
        public SqlDataReader GetAllPP(int id)
        {
            SqlDataReader dr;
            SqlCommand cmd = new SqlCommand("EmployeePPBySupID", this.connection);
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
