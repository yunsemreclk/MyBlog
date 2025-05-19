using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.DTO.DTOs.CommentDtos
{
    public class CommentDto
    {
        public int Id { get; set; } // Yorum ID'si
        public string Content { get; set; } // Yorum içeriği
        public int BlogPostId { get; set; } // Yorumun ait olduğu blog yazısının ID'si
        public int AppUserId { get; set; } // Yorumu yapan kullanıcının ID'si
        public string AppUserFullName { get; set; }
        public string AppUserProfilePicture { get; set; }
        public DateTime CreatedDate { get; set; } // Oluşturulma tarihi
        public DateTime UpdatedDate { get; set; } // Güncellenme tarihi
    }
}
