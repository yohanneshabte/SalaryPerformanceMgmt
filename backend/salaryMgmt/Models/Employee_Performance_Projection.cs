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
    public class Employee_Performance_Projection
    {
        public Employee_Performance_ProjectionDTO Emp_ppDTO { get; set; }
        private DatabaseGateway db;

        public Employee_Performance_Projection(int id)
        {
            Emp_ppDTO = new Employee_Performance_ProjectionDTO();
            db = new DatabaseGateway();
            SqlDataReader emp_pp = GetEmployee_Performance_Projection(id);
            while (emp_pp.Read())
            {
                Emp_ppDTO.EMP_ID = emp_pp.GetInt32(emp_pp.GetOrdinal("emp_id"));
                Emp_ppDTO.PROJ_DATE = emp_pp.GetDateTime(emp_pp.GetOrdinal("proj_date"));
                Emp_ppDTO.RATING_ID = emp_pp.GetInt32(emp_pp.GetOrdinal("rating_id"));
            }
        }


        private SqlDataReader GetEmployee_Performance_Projection(int id)
        {
            SqlDataReader dr;
            SqlCommand cmd = new SqlCommand("GetDepartmentByID", db.connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@emp_id", SqlDbType.Int).Value = id;

            dr = cmd.ExecuteReader();
            return dr;
        }
    }
}
