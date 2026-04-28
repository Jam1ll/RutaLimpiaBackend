using MediatR;
using RutaLimpiaBackend.Core.Application.Wrappers;
using RutaLimpiaBackend.Core.Domain.Entities.Enums;

namespace RutaLimpiaBackend.Core.Application.Features.NotificationFeatures.Commands.Create
{
    public class CreateNotificationCommand : IRequest<Response<Guid>>
    {
        public required string Title { get; set; }
        public required string Message { get; set; }
        public required NotificationType NotificationType { get; set; }
        public bool IsRead { get; set; }
    }
}