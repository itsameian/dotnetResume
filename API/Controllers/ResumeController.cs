using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnetResume.Dtos.Resume;
using dotnetResume.Models;
using dotnetResume.Services;
using dotnetResume.Services.ResumeService;
using Microsoft.AspNetCore.Mvc;

namespace dotnetResume.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ResumeController : ControllerBase
    {
        private readonly IResumeService _resumeService;
        public ResumeController(IResumeService resumeService)
        {
            this._resumeService = resumeService;
        }

        [HttpDelete("Job/{id}")]
        public async Task<IActionResult> DeleteJob(int id)
        {
            ServiceResponse<List<GetJobDto>> response = await _resumeService.DeleteJob(id);
            if(!response.Success)
            {
                return NotFound(response);
            }
            return Ok(response);
        }

        [HttpGet("Job/All")]
        public async Task<IActionResult> GetAllJobs()
        {
            return Ok(await _resumeService.GetAllJobs());
        }

        [HttpGet("Responsibility/All/{jobId}")]
        public async Task<IActionResult> GetAllResponsibilities(int jobId)
        {
            return Ok(await _resumeService.GetJobResponsibilities(jobId));
        }

        [HttpGet("Job/{id}")]
        public async Task<IActionResult> GetSingleJob(int id)
        {
            ServiceResponse<GetJobDto> response = await _resumeService.GetJobById(id);
            if(response.Data == null)
            {
                return NotFound(response);
            }
            return Ok(response);
        }

        [HttpGet("Responsibility/{id}")]
        public async Task<IActionResult> GetSingleResponsibility(int id)
        {
            return Ok(await _resumeService.GetResponsibilityById(id));
        }

        [HttpPost("Job")]
        public async Task<IActionResult> PostJob(AddJobDto newJob)
        {
            return Ok(await _resumeService.AddJob(newJob));
        }

        [HttpPost("Responsibility")]
        public async Task<IActionResult> PostResponsibility(Responsibility responsibility)
        {
            return Ok(await _resumeService.AddResponsibility(responsibility));
        }

        [HttpPut("Job")]
        public async Task<IActionResult> PutJob(UpdateJobDto updatedJob)
        {
            ServiceResponse<GetJobDto> response = await _resumeService.UpdateJob(updatedJob);
            if(response.Data == null)
            {
                return NotFound(response);
            }
            return Ok(response);
        }
        
    }
}