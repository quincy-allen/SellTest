using AutoMapper;
using Sell.API.Requests;
using Sell.Domain.Models;

namespace Sell.API.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<UserDTO, UserRequestObject>().ReverseMap();
            CreateMap<List<UserDTO>, List<UserRequestObject>>().ReverseMap();
        }
    }
}
