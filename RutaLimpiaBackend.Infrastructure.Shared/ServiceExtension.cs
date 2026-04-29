using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RutaLimpiaBackend.Core.Application.Interfaces;
using RutaLimpiaBackend.Infrastructure.Shared.Services;

namespace RutaLimpiaBackend.Infrastructure.Shared
{
    public static class ServiceExtension
    {
        public static void AddSharedInfrastructure(this IServiceCollection services, IConfiguration config)
        {
            services.AddTransient<IDateTimeService, DateTimeService>();
        }
    }
}
