using AutoMapper;
using MyBlog.Business.Abstract;
using MyBlog.DataAccess.Abstract;
using MyBlog.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Business.Concrete
{
    public class BlogPostService : GenericService<BlogPost>, IBlogPostService
    {
        private readonly IBlogPostRepository _postRepository;


        public BlogPostService(IBlogPostRepository postRepository) : base(postRepository)
        {
            _postRepository = postRepository;
        }


        public async Task<BlogPost> GetBySlugAsync(string slug)
        {
            return await _postRepository.GetBySlugAsync(slug);
        }
    }
}
