using Ardalis.Specification;
using RutaLimpiaBackend.Core.Domain.Entities;

namespace RutaLimpiaBackend.Core.Application.Specifications.NotificationSpecifications
{
    public class NotificationByIdSpecification : Specification<Notification, ISingleResultSpecification<Notification>>
    {
        public NotificationByIdSpecification(Guid id)
        {
            Query.Where(x => x.Id == id);
        }
    }
}