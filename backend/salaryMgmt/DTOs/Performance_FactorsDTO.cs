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
        public string RATING_NAME { get; set; }
        public string FACTOR_NAME { get; set; }
        public string FACTOR_DIMENSIONS { get; set; }
        public string FACTOR_CATEGORY { get; set; }
    }
}
