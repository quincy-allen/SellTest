namespace Sell.Domain.Models
{
    public class UserDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsActive { get; set; }
        public int ApplicationUserRoleId { get; set; }
        public int ApplicationUserSalaryId { get; set; }
        public int ApplicationtionUserAddressId { get; set; }
    }
}
