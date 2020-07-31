using System.Collections.Generic;
using System.Threading.Tasks;
using dotnetResume.Dtos.Resume;
using dotnetResume.Models;

namespace dotnetResume.Services.ResumeService
{
    public interface IResumeService
    {
         Task<ServiceResponse<List<GetJobDto>>> GetAllJobs();
         Task<ServiceResponse<GetJobDto>> GetJobById(int id);
         Task<ServiceResponse<List<GetJobDto>>> AddJob(AddJobDto newJob);
         Task<ServiceResponse<GetJobDto>> UpdateJob(UpdateJobDto updatedJob);
         Task<ServiceResponse<List<GetJobDto>>> DeleteJob(int id);
         Task<ServiceResponse<List<Responsibility>>> GetJobResponsibilities(int jobId);
         Task<ServiceResponse<Responsibility>> GetResponsibilityById(int id);
         Task<ServiceResponse<List<Responsibility>>> AddResponsibility(Responsibility newResponsibility);
         Task<ServiceResponse<Responsibility>> UpdateResponsibility(Responsibility updatedResponsibility);
         Task<ServiceResponse<List<Responsibility>>> DeleteResponsibilty(int id);

    }
}