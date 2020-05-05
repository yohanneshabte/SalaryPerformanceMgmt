using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace salaryMgmt.Models
{
    [Serializable]
    public class SalaryDTO
    {
        public int EMP_ID { get; set; }
        public float salary { get; set; }
    }
}
