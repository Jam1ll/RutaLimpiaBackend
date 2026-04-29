using Ardalis.Specification;
using MapsterMapper;
using RutaLimpiaBackend.Core.Application.DTOs;
using RutaLimpiaBackend.Core.Application.Features.Common.CommonQueries;
using RutaLimpiaBackend.Core.Application.Interfaces;
using RutaLimpiaBackend.Core.Application.Specifications.CleaningDaySpecification;
using RutaLimpiaBackend.Core.Domain.Entities;

namespace RutaLimpiaBackend.Core.Application.Features.CleaningDayFeatures.Queries.GetById
{
    public class GetCleaningDayByIdQueryHandler : GetByIdGenericQueryHandler<GetCleaningDayByIdQuery, CleaningDay, CleaningDayResponseDTO>
    {
        public GetCleaningDayByIdQueryHandler(IReadRepositoryAsync<CleaningDay> repositoryAsync, IMapper mapper) : base(repositoryAsync, mapper)
        {
        }

        protected override Guid GetEntityId(GetCleaningDayByIdQuery request) => request.Id;

        protected override ISpecification<CleaningDay> CreateSpecification(GetCleaningDayByIdQuery request)
        {
            return new CleaningDayByIdSpecification(request.Id);
        }
    }
}