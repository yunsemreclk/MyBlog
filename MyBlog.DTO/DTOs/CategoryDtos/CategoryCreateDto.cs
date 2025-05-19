using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.DTO.DTOs.CategoryDtos
{
    public class CategoryCreateDto
    {
        public string Name { get; set; } // Kategori adı
        public string Description { get; set; } // Kategori açıklaması
    }
}
