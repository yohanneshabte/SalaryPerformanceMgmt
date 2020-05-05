using System;
using Newtonsoft.Json;

namespace salaryMgmt.DTOs
{
    public class EmployeeDTO
    {
        public int EMP_ID { get; set; }
        public int SUP_ID { get; set; }
        public string firstName { get; set; }
        public string middleName { get; set; }
        public string lastName { get; set; }
        public string address { get; set; }
        public string ssn { get; set; }
        public string cell { get; set; }
        public string email { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public string profilePic { get; set; }
        public int POS_ID { get; set; }
        public int DEP_ID { get; set; }
        //public char PAY_TYPE { get; set; }
    }
}
