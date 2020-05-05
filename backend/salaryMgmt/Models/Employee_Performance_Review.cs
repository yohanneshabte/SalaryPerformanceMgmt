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
    public class Employee_Performance_Review
    {   public Employee_Performance_ReviewDTO Emp_prDTO { get; set; }
        private DatabaseGateway db;

        public Employee_Performance_Review(int id)
        {
            Emp_prDTO = new Employee_Performance_ReviewDTO();
            db = new DatabaseGateway();
            SqlDataReader emp_pr = GetEmployee_Performance_Review(id);
            while (emp_pr.Read())
            {
                Emp_prDTO.EMP_PER_REV = emp_pr.GetInt32(emp_pr.GetOrdinal("emp_per_rev"));
                Emp_prDTO.EMP_ID = emp_pr.GetInt32(emp_pr.GetOrdinal("EMP_ID"));
                Emp_prDTO.REVIEW_DATE = emp_pr.GetDateTime(emp_pr.GetOrdinal("review_date"));
                Emp_prDTO.PREVIOUS_REVIEW = emp_pr.GetString(emp_pr.GetOrdinal("previous_review"));
                Emp_prDTO.PERFORMANCE_FEEDBACK = emp_pr.GetString(emp_pr.GetOrdinal("performance_feedback"));
                Emp_prDTO.DEP_ID = emp_pr.GetInt32(emp_pr.GetOrdinal("dep_id"));
                Emp_prDTO.RATING_ID = emp_pr.GetInt32(emp_pr.GetOrdinal("rating_id"));
                Emp_prDTO.PER_FACT_ID = emp_pr.GetInt32(emp_pr.GetOrdinal("per_fact_id"));
                Emp_prDTO.MERIT_ID = emp_pr.GetInt32(emp_pr.GetOrdinal("merit_id"));

            }
        }


        private SqlDataReader GetEmployee_Performance_Review(int id)
        {
            SqlDataReader dr;
            SqlCommand cmd = new SqlCommand("GetEmployee_Performance_ReviewByID", db.connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@emp_per_rev", SqlDbType.Int).Value = id;

            dr = cmd.ExecuteReader();
            return dr;
        }
    }
}
