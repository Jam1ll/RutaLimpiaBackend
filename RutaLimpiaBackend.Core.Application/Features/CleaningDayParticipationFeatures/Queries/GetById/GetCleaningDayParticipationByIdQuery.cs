using MediatR;
using RutaLimpiaBackend.Core.Application.DTOs;
using RutaLimpiaBackend.Core.Application.Wrappers;

namespace RutaLimpiaBackend.Core.Application.Features.CleaningDayParticipationFeatures.Queries.GetById
{
    public class GetCleaningDayParticipationByIdQuery : IRequest<Response<CleaningDayParticipationResponseDTO>>
    {
        public Guid Id { get; set; }
    }
}