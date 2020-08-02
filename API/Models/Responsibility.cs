namespace API.Models
{
    public class Responsibility
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public Job Job { get; set; }
    }
}