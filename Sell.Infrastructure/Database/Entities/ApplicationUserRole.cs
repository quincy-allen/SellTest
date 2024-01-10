namespace Sell.Infrastructure.Database.Entities
{
    public class ApplicationUserRole : BaseEntity
    {
        public string RoleName { get; set; }
        public bool IsActive { get; set; }
    }
}
