using MyBlog.DTO.DTOs.BlogPostDtos;
using MyBlog.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Business.Abstract
{
    public interface IGenericService<T> where T : BaseEntity
    {
        Task<IEnumerable<T>> TGetAllAsync();
        Task<T> TGetPostByIdAsync(int id);
        Task<T> TCreateAsync(T entity, string userId);
        Task<T> TUpdateAsync(int id, T entity);
        Task<bool> TDeleteAsync(int id);
        Task<IEnumerable<T>> TFindAsync(Expression<Func<T, bool>> predicate);
    }
}
