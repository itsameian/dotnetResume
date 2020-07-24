using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using dotnetResume.Models;

namespace dotnetResume.Controllers{
    [ApiController]
    [Route("[controller]")]

    class JobController : ControllerBase {
        private readonly ILogger<JobController> _logger;

        public JobController(ILogger<JobController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public Job Get(int id)
        {
            return new Job();
        }

        [HttpPost]
        public Job Post
    }

}