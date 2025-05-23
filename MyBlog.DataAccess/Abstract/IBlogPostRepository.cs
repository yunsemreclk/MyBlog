﻿using MyBlog.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.DataAccess.Abstract
{
    public interface IBlogPostRepository : IGenericRepository<BlogPost>
    {
        Task<BlogPost> GetBySlugAsync(string slug);
    }
}
