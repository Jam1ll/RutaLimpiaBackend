using RutaLimpiaBackend.Core.Domain.Entities;

namespace RutaLimpiaBackend.Core.Application.Specifications.CollectionScheduleSpecifications
{
    public class CollectionScheduleSpecification : PagedGeneralSpecification<CollectionSchedule>
    {
        public CollectionScheduleSpecification(int pageSize, int pageNumber) : base(pageSize, pageNumber)
        {
        }
    }
}