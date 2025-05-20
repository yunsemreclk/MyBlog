using AutoMapper;
using MyBlog.Entity.Entities;
using MyBlog.DTO.DTOs.CommentDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Business.Mapping
{
    public class CommentProfile : Profile
    {
        public CommentProfile()
        {
            CreateMap<CommentCreateDto, Comment>().ReverseMap();
            CreateMap<CommentUpdateDto, Comment>().ReverseMap();
            CreateMap<CommentDto, Comment>().ReverseMap();

        }
    }
}
