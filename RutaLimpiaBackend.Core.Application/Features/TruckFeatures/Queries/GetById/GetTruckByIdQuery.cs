using MediatR;
using RutaLimpiaBackend.Core.Application.DTOs;
using RutaLimpiaBackend.Core.Application.Wrappers;

namespace RutaLimpiaBackend.Core.Application.Features.TruckFeatures.Queries.GetById
{
    public class GetTruckByIdQuery : IRequest<Response<TruckResponseDTO>>
    {
        public Guid Id { get; set; }
    }
}