using Ardalis.Specification;
using RutaLimpiaBackend.Core.Domain.Entities;

namespace RutaLimpiaBackend.Core.Application.Specifications.CollectionScheduleSpecifications
{
    public class CollectionScheduleByIdSpecification : Specification<CollectionSchedule, ISingleResultSpecification<CollectionSchedule>>
    {
        public CollectionScheduleByIdSpecification(Guid id)
        {
            Query.Where(x => x.Id == id);
        }
    }
}