using MediatR;
using RutaLimpiaBackend.Core.Application.Wrappers;

namespace RutaLimpiaBackend.Core.Application.Features.SectorFeatures.Commands.Create
{
    public class CreateSectorCommand : IRequest<Response<Guid>>
    {
        public required string Name { get; set; }
        public required string Municipality { get; set; }
        public string? Description { get; set; }
    }
}
