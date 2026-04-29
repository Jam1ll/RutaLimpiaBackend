using MediatR;
using RutaLimpiaBackend.Core.Application.DTOs;
using RutaLimpiaBackend.Core.Application.Wrappers;

namespace RutaLimpiaBackend.Core.Application.Features.CleaningDayParticipationFeatures.Queries.GetAll
{
    public class GetAllCleaningDayParticipationsQuery : IRequest<PagedResponse<List<CleaningDayParticipationResponseDTO>>>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
    }
}