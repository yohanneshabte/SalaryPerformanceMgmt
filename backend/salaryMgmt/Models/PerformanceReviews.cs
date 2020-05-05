using System;
using System.Collections.Generic;
using salaryMgmt.DTOs;
using salaryMgmt.Config.Gateway;
using System.Data.SqlClient;

namespace salaryMgmt.Models
{
    public class PerformanceReviews
    {
        public List<PerformanceReview> AllPR = new List<PerformanceReview>();

        public PerformanceReviews(int id)
        {
            DatabaseGateway db = new DatabaseGateway();

            SqlDataReader emp = db.GetAllPR(id);
            while (emp.Read())
            {
                int emp_id = (int)emp.GetSqlInt32(emp.GetOrdinal("emp_id"));

                PerformanceReview pr = new PerformanceReview(emp_id);

                AllPR.Add(pr);
            }
        }
    }
}
