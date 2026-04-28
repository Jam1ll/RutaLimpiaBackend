using RutaLimpiaBackend.Core.Application.Interfaces.CommonHandlers;

namespace RutaLimpiaBackend.Core.Application.Features.RouteFeatures.Commands.Update
{
    public class UpdateRouteCommand : IUpdateRequest
    {
        public Guid Id { get; set; }
        public Guid SectorId { get; set; }
        public required string Number { get; set; }
        public bool IsActive { get; set; }
    }
}