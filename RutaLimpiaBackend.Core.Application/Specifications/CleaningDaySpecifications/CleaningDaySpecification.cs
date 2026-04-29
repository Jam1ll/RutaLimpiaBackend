using RutaLimpiaBackend.Core.Domain.Entities;

namespace RutaLimpiaBackend.Core.Application.Specifications.CleaningDaySpecifications
{
    public class CleaningDaySpecification : PagedGeneralSpecification<CleaningDay>
    {
        public CleaningDaySpecification(int pageSize, int pageNumber) : base(pageSize, pageNumber)
        {
        }
    }
}