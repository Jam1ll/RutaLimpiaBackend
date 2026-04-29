using MapsterMapper;
using RutaLimpiaBackend.Core.Application.Features.Common.CommonCommands;
using RutaLimpiaBackend.Core.Application.Interfaces;
using RutaLimpiaBackend.Core.Domain.Entities;

namespace RutaLimpiaBackend.Core.Application.Features.CleaningDayParticipationFeatures.Commands.Create
{
    public class CreateCleaningDayParticipationCommandHandler : CreateGenericCommandHandler<CreateCleaningDayParticipationCommand, CleaningDayParticipation>
    {
        public CreateCleaningDayParticipationCommandHandler(IRepositoryAsync<CleaningDayParticipation> repositoryAsync, IMapper mapper) : base(repositoryAsync, mapper)
        {
        }
    }
}