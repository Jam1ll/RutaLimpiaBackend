using MediatR;
using RutaLimpiaBackend.Core.Application.DTOs;
using RutaLimpiaBackend.Core.Application.Wrappers;

namespace RutaLimpiaBackend.Core.Application.Features.RouteFeatures.Queries.GetAll
{
    public class GetAllRoutesQuery : IRequest<PagedResponse<List<RouteResponseDTO>>>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
    }
}