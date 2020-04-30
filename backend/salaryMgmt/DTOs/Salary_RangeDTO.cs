using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace salaryMgmt.Models
{
    public class Salary_RangeDTO
    {
        public int POS_ID { get; set; }
        public float POS_SALARY { get; set; }
        public float SALARY_MAX { get; set; }
        public float SALARY_MIN { get; set; }

    }
}
