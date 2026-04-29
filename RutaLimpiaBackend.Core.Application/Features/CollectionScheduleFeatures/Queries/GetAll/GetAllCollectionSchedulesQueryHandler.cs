using Ardalis.Specification;
using MapsterMapper;
using RutaLimpiaBackend.Core.Application.DTOs;
using RutaLimpiaBackend.Core.Application.Features.Common.CommonQueries;
using RutaLimpiaBackend.Core.Application.Interfaces;
using RutaLimpiaBackend.Core.Application.Specifications.CollectionScheduleSpecifications;
using RutaLimpiaBackend.Core.Domain.Entities;

namespace RutaLimpiaBackend.Core.Application.Features.CollectionScheduleFeatures.Queries.GetAll
{
    public class GetAllCollectionSchedulesQueryHandler : GetAllGenericQueryHandler<GetAllCollectionSchedulesQuery, CollectionSchedule, CollectionScheduleResponseDTO>
    {
        public GetAllCollectionSchedulesQueryHandler(IReadRepositoryAsync<CollectionSchedule> repositoryAsync, IMapper mapper) : base(repositoryAsync, mapper)
        {
        }

        protected override int GetPageNumber(GetAllCollectionSchedulesQuery request) => request.PageNumber;
        protected override int GetPageSize(GetAllCollectionSchedulesQuery request) => request.PageSize;

        protected override ISpecification<CollectionSchedule> CreateCountSpecification(GetAllCollectionSchedulesQuery request)
        {
            return new CollectionScheduleSpecification(-1, -1);
        }

        protected override ISpecification<CollectionSchedule> CreatePagedSpecification(GetAllCollectionSchedulesQuery request)
        {
            return new CollectionScheduleSpecification(request.PageSize, request.PageNumber);
        }
    }
}