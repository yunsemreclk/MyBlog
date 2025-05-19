using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.DTO.DTOs.CommentDtos
{
    public class CommentCreateDto
    {
        public string Content { get; set; } // Yorum içeriği
        public int BlogPostId { get; set; } // Yorumun ait olduğu blog yazısının ID'si
        public int UserId { get; set; } // Yorumu yapan kullanıcının ID'si

    }
}
