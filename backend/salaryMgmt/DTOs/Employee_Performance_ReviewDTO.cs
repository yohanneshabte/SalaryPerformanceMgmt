using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace salaryMgmt.Models
{
    public class Employee_Performance_Review
    {
        public int EMP_PER_REV { get; set; }
        public int EMP_ID { get; set; }
        public DateTime REVIEW_DATE { get; set; }
        public string PREVIOUS_REVIEW { get; set; }
        public string PERFORMANCE_FEEDBACK { get; set; }
        public int DEP_ID { get; set; }
        public int RATING_ID { get; set; }
        public int PER_FACT_ID { get; set; }
        public int MERIT_ID { get; set; }

    }
}
