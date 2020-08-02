namespace API.Models
{
    public class Skill
    {
        public int Id { get; set; }
        public string SkillName { get; set; }
        public string Description { get; set; }
        public int Years { get; set; }
        public SkillLevel SkillLevel { get; set; }
    }

    public enum SkillLevel
    {
        Beginner = 1,
        Intermediate = 2,
        Advanced = 3,
        Expert = 4
    }
}