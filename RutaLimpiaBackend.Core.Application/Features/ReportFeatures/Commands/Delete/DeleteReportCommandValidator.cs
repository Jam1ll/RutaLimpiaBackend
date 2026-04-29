using FluentValidation;

namespace RutaLimpiaBackend.Core.Application.Features.ReportFeatures.Commands.Delete
{
    public class DeleteReportCommandValidator : AbstractValidator<DeleteReportCommand>
    {
        public DeleteReportCommandValidator()
        {
        }
    }
}