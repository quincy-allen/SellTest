using Sell.Infrastructure.Database.Entities;

namespace Sell.Infrastructure.Database.Repositories.Interfaces
{
    public interface IUserRoleRepository
    {
        Task<IEnumerable<ApplicationUserRole>> GetAllUserRolesAsync();
        void CreateUserRole(ApplicationUserRole userRole);
    }
}
