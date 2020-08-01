using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using dotnetResume.Data;
using dotnetResume.Models;
using dotnetResume.Services;

namespace API.Services.SkillService
{
    public class SkillService : ISkillService
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        public SkillService(IMapper mapper, DataContext context)
        {
            this._mapper = mapper;
            this._context = context;

        }
        public Task<ServiceResponse<Skill>> AddSkill(Skill skill)
        {
            ServiceResponse<Skill> response = new ServiceResponse<Skill>();
        }

        public Task<ServiceResponse<List<Skill>>> DeleteSkill(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<ServiceResponse<List<Skill>>> GetAllSkills()
        {
            throw new System.NotImplementedException();
        }

        public Task<ServiceResponse<Skill>> GetSkillById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<ServiceResponse<Skill>> UpdateSkill(Skill skill)
        {
            throw new System.NotImplementedException();
        }
    }
}