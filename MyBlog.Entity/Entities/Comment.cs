using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Entity.Entities
{
    public class Comment : BaseEntity
    {
        public string Content { get; set; }
        public DateTime CommentedAt { get; set; } = DateTime.UtcNow;
        public int BlogPostId { get; set; }
        public BlogPost BlogPost { get; set; }
        public int UserId { get; set; }
        public AppUser AppUser { get; set; }

        //Başkasının yorumunu yanıtlamak için kullanılıyor
        //public int? ParentCommentId { get; set; }
        //public Comment ParentComment { get; set; }
        //public ICollection<Comment> Replies { get; set; }
    }
}
