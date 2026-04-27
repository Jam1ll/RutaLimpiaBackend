using RutaLimpiaBackend.Core.Domain.Entities;

namespace RutaLimpiaBackend.Core.Application.Specifications.SectorSpecifications
{
    public class SectorSpecification : PagedGeneralSpecification<Sector>
    {
        public SectorSpecification(int pageSize, int pageNumber) : base(pageSize, pageNumber)
        {
        }
    }
}
