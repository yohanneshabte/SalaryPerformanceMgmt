using System;
using System.Data.SqlClient;
using salaryMgmt.DTOs;
using salaryMgmt.Config.Gateway;
using System.Collections.Generic;

namespace salaryMgmt.Models
{
    [Serializable]
    public class Salary
    {
        public SalaryDTO salary { get; set; }
        public SalaryRangeDTO salaryRange { get; set; }
        public PositionDTO position { get; set; }
        public PayRaiseDTO payRaise { get; set; }

        private DatabaseGateway db;

        public Salary(int id)
        {
            salary = new SalaryDTO();
            salaryRange = new SalaryRangeDTO();
            position = new PositionDTO();
            payRaise = new PayRaiseDTO();
            db = new DatabaseGateway();

            SqlDataReader sal = db.GetSalary(id);
            while (sal.Read())
            {
                salary.EMP_ID = (int)sal.GetSqlInt32(sal.GetOrdinal("emp_id"));
                salary.salary = (float)sal.GetDouble(sal.GetOrdinal("salary"));
                salaryRange.POS_ID = (int)sal.GetSqlInt32(sal.GetOrdinal("pos_id"));
                salaryRange.posSalary = (float)sal.GetDouble(sal.GetOrdinal("pos_salary"));
                salaryRange.salaryMax = (float)sal.GetDouble(sal.GetOrdinal("salary_max"));
                salaryRange.salaryMin = (float)sal.GetDouble(sal.GetOrdinal("salary_min"));
                //position.POS_PAY_TYPE =
                position.posTitle = sal.GetString(sal.GetOrdinal("pos_titile"));
                if (!sal.IsDBNull(sal.GetOrdinal("emp_per_rev")))
                    payRaise.EMP_PER_REV = (int)sal.GetSqlInt32(sal.GetOrdinal("emp_per_rev"));
                if (!sal.IsDBNull(sal.GetOrdinal("emp_raise_id")))
                    payRaise.EMP_RAISE_ID = (int)sal.GetSqlInt32(sal.GetOrdinal("emp_raise_id"));
                if (!sal.IsDBNull(sal.GetOrdinal("raise_amount")))
                    payRaise.raiseAmount = (float)sal.GetFloat(sal.GetOrdinal("raise_amount"));
                if (!sal.IsDBNull(sal.GetOrdinal("emp_start_date")))
                    payRaise.raiseDate = sal.GetDateTime(sal.GetOrdinal("emp_start_date"));
            }
      
        }
    }
}
