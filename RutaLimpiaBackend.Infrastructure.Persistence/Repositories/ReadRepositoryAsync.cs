using Ardalis.Specification.EntityFrameworkCore;
using RutaLimpiaBackend.Core.Application.Interfaces;
using RutaLimpiaBackend.Infrastructure.Persistence.Contexts;

namespace RutaLimpiaBackend.Infrastructure.Persistence.Repositories
{
    public class ReadRepositoryAsync<T> : RepositoryBase<T>, IReadRepositoryAsync<T> where T : class
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public ReadRepositoryAsync(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
    }
}
