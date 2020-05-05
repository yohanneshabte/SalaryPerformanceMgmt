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
        public MeritGuidelinesDTO M_guideDTO { get; set; }
        private DatabaseGateway db;

        public Merit_Guidelines(int id)
        {
            M_guideDTO = new MeritGuidelinesDTO();
            db = new DatabaseGateway();
            SqlDataReader m_guide = GetMerit_Guidelines(id);
            while (m_guide.Read())
            {
                M_guideDTO.MERIT_ID = m_guide.GetInt32(m_guide.GetOrdinal("merit_id"));
                M_guideDTO.raiseMin = m_guide.GetFloat(m_guide.GetOrdinal("raise_min"));
                M_guideDTO.raiseMax = m_guide.GetFloat(m_guide.GetOrdinal("raise_max"));
                M_guideDTO.raiseTarget = m_guide.GetFloat(m_guide.GetOrdinal("raise_target"));

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
