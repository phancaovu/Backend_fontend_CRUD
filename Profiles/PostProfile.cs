using AutoMapper;
using Backend.DTO;
using Backend.Models;

namespace Backend.Profiles
{
        public class PostProfile : Profile
        {
            public PostProfile()
            {
                CreateMap<Post, PostDTO>();
            }
      
    }
}
