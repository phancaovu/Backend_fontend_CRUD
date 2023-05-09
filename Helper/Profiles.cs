/*using AutoMapper;
using Backend.DTO;
using Backend.Models;

namespace Backend.Helper
{
    public class Profiles : Profile
    {
        public Profiles() {
            CreateMap<User, UserDTO>().ReverseMap();// map nguoc lai
            *//*
              CreateMap<User, UserReadDto>()
                .ForMember(
                    dest => dest.FullName,
                    opt => opt.MapFrom(src => $"{src.FirstName} {src.LastName}"))
                .ForMember(
                    dest => dest.Age,
                    opt => opt.MapFrom(src => src.DateOfBirth.GetCurrentAge())
                    );

            CreateMap<UserCreateDto, User>();
             *//*
        }
    }
}
*/