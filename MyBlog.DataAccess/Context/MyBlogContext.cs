using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyBlog.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.DataAccess.Context
{
    public class MyBlogContext : DbContext
    {
        public MyBlogContext(DbContextOptions<MyBlogContext> options) : base(options)
        {
        }
        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Fluent API configurations can be added here if needed
            // BlogPost ve Category arasındaki ilişki (Bir BlogPost, bir Category'ye ait olacak)
            modelBuilder.Entity<BlogPost>()
                .HasOne(bp => bp.Category)  // BlogPost'un bir Category'ye sahip olduğunu belirtiyoruz
                .WithMany(c => c.BlogPosts)  // Her Category'nin birden fazla BlogPost'u olabileceğini belirtiyoruz
                .HasForeignKey(bp => bp.CategoryId)  // BlogPost'taki CategoryId'nin, Category tablosundaki anahtara işaret ettiğini belirtiyoruz
                .OnDelete(DeleteBehavior.Restrict);  // Kategori silindiğinde, ilişkili BlogPost'ların silinmemesi için

            //// BlogPost ve AppUser arasındaki ilişki (Her BlogPost'un bir yazarı olacak)
            //modelBuilder.Entity<BlogPost>()
            //    .HasOne(bp => bp.AppUser)  // BlogPost'un bir AppUser'a (yazar) ait olduğunu belirtiyoruz
            //    .WithMany(u => u.BlogPosts)  // Bir AppUser'ın birçok BlogPost'u olabileceğini belirtiyoruz
            //    .HasForeignKey(bp => bp.UserId)  // BlogPost'taki UserId'nin, AppUser tablosundaki anahtara işaret ettiğini belirtiyoruz
            //    .OnDelete(DeleteBehavior.SetNull);  // Kullanıcı silindiğinde, ilgili BlogPost'lar silinmesin, UserId null yapılsın

            // BlogPost ve Comment arasındaki ilişki (Her BlogPost'un birden fazla Comment'i olabilir)
            modelBuilder.Entity<Comment>()
                .HasOne(c => c.BlogPost)  // Comment'in bir BlogPost'a ait olduğunu belirtiyoruz
                .WithMany(bp => bp.Comments)  // Bir BlogPost'un birden fazla Comment'i olabileceğini belirtiyoruz
                .HasForeignKey(c => c.BlogPostId)  // Comment'teki BlogPostId'nin, BlogPost tablosundaki anahtara işaret ettiğini belirtiyoruz
                .OnDelete(DeleteBehavior.Cascade);  // BlogPost silindiğinde, ilişkili Comment'ler de silinsin

            //// Comment ve AppUser arasındaki ilişki (Her Comment bir AppUser tarafından yapılır)
            //modelBuilder.Entity<Comment>()
            //    .HasOne(c => c.AppUser)  // Comment'in bir AppUser'a (kullanıcı) ait olduğunu belirtiyoruz
            //    .WithMany(u => u.Comments)  // Bir AppUser'ın birçok Comment'i olabileceğini belirtiyoruz
            //    .HasForeignKey(c => c.UserId)  // Comment'teki UserId'nin, AppUser tablosundaki anahtara işaret ettiğini belirtiyoruz
            //    .OnDelete(DeleteBehavior.SetNull);  // AppUser silindiğinde, ilgili Comment'ler de silinsin

        }
    }    
    
}


