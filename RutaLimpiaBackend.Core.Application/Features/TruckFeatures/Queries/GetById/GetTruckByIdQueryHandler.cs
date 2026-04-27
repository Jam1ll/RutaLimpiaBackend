using Ardalis.Specification;
using MapsterMapper;
using RutaLimpiaBackend.Core.Application.DTOs;
using RutaLimpiaBackend.Core.Application.Features.Common.CommonQueries;
using RutaLimpiaBackend.Core.Application.Interfaces;
using RutaLimpiaBackend.Core.Application.Specifications.TruckSpecification;
using RutaLimpiaBackend.Core.Domain.Entities;

namespace RutaLimpiaBackend.Core.Application.Features.TruckFeatures.Queries.GetById
{
    public class GetTruckByIdQueryHandler : GetByIdGenericQueryHandler<GetTruckByIdQuery, Truck, TruckResponseDTO>
    {
        public GetTruckByIdQueryHandler(IReadRepositoryAsync<Truck> repositoryAsync, IMapper mapper) : base(repositoryAsync, mapper)
        {
        }

        protected override Guid GetEntityId(GetTruckByIdQuery request) => request.Id;

        protected override ISpecification<Truck> CreateSpecification(GetTruckByIdQuery request)
        {
            return new TruckByIdSpecification(request.Id);
        }
    }
}