using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.DTO.DTOs.CommentDtos
{
    public class CommentUpdateDto
    {
        public int Id { get; set; } // Yorum ID'si
        public string Content { get; set; } // Yorum içeriği
        public int BlogPostId { get; set; } // Yorumun ait olduğu blog yazısının ID'si
        public int AppUserId { get; set; } // Yorumu yapan kullanıcının ID'si
    }
}
