using API.Models;

namespace API.Dtos.Resume
{
    public class GetResponsibilityDto
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public Job Job { get; set; }
    }
}