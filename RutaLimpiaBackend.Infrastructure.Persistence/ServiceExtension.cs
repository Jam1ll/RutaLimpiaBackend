using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RutaLimpiaBackend.Core.Application.Interfaces;
using RutaLimpiaBackend.Infrastructure.Persistence.Contexts;
using RutaLimpiaBackend.Infrastructure.Persistence.Repositories;
using RutaLimpiaBackend.Infrastructure.Services;

namespace RutaLimpiaBackend.Infrastructure.Persistence
{
    public static class ServiceExtension
    {
        public static void AddPersistenceInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            //configuracion de cadena de conexion a la bd
            services.AddDbContext<ApplicationDbContext>(opt => opt.UseSqlServer(
                configuration.GetConnectionString("DefaultConnection"),
                b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));

            #region repositories

            services.AddTransient(typeof(IRepositoryAsync<>), typeof(RepositoryAsync<>));
            services.AddTransient(typeof(IReadRepositoryAsync<>), typeof(ReadRepositoryAsync<>));

            #endregion

            #region Services

            services.AddTransient<IFileUploadService, LocalFileUploadService>();

            #endregion
        }
    }
}