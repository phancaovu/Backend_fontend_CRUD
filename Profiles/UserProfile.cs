using AutoMapper;
using Backend.DTO;
using Backend.Models;

namespace Backend.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile() {
            CreateMap<User,UserDTO>();
        }
        /*public class MappingProfile : Profile
            {
                public MappingProfile()
                {
                    //Source -> Destination
                    CreateMap<User, UserReadDto>()
                        .ForMember(
                            dest => dest.FullName,
                            opt => opt.MapFrom(src => $"{src.FirstName} {src.LastName}"))
                        .ForMember(
                            dest => dest.Age,
                            opt => opt.MapFrom(src => src.DateOfBirth.GetCurrentAge())
                            );

                    CreateMap<UserCreateDto, User>();
                }
            }*/
    }
}
