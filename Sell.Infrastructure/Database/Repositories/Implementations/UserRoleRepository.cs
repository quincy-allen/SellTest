using Microsoft.EntityFrameworkCore;
using Sell.Infrastructure.Database.Context;
using Sell.Infrastructure.Database.Entities;
using Sell.Infrastructure.Database.Repositories.Interfaces;

namespace Sell.Infrastructure.Database.Repositories.Implementations
{
    public class UserRoleRepository : RepositoryBase<ApplicationUserRole>, IUserRoleRepository
    {
        public UserRoleRepository(SellDbContext context) : base(context)
        {

        }
        public void CreateUserRole(ApplicationUserRole userRole)
        {
            CreateUserRole(userRole);
        }

        public async Task<IEnumerable<ApplicationUserRole>> GetAllUserRolesAsync()
        {
            return await FindAll().OrderBy(x => x.DateCreated).ToListAsync();
        }
    }
}
