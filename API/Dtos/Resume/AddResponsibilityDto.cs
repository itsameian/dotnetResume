using API.Models;

namespace API.Dtos.Resume
{
    public class AddResponsibilityDto
    {
        public string Description { get; set; }
        public Job Job { get; set; }
    }
}