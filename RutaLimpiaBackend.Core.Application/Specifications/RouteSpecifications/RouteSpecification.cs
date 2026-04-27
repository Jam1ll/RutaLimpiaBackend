using RutaLimpiaBackend.Core.Domain.Entities;

namespace RutaLimpiaBackend.Core.Application.Specifications.RouteSpecification
{
    public class RouteSpecification : PagedGeneralSpecification<Route>
    {
        public RouteSpecification(int pageSize, int pageNumber) : base(pageSize, pageNumber)
        {
        }
    }
}