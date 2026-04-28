using Ardalis.Specification;
using MapsterMapper;
using RutaLimpiaBackend.Core.Application.DTOs;
using RutaLimpiaBackend.Core.Application.Features.Common.CommonQueries;
using RutaLimpiaBackend.Core.Application.Interfaces;
using RutaLimpiaBackend.Core.Application.Specifications.CleaningDaySpecifications;
using RutaLimpiaBackend.Core.Domain.Entities;

namespace RutaLimpiaBackend.Core.Application.Features.CleaningDayFeatures.Queries.GetAll
{
    public class GetAllCleaningDaysQueryHandler : GetAllGenericQueryHandler<GetAllCleaningDaysQuery, CleaningDay, CleaningDayResponseDTO>
    {
        public GetAllCleaningDaysQueryHandler(IReadRepositoryAsync<CleaningDay> repositoryAsync, IMapper mapper) : base(repositoryAsync, mapper)
        {
        }

        protected override int GetPageNumber(GetAllCleaningDaysQuery request) => request.PageNumber;
        protected override int GetPageSize(GetAllCleaningDaysQuery request) => request.PageSize;

        protected override ISpecification<CleaningDay> CreateCountSpecification(GetAllCleaningDaysQuery request)
        {
            return new CleaningDaySpecification(-1, -1);
        }

        protected override ISpecification<CleaningDay> CreatePagedSpecification(GetAllCleaningDaysQuery request)
        {
            return new CleaningDaySpecification(request.PageSize, request.PageNumber);
        }
    }
}