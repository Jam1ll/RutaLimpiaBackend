using MediatR;
using RutaLimpiaBackend.Core.Application.DTOs;
using RutaLimpiaBackend.Core.Application.Wrappers;

namespace RutaLimpiaBackend.Core.Application.Features.NotificationFeatures.Queries.GetById
{
    public class GetNotificationByIdQuery : IRequest<Response<NotificationResponseDTO>>
    {
        public Guid Id { get; set; }
    }
}