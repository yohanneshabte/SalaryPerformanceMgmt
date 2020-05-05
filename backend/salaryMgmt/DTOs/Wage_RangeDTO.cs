 using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace salaryMgmt.Models
{
    public class Wage_RangeDTO
    {
        public int POS_ID { get; set; }
        public float POS_WAGE { get; set; }
        public float WAGE_MAX { get; set; }
        public float WAGE_MIN { get; set; }

    }
}
