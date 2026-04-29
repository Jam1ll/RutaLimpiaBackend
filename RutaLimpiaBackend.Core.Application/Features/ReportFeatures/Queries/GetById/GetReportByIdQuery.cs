using MediatR;
using RutaLimpiaBackend.Core.Application.DTOs;
using RutaLimpiaBackend.Core.Application.Wrappers;

namespace RutaLimpiaBackend.Core.Application.Features.ReportFeatures.Queries.GetById
{
    public class GetReportByIdQuery : IRequest<Response<ReportResponseDTO>>
    {
        public Guid Id { get; set; }
    }
}