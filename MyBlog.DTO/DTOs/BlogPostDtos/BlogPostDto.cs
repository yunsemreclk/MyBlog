using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.DTO.DTOs.BlogPostDtos
{
    public class BlogPostDto
    {
        public int Id { get; set; } // BlogPost'un ID'si
        public string Title { get; set; } // Başlık
        public string Slug { get; set; } // Slug (SEO friendly link)
        public string Content { get; set; }
        public string ImageUrl { get; set; }
        public DateTime PublishedAt { get; set; } // Yayın tarihi
        public int ViewCount { get; set; } // Görüntülenme sayısı
        public int CategoryId { get; set; } // Kategori ID'si
        public string CategoryName { get; set; } // Kategori adı
        public int AppUserId { get; set; } // Kullanıcı ID'si
        public string AppUserName { get; set; } // Yazar adı
        public DateTime CreatedDate { get; set; } // Oluşturulma tarihi
        public DateTime UpdatedDate { get; set; } // Güncellenme tarihi
    }
}
