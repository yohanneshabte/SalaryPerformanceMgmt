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
        public float RAISE_MIN { get; set; }
        public float RAISE_MAX { get; set;}
        public float RAISE_TARGET { get; set; }

    }
}
