using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Sell.Domain.Implementation.Mapper;
using Sell.Domain.Implementation.User;
using Sell.Domain.Interfaces.User;
using Sell.Infrastructure.Database.Context;
using Sell.Infrastructure.Database.Repositories.Implementations;
using Sell.Infrastructure.Database.Repositories.Interfaces;

namespace Sell.Domain.Implementation.Extensions
{
    public static class ServiceExtension
    {
        public static IServiceCollection InjectDomainDependencies(this IServiceCollection services,
            IConfiguration Configuration)
        {
            //Inject Infrastructures service
            services.AddDbContext<SellDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("Default")));
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddAutoMapper(typeof(AutoMapperProfile));

            return services;
        }
    }
}
