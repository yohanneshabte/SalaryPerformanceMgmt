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
    public class Pay_Raise
    {
        public PayRaiseDTO P_raiseDTO { get; set; }
        private DatabaseGateway db;

        public Pay_Raise(int id)
        {
            P_raiseDTO = new PayRaiseDTO();
            db = new DatabaseGateway();
            SqlDataReader P_raise = GetPay_Raise(id);
            while (P_raise.Read())
            {
                P_raiseDTO.EMP_RAISE_ID = P_raise.GetInt32(P_raise.GetOrdinal("emp_raise_id"));
                P_raiseDTO.EMP_ID = P_raise.GetInt32(P_raise.GetOrdinal("emp_id"));
                P_raiseDTO.EMP_PER_REV = P_raise.GetInt32(P_raise.GetOrdinal("emp_per_rev"));
                P_raiseDTO.raiseAmount = P_raise.GetFloat(P_raise.GetOrdinal("raise_amount"));
                P_raiseDTO.raiseDate = P_raise.GetDateTime(P_raise.GetOrdinal("raise_date"));

            }
        }


        private SqlDataReader GetPay_Raise(int id)
        {
            SqlDataReader dr;
            SqlCommand cmd = new SqlCommand("GetDepartmentByID", db.connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@emp_payraise_id", SqlDbType.Int).Value = id;

            dr = cmd.ExecuteReader();
            return dr;
        }
    }
}
