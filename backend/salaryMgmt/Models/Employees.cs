using System;
using System.Collections.Generic;
using salaryMgmt.DTOs;
using salaryMgmt.Config.Gateway;
using System.Data.SqlClient;

namespace salaryMgmt.Models
{
    public class Employees
    {
        public List<Employee> myEmps = new List<Employee>();
        public List<EmployeeDTO> AllEmployees { get; set; }

        public Employees(int id)
        {
            DatabaseGateway db = new DatabaseGateway();
            AllEmployees = new List<EmployeeDTO>();
            EmployeeDTO EmpDTO = new EmployeeDTO();
            SqlDataReader emp = db.GetAllEmployees(id);
            while (emp.Read())
            {
                EmpDTO.EMP_ID = (int)emp.GetSqlInt32(emp.GetOrdinal("emp_id"));

                Employee myEmp = new Employee(EmpDTO.EMP_ID);

                EmpDTO.DEP_ID = (int)emp.GetSqlInt32(emp.GetOrdinal("dep_id"));
                EmpDTO.POS_ID = (int)emp.GetSqlInt32(emp.GetOrdinal("pos_id"));
                EmpDTO.SUP_ID = (int)emp.GetSqlInt32(emp.GetOrdinal("sup_id"));
                EmpDTO.EMP_FIRST_NAME = emp.GetString(emp.GetOrdinal("emp_first_name"));
                EmpDTO.EMP_LAST_NAME = emp.GetString(emp.GetOrdinal("emp_last_name"));
                EmpDTO.EMP_MIDDLE_NAME = emp.GetString(emp.GetOrdinal("emp_middle_initial"));
                EmpDTO.EMP_SSN = emp.GetString(emp.GetOrdinal("emp_ssn"));
                EmpDTO.EMP_ADDRESS = emp.GetString(emp.GetOrdinal("emp_address"));
                EmpDTO.EMP_CELL = emp.GetString(emp.GetOrdinal("emp_cell"));
                EmpDTO.EMP_START_DATE = emp.GetDateTime(emp.GetOrdinal("emp_start_date"));
                //EmpDTO.EMP_END_DATE = emp.GetDateTime(emp.GetOrdinal("emp_end_date"));
                EmpDTO.EMP_EMAIL = emp.GetString(emp.GetOrdinal("emp_email"));
                //EmpDTO.PAY_TYPE = (char)emp.GetChar(emp.GetOrdinal("emp_pay_type"));
                EmpDTO.EMP_PROFILE_PIC = emp.GetString(emp.GetOrdinal("emp_profile_pic"));
                myEmps.Add(myEmp);
                AllEmployees.Add(EmpDTO);
            }
        }
    }
}
