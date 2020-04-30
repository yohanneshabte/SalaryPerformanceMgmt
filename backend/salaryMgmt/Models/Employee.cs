using System;
using System.Data;
using System.Data.SqlClient;
using salaryMgmt.DTOs;
using salaryMgmt.Config.Gateway;
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
                EmpDTO.EMP_ID = emp.GetInt32(emp.GetOrdinal("emp_id"));
                EmpDTO.SUP_ID = emp.GetInt32(emp.GetOrdinal("sup_id"));
                EmpDTO.EMP_FIRST_NAME = emp.GetString(emp.GetOrdinal("emp_first_name"));
                EmpDTO.EMP_MIDDLE_NAME = emp.GetString(emp.GetOrdinal("emp_middle_name"));
                EmpDTO.EMP_LAST_NAME = emp.GetString(emp.GetOrdinal("emp_last_name"));
                EmpDTO.EMP_ADDRESS = emp.GetString(emp.GetOrdinal("emp_address"));
                EmpDTO.EMP_SSN = emp.GetString(emp.GetOrdinal("emp_ssn"));
                EmpDTO.EMP_CELL = emp.GetString(emp.GetOrdinal("emp_cell"));
                EmpDTO.EMP_EMAIL = emp.GetString(emp.GetOrdinal("emp_email"));
                EmpDTO.EMP_START_DATE = emp.GetDateTime(emp.GetOrdinal("emp_start_date"));
                EmpDTO.EMP_END_DATE = emp.GetDateTime(emp.GetOrdinal("emp_end_date"));
                EmpDTO.EMP_PROFILE_PIC = emp.GetString(emp.GetOrdinal("emp_profile_pic"));
                EmpDTO.POS_ID = emp.GetInt32(emp.GetOrdinal("pos_id"));
                EmpDTO.DEP_ID = emp.GetInt32(emp.GetOrdinal("dep_id"));
                EmpDTO.PAY = emp.GetDecimal(emp.GetOrdinal("pay"));


            }
        }


        private SqlDataReader GetEmployee(int id)
        {
            SqlDataReader dr;
            SqlCommand cmd = new SqlCommand("GetEmployeeByID", db.connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@emp_id", SqlDbType.Int).Value = id;

            dr = cmd.ExecuteReader();
            return dr;
        }
        

    }
}
