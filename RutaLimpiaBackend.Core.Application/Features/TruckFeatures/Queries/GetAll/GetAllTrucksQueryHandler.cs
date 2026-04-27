using Ardalis.Specification;
using MapsterMapper;
using RutaLimpiaBackend.Core.Application.DTOs;
using RutaLimpiaBackend.Core.Application.Features.Common.CommonQueries;
using RutaLimpiaBackend.Core.Application.Interfaces;
using RutaLimpiaBackend.Core.Application.Specifications.TruckSpecifications;
using RutaLimpiaBackend.Core.Domain.Entities;

namespace RutaLimpiaBackend.Core.Application.Features.TruckFeatures.Queries.GetAll
{
    public class GetAllTrucksQueryHandler : GetAllGenericQueryHandler<GetAllTrucksQuery, Truck, TruckResponseDTO>
    {
        public GetAllTrucksQueryHandler(IReadRepositoryAsync<Truck> repositoryAsync, IMapper mapper) : base(repositoryAsync, mapper)
        {
        }

        protected override int GetPageNumber(GetAllTrucksQuery request) => request.PageNumber;
        protected override int GetPageSize(GetAllTrucksQuery request) => request.PageSize;

        protected override ISpecification<Truck> CreateCountSpecification(GetAllTrucksQuery request)
        {
            return new TruckSpecification(-1, -1);
        }

        protected override ISpecification<Truck> CreatePagedSpecification(GetAllTrucksQuery request)
        {
            return new TruckSpecification(request.PageSize, request.PageNumber);
        }
    }
}