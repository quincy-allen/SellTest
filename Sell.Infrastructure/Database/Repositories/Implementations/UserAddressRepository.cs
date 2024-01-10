using Microsoft.EntityFrameworkCore;
using Sell.Infrastructure.Database.Context;
using Sell.Infrastructure.Database.Entities;
using Sell.Infrastructure.Database.Repositories.Interfaces;

namespace Sell.Infrastructure.Database.Repositories.Implementations
{
    public class UserAddressRepository : RepositoryBase<ApplicationUserAddress>, IUserAddressRepository
    {
        public UserAddressRepository(SellDbContext context) : base(context)
        {

        }
        public void CreateUserAddress(ApplicationUserAddress userAddress)
        {
            CreateUserAddress(userAddress);
        }

        public async Task<IEnumerable<ApplicationUserAddress>> GetAllUsersAddressesAsync()
        {
            return await FindAll().OrderBy(x => x.DateCreated).ToListAsync();
        }
    }
}
