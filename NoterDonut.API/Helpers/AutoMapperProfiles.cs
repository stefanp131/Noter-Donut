using AutoMapper;
using NoterDonut.API.Models;
using NoterDonut.DATA.Entities;

namespace NoterDonut.API.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<RegisterUserDto, AppUser>();
        }
    }
}