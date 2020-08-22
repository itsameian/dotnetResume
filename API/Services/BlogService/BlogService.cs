using System.Collections.Generic;
using System.Threading.Tasks;
using API.Models;

namespace API.Services.BlogService
{
  public class BlogService : IBlogService
  {
    public Task<ServiceResponse<BlogPost>> AddSkill(BlogPost newSkill)
    {
      throw new System.NotImplementedException();
    }

    public Task<ServiceResponse<List<BlogPost>>> DeleteSkill(int id)
    {
      throw new System.NotImplementedException();
    }

    public Task<ServiceResponse<List<BlogPost>>> GetAllSkills()
    {
      throw new System.NotImplementedException();
    }

    public Task<ServiceResponse<BlogPost>> GetSkillById(int id)
    {
      throw new System.NotImplementedException();
    }

    public Task<ServiceResponse<BlogPost>> UpdateSkill(BlogPost skill)
    {
      throw new System.NotImplementedException();
    }
  }
}