using MediatR;
using RutaLimpiaBackend.Core.Application.DTOs;
using RutaLimpiaBackend.Core.Application.Wrappers;

namespace RutaLimpiaBackend.Core.Application.Features.SectorFeatures.Queries.GetById
{
    public class GetSectorByIdQuery : IRequest<Response<SectorResponseDTO>>
    {
        public Guid Id { get; set; }
    }
}
