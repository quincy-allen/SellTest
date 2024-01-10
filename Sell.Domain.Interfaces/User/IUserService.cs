using Sell.Domain.Models;

namespace Sell.Domain.Interfaces.User
{
    public interface IUserService
    {
        Task<UserDTO> CreateUser(UserDTO data);
        Task<List<UserDTO>> GetAllUser();
    }
}
