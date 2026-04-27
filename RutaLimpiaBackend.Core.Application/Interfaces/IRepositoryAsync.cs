using Ardalis.Specification;

namespace RutaLimpiaBackend.Core.Application.Interfaces
{
    public interface IRepositoryAsync<T> : IRepositoryBase<T> where T : class
    {
    }
}
