using Ardalis.Specification;
using RutaLimpiaBackend.Core.Domain.Entities;

namespace RutaLimpiaBackend.Core.Application.Specifications.RouteSpecification
{
    public class RouteByIdSpecification : Specification<Route, ISingleResultSpecification<Route>>
    {
        public RouteByIdSpecification(Guid id)
        {
            Query.Where(x => x.Id == id);
        }
    }
}