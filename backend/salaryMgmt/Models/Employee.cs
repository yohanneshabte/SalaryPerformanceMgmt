using System;
using System.Data;
using System.Data.SqlClient;
using salaryMgmt.DTOs;
using salaryMgmt.Config.Gateway;

namespace salaryMgmt.Models
{
    public class Employee
    {
        public EmployeeDTO EmpDTO { get; set; }
        private DatabaseGateway db;

        public Employee(int id)
        {
            EmpDTO = new EmployeeDTO();
            db = new DatabaseGateway();
            SqlDataReader emp = GetEmployee(id);
            while (emp.Read())
            {
                EmpDTO.FirstName = emp.GetString(emp.GetOrdinal("emp_first_name"));
                EmpDTO.LastName = emp.GetString(emp.GetOrdinal("emp_last_name"));
            }
            
        }

        private SqlDataReader GetEmployee(int id)
        {
            SqlDataReader dr;
            SqlCommand cmd = new SqlCommand("GetEmployeeByID", db.connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@emp_id",SqlDbType.Int).Value = id;

            dr = cmd.ExecuteReader();
            return dr;
        }
    }
}
