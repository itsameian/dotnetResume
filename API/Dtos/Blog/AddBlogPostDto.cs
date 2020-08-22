using System;

namespace API.Dtos.Blog
{
  public class AddBlogPostDto
  {
    public string Post { get; set; }
    public DateTime Date { get; set; }
  }
}