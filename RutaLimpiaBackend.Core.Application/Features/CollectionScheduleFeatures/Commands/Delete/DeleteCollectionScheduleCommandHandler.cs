using RutaLimpiaBackend.Core.Application.Features.Common.CommonCommands;
using RutaLimpiaBackend.Core.Application.Interfaces;
using RutaLimpiaBackend.Core.Domain.Entities;

namespace RutaLimpiaBackend.Core.Application.Features.CollectionScheduleFeatures.Commands.Delete
{
    public class DeleteCollectionScheduleCommandHandler : DeleteGenericCommandHandler<DeleteCollectionScheduleCommand, CollectionSchedule>
    {
        public DeleteCollectionScheduleCommandHandler(IRepositoryAsync<CollectionSchedule> repositoryAsync) : base(repositoryAsync)
        {
        }
    }
}