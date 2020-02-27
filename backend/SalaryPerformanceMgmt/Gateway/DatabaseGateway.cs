using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace salaryMgmt.Gateway
{
    public class DatabaseGateway
    {
        
        SqlConnection connection;
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

        public SqlDataReader getEmployees()
        {
            SqlDataReader dr;
            SqlCommand cmd = new SqlCommand("GuiFormVersionOne", connection);
            cmd.CommandType = CommandType.StoredProcedure;
      
            dr = cmd.ExecuteReader();
            return dr;
        }

        public void CloseConnection()
        {
            connection.Close();
        }
        ~DatabaseGateway()
        {
            connection.Close();
        }
    }
}
