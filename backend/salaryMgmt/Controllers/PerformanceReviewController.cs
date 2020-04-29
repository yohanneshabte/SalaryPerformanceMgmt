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
    [Route("api/employee/{id}/pr")]
    public class PerformanceReviewController : ControllerBase
    {
        //private PerformanceReview newPr;
        private readonly ILogger<PerformanceReviewController> _logger;

        public PerformanceReviewController(ILogger<PerformanceReviewController> logger)
        {
            _logger = logger;
        }

        [HttpGet]

        public IActionResult GetALLPerfomanceReiview()
        {
            //newPr = new PerformanceReview();
            string[] results = { "test", "test" };

            /*results[0] = newPr.PrDTO.CurrentPR;
            results[1] = newPr.PrDTO.ReviewDate;
            results[2] = newPr.PrDTO.PreviousReview;
            results[3] = newPr.PrDTO.PreviousReviewDate;
*/
            return Ok("currentPerformanceReview:" + results[0] + "\nreviewDate:" + results[1]
                + "\npreviousPerformanceReview:" + results[2] + "\npreviousReviewDate" + results[3]);

        }
        public IActionResult GetPerformanceReview()
        {
            //newPr = new PerformanceReview();
            string[] results = { "test", "test" };

            //results[0] = newPr.PrDTO.CurrentPR;
            //results[1] = newPr.PrDTO.ReviewDate;

            return Ok("currentPerformanceReview:" + results[0] + "\nreviewDate:" + results[1]);
        }
    }
}
