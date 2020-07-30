using System;
using System.Collections.Generic;
using System.Linq;
using dotnetResume.Models;
using dotnetResume.Services.JobService;
using Microsoft.AspNetCore.Mvc;

namespace dotnetResume.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ResumeController : ControllerBase
    {
        private readonly IJobService _jobService;
        public ResumeController(IJobService jobService)
        {
            this._jobService = jobService;

        }

        [HttpGet("AllJobs")]
        public IActionResult GetJobs()
        {
            return Ok(_jobService.GetAllJobs());
        }

        [HttpGet("{id}")]
        public IActionResult GetJob(int id)
        {
            return Ok(_jobService.GetJobById(id));
        }

        [HttpPost]
        public IActionResult PostJob(Job newJob)
        {
            return Ok(_jobService.AddJob(newJob));
        }
    }
}