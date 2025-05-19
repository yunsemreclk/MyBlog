using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MyBlog.DataAccess.Abstract;
using MyBlog.DataAccess.Context;
using MyBlog.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.DataAccess.Concrete
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        private readonly MyBlogContext _context;

        public GenericRepository(MyBlogContext context)
        {
            _context = context;
        }
        public async Task<T> CreateAsync(T entity)
        {
            entity.CreatedDate = DateTime.UtcNow; // oluşturma zamanınını ayarlama
            await _context.Set<T>().AddAsync(entity); 
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            //await _context.Set<T>().Where(x => x.Id == id).ExecuteDeleteAsync(); // id'ye göre silme işlemi
            //await _context.SaveChangesAsync(); // değişiklikleri kaydetme
            //return true; // silinen entity'i döndürme (null döndürüyoruz çünkü silindi)

            var entity = await GetByIdAsync(id); // id'ye göre entity'i bulma
            if (entity == null) // eğer entity bulunamazsa
            {
                return false; // false döndürme
            }
            _context.Set<T>().Remove(entity); // entity'i silme
            await _context.SaveChangesAsync(); // değişiklikleri kaydetme   
            return true;
        }

        public async Task<T> UpdateAsync(T entity)
        {

            _context.Set<T>().Update(entity); // entity'i güncelleme
            entity.UpdatedDate = DateTime.UtcNow; // güncelleme zamanını ayarlama
            await _context.SaveChangesAsync(); // değişiklikleri kaydetme   
            return entity;
        }

        public async Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate)
        {
            return await _context.Set<T>()
                .Where(predicate)
                .ToListAsync(); // belirli bir koşula uyan entity'leri bulma
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            var entities = await _context.Set<T>().ToListAsync(); // tüm entity'leri listeleme
            return entities;
        }

        public async Task<T?> GetByIdAsync(int id) // Updated return type to T? to indicate it can be null
        {
            return await _context.Set<T>().FirstOrDefaultAsync(x => x.Id == id);
        }


    }
}
