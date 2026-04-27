using MapsterMapper;
using RutaLimpiaBackend.Core.Application.Features.Common.CommonCommands;
using RutaLimpiaBackend.Core.Application.Interfaces;
using RutaLimpiaBackend.Core.Domain.Entities;

namespace RutaLimpiaBackend.Core.Application.Features.TruckFeatures.Commands.Update
{
    internal class UpdateTruckCommandHandler : UpdateGenericCommandHandler<UpdateTruckCommand, Truck>
    {
        public UpdateTruckCommandHandler(IRepositoryAsync<Truck> repositoryAsync, IMapper mapper) : base(repositoryAsync, mapper)
        {
        }
    }
}