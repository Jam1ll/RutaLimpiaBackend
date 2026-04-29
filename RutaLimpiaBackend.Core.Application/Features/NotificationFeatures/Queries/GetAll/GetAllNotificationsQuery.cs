using MediatR;
using RutaLimpiaBackend.Core.Application.DTOs;
using RutaLimpiaBackend.Core.Application.Wrappers;

namespace RutaLimpiaBackend.Core.Application.Features.NotificationFeatures.Queries.GetAll
{
    public class GetAllNotificationsQuery : IRequest<PagedResponse<List<NotificationResponseDTO>>>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
    }
}