using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace salaryMgmt.Models
{
<<<<<<< HEAD
    [Serializable]
    public class EmployeePerformanceReviewDTO
=======
    public class Employee_Performance_ReviewDTO
>>>>>>> b55474b9e617de81789d23649bdd9aa40e8a0bc2
    {
        public int EMP_PER_REV { get; set; }
        public int EMP_ID { get; set; }
        public DateTime REVIEW_DATE { get; set; }
        public string PREVIOUS_REVIEW { get; set; }
        public string PERFORMANCE_FEEDBACK { get; set; }
        public int RATING_ID { get; set; }
        public List<PerformanceReviewDetail> PRDetails { get; set; } 

    }
}
