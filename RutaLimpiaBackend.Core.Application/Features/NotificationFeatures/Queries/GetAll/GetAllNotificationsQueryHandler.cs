using Ardalis.Specification;
using MapsterMapper;
using RutaLimpiaBackend.Core.Application.DTOs;
using RutaLimpiaBackend.Core.Application.Features.Common.CommonQueries;
using RutaLimpiaBackend.Core.Application.Interfaces;
using RutaLimpiaBackend.Core.Application.Specifications.NotificationSpecifications;
using RutaLimpiaBackend.Core.Domain.Entities;

namespace RutaLimpiaBackend.Core.Application.Features.NotificationFeatures.Queries.GetAll
{
    public class GetAllNotificationsQueryHandler : GetAllGenericQueryHandler<GetAllNotificationsQuery, Notification, NotificationResponseDTO>
    {
        public GetAllNotificationsQueryHandler(IReadRepositoryAsync<Notification> repositoryAsync, IMapper mapper) : base(repositoryAsync, mapper)
        {
        }

        protected override int GetPageNumber(GetAllNotificationsQuery request) => request.PageNumber;
        protected override int GetPageSize(GetAllNotificationsQuery request) => request.PageSize;

        protected override ISpecification<Notification> CreateCountSpecification(GetAllNotificationsQuery request)
        {
            return new NotificationSpecification(-1, -1);
        }

        protected override ISpecification<Notification> CreatePagedSpecification(GetAllNotificationsQuery request)
        {
            return new NotificationSpecification(request.PageSize, request.PageNumber);
        }
    }
}