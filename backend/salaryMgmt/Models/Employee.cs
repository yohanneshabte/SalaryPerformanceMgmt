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
        public EmployeeDTO employee { get; set; }
        private DatabaseGateway db;

        public Employee(int id)
        {
            employee = new EmployeeDTO();
            db = new DatabaseGateway();
            SqlDataReader emp = GetEmployee(id);
            while (emp.Read())
            {
                employee.EMP_ID = (int)emp.GetSqlInt32(emp.GetOrdinal("emp_id"));
                employee.DEP_ID = (int)emp.GetSqlInt32(emp.GetOrdinal("dep_id"));
                employee.POS_ID = (int)emp.GetSqlInt32(emp.GetOrdinal("pos_id"));
                employee.SUP_ID = (int)emp.GetSqlInt32(emp.GetOrdinal("sup_id"));
                employee.firstName = emp.GetString(emp.GetOrdinal("emp_first_name"));
                employee.lastName = emp.GetString(emp.GetOrdinal("emp_last_name"));
                employee.middleName = emp.GetString(emp.GetOrdinal("emp_middle_initial"));
                employee.ssn = emp.GetString(emp.GetOrdinal("emp_ssn"));
                employee.address = emp.GetString(emp.GetOrdinal("emp_address"));
                employee.cell = emp.GetString(emp.GetOrdinal("emp_cell"));
                employee.startDate = emp.GetDateTime(emp.GetOrdinal("emp_start_date"));
                //employee.endDate = emp.GetDateTime(emp.GetOrdinal("emp_end_date"));
                employee.email = emp.GetString(emp.GetOrdinal("emp_email"));
                //employee.PAY_TYPE = (char)emp.GetChar(emp.GetOrdinal("emp_pay_type"));
                employee.profilePic = emp.GetString(emp.GetOrdinal("emp_profile_pic"));
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
