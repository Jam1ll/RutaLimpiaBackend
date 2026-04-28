using MapsterMapper;
using RutaLimpiaBackend.Core.Application.Features.Common.CommonCommands;
using RutaLimpiaBackend.Core.Application.Interfaces;
using RutaLimpiaBackend.Core.Domain.Entities;

namespace RutaLimpiaBackend.Core.Application.Features.ReportFeatures.Commands.Update
{
    internal class UpdateReportCommandHandler : UpdateGenericCommandHandler<UpdateReportCommand, Report>
    {
        public UpdateReportCommandHandler(IRepositoryAsync<Report> repositoryAsync, IMapper mapper) : base(repositoryAsync, mapper)
        {
        }
    }
}