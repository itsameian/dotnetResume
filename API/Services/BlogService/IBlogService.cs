using System.Collections.Generic;
using System.Threading.Tasks;
using API.Models;

namespace API.Services.BlogService
{
    public interface IBlogService
    {
        Task<ServiceResponse<BlogPost>> AddSkill(BlogPost newSkill);
        Task<ServiceResponse<BlogPost>> GetSkillById(int id);
        Task<ServiceResponse<List<BlogPost>>> GetAllSkills();
        Task<ServiceResponse<List<BlogPost>>> DeleteSkill(int id);
        Task<ServiceResponse<BlogPost>> UpdateSkill(BlogPost skill);
    }
}