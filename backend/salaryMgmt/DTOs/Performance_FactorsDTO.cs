 using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace salaryMgmt.Models
{
    [Serializable]
    public class PRDetailDTO
    {
        public int PR_DETAIL_ID { get; set; }
        public int EMP_PER_REV { get; set; }
        public string ratingName { get; set; }
        public string factorName { get; set; }
        public string factorDimensionS { get; set; }
        public string factorCategory { get; set; }
    }
}
