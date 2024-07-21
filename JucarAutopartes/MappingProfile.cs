using AutoMapper;
using Entities.Models;
using Entities.Models.Users;
using Shared.DataTransferObjects;
using Shared.DataTransferObjects.Users;

namespace JucarAutopartes
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
           
            // UserForRegistrationDto
            CreateMap<UserForRegistrationDto, User>();
            CreateMap<User, UserDto>();
        }
    }
}
