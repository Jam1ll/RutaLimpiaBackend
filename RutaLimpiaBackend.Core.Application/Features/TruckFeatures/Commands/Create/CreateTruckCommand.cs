using MediatR;
using RutaLimpiaBackend.Core.Application.Wrappers;

namespace RutaLimpiaBackend.Core.Application.Features.TruckFeatures.Commands.Create
{
    public class CreateTruckCommand : IRequest<Response<Guid>>
    {
        public Guid RouteId { get; set; }
        public required string LicensePlate { get; set; }
        public decimal Capacity { get; set; }
        public bool IsActive { get; set; }
    }
}