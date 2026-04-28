using MediatR;
using RutaLimpiaBackend.Core.Application.DTOs;
using RutaLimpiaBackend.Core.Application.Wrappers;

namespace RutaLimpiaBackend.Core.Application.Features.CleaningDayFeatures.Queries.GetById
{
    public class GetCleaningDayByIdQuery : IRequest<Response<CleaningDayResponseDTO>>
    {
        public Guid Id { get; set; }
    }
}