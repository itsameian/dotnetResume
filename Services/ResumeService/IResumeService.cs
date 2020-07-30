using System.Collections.Generic;
using System.Threading.Tasks;
using dotnetResume.Models;

namespace dotnetResume.Services.ResumeService
{
    public interface IResumeService
    {
         Task<List<Job>> GetAllJobs();
         Task<Job> GetJobById(int id);
         Task<List<Job>> AddJob(Job newJob);
         Task<Job> UpdateJob(Job updatedJob);
         Task<List<Job>> DeleteJob(int id);
         Task<List<Responsibility>> GetJobResponsibilities(int jobId);
         Task<Responsibility> GetResponsibilityById(int id);
         Task<List<Responsibility>> AddResponsibility(Responsibility newResponsibility);
         Task<Responsibility> UpdateResponsibility(Responsibility updatedResponsibility);
         Task<Responsibility> DeleteResponsibilty(int id);

    }
}