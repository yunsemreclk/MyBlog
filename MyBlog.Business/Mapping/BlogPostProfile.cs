using AutoMapper;
using MyBlog.DTO.DTOs.BlogPostDtos;
using MyBlog.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Business.Mapping
{
    public class BlogPostProfile : Profile
    {
        public BlogPostProfile()
        {
            CreateMap<BlogPostCreateDto, BlogPost>().ReverseMap();
            CreateMap<BlogPostUpdateDto, BlogPost>().ReverseMap();
            CreateMap<BlogPostDto, BlogPost>().ReverseMap();
        }
    }
}
