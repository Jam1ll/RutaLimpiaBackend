using MapsterMapper;
using RutaLimpiaBackend.Core.Application.Features.Common.CommonCommands;
using RutaLimpiaBackend.Core.Application.Interfaces;
using RutaLimpiaBackend.Core.Domain.Entities;

namespace RutaLimpiaBackend.Core.Application.Features.SectorFeatures.Commands.Update
{
    internal class UpdateSectorCommandHandler : UpdateGenericCommandHandler<UpdateSectorCommand, Sector>
    {
        public UpdateSectorCommandHandler(IRepositoryAsync<Sector> repositoryAsync, IMapper mapper) : base(repositoryAsync, mapper)
        {
        }
    }
}
