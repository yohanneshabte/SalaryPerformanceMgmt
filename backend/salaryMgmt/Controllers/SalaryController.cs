using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using salaryMgmt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace salaryMgmt.Controllers
{
    [ApiController]
    [Route("api/employee/{id}/salary")]
    [EnableCors("MyPolicy")]
    public class SalaryController : ControllerBase
    {
        private Salary salary;
        private Salaries salaries;

        private readonly ILogger<SalaryController> _logger;

        public SalaryController(ILogger<SalaryController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult GetSalary(int id)
        {
            salary = new Salary(id);
            //string[] results = { "200,000", "150,000", "50,000", "250,000", "50,000", "150,000 - 300,000"};

            return Ok(salary);
        }

        [HttpGet]
        [Route("all")]
        public IActionResult GetAllSalary(int id)
        {
            salaries = new Salaries(id);
            //string[] results = { "200,000", "150,000", "50,000", "250,000", "50,000", "150,000 - 300,000"};

            return Ok(salaries.AllSalary);
        }
    }
}
