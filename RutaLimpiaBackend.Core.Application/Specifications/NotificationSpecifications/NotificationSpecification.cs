using RutaLimpiaBackend.Core.Domain.Entities;

namespace RutaLimpiaBackend.Core.Application.Specifications.NotificationSpecifications
{
    public class NotificationSpecification : PagedGeneralSpecification<Notification>
    {
        public NotificationSpecification(int pageSize, int pageNumber) : base(pageSize, pageNumber)
        {
        }
    }
}