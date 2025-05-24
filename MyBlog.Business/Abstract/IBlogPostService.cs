using MyBlog.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Business.Abstract
{
    public interface IBlogPostService : IGenericService<BlogPost>
    {
        Task<BlogPost> GetBySlugAsync(string slug);
    }
}
