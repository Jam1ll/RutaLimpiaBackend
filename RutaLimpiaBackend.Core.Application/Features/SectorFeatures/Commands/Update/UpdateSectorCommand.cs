using RutaLimpiaBackend.Core.Application.Interfaces.CommonHandlers;

namespace RutaLimpiaBackend.Core.Application.Features.SectorFeatures.Commands.Update
{
    public class UpdateSectorCommand : IUpdateRequest
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public required string Municipality { get; set; }
        public string? Description { get; set; }
    }
}
