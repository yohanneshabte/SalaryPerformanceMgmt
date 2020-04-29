using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace salaryMgmt.Controllers
{
    [ApiController]
    [Route("api/employee/{id}/salary")]
    public class SalaryController : ControllerBase
    {
        //private Salary newSal;
        private readonly ILogger<SalaryController> _logger;

        public SalaryController(ILogger<SalaryController> logger)
        {
            _logger = logger;
        }

        [HttpGet]

        public IActionResult GetSalary()
        {
           // newSal = new Salary();
            string[] results = { "200,000", "150,000", "50,000", "250,000", "50,000", "150,000 - 300,000"};

            /*results[0] = newsSal.SalDTO.CurrentSalary;
            results[1] = newSal.SalDTO.PreviousSalary;
            results[2] = newSal.SalDTO.LastProjectedSalaryRaise;
            results[3] = newSal.SalDTO.ProjectedSalary;
            results[4] = newSal.SalDTO.ProjectedSalaryRaise;
            results[5] = newSal.SalDto.SalaryRange;
*/
            return Ok("currentSalary:" + results[0] + ", previousSalary:" + results[1] + ", lastProSalRaise:"
                    + results[2] + ", proSalary:" + results[3] + ", proSalRaise:" + results[4] + ", salRange:" + results[5]);
        }
    }
}
