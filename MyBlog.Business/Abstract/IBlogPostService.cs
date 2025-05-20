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
    public interface IBlogPostService
    {

        //Task<IEnumerable<T>> GetAllAsync();
        //Task<T> GetPostByIdAsync(int id);
        //Task<T > GetPostBySlugAsync(string slug);
        //Task<T> CreateAsync(BlogPostCreateDto postDto, string userId);
        //Task<T> UpdateAsync(int id, BlogPostUpdateDto postDto);
        //Task<bool> DeleteAsync(int id);
        //Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate);

        Task<IEnumerable<BlogPostDto>> GetAllAsync();
        Task<BlogPostDto> GetByIdAsync(int id);
        Task<BlogPostDto> GetPostBySlugAsync(string slug);
        Task<BlogPostDto> CreateAsync(BlogPostCreateDto blogDto, string userId);
        Task<BlogPostDto> UpdateAsync(int id, BlogPostUpdateDto blogDto);
        Task<bool> DeleteAsync(int id);
    }
}
