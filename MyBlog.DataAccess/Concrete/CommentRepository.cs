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
    public class CommentRepository : GenericRepository<Comment>, ICommentRepository
    {
        public CommentRepository(MyBlogContext context) : base(context)
        {
        }
    }
}
