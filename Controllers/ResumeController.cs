using System;
using System.Collections.Generic;
using System.Linq;
using dotnetResume.Models;
using dotnetResume.Services.ResumeService;
using Microsoft.AspNetCore.Mvc;

namespace dotnetResume.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ResumeController : ControllerBase
    {
        private readonly IResumeService _resumeService;
        public ResumeController(IResumeService resumeService)
        {
            this._resumeService = resumeService;

        }

        [HttpGet("AllJobs")]
        public IActionResult GetJobs()
        {
            return Ok(_resumeService.GetAllJobs());
        }

        [HttpGet("{id}")]
        public IActionResult GetJob(int id)
        {
            return Ok(_resumeService.GetJobById(id));
        }

        [HttpPost]
        public IActionResult PostJob(Job newJob)
        {
            return Ok(_resumeService.AddJob(newJob));
        }
    }
}