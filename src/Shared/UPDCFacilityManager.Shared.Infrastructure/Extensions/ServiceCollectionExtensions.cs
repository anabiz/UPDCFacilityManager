using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPDCFacilityManager.Shared.Infrastructure
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddResidenceModule(this IServiceCollection services, IConfiguration config)
        {
            return RegisterController(services);
        }

        public static IServiceCollection AddAuthModule(this IServiceCollection services, IConfiguration config)
        {
            return RegisterController(services);
        }

        public static IServiceCollection AddReportModule(this IServiceCollection services, IConfiguration config)
        {
            return RegisterController(services);
        }

        private static IServiceCollection RegisterController(IServiceCollection services)
        {
            services.AddControllersWithViews()
                            .ConfigureApplicationPartManager(manager =>
                            {
                                manager.FeatureProviders.Add(new InternalControllerFeatureProvider());
                            });
            return services;
        }
    }
}
