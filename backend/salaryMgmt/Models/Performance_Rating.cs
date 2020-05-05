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
    public class Performance_Rating
    {
        public PerformanceRatingDTO P_ratingDTO { get; set; }
        private DatabaseGateway db;

        public Performance_Rating(int id)
        {
            P_ratingDTO = new PerformanceRatingDTO();
            db = new DatabaseGateway();
            SqlDataReader p_rating = GetPerformance_Rating(id);
            while (p_rating.Read())
            {
                P_ratingDTO.RATING_ID = p_rating.GetInt32(p_rating.GetOrdinal("rating_id"));
                P_ratingDTO.ratingName = p_rating.GetString(p_rating.GetOrdinal("rating_name"));
                P_ratingDTO.ratingDesc = p_rating.GetString(p_rating.GetOrdinal("rating_desc"));

            }
        }


        private SqlDataReader GetPerformance_Rating(int id)
        {
            SqlDataReader dr;
            SqlCommand cmd = new SqlCommand("GetPerformance_RatingByID", db.connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@rating_id", SqlDbType.Int).Value = id;

            dr = cmd.ExecuteReader();
            return dr;
        }
    }
}
