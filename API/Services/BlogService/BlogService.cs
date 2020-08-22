using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Dtos.Blog;
using API.Models;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace API.Services.BlogService
{
  public class BlogService : IBlogService
  {
    private readonly DataContext _context;
    private readonly IMapper _mapper;
    public BlogService(IMapper mapper, DataContext context)
    {
      this._mapper = mapper;
      this._context = context;
    }
    public async Task<ServiceResponse<GetBlogPostDto>> AddBlogPost(BlogPost newBlogPost)
    {
      ServiceResponse<GetBlogPostDto> response = new ServiceResponse<GetBlogPostDto>();
      BlogPost blogPost = _mapper.Map<BlogPost>(newBlogPost);
      try
      {
        await _context.AddAsync(blogPost);
        await _context.SaveChangesAsync();
        response.Data = _mapper.Map<GetBlogPostDto>(blogPost);
      }
      catch(Exception ex){
          response.Success = false;
          response.Message = ex.Message;
      }
      return response;
    }

    public Task<ServiceResponse<List<BlogPost>>> DeleteBlogPost(int id)
    {
      throw new System.NotImplementedException();
    }

    public async Task<ServiceResponse<List<GetBlogPostDto>>> GetAllBlogPosts()
    {
      ServiceResponse<List<GetBlogPostDto>> response = new ServiceResponse<List<GetBlogPostDto>>();
      response.Data = await _context.BlogPosts.Select(p => _mapper.Map<GetBlogPostDto>(p)).ToListAsync();
      return response;
    }

    public Task<ServiceResponse<GetBlogPostDto>> GetBlogPostById(int id)
    {
      throw new System.NotImplementedException();
    }

    public Task<ServiceResponse<BlogPost>> UpdateBlogPost(BlogPost blogPost)
    {
      throw new System.NotImplementedException();
    }
  }
}