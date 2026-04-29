using MediatR;
using RutaLimpiaBackend.Core.Application.DTOs;
using RutaLimpiaBackend.Core.Application.Wrappers;

namespace RutaLimpiaBackend.Core.Application.Features.ReportFeatures.Queries.GetAll
{
    public class GetAllReportsQuery : IRequest<PagedResponse<List<ReportResponseDTO>>>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
    }
}