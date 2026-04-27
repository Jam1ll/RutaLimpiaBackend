using Ardalis.Specification;
using RutaLimpiaBackend.Core.Domain.Entities;

namespace RutaLimpiaBackend.Core.Application.Specifications.SectorSpecifications
{
    public class SectorByIdSpecification : Specification<Sector, ISingleResultSpecification<Sector>>
    {
        public SectorByIdSpecification(Guid id)
        {
            Query.Where(x => x.Id == id);
        }
    }
}
