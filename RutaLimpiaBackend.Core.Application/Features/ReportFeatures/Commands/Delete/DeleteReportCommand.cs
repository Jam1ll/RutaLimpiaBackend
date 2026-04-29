using RutaLimpiaBackend.Core.Application.Interfaces;
using RutaLimpiaBackend.Core.Application.Interfaces.CommonHandlers;

namespace RutaLimpiaBackend.Core.Application.Features.ReportFeatures.Commands.Delete
{
    public class DeleteReportCommand : IGenericDeleteValidator, IDeleteRequest
    {
        public Guid Id { get; set; }
    }
}