using Ardalis.Specification;
using MapsterMapper;
using RutaLimpiaBackend.Core.Application.DTOs;
using RutaLimpiaBackend.Core.Application.Features.Common.CommonQueries;
using RutaLimpiaBackend.Core.Application.Interfaces;
using RutaLimpiaBackend.Core.Application.Specifications.CleaningDayParticipationSpecifications;
using RutaLimpiaBackend.Core.Domain.Entities;

namespace RutaLimpiaBackend.Core.Application.Features.CleaningDayParticipationFeatures.Queries.GetAll
{
    public class GetAllCleaningDayParticipationsQueryHandler : GetAllGenericQueryHandler<GetAllCleaningDayParticipationsQuery, CleaningDayParticipation, CleaningDayParticipationResponseDTO>
    {
        public GetAllCleaningDayParticipationsQueryHandler(IReadRepositoryAsync<CleaningDayParticipation> repositoryAsync, IMapper mapper) : base(repositoryAsync, mapper)
        {
        }

        protected override int GetPageNumber(GetAllCleaningDayParticipationsQuery request) => request.PageNumber;
        protected override int GetPageSize(GetAllCleaningDayParticipationsQuery request) => request.PageSize;

        protected override ISpecification<CleaningDayParticipation> CreateCountSpecification(GetAllCleaningDayParticipationsQuery request)
        {
            return new CleaningDayParticipationSpecification(-1, -1);
        }

        protected override ISpecification<CleaningDayParticipation> CreatePagedSpecification(GetAllCleaningDayParticipationsQuery request)
        {
            return new CleaningDayParticipationSpecification(request.PageSize, request.PageNumber);
        }
    }
}