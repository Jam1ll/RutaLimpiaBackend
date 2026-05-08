using MediatR;
using RutaLimpiaBackend.Core.Application.Wrappers;
using RutaLimpiaBackend.Core.Domain.Entities.Enums;

namespace RutaLimpiaBackend.Core.Application.Features.ReportFeatures.Commands.ChangeState
{
    public class ChangeReportStateCommand : IRequest<Response<Guid>>
    {
        public Guid Id { get; set; }
        public ReportState ReportState { get; set; }
    }
}