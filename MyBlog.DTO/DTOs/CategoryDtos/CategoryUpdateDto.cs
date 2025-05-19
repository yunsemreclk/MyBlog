using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.DTO.DTOs.CategoryDtos
{
    public class CategoryUpdateDto
    {
        public int Id { get; set; } // Kategori ID'si
        public string Name { get; set; } // Kategori adı
        public string Description { get; set; } // Kategori açıklaması

    }
}
