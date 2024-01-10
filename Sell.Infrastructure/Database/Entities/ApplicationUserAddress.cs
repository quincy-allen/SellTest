namespace Sell.Infrastructure.Database.Entities
{
    public class ApplicationUserAddress : BaseEntity
    {
        public string Address { get; set; }
        public bool IsCurrentAddress { get; set; }
        public virtual ICollection<ApplicationUser> ApplicationUsers { get; set; }
    }
}
