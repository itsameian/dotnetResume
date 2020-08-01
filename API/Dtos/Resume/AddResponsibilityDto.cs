using dotnetResume.Models;

namespace API.Dtos.Resume
{
    public class AddResponsibilityDto
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public Job Job { get; set; }
    }
}