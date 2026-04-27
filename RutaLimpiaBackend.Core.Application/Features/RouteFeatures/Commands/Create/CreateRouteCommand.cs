using MediatR;
using RutaLimpiaBackend.Core.Application.Wrappers;

namespace RutaLimpiaBackend.Core.Application.Features.RouteFeatures.Commands.Create
{
    public class CreateRouteCommand : IRequest<Response<Guid>>
    {
        public Guid IdSector { get; set; }
        public required string Number { get; set; }
        public bool IsActive { get; set; }
    }
}