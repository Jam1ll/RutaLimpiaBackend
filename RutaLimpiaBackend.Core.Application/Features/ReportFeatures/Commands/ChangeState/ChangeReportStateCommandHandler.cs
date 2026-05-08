using MediatR;
using RutaLimpiaBackend.Core.Application.Interfaces;
using RutaLimpiaBackend.Core.Application.Wrappers;
using RutaLimpiaBackend.Core.Domain.Entities;

namespace RutaLimpiaBackend.Core.Application.Features.ReportFeatures.Commands.ChangeState
{
    public class ChangeReportStateCommandHandler : IRequestHandler<ChangeReportStateCommand, Response<Guid>>
    {
        private readonly IRepositoryAsync<Report> _repository;

        public ChangeReportStateCommandHandler(IRepositoryAsync<Report> repository)
        {
            _repository = repository;
        }

        public async Task<Response<Guid>> Handle(ChangeReportStateCommand request, CancellationToken cancellationToken)
        {
            var report = await _repository.GetByIdAsync(request.Id);
            if (report == null) throw new Exception("Reporte no encontrado");

            report.ReportState = request.ReportState;

            await _repository.UpdateAsync(report, cancellationToken);
            return new Response<Guid>(report.Id, "Estado actualizado con éxito");
        }
    }
}