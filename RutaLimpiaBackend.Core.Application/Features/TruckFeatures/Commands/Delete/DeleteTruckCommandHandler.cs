using RutaLimpiaBackend.Core.Application.Features.Common.CommonCommands;
using RutaLimpiaBackend.Core.Application.Interfaces;
using RutaLimpiaBackend.Core.Domain.Entities;

namespace RutaLimpiaBackend.Core.Application.Features.TruckFeatures.Commands.Delete
{
    public class DeleteTruckCommandHandler : DeleteGenericCommandHandler<DeleteTruckCommand, Truck>
    {
        public DeleteTruckCommandHandler(IRepositoryAsync<Truck> repositoryAsync) : base(repositoryAsync)
        {
        }
    }
}