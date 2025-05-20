using MyBlog.DTO.DTOs.BlogPostDtos;
using MyBlog.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Business.Abstract
{
    public interface IGenericService
    {
        Task<IEnumerable<BlogPostDto>> GetAllAsync();
        Task<BlogPostDto> GetPostByIdAsync(int id);
        Task<BlogPostDto> GetPostBySlugAsync(string slug);
        Task<BlogPostDto> CreateAsync(BlogPostCreateDto entity, string userId);
        Task<BlogPostDto> UpdateAsync(int id, BlogPostUpdateDto entity);
        Task<bool> DeleteAsync(int id);
        Task<IEnumerable<BlogPostDto>> FindAsync(Expression<Func<BlogPostDto, bool>> predicate);
    }
}
