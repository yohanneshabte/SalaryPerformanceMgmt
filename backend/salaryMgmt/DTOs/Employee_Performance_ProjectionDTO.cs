using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace salaryMgmt.Models
{
    public class Employee_Performance_Projection
    {
        public int EMP_ID { get; set; }
        public DateTime PROJ_DATE { get; set; }
        public int RATING_ID { get; set; }
    }
}
