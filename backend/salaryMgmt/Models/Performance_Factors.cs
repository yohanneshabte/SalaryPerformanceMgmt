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
    public class Performance_Factors
    {
        public Performance_FactorsDTO P_factorsDTO { get; set; }
        private DatabaseGateway db;

        public Performance_Factors(int id)
        {
            P_factorsDTO = new Performance_FactorsDTO();
            db = new DatabaseGateway();
            SqlDataReader p_factors = GetPerformance_Factors(id);
            while (p_factors.Read())
            {
                P_factorsDTO.PER_FACT_ID = p_factors.GetInt32(p_factors.GetOrdinal("per_fact_id"));
                P_factorsDTO.FACTOR_NAME = p_factors.GetString(p_factors.GetOrdinal("factor_name"));
                P_factorsDTO.FACTOR_DIMENSIONS = p_factors.GetString(p_factors.GetOrdinal("factor_dimensions"));
                P_factorsDTO.FACTOR_CATAGORY = p_factors.GetString(p_factors.GetOrdinal("factors_catagory"));

            }
        }


        private SqlDataReader GetPerformance_Factors(int id)
        {
            SqlDataReader dr;
            SqlCommand cmd = new SqlCommand("GetPerformance_FactorsByID", db.connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@per_fact_id", SqlDbType.Int).Value = id;

            dr = cmd.ExecuteReader();
            return dr;
        }
    }
}
