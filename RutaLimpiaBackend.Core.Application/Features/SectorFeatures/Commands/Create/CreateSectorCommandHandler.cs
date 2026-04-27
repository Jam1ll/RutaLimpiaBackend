using MapsterMapper;
using RutaLimpiaBackend.Core.Application.Features.Common.CommonCommands;
using RutaLimpiaBackend.Core.Application.Interfaces;
using RutaLimpiaBackend.Core.Domain.Entities;

namespace RutaLimpiaBackend.Core.Application.Features.SectorFeatures.Commands.Create
{
    public class CreateSectorCommandHandler : CreateGenericCommandHandler<CreateSectorCommand, Sector>
    {
        public CreateSectorCommandHandler(IRepositoryAsync<Sector> repositoryAsync, IMapper mapper) : base(repositoryAsync, mapper)
        {
        }
    }
}
