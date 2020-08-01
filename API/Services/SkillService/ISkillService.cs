using System.Collections.Generic;
using System.Threading.Tasks;
using dotnetResume.Models;
using dotnetResume.Services;

namespace API.Services.SkillService
{
    public interface ISkillService
    {
         Task<ServiceResponse<Skill>> AddSkill(Skill skill);
         Task<ServiceResponse<Skill>> GetSkillById(int id);
         Task<ServiceResponse<List<Skill>>> GetAllSkills();
         Task<ServiceResponse<List<Skill>>> DeleteSkill(int id);
         Task<ServiceResponse<Skill>> UpdateSkill(Skill skill);
    }
}