using Microsoft.Extensions.DependencyInjection;
using UPDCFacilityManager.Modules.Cluster.Core.Repositories;
using UPDCFacilityManager.Modules.Cluster.Core.Services;

namespace UPDCFacilityManager.Modules.Residence.Core
{
    public static class Extensions
    {
        public static void AddClusterConfiguration(this IServiceCollection services)
        { 

            services.AddScoped<IClusterRepository, ClusterRepository>();
            services.AddScoped<IClusterService, ClusterService>();
        }
    }
}
