using System.Collections.Generic;
using System.Threading.Tasks;
using API.Dtos.Resume;

namespace API.Services.ResumeService
{
    public interface IResumeService
    {
         Task<ServiceResponse<List<GetJobDto>>> GetAllJobs();
         Task<ServiceResponse<GetJobDto>> GetJobById(int id);
         Task<ServiceResponse<List<GetJobDto>>> AddJob(AddJobDto newJob);
         Task<ServiceResponse<GetJobDto>> UpdateJob(UpdateJobDto updatedJob);
         Task<ServiceResponse<List<GetJobDto>>> DeleteJob(int id);
         Task<ServiceResponse<List<GetResponsibilityDto>>> GetJobResponsibilities(int jobId);
         Task<ServiceResponse<GetResponsibilityDto>> GetResponsibilityById(int id);
         Task<ServiceResponse<List<GetResponsibilityDto>>> AddResponsibility(AddResponsibilityDto newResponsibility);
         Task<ServiceResponse<GetResponsibilityDto>> UpdateResponsibility(UpdateResponsibilityDto updatedResponsibility);
         Task<ServiceResponse<List<GetResponsibilityDto>>> DeleteResponsibilty(int id);

    }
}