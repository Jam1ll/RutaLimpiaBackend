using Ardalis.Specification;
using RutaLimpiaBackend.Core.Domain.Entities;

namespace RutaLimpiaBackend.Core.Application.Specifications.TruckSpecification
{
    public class TruckByIdSpecification : Specification<Truck, ISingleResultSpecification<Truck>>
    {
        public TruckByIdSpecification(Guid id)
        {
            Query.Where(x => x.Id == id);
        }
    }
}