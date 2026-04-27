using MediatR;
using RutaLimpiaBackend.Core.Application.DTOs;
using RutaLimpiaBackend.Core.Application.Wrappers;

namespace RutaLimpiaBackend.Core.Application.Features.CollectionScheduleFeatures.Queries.GetAll
{
    public class GetAllCollectionSchedulesQuery : IRequest<PagedResponse<List<CollectionScheduleResponseDTO>>>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
    }
}