using API.Services.SkillService;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class SkillController : ControllerBase
    {
        private readonly SkillService _skillService;
        public SkillController(ISkillService skillService)
        {
            this._skillService = skillService;

        }
    }
}