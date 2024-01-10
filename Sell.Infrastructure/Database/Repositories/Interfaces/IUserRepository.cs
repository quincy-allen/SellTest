using Sell.Infrastructure.Database.Entities;

namespace Sell.Infrastructure.Database.Repositories.Interfaces
{
    public interface IUserRepository
    {
        Task<IEnumerable<ApplicationUser>> GetAllUsersAsync();
        void CreateUser(ApplicationUser user);
    }
}
