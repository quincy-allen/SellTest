namespace Sell.Infrastructure.Database.Entities
{
    public class ApplicationUser : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsActive { get; set; }
        public int ApplicationUserRoleId { get; set; }
        public ApplicationUserRole ApplicationUserRole { get; set; }
        public int ApplicationUserSalaryId { get; set; }
        public ApplicationUserSalary ApplicationUserSalary { get; set; }
        public int ApplicationtionUserAddressId { get; set; }
        public ApplicationUserAddress ApplicationUserAddress { get; set; }

    }
}
