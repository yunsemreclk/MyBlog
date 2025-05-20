using MyBlog.Business.Abstract;
using MyBlog.DataAccess.Abstract;
using MyBlog.DTO.DTOs.BlogPostDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Business.Concrete
{
    public class BlogPostService : IBlogPostService
    {
        private readonly IGenericRepository<BlogPost> _blogPostRepository;
        private readonly IMapper _mapper;

        public BlogPostService(IGenericRepository<BlogPost> blogPostRepository, IMapper mapper)
        {
            _blogPostRepository = blogPostRepository;
            _mapper = mapper;
        }
        public Task<bool> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }
        public Task<IEnumerable<BlogPostDto>> FindAsync(Expression<Func<BlogPostDto, bool>> predicate)
        {
            throw new NotImplementedException();
        }
        public Task<IEnumerable<BlogPostDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }
        public Task<BlogPostDto> GetPostByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
        public Task<BlogPostDto> GetPostBySlugAsync(string slug)
        {
            throw new NotImplementedException();
        }
        public Task<BlogPostDto> CreateAsync(BlogPostCreateDto postDto, string userId)
        {
            throw new NotImplementedException();
        }
        public Task<BlogPostDto> UpdateAsync(int id, BlogPostUpdateDto postDto)
        {
            throw new NotImplementedException();
        }
    }
    {
    
    }
}
