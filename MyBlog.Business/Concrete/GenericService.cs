using MyBlog.Business.Abstract;
using MyBlog.DataAccess.Abstract;
using MyBlog.DTO.DTOs.BlogPostDtos;
using MyBlog.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Business.Concrete
{
    public class GenericService : IBlogPostService
    {
        private readonly IBlogPostRepository _blogPostRepository;
        public Task<BlogPostDto> CreateAsync(BlogPostCreateDto blogDto, string userId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<BlogPostDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<BlogPostDto> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<BlogPostDto> GetPostBySlugAsync(string slug)
        {
            throw new NotImplementedException();
        }

        public Task<BlogPostDto> UpdateAsync(int id, BlogPostUpdateDto blogDto)
        {
            throw new NotImplementedException();
        }
    }
}
