using Microsoft.EntityFrameworkCore;
using Sell.Infrastructure.Database.Entities;

namespace Sell.Infrastructure.Database.Context
{
    public class SellDbContext : DbContext
    {
        public SellDbContext(DbContextOptions<SellDbContext> options) : base(options)
        {

        }
        public virtual DbSet<ApplicationUser> ApplicationUser { get; set; }
        public virtual DbSet<ApplicationUserAddress> ApplicationUserAddress { get; set; }
        public virtual DbSet<ApplicationUserRole> ApplicationUserRole { get; set; }
        public virtual DbSet<ApplicationUserSalary> ApplicationUserSalary { get; set; }
    }
}
