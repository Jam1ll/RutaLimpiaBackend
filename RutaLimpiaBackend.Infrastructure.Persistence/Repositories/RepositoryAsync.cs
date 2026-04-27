using Ardalis.Specification.EntityFrameworkCore;
using RutaLimpiaBackend.Core.Application.Interfaces;
using RutaLimpiaBackend.Infrastructure.Persistence.Contexts;

namespace RutaLimpiaBackend.Infrastructure.Persistence.Repositories
{
    public class RepositoryAsync<T> : RepositoryBase<T>, IRepositoryAsync<T> where T : class
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public RepositoryAsync(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
    }
}
