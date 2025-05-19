using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Entity.Entities
{
    public class BlogPost : BaseEntity
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string ImageUrl { get; set; }
        public string Slug { get; set; }
        public DateTime PublishedAt { get; set; } = DateTime.UtcNow;
        public int ViewCount { get; set; } = 0;

        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int UserId { get; set; }
        public AppUser AppUser { get; set; }

        public ICollection<Comment> Comments { get; set; } 
    }
}
