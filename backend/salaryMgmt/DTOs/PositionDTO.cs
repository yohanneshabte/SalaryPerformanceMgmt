using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace salaryMgmt.Models
{
    public class PositionDTO
    {
        public int POS_ID { get; set; }
        public string POS_TITLE { get; set; }
        public char POS_PAY_TYPE { get; set; }
    }
}
