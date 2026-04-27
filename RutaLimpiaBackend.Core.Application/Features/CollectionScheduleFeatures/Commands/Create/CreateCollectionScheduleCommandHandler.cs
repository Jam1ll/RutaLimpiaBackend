using MapsterMapper;
using RutaLimpiaBackend.Core.Application.Features.Common.CommonCommands;
using RutaLimpiaBackend.Core.Application.Interfaces;
using RutaLimpiaBackend.Core.Domain.Entities;

namespace RutaLimpiaBackend.Core.Application.Features.CollectionScheduleFeatures.Commands.Create
{
    public class CreateCollectionScheduleCommandHandler : CreateGenericCommandHandler<CreateCollectionScheduleCommand, CollectionSchedule>
    {
        public CreateCollectionScheduleCommandHandler(IRepositoryAsync<CollectionSchedule> repositoryAsync, IMapper mapper) : base(repositoryAsync, mapper)
        {
        }
    }
}