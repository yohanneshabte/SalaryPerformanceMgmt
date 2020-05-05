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
    public class Wage
    {
        public WageDTO WgeDTO { get; set; }
        private DatabaseGateway db;

        public Wage(int id)
        {
            WgeDTO = new WageDTO();
            db = new DatabaseGateway();
            SqlDataReader wge = GetWage(id);
            while (wge.Read())
            {
                WgeDTO.EMP_ID = wge.GetInt32(wge.GetOrdinal("emp_id"));
                WgeDTO.WAGE = wge.GetFloat(wge.GetOrdinal("dep_name"));

            }
        }


        private SqlDataReader GetWage(int id)
        {
            SqlDataReader dr;
            SqlCommand cmd = new SqlCommand("GetWageByID", db.connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@emp_id", SqlDbType.Int).Value = id;

            dr = cmd.ExecuteReader();
            return dr;
        }
    }
}
