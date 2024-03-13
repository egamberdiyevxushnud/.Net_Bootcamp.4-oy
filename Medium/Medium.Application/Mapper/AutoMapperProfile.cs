using AutoMapper;
using Medium.Application.Commads;
using Medium.Domain.Entity.Model;

namespace Medium.Application.Mapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, CreateUserCommand>().ReverseMap();
        }
    }
}
