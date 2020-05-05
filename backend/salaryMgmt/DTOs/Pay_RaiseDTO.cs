﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace salaryMgmt.Models
{
    [Serializable]
    public class PayRaiseDTO
    {
        public int EMP_RAISE_ID { get; set; }
        public int EMP_ID { get; set; }
        public int EMP_PER_REV { get; set; }
        public float raiseAmount { get; set; }
        public DateTime raiseDate { get; set; }
    }
}
