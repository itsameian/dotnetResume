using System.Collections.Generic;
using System.Threading.Tasks;
using API.Dtos.Blog;
using API.Models;

namespace API.Services.BlogService
{
    public interface IBlogService
    {
        Task<ServiceResponse<GetBlogPostDto>> AddBlogPost(BlogPost newBlogPost);
        Task<ServiceResponse<GetBlogPostDto>> GetBlogPostById(int id);
        Task<ServiceResponse<List<GetBlogPostDto>>> GetAllBlogPosts();
        Task<ServiceResponse<List<BlogPost>>> DeleteBlogPost(int id);
        Task<ServiceResponse<BlogPost>> UpdateBlogPost(BlogPost blogPost);
    }
}