using System;
<<<<<<< HEAD
using System.Data.SqlClient;
using salaryMgmt.DTOs;
using salaryMgmt.Config.Gateway;
using System.Collections.Generic;

namespace salaryMgmt.Models
{
    [Serializable]
    public class Salary
    {
        public SalaryDTO salary { get; set; }
        public SalaryRangeDTO salaryRange { get; set; }
        public PositionDTO position { get; set; }
        public PayRaiseDTO payRaise { get; set; }

=======
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
>>>>>>> b55474b9e617de81789d23649bdd9aa40e8a0bc2
        private DatabaseGateway db;

        public Salary(int id)
        {
<<<<<<< HEAD
            salary = new SalaryDTO();
            salaryRange = new SalaryRangeDTO();
            position = new PositionDTO();
            payRaise = new PayRaiseDTO();
            db = new DatabaseGateway();

            SqlDataReader sal = db.GetSalary(id);
            while (sal.Read())
            {
                salary.EMP_ID = (int)sal.GetSqlInt32(sal.GetOrdinal("emp_id"));
                salary.SALARY = (float)sal.GetDouble(sal.GetOrdinal("salary"));
                salaryRange.POS_ID = (int)sal.GetSqlInt32(sal.GetOrdinal("pos_id"));
                salaryRange.POS_SALARY = (float)sal.GetDouble(sal.GetOrdinal("pos_salary"));
                salaryRange.SALARY_MAX = (float)sal.GetDouble(sal.GetOrdinal("salary_max"));
                salaryRange.SALARY_MIN = (float)sal.GetDouble(sal.GetOrdinal("salary_min"));
                //position.POS_PAY_TYPE =
                position.POS_TITLE = sal.GetString(sal.GetOrdinal("pos_titile"));
                if (!sal.IsDBNull(sal.GetOrdinal("emp_per_rev")))
                    payRaise.EMP_PER_REV = (int)sal.GetSqlInt32(sal.GetOrdinal("emp_per_rev"));
                if (!sal.IsDBNull(sal.GetOrdinal("emp_raise_id")))
                    payRaise.EMP_RAISE_ID = (int)sal.GetSqlInt32(sal.GetOrdinal("emp_raise_id"));
                if (!sal.IsDBNull(sal.GetOrdinal("raise_amount")))
                    payRaise.RAISE_AMOUNT = (float)sal.GetFloat(sal.GetOrdinal("raise_amount"));
                if (!sal.IsDBNull(sal.GetOrdinal("emp_start_date")))
                    payRaise.RAISE_DATE = sal.GetDateTime(sal.GetOrdinal("emp_start_date"));
            }
      
=======
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
>>>>>>> b55474b9e617de81789d23649bdd9aa40e8a0bc2
        }
    }
}
