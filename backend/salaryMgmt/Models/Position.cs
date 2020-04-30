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
    public class Position
    {
        public PositionDTO PosDTO { get; set; }
        private DatabaseGateway db;

        public Position(int id)
        {
            PosDTO = new PositionDTO();
            db = new DatabaseGateway();
            SqlDataReader pos = GetPosition(id);
            while (pos.Read())
            {
                PosDTO.POS_ID = pos.GetInt32(pos.GetOrdinal("pos_id"));
                PosDTO.POS_TITLE = pos.GetString(pos.GetOrdinal("pos_title"));
                PosDTO.POS_PAY_TYPE = pos.GetChar(pos.GetOrdinal("pos_pay_type"));

            }
        }


        private SqlDataReader GetPosition(int id)
        {
            SqlDataReader dr;
            SqlCommand cmd = new SqlCommand("GetDepartmentByID", db.connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@pos_id", SqlDbType.Int).Value = id;

            dr = cmd.ExecuteReader();
            return dr;
        }
    }
}
