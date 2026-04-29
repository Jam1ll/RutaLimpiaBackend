using Ardalis.Specification;
using MapsterMapper;
using RutaLimpiaBackend.Core.Application.DTOs;
using RutaLimpiaBackend.Core.Application.Features.Common.CommonQueries;
using RutaLimpiaBackend.Core.Application.Interfaces;
using RutaLimpiaBackend.Core.Application.Specifications.CleaningDayParticipationSpecifications;
using RutaLimpiaBackend.Core.Domain.Entities;

namespace RutaLimpiaBackend.Core.Application.Features.CleaningDayParticipationFeatures.Queries.GetById
{
    public class GetCleaningDayParticipationByIdQueryHandler : GetByIdGenericQueryHandler<GetCleaningDayParticipationByIdQuery, CleaningDayParticipation, CleaningDayParticipationResponseDTO>
    {
        public GetCleaningDayParticipationByIdQueryHandler(IReadRepositoryAsync<CleaningDayParticipation> repositoryAsync, IMapper mapper) : base(repositoryAsync, mapper)
        {
        }

        protected override Guid GetEntityId(GetCleaningDayParticipationByIdQuery request) => request.Id;

        protected override ISpecification<CleaningDayParticipation> CreateSpecification(GetCleaningDayParticipationByIdQuery request)
        {
            return new CleaningDayParticipationByIdSpecification(request.Id);
        }
    }
}