using MapsterMapper;
using RutaLimpiaBackend.Core.Application.Features.Common.CommonCommands;
using RutaLimpiaBackend.Core.Application.Interfaces;
using RutaLimpiaBackend.Core.Domain.Entities;

namespace RutaLimpiaBackend.Core.Application.Features.TruckFeatures.Commands.Create
{
    public class CreateTruckCommandHandler : CreateGenericCommandHandler<CreateTruckCommand, Truck>
    {
        public CreateTruckCommandHandler(IRepositoryAsync<Truck> repositoryAsync, IMapper mapper) : base(repositoryAsync, mapper)
        {
        }
    }
}