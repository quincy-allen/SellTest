using Sell.Infrastructure.Database.Entities;

namespace Sell.Infrastructure.Database.Repositories.Interfaces
{
    public interface IUserAddressRepository
    {
        Task<IEnumerable<ApplicationUserAddress>> GetAllUsersAddressesAsync();
        void CreateUserAddress(ApplicationUserAddress userAddress);
    }
}
