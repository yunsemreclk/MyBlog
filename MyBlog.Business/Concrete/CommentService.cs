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
    public class CommentService : GenericService<Comment>, ICommentService
    {
        private readonly ICommentRepository _commentService;

        public CommentService(ICommentRepository commentService) : base(commentService) 
        {
            _commentService = commentService;
        }
    }
}
