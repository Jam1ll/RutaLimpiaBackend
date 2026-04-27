using RutaLimpiaBackend.Core.Application.Features.Common.CommonCommands;
using RutaLimpiaBackend.Core.Application.Interfaces;
using RutaLimpiaBackend.Core.Domain.Entities;

namespace RutaLimpiaBackend.Core.Application.Features.SectorFeatures.Commands.Delete
{
    public class DeleteSectorCommandHandler : DeleteGenericCommandHandler<DeleteSectorCommand, Sector>
    {
        public DeleteSectorCommandHandler(IRepositoryAsync<Sector> repositoryAsync) : base(repositoryAsync)
        {
        }
    }
}
