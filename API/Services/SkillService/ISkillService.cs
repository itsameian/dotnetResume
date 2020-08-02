using System.Collections.Generic;
using System.Threading.Tasks;
using API.Dtos.Resume;

namespace API.Services.SkillService
{
    public interface ISkillService
    {
        Task<ServiceResponse<GetSkillDto>> AddSkill(AddSkillDto newSkill);
        Task<ServiceResponse<GetSkillDto>> GetSkillById(int id);
        Task<ServiceResponse<List<GetSkillDto>>> GetAllSkills();
        Task<ServiceResponse<List<GetSkillDto>>> DeleteSkill(int id);
        Task<ServiceResponse<GetSkillDto>> UpdateSkill(UpdateSkillDto skill);
    }
}