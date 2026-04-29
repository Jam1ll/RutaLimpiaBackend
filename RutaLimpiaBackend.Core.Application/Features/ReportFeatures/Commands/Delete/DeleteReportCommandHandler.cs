using RutaLimpiaBackend.Core.Application.Features.Common.CommonCommands;
using RutaLimpiaBackend.Core.Application.Interfaces;
using RutaLimpiaBackend.Core.Domain.Entities;

namespace RutaLimpiaBackend.Core.Application.Features.ReportFeatures.Commands.Delete
{
    public class DeleteReportCommandHandler : DeleteGenericCommandHandler<DeleteReportCommand, Report>
    {
        public DeleteReportCommandHandler(IRepositoryAsync<Report> repositoryAsync) : base(repositoryAsync)
        {
        }
    }
}