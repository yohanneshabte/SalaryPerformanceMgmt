using System;
namespace salaryMgmt.DTOs
{
    public class EmployeeDTO
    {
        public int EMP_ID { get; set; }
        public int SUP_ID { get; set; }
        public string EMP_FIRST_NAME { get; set; }
        public string EMP_MIDDLE_NAME { get; set; }
        public string EMP_LAST_NAME { get; set; }
        public string EMP_ADDRESS { get; set; }
        public string EMP_SSN { get; set; }
        public string EMP_CELL { get; set; }
        public string EMP_EMAIL { get; set; }
        public DateTime EMP_START_DATE { get; set; }
        public DateTime EMP_END_DATE { get; set; }
        public string EMP_PROFILE_PIC { get; set; }
        public int POS_ID { get; set; }
        public int DEP_ID { get; set; }
        public decimal PAY { get; set; }
        public EmployeeDTO()
        {
        }
    }
}
