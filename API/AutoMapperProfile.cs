using API.Dtos.Resume;
using AutoMapper;
using API.Models;
using API.Dtos.Blog;

namespace API
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Job, GetJobDto>();
            CreateMap<AddJobDto, Job>();   
            CreateMap<Responsibility, GetResponsibilityDto>();
            CreateMap<Skill, GetSkillDto>();
            CreateMap<AddSkillDto, Skill>();   
            CreateMap<AddBlogPostDto, BlogPost>();   
            CreateMap<BlogPost, GetBlogPostDto>();   
        }
    }
}