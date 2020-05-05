using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
<<<<<<< HEAD
                employee.EMP_ID = (int)emp.GetSqlInt32(emp.GetOrdinal("emp_id"));
                employee.DEP_ID = (int)emp.GetSqlInt32(emp.GetOrdinal("dep_id"));
                employee.POS_ID = (int)emp.GetSqlInt32(emp.GetOrdinal("pos_id"));
                employee.SUP_ID = (int)emp.GetSqlInt32(emp.GetOrdinal("sup_id"));
                employee.firstName = emp.GetString(emp.GetOrdinal("emp_first_name"));
                employee.EMP_LAST_NAME = emp.GetString(emp.GetOrdinal("emp_last_name"));
                employee.EMP_MIDDLE_NAME = emp.GetString(emp.GetOrdinal("emp_middle_initial"));
                employee.EMP_SSN = emp.GetString(emp.GetOrdinal("emp_ssn"));
                employee.EMP_ADDRESS = emp.GetString(emp.GetOrdinal("emp_address"));
                employee.EMP_CELL = emp.GetString(emp.GetOrdinal("emp_cell"));
                employee.EMP_START_DATE = emp.GetDateTime(emp.GetOrdinal("emp_start_date"));
                //employee.EMP_END_DATE = emp.GetDateTime(emp.GetOrdinal("emp_end_date"));
                employee.EMP_EMAIL = emp.GetString(emp.GetOrdinal("emp_email"));
                //employee.PAY_TYPE = (char)emp.GetChar(emp.GetOrdinal("emp_pay_type"));
                employee.EMP_PROFILE_PIC = emp.GetString(emp.GetOrdinal("emp_profile_pic"));
=======
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


>>>>>>> b55474b9e617de81789d23649bdd9aa40e8a0bc2
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
