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
   
    public class Department
    {
        public DepartmentDTO DepDTO { get; set; }
        private DatabaseGateway db;

        public Department(int id)
        {
            DepDTO = new DepartmentDTO();
            db = new DatabaseGateway();
            SqlDataReader dep = GetDepartment(id);
            while (dep.Read())
            {
                DepDTO.DEP_ID = dep.GetInt32(dep.GetOrdinal("dep_id"));
                DepDTO.depName = dep.GetString(dep.GetOrdinal("dep_name"));

            }
        }


        private SqlDataReader GetDepartment(int id)
        {
            SqlDataReader dr;
            SqlCommand cmd = new SqlCommand("GetDepartmentByID", db.connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@dep_id", SqlDbType.Int).Value = id;

            dr = cmd.ExecuteReader();
            return dr;
        }





    }
}
