using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace salaryMgmt.Config.Gateway
{
    public class DatabaseGateway
    {
        private string connectionString = "";
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
        ~DatabaseGateway()
        {
            connection.Close();
        }
    }
}
