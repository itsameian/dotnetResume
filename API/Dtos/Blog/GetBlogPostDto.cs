using System;

namespace API.Dtos.Blog
{
  public class GetBlogPostDto
  {
    public int id { get; set; }
    public string Post { get; set; }
    public DateTime Date { get; set; }
  }
}