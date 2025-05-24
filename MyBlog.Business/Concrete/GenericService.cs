using AutoMapper;
using MyBlog.Business.Abstract;
using MyBlog.DataAccess.Abstract;
using MyBlog.DTO.DTOs.BlogPostDtos;
using MyBlog.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Business.Concrete
{
    public class GenericService<T> : IGenericService<T> where T : BaseEntity
    {
        
        internal readonly IGenericRepository<T> _repository;

        public GenericService( IGenericRepository<T> repository)
        {
            _repository = repository;
        }

        public Task<T> TCreateAsync(T entity, string userId)
        {
            return _repository.CreateAsync(entity);
        }

        public async Task<bool> TDeleteAsync(int id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<IEnumerable<T>> TFindAsync(Expression<Func<T, bool>> predicate)
        {
            return await _repository.FindAsync(predicate);
        }

        public async Task<IEnumerable<T>> TGetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public Task<T> TGetPostByIdAsync(int id)
        {
            if(id <= 0)
            {
                throw new ArgumentException("Invalid ID", nameof(id));
            }
             return _repository.GetByIdAsync(id);
        }

        public async Task<T> TUpdateAsync(int id, T entity)
        {
            return await _repository.UpdateAsync(entity);
        }

        private string GenerateSlug(string title)
        {
            // Slug oluşturma işlemi
            string slug = title.ToLower().Replace(" ", "-").Replace("'", "").Replace("&", "ve");
            return slug;
        }

    }
}
