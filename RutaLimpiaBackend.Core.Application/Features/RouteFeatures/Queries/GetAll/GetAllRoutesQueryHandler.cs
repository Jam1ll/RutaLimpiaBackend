using Ardalis.Specification;
using MapsterMapper;
using RutaLimpiaBackend.Core.Application.DTOs;
using RutaLimpiaBackend.Core.Application.Features.Common.CommonQueries;
using RutaLimpiaBackend.Core.Application.Interfaces;
using RutaLimpiaBackend.Core.Application.Specifications.RouteSpecification;
using RutaLimpiaBackend.Core.Domain.Entities;

namespace RutaLimpiaBackend.Core.Application.Features.RouteFeatures.Queries.GetAll
{
    public class GetAllRoutesQueryHandler : GetAllGenericQueryHandler<GetAllRoutesQuery, Route, RouteResponseDTO>
    {
        public GetAllRoutesQueryHandler(IReadRepositoryAsync<Route> repositoryAsync, IMapper mapper) : base(repositoryAsync, mapper)
        {
        }

        protected override int GetPageNumber(GetAllRoutesQuery request) => request.PageNumber;
        protected override int GetPageSize(GetAllRoutesQuery request) => request.PageSize;

        protected override ISpecification<Route> CreateCountSpecification(GetAllRoutesQuery request)
        {
            return new RouteSpecification(-1, -1);
        }

        protected override ISpecification<Route> CreatePagedSpecification(GetAllRoutesQuery request)
        {
            return new RouteSpecification(request.PageSize, request.PageNumber);
        }
    }
}