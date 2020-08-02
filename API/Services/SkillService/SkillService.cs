using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Dtos.Resume;
using AutoMapper;
using dotnetResume.Data;
using dotnetResume.Models;
using dotnetResume.Services;
using Microsoft.EntityFrameworkCore;

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
        public async Task<ServiceResponse<GetSkillDto>> AddSkill(AddSkillDto addedSkill)
        {
            ServiceResponse<GetSkillDto> response = new ServiceResponse<GetSkillDto>();
            Skill skill = _mapper.Map<Skill>(addedSkill);
            try{
                await _context.AddAsync(skill);
                await _context.SaveChangesAsync();
                response.Data = _mapper.Map<GetSkillDto>(skill);
            }
            catch(Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
            }
            return response;
        }

        public async Task<ServiceResponse<List<GetSkillDto>>> DeleteSkill(int id)
        {
            ServiceResponse<List<GetSkillDto>> response = new ServiceResponse<List<GetSkillDto>>();
            try
            {
                Skill skill = await _context.Skills.FirstOrDefaultAsync(s => s.Id == id);
                _context.Skills.Remove(skill);
                await _context.SaveChangesAsync();
                response.Data = await _context.Skills.Select(s => _mapper.Map<GetSkillDto>(s)).ToListAsync();
            }
            catch(Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
            }
            return response;
        }

        public async Task<ServiceResponse<List<GetSkillDto>>> GetAllSkills()
        {
            ServiceResponse<List<GetSkillDto>> response = new ServiceResponse<List<GetSkillDto>>();
            response.Data = await _context.Skills.Select(s => _mapper.Map<GetSkillDto>(s)).ToListAsync();
            return response;
        }

        public async Task<ServiceResponse<GetSkillDto>> GetSkillById(int id)
        {
            ServiceResponse<GetSkillDto> response = new ServiceResponse<GetSkillDto>();
            Skill skill = await _context.Skills.FirstOrDefaultAsync(s => s.Id == id);
            response.Data = _mapper.Map<GetSkillDto>(skill);
            return response;
        }

        public async Task<ServiceResponse<GetSkillDto>> UpdateSkill(UpdateSkillDto skill)
        {
            ServiceResponse<GetSkillDto> response = new ServiceResponse<GetSkillDto>();
            return response;
        }
    }
}