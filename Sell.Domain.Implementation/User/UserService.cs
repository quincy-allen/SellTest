using AutoMapper;
using Sell.Domain.Interfaces.User;
using Sell.Domain.Models;
using Sell.Infrastructure.Database.Entities;
using Sell.Infrastructure.Database.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sell.Domain.Implementation.User
{
    public class UserService : IUserService
    {
        private readonly IMapper _mapper;
        private readonly IUserRepository _repository;
        public UserService(IMapper mapper, IUserRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }
        public async Task<UserDTO> CreateUser(UserDTO data)
        {
            var destination = _mapper.Map<ApplicationUser>(data);

            _repository.CreateUser(destination);

            return data;
        }

        public async Task<List<UserDTO>> GetAllUser()
        {
            var response = await _repository.GetAllUsersAsync();
            var detination = _mapper.Map<List<UserDTO>>(response);

            return detination;
        }
    }
}
