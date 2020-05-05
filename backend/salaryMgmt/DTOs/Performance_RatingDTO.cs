 using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace salaryMgmt.Models
{
    [Serializable]
    public class PerformanceRatingDTO
    {
        public int RATING_ID { get; set; }
        public string ratingName { get; set; }
        public string ratingDesc { get; set; }
    }
}
