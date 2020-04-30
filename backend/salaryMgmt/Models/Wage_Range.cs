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
    public class Wage_Range
    {
        public Wage_RangeDTO W_rangeDTO { get; set; }
        private DatabaseGateway db;

        public Wage_Range(int id)
        {
            W_rangeDTO = new Wage_RangeDTO();
            db = new DatabaseGateway();
            SqlDataReader w_range = GetWage_Range(id);
            while (w_range.Read())
            {
                W_rangeDTO.POS_ID = w_range.GetInt32(w_range.GetOrdinal("pos_id"));
                W_rangeDTO.POS_WAGE = w_range.GetFloat(w_range.GetOrdinal("pos_wage"));
                W_rangeDTO.WAGE_MAX = w_range.GetFloat(w_range.GetOrdinal("wage_max"));
                W_rangeDTO.WAGE_MIN = w_range.GetFloat(w_range.GetOrdinal("wage_min"));

            }
        }


        private SqlDataReader GetWage_Range(int id)
        {
            SqlDataReader dr;
            SqlCommand cmd = new SqlCommand("GetWage_RangeByID", db.connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@pos_id", SqlDbType.Int).Value = id;

            dr = cmd.ExecuteReader();
            return dr;
        }
    }
}
