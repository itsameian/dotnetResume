using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using dotnetResume.Models;

namespace dotnetResume.Services.ResumeService
{
    public class ResumeService : IResumeService
    {
        private List<Job> Jobs = new List<Job>{
            new Job{
                Id = 1,
                Title = "Big Data Engineer",
                Company = "Allstate",
                StartDate = Convert.ToDateTime("04/27/2018"),
                EndDate = Convert.ToDateTime("07/03/2020")
            },
            new Job{
                Id = 2,
                Title = "Full Stack Engineer",
                Company = "Allstate",
                StartDate = Convert.ToDateTime("12/27/2015"),
                EndDate = Convert.ToDateTime("04/27/2018")
            }
        };
        public async Task<List<Job>> AddJob(Job newJob)
        {
            throw new System.NotImplementedException();
        }

        public async Task<List<Responsibility>> AddResponsibility(Responsibility newResponsibility)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Job>> DeleteJob(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Responsibility> DeleteResponsibilty(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Job>> GetAllJobs()
        {
            throw new System.NotImplementedException();
        }

        public async Task<Job> GetJobById(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<List<Responsibility>> GetJobResponsibilities(int jobId)
        {
            throw new NotImplementedException();
        }

        public  async Task<Responsibility> GetResponsibilityById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Job> UpdateJob(Job updatedJob)
        {
            throw new NotImplementedException();
        }

        public async Task<Responsibility> UpdateResponsibility(Responsibility updatedResponsibility)
        {
            throw new NotImplementedException();
        }
    }
}