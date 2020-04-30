using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace salaryMgmt.Models
{
    public class Pay_RaiseDTO
    {
        public int EMP_RAISE_ID { get; set; }
        public int EMP_ID { get; set; }
        public int EMP_PER_REV { get; set; }
        public float RAISE_AMOUNT { get; set; }
        public DateTime RAISE_DATE { get; set; }
    }
}
