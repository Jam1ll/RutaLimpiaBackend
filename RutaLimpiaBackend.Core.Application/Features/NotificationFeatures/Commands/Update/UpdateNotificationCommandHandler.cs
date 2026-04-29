using MapsterMapper;
using RutaLimpiaBackend.Core.Application.Features.Common.CommonCommands;
using RutaLimpiaBackend.Core.Application.Interfaces;
using RutaLimpiaBackend.Core.Domain.Entities;

namespace RutaLimpiaBackend.Core.Application.Features.NotificationFeatures.Commands.Update
{
    internal class UpdateNotificationCommandHandler : UpdateGenericCommandHandler<UpdateNotificationCommand, Notification>
    {
        public UpdateNotificationCommandHandler(IRepositoryAsync<Notification> repositoryAsync, IMapper mapper) : base(repositoryAsync, mapper)
        {
        }
    }
}