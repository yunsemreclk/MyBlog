using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Entity.Entities
{
    public class AppUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        public string ProfilePicture { get; set; }
        public DateTime DateOfBirth { get; set; }


        public ICollection<BlogPost> BlogPosts { get; set; } 
        public ICollection<Comment> Comments { get; set; }
    }
}
