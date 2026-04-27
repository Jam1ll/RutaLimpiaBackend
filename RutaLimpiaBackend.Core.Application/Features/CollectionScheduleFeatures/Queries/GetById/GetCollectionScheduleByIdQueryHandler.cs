using Ardalis.Specification;
using MapsterMapper;
using RutaLimpiaBackend.Core.Application.DTOs;
using RutaLimpiaBackend.Core.Application.Features.Common.CommonQueries;
using RutaLimpiaBackend.Core.Application.Interfaces;
using RutaLimpiaBackend.Core.Application.Specifications.CollectionScheduleSpecifications;
using RutaLimpiaBackend.Core.Domain.Entities;

namespace RutaLimpiaBackend.Core.Application.Features.CollectionScheduleFeatures.Queries.GetById
{
    public class GetCollectionScheduleByIdQueryHandler : GetByIdGenericQueryHandler<GetCollectionScheduleByIdQuery, CollectionSchedule, CollectionScheduleResponseDTO>
    {
        public GetCollectionScheduleByIdQueryHandler(IReadRepositoryAsync<CollectionSchedule> repositoryAsync, IMapper mapper) : base(repositoryAsync, mapper)
        {
        }

        protected override Guid GetEntityId(GetCollectionScheduleByIdQuery request) => request.Id;

        protected override ISpecification<CollectionSchedule> CreateSpecification(GetCollectionScheduleByIdQuery request)
        {
            return new CollectionScheduleByIdSpecification(request.Id);
        }
    }
}