using Microsoft.Extensions.DependencyInjection;
using UPDCFacilityManager.Modules.Estates.Services;

namespace UPDCFacilityManager.Modules.Estates.Core
{
    public static class Extensions
    {
        public static void AddEstateConfiguration(this IServiceCollection services)
        { 

            services.AddScoped<IEstateService, EstateService>();
        }
    }
}
