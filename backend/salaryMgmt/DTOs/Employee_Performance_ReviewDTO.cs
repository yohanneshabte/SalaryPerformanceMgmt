using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace salaryMgmt.Models
{
    [Serializable]
    public class EmployeePerformanceReviewDTO
    {
        public int EMP_PER_REV { get; set; }
        public int EMP_ID { get; set; }
        public DateTime reviewDate { get; set; }
        public string previousReview { get; set; }
        public string performanceFeedback { get; set; }
        public int RATING_ID { get; set; }
        public List<PerformanceReviewDetail> PRDetails { get; set; } 

    }
}
