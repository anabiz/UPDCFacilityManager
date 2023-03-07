
using Microsoft.Extensions.DependencyInjection;
using UPDCFacilityManager.Shared.Infrastructure.HttpDataService;

namespace UPDCFacilityManager.Shared.Infrastructure
{
    public static class Extensions
    {
        public static void AddSharedConfiguration(this IServiceCollection services)
        {
            services.AddHttpClient<IHttpUpdcDataClient, HttpUpdcDataClient>();
        }
    }
}
