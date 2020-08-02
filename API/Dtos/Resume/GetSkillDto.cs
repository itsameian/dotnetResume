using dotnetResume.Models;

namespace API.Dtos.Resume
{
    public class GetSkillDto
    {
        public int Id { get; set; }
        public string SkillName { get; set; }
        public string Description { get; set; }
        public int Years { get; set; }
        public SkillLevel SkillLevel { get; set; }
    }
}