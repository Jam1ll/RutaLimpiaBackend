using MediatR;
using RutaLimpiaBackend.Core.Application.DTOs;
using RutaLimpiaBackend.Core.Application.Wrappers;

namespace RutaLimpiaBackend.Core.Application.Features.CleaningDayFeatures.Queries.GetAll
{
    public class GetAllCleaningDaysQuery : IRequest<PagedResponse<List<CleaningDayResponseDTO>>>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
    }
}