using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.DTO.DTOs.CategoryDtos
{
    public class CategoryDto
    {
        public int Id { get; set; } // Kategori ID'si
        public string Name { get; set; } // Kategori adı
        public string Description { get; set; } // Kategori açıklaması
        public DateTime CreatedDate { get; set; } // Oluşturulma tarihi
        public DateTime UpdatedDate { get; set; } // Güncellenme tarihi
    }
}
