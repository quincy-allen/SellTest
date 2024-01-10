using Sell.Infrastructure.Database.Enums;

namespace Sell.Infrastructure.Database.Entities
{
    public class ApplicationUserSalary : BaseEntity
    {
        public decimal Amount { get; set; }
        public SalaryType SalaryType { get; set; }
        public virtual ICollection<ApplicationUser> ApplicationUsers { get; set; }
    }
}
