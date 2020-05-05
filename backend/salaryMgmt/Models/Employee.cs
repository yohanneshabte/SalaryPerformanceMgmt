using System;
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
            SqlDataReader emp = db.GetEmployee(id);
            while (emp.Read())
            {
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
            }
        }

    
    }
}
