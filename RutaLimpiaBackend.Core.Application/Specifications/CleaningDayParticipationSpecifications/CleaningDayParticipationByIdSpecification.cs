using Ardalis.Specification;
using RutaLimpiaBackend.Core.Domain.Entities;

namespace RutaLimpiaBackend.Core.Application.Specifications.CleaningDayParticipationSpecifications
{
    public class CleaningDayParticipationByIdSpecification : Specification<CleaningDayParticipation, ISingleResultSpecification<CleaningDayParticipation>>
    {
        public CleaningDayParticipationByIdSpecification(Guid id)
        {
            Query.Where(x => x.Id == id);
        }
    }
}