using AutoMapper;
using FoolCardGame.API.Entities;
using FoolCardGame.API.Models.Users;

namespace FoolCardGame.API.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, UserModel>();
            CreateMap<RegisterModel, User>();
            CreateMap<UpdateModel, User>();
        }
    }
}