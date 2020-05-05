using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using salaryMgmt.Config.Gateway;

namespace salaryMgmt.Models
{
    public class Salaries
    {
        public List<Salary> AllSalary = new List<Salary>();
        //public List<SalaryDTO> AllSalaryDTO { get; set; }
        //public List<SalaryRangeDTO> AllSalaryRange { get; set; }
        //public List<PositionDTO> AllPosition { get; set; }
        //public List<PayRaiseDTO> AllPayRaise { get; set; }


        //public Salaries(int id)
        //{
        //    DatabaseGateway db = new DatabaseGateway();
        //    AllSalary = new List<SalaryDTO>();
        //    SalaryDTO salary = new SalaryDTO();
        //    AllSalaryRange = new List<SalaryRangeDTO>();
        //    SalaryRangeDTO salaryRange = new SalaryRangeDTO();
        //    AllPosition = new List<PositionDTO>();
        //    PositionDTO position = new PositionDTO();
        //    AllPayRaise = new List<PayRaiseDTO>();
        //    PayRaiseDTO payRaise = new PayRaiseDTO();

        //    SqlDataReader sal = db.GetAllSalary(id);
        //    while (sal.Read())
        //    {
        //        salary.EMP_ID = (int)sal.GetSqlInt32(sal.GetOrdinal("emp_id"));
        //        Salary mySal = new Salary(salary.EMP_ID);

        //        salary.EMP_ID = (int)sal.GetSqlInt32(sal.GetOrdinal("emp_id"));
        //        salary.SALARY = (float)sal.GetDouble(sal.GetOrdinal("salary"));
        //        salaryRange.POS_ID = (int)sal.GetSqlInt32(sal.GetOrdinal("pos_id"));
        //        salaryRange.POS_SALARY = (float)sal.GetDouble(sal.GetOrdinal("pos_salary"));
        //        salaryRange.SALARY_MAX = (float)sal.GetDouble(sal.GetOrdinal("salary_max"));
        //        salaryRange.SALARY_MIN = (float)sal.GetDouble(sal.GetOrdinal("salary_min"));
        //        //position.POS_PAY_TYPE =
        //        position.POS_TITLE = sal.GetString(sal.GetOrdinal("pos_titile"));
        //        if (!sal.IsDBNull(sal.GetOrdinal("emp_per_rev")))
        //            payRaise.EMP_PER_REV = (int)sal.GetSqlInt32(sal.GetOrdinal("emp_per_rev"));
        //        if (!sal.IsDBNull(sal.GetOrdinal("emp_raise_id")))
        //            payRaise.EMP_RAISE_ID = (int)sal.GetSqlInt32(sal.GetOrdinal("emp_raise_id"));
        //        if (!sal.IsDBNull(sal.GetOrdinal("raise_amount")))
        //            payRaise.RAISE_AMOUNT = (float)sal.GetFloat(sal.GetOrdinal("raise_amount"));
        //        if (!sal.IsDBNull(sal.GetOrdinal("emp_start_date")))
        //            payRaise.RAISE_DATE = sal.GetDateTime(sal.GetOrdinal("emp_start_date"));

        //        mySalary.Add(mySal);

        //        AllSalary.Add(salary);
        //        AllSalaryRange.Add(salaryRange);
        //        AllPosition.Add(position);
        //        AllPayRaise.Add(payRaise);
        //    }
        //}

        public Salaries(int id)
        {
            DatabaseGateway db = new DatabaseGateway();

            //AllSalaryDTO = new List<SalaryDTO>();
            //AllSalaryRange = new List<SalaryRangeDTO>();
            //AllPosition = new List<PositionDTO>();
            //AllPayRaise = new List<PayRaiseDTO>();

            SqlDataReader sal = db.GetAllSalary(id);

            while (sal.Read())
            {
                int emp_id = (int)sal.GetSqlInt32(sal.GetOrdinal("emp_id"));
                Salary curSal = new Salary(emp_id);
                AllSalary.Add(curSal);

                //AllSalaryDTO.Add(curSal.salary);
                //AllSalaryRange.Add(curSal.salaryRange);
                //AllPosition.Add(curSal.position);
                //AllPayRaise.Add(curSal.payRaise);
            }
        }
    }
}
