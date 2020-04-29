using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using salaryMgmt.Models;
using Microsoft.AspNetCore.Http;

namespace salaryMgmt.Controllers
{
    [ApiController]
    [Route("api/employee/")]
    public class EmployeeController : ControllerBase
    {
        private Employee newEmp;
        private readonly ILogger<EmployeeController> _logger;

        public EmployeeController(ILogger<EmployeeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetEmployee(int id)
        {
            //newEmp = new Employee(id);
            string[] results = { "Janet", "Townsend", "C.", "3244 Lake Street", "432-54-2355", "janettownsend@federated.com", "Supervisor", "SC+", "$125,000" };
            //results[0] = newEmp.EmpDTO.FirstName;
            //results[1] = newEmp.EmpDTO.LastName;
            //results[2] = newEmp.EmpDTO.MiddleInitial;
            //results[3] = newEmp.EmpDTO.EmployeeAddress;
            //results[4] = newEmp.EmpDTO.EmplooyeeSSN;
            //results[5] = newEmp.EmpDTO.EmployeeEmail;
            //results[7] = newEmp.EmpDTO.CurrentPR;
            //results[8] = newEmp.EmpDTO.CurrentSalary;
            //results[6] = newEmp.EmpDTO.EmployeeTitle;

            return Ok("firstName:" + results[0] + "\nlastName" + results[1] + "\nmiddleName" + results[2]
                    + "\nempAddress" + results[3] + "\nempSSN" + results[4] + "\nempEmail" + results[5]
                    + "\nempTitle" + results[6] + "\ncurrentPR" + results[7] + "\ncurrentSal" + results[8]);
        }

        [HttpGet]
        [Route("{id}/Department")]
        public IActionResult GetDepartment(int id)
        {
            Employee newEmp = new Employee(id);
            string[] results = { "Research" };
            //results[0] = newEmp.EmpDTO.Department;
            results[0] = "Research";
            return Ok("department" + results[0]);
        }
    }
}
