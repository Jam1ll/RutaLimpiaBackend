using RutaLimpiaBackend.Core.Domain.Entities;

namespace RutaLimpiaBackend.Core.Application.Specifications.TruckSpecifications
{
    public class TruckSpecification : PagedGeneralSpecification<Truck>
    {
        public TruckSpecification(int pageSize, int pageNumber) : base(pageSize, pageNumber)
        {
        }
    }
}