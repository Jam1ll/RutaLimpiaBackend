using Ardalis.Specification;

namespace RutaLimpiaBackend.Core.Application.Interfaces
{
    public interface IReadRepositoryAsync<T> : IReadRepositoryBase<T> where T : class
    {
    }
}
