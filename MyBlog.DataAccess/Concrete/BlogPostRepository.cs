using MyBlog.DataAccess.Abstract;
using MyBlog.DataAccess.Context;
using MyBlog.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.DataAccess.Concrete
{
    public class BlogPostRepository : GenericRepository<BlogPost>, IBlogPostRepository
    {
        public BlogPostRepository(MyBlogContext context) : base(context)
        {
        }
    }
}
