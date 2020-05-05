using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using salaryMgmt.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Cors;

namespace salaryMgmt.Controllers
{
    [ApiController]
    [Route("api/employee/{id}/performance")]
    [EnableCors("MyPolicy")]
    public class PerformanceController : ControllerBase
    {
        private readonly ILogger<PerformanceController> _logger;

        public PerformanceController(ILogger<PerformanceController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("review")]
        public IActionResult GetPerfomanceReview(int id)
        {
            PerformanceReview newPr = new PerformanceReview(id);
          

            return Ok(newPr);

        }

        [HttpGet]
        [Route("review/all")]
        public IActionResult GetAllPerformanceReview(int id)
        {
            PerformanceReviews newPr = new PerformanceReviews(id);
           

            return Ok(newPr);
        }
    }
}
