using RutaLimpiaBackend.Core.Application.Interfaces;
using RutaLimpiaBackend.Core.Application.Interfaces.CommonHandlers;

namespace RutaLimpiaBackend.Core.Application.Features.NotificationFeatures.Commands.Delete
{
    public class DeleteNotificationCommand : IGenericDeleteValidator, IDeleteRequest
    {
        public Guid Id { get; set; }
    }
}