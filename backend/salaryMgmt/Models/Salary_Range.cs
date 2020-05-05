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
    public class Salary_Range
    {
        public SalaryRangeDTO S_rangeDTO { get; set; }
        private DatabaseGateway db;

        public Salary_Range(int id)
        {
            S_rangeDTO = new SalaryRangeDTO();
            db = new DatabaseGateway();
            SqlDataReader s_range = GetSalary_Range(id);
            while (s_range.Read())
            {
                S_rangeDTO.POS_ID = s_range.GetInt32(s_range.GetOrdinal("pos_id"));
                S_rangeDTO.posSalary = s_range.GetFloat(s_range.GetOrdinal("pos_salary"));
                S_rangeDTO.salaryMax = s_range.GetFloat(s_range.GetOrdinal("salary_max"));
                S_rangeDTO.salaryMin = s_range.GetFloat(s_range.GetOrdinal("salary_min"));

            }
        }


        private SqlDataReader GetSalary_Range(int id)
        {
            SqlDataReader dr;
            SqlCommand cmd = new SqlCommand("GetSalary_RangeByID", db.connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@pos_id", SqlDbType.Int).Value = id;

            dr = cmd.ExecuteReader();
            return dr;
        }
    }
}
