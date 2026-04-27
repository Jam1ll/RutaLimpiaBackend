using MediatR;
using RutaLimpiaBackend.Core.Application.DTOs;
using RutaLimpiaBackend.Core.Application.Wrappers;

namespace RutaLimpiaBackend.Core.Application.Features.RouteFeatures.Queries.GetById
{
    public class GetRouteByIdQuery : IRequest<Response<RouteResponseDTO>>
    {
        public Guid Id { get; set; }
    }
}