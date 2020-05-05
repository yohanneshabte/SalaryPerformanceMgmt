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
    public class Merit_Guidelines
    {
        public Merit_GuidelinesDTO M_guideDTO { get; set; }
        private DatabaseGateway db;

        public Merit_Guidelines(int id)
        {
            M_guideDTO = new Merit_GuidelinesDTO();
            db = new DatabaseGateway();
            SqlDataReader m_guide = GetMerit_Guidelines(id);
            while (m_guide.Read())
            {
                M_guideDTO.MERIT_ID = m_guide.GetInt32(m_guide.GetOrdinal("merit_id"));
                M_guideDTO.RAISE_MIN = m_guide.GetFloat(m_guide.GetOrdinal("raise_min"));
                M_guideDTO.RAISE_MAX = m_guide.GetFloat(m_guide.GetOrdinal("raise_max"));
                M_guideDTO.RAISE_TARGET = m_guide.GetFloat(m_guide.GetOrdinal("raise_target"));

            }
        }


        private SqlDataReader GetMerit_Guidelines(int id)
        {
            SqlDataReader dr;
            SqlCommand cmd = new SqlCommand("GetMerit_GuidelinesByID", db.connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@merit_id", SqlDbType.Int).Value = id;

            dr = cmd.ExecuteReader();
            return dr;
        }
    }
}
