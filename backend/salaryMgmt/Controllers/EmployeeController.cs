using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using salaryMgmt.Models;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace salaryMgmt.Controllers
{
    [ApiController]
    [Route("api/employee/")]
    public class EmployeeController : ControllerBase
    {
        private Employee newEmp;
        private Employees myEmployees;

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
            newEmp = new Employee(id);

            return Ok(newEmp);

        }

        [HttpGet]
        [Route("{id}/all")]
        public IActionResult GetMyEmployees(int id)
        {
            //newEmp = new Employee(id);
            
            myEmployees = new Employees(id);

            return Ok(myEmployees);

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
