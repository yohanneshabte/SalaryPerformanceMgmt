﻿using System;
using System.Collections.Generic;
using salaryMgmt.DTOs;
using salaryMgmt.Config.Gateway;
using System.Data.SqlClient;

namespace salaryMgmt.Models
{
    public class Employees
    {
        public List<Employee> AllEmps = new List<Employee>();

        public Employees(int id)
        {
            DatabaseGateway db = new DatabaseGateway();
            SqlDataReader emp = db.GetAllEmployees(id);
            while (emp.Read())
            {
                int emp_id = (int)emp.GetSqlInt32(emp.GetOrdinal("emp_id"));

                Employee myEmp = new Employee(emp_id);

                AllEmps.Add(myEmp);
            }
        }
    }
}
