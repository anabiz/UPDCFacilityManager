using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using UPDCFacilityManager.Modules.Auth.Core.Data;
using UPDCFacilityManager.Modules.Auth.Core.Entities;
using UPDCFacilityManager.Modules.Auth.Core.Repositories;
using UPDCFacilityManager.Modules.Auth.Core.Services;
using UPDCFacilityManager.Modules.Residence.Core.Repositories;

namespace UPDCFacilityManager.Modules.Residence.Core
{
    public static class Extensions
    {
        public static void AddResidentConfiguration(this IServiceCollection services)
        { 

            services.AddScoped<IResidentRepository, ResidentRepository>();
            services.AddScoped<IResidentService, ResidentService>();
        }
    }
}
