using System.Collections.Generic;
using System.Threading.Tasks;
using API.Dtos.Resume;
using API.Services.SkillService;
using API.Services;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class SkillController : ControllerBase
    {
        private readonly ISkillService _skillService;
        public SkillController(ISkillService skillService)
        {
            this._skillService = skillService;
        }

        [HttpGet("Resume/Skill/All")]
        public async Task<IActionResult> GetAllSkills()
        {
            return Ok(await _skillService.GetAllSkills());
        }

        [HttpGet("Resume/Skill/{id}")]
        public async Task<IActionResult> GetSkillById(int id)
        {
            ServiceResponse<GetSkillDto> response = await _skillService.GetSkillById(id);
            if (response.Data == null)
            {
                return NotFound(response);
            }
            return Ok(response);
        }

        [HttpPost("Resume/Skill")]
        public async Task<IActionResult> PostSkill(AddSkillDto newSkill)
        {
            ServiceResponse<GetSkillDto> response = await _skillService.AddSkill(newSkill);
            if (!response.Success)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }

        [HttpDelete("Resume/Skill")]
        public async Task<IActionResult> DeleteSkill(int id)
        {
            ServiceResponse<List<GetSkillDto>> response = await _skillService.DeleteSkill(id);
            if (!response.Success)
            {
                return NotFound(response);
            }
            return Ok(response);
        }
    }
}