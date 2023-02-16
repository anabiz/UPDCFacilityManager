using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using UPDCFacilityManager.Modules.Auth.Core.Data;

namespace UPDCFacilityManager.Modules.Auth.Core
{
    internal static class Extensions
    {
        public static IServiceCollection AddCore(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<AppDbContext>(options =>
               options.UseSqlServer(config.GetConnectionString("MvcMovieContext") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.")));

            services.AddIdentity<IdentityUser, IdentityRole>()
                .AddEntityFrameworkStores<AppDbContext>();

            return services;
        }
    }
}
