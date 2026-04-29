using Ardalis.Specification;
using MapsterMapper;
using RutaLimpiaBackend.Core.Application.DTOs;
using RutaLimpiaBackend.Core.Application.Features.Common.CommonQueries;
using RutaLimpiaBackend.Core.Application.Interfaces;
using RutaLimpiaBackend.Core.Application.Specifications.SectorSpecifications;
using RutaLimpiaBackend.Core.Domain.Entities;

namespace RutaLimpiaBackend.Core.Application.Features.SectorFeatures.Queries.GetById
{
    public class GetSectorByIdQueryHandler : GetByIdGenericQueryHandler<GetSectorByIdQuery, Sector, SectorResponseDTO>
    {
        public GetSectorByIdQueryHandler(IReadRepositoryAsync<Sector> repositoryAsync, IMapper mapper) : base(repositoryAsync, mapper)
        {
        }

        protected override Guid GetEntityId(GetSectorByIdQuery request) => request.Id;

        protected override ISpecification<Sector> CreateSpecification(GetSectorByIdQuery request)
        {
            return new SectorByIdSpecification(request.Id);
        }
    }
}