using Sell.Infrastructure.Database.Entities;

namespace Sell.Infrastructure.Database.Repositories.Interfaces
{
    public interface IUserSalaryRepository
    {
        Task<IEnumerable<ApplicationUserSalary>> GetAllUserSalariesAsync();
        void CreateUserSalary(ApplicationUserSalary userSalary);
    }
}
