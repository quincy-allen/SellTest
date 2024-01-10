using Microsoft.EntityFrameworkCore;
using Sell.Infrastructure.Database.Context;
using Sell.Infrastructure.Database.Entities;
using Sell.Infrastructure.Database.Repositories.Interfaces;

namespace Sell.Infrastructure.Database.Repositories.Implementations
{
    public class UserSalaryRepository : RepositoryBase<ApplicationUserSalary>, IUserSalaryRepository
    {
        public UserSalaryRepository(SellDbContext context) : base(context)
        {

        }
        public void CreateUserSalary(ApplicationUserSalary userSalary)
        {
            CreateUserSalary(userSalary);
        }

        public async Task<IEnumerable<ApplicationUserSalary>> GetAllUserSalariesAsync()
        {
            return await FindAll().OrderBy(x => x.DateCreated).ToListAsync();
        }
    }
}
