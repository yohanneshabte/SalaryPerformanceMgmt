using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace salaryMgmt.Models
{ 
    [Serializable]
    public class DepartmentDTO
    {
        public int DEP_ID { get; set; }
        public string depName { get; set; }

    }
}
