using RutaLimpiaBackend.Core.Application.Interfaces.CommonHandlers;

namespace RutaLimpiaBackend.Core.Application.Features.TruckFeatures.Commands.Update
{
    public class UpdateTruckCommand : IUpdateRequest
    {
        public Guid Id { get; set; }
        public Guid RouteId { get; set; }
        public required string LicensePlate { get; set; }
        public decimal Capacity { get; set; }
        public bool IsActive { get; set; }
    }
}