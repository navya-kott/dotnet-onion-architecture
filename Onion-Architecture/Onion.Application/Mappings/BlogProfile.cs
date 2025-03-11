using AutoMapper;
using MongoDB.Bson;
using Onion.Application.DTO;
using Onion.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.Application.Mappings
{
   public class BlogProfile :Profile
    {
        public BlogProfile()
        {
     
      CreateMap<Blog, BlogDto>()
     .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id.ToString())) //  Convert ObjectId to string
     .ReverseMap()
     .ForMember(dest => dest.Id, opt => opt.MapFrom(src => string.IsNullOrEmpty(src.Id) ? ObjectId.GenerateNewId().ToString() : src.Id)); //  Ensure correct mapping


        }
    }
}
