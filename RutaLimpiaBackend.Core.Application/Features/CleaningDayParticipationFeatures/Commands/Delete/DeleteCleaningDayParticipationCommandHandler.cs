using RutaLimpiaBackend.Core.Application.Features.Common.CommonCommands;
using RutaLimpiaBackend.Core.Application.Interfaces;
using RutaLimpiaBackend.Core.Domain.Entities;

namespace RutaLimpiaBackend.Core.Application.Features.CleaningDayParticipationFeatures.Commands.Delete
{
    public class DeleteCleaningDayParticipationCommandHandler : DeleteGenericCommandHandler<DeleteCleaningDayParticipationCommand, CleaningDayParticipation>
    {
        public DeleteCleaningDayParticipationCommandHandler(IRepositoryAsync<CleaningDayParticipation> repositoryAsync) : base(repositoryAsync)
        {
        }
    }
}