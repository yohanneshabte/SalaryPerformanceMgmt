using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace salaryMgmt.Models
{
    [Serializable]
    public class EmployeePerformanceProjectionDTO
    {
        public int EMP_ID { get; set; }
        public DateTime PROJ_DATE { get; set; }
        public int RATING_ID { get; set; }
    }
}
