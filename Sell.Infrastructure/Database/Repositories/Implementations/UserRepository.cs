using Microsoft.EntityFrameworkCore;
using Sell.Infrastructure.Database.Context;
using Sell.Infrastructure.Database.Entities;
using Sell.Infrastructure.Database.Repositories.Interfaces;

namespace Sell.Infrastructure.Database.Repositories.Implementations
{
    public class UserRepository : RepositoryBase<ApplicationUser>, IUserRepository
    {
        public UserRepository(SellDbContext context) : base(context)
        {

        }
        public void CreateUser(ApplicationUser user)
        {
            Create(user);
        }

        public async Task<IEnumerable<ApplicationUser>> GetAllUsersAsync()
        {
            return await FindAll().OrderBy(x => x.LastName).ToListAsync();
        }
    }
}
