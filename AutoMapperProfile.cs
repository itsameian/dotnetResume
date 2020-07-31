using AutoMapper;
using dotnetResume.Dtos.Resume;
using dotnetResume.Models;

namespace dotnetResume
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Job, GetJobDto>();
            CreateMap<AddJobDto, Job>();            
        }
    }
}