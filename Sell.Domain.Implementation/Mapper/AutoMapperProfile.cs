using AutoMapper;
using Sell.Domain.Models;
using Sell.Infrastructure.Database.Entities;

namespace Sell.Domain.Implementation.Mapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<ApplicationUser, UserDTO>().ReverseMap();
            CreateMap<List<ApplicationUser>, List<UserDTO>>().ReverseMap(); 
        }
    }
}
