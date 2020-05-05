using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace salaryMgmt.Models
{
    [Serializable]
    public class SalaryRangeDTO
    {
        public int POS_ID { get; set; }
        public float posSalary { get; set; }
        public float salaryMax { get; set; }
        public float salaryMin { get; set; }

    }
}
