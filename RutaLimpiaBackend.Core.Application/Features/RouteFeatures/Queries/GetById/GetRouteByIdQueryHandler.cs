using Ardalis.Specification;
using MapsterMapper;
using RutaLimpiaBackend.Core.Application.DTOs;
using RutaLimpiaBackend.Core.Application.Features.Common.CommonQueries;
using RutaLimpiaBackend.Core.Application.Interfaces;
using RutaLimpiaBackend.Core.Application.Specifications.RouteSpecification;
using RutaLimpiaBackend.Core.Domain.Entities;

namespace RutaLimpiaBackend.Core.Application.Features.RouteFeatures.Queries.GetById
{
    public class GetRouteByIdQueryHandler : GetByIdGenericQueryHandler<GetRouteByIdQuery, Route, RouteResponseDTO>
    {
        public GetRouteByIdQueryHandler(IReadRepositoryAsync<Route> repositoryAsync, IMapper mapper) : base(repositoryAsync, mapper)
        {
        }

        protected override Guid GetEntityId(GetRouteByIdQuery request) => request.Id;

        protected override ISpecification<Route> CreateSpecification(GetRouteByIdQuery request)
        {
            return new RouteByIdSpecification(request.Id);
        }
    }
}