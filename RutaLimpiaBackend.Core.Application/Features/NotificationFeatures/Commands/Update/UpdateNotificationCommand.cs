using RutaLimpiaBackend.Core.Application.Interfaces.CommonHandlers;
using RutaLimpiaBackend.Core.Domain.Entities.Enums;

namespace RutaLimpiaBackend.Core.Application.Features.NotificationFeatures.Commands.Update
{
    public class UpdateNotificationCommand : IUpdateRequest
    {
        public Guid Id { get; set; }
        public required string Title { get; set; }
        public required string Message { get; set; }
        public required NotificationType NotificationType { get; set; }
        public bool IsRead { get; set; }
    }
}