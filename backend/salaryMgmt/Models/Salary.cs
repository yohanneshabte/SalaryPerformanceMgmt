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
    public class Salary
    {
        public SalaryDTO SalDTO { get; set; }
        private DatabaseGateway db;

        public Salary(int id)
        {
            SalDTO = new SalaryDTO();
            db = new DatabaseGateway();
            SqlDataReader sal = GetDepartment(id);
            while (sal.Read())
            {
                SalDTO.EMP_ID = sal.GetInt32(sal.GetOrdinal("emp_id"));
                SalDTO.SALARY = sal.GetFloat(sal.GetOrdinal("SALARY"));

            }
        }


        private SqlDataReader GetDepartment(int id)
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
