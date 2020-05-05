 using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace salaryMgmt.Models
{
    [Serializable]
    public class MeritGuidelinesDTO
    {
        public int MERIT_ID { get; set; }
        public float raiseMin { get; set; }
        public float raiseMax { get; set;}
        public float raiseTarget { get; set; }

    }
}
