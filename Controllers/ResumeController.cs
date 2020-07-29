using System;
using System.Collections.Generic;
using dotnetResume.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnetResume.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ResumeController : ControllerBase
    {
        private List<Job> Jobs = new List<Job>{
            new Job{
                Id = 1,
                Title = "Big Data Engineer",
                Company = "Allstate",
                StartDate = Convert.ToDateTime("04/27/2018"),
                EndDate = Convert.ToDateTime("07/03/2020")
            }
        };

        [HttpGet("Jobs")]
        public IActionResult GetJobs()
        {
            return Ok(Jobs);
        }
    }
}