using MapsterMapper;
using RutaLimpiaBackend.Core.Application.Features.Common.CommonCommands;
using RutaLimpiaBackend.Core.Application.Interfaces;
using RutaLimpiaBackend.Core.Domain.Entities;

namespace RutaLimpiaBackend.Core.Application.Features.CleaningDayParticipationFeatures.Commands.Update
{
    internal class UpdateCleaningDayParticipationCommandHandler : UpdateGenericCommandHandler<UpdateCleaningDayParticipationCommand, CleaningDayParticipation>
    {
        public UpdateCleaningDayParticipationCommandHandler(IRepositoryAsync<CleaningDayParticipation> repositoryAsync, IMapper mapper) : base(repositoryAsync, mapper)
        {
        }
    }
}