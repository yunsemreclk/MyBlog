using Microsoft.EntityFrameworkCore;
using MyBlog.DataAccess.Abstract;
using MyBlog.DataAccess.Context;
using MyBlog.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.DataAccess.Concrete
{
    public class BlogPostRepository : GenericRepository<BlogPost>, IBlogPostRepository
    {
        public BlogPostRepository(MyBlogContext context) : base(context)
        {
        }

        public async Task<BlogPost> GetBySlugAsync(string slug)
        {
            return await _context.BlogPosts
                .Where(b => b.Slug == slug)
                //.Include(b => b.AppUser)
                .Include(b => b.Category)
                .FirstOrDefaultAsync();
        }

    }
}
