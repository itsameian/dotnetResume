using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using dotnetResume.Models;
using Microsoft.EntityFrameworkCore;

namespace dotnetResume.Controllers{
    [ApiController]
    [Route("[controller]")]

    class JobController : ControllerBase {
        private readonly ILogger<JobController> _logger;
        private readonly DbContext _context;

        public JobController(ILogger<JobController> logger, DbContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public Job Get(int id)
        {
            return new Job();
        }
        
        [HttpPost]
        public Job PostJob(Job job){
            return job;
        }
        
    }

}