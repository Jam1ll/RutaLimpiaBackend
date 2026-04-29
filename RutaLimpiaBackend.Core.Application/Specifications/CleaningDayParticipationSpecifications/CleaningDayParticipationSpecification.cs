using RutaLimpiaBackend.Core.Domain.Entities;

namespace RutaLimpiaBackend.Core.Application.Specifications.CleaningDayParticipationSpecifications
{
    public class CleaningDayParticipationSpecification : PagedGeneralSpecification<CleaningDayParticipation>
    {
        public CleaningDayParticipationSpecification(int pageSize, int pageNumber) : base(pageSize, pageNumber)
        {
        }
    }
}