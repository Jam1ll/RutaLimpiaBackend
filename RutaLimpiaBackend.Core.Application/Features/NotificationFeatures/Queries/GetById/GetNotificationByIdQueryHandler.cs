using Ardalis.Specification;
using MapsterMapper;
using RutaLimpiaBackend.Core.Application.DTOs;
using RutaLimpiaBackend.Core.Application.Features.Common.CommonQueries;
using RutaLimpiaBackend.Core.Application.Interfaces;
using RutaLimpiaBackend.Core.Application.Specifications.NotificationSpecifications;
using RutaLimpiaBackend.Core.Domain.Entities;

namespace RutaLimpiaBackend.Core.Application.Features.NotificationFeatures.Queries.GetById
{
    public class GetNotificationByIdQueryHandler : GetByIdGenericQueryHandler<GetNotificationByIdQuery, Notification, NotificationResponseDTO>
    {
        public GetNotificationByIdQueryHandler(IReadRepositoryAsync<Notification> repositoryAsync, IMapper mapper) : base(repositoryAsync, mapper)
        {
        }

        protected override Guid GetEntityId(GetNotificationByIdQuery request) => request.Id;

        protected override ISpecification<Notification> CreateSpecification(GetNotificationByIdQuery request)
        {
            return new NotificationByIdSpecification(request.Id);
        }
    }
}