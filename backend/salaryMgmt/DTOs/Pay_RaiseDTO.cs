using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace salaryMgmt.Models
{
<<<<<<< HEAD
    [Serializable]
    public class PayRaiseDTO
=======
    public class Pay_RaiseDTO
>>>>>>> b55474b9e617de81789d23649bdd9aa40e8a0bc2
    {
        public int EMP_RAISE_ID { get; set; }
        public int EMP_ID { get; set; }
        public int EMP_PER_REV { get; set; }
        public float RAISE_AMOUNT { get; set; }
        public DateTime RAISE_DATE { get; set; }
    }
}
