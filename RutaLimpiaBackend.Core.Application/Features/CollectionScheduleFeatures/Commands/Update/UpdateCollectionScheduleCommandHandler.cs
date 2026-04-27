using MapsterMapper;
using RutaLimpiaBackend.Core.Application.Features.Common.CommonCommands;
using RutaLimpiaBackend.Core.Application.Interfaces;
using RutaLimpiaBackend.Core.Domain.Entities;

namespace RutaLimpiaBackend.Core.Application.Features.CollectionScheduleFeatures.Commands.Update
{
    internal class UpdateCollectionScheduleCommandHandler : UpdateGenericCommandHandler<UpdateCollectionScheduleCommand, CollectionSchedule>
    {
        public UpdateCollectionScheduleCommandHandler(IRepositoryAsync<CollectionSchedule> repositoryAsync, IMapper mapper) : base(repositoryAsync, mapper)
        {
        }
    }
}