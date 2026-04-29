using Ardalis.Specification;
using RutaLimpiaBackend.Core.Domain.Entities;

namespace RutaLimpiaBackend.Core.Application.Specifications.CleaningDaySpecification
{
    public class CleaningDayByIdSpecification : Specification<CleaningDay, ISingleResultSpecification<CleaningDay>>
    {
        public CleaningDayByIdSpecification(Guid id)
        {
            Query.Where(x => x.Id == id);
        }
    }
}