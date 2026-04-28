using RutaLimpiaBackend.Core.Application.Features.Common.CommonCommands;
using RutaLimpiaBackend.Core.Application.Interfaces;
using RutaLimpiaBackend.Core.Domain.Entities;

namespace RutaLimpiaBackend.Core.Application.Features.NotificationFeatures.Commands.Delete
{
    public class DeleteNotificationCommandHandler : DeleteGenericCommandHandler<DeleteNotificationCommand, Notification>
    {
        public DeleteNotificationCommandHandler(IRepositoryAsync<Notification> repositoryAsync) : base(repositoryAsync)
        {
        }
    }
}