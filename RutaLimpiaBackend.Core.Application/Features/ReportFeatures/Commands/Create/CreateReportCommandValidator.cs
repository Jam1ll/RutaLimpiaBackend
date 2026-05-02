using FluentValidation;

namespace RutaLimpiaBackend.Core.Application.Features.ReportFeatures.Commands.Create
{
    public class CreateReportCommandValidator : AbstractValidator<CreateReportCommand>
    {
        public CreateReportCommandValidator()
        {
            RuleFor(x => x.Title)
                .NotNull().WithMessage("{PropertyName} no puede ser null.")
                .NotEmpty().WithMessage("{PropertyName} no puede estar empty.");

            RuleFor(x => x.Description)
                .NotNull().WithMessage("{PropertyName} no puede ser null.")
                .NotEmpty().WithMessage("{PropertyName} no puede estar empty.");

            RuleFor(x => x.PhotoUrl)
                .NotNull().WithMessage("{PropertyName} no puede ser null.")
                .NotEmpty().WithMessage("{PropertyName} no puede estar empty.");

            RuleFor(x => x.DirectionReference)
                .NotNull().WithMessage("{PropertyName} no puede ser null.")
                .NotEmpty().WithMessage("{PropertyName} no puede estar empty.");

            RuleFor(x => x.Latitude)
                .InclusiveBetween(-90, 90).WithMessage("{PropertyName} debe estar entre -90 y 90.");

            RuleFor(x => x.Longitude)
                .InclusiveBetween(-180, 180).WithMessage("{PropertyName} debe estar entre -180 y 180.");

            RuleFor(x => x.UserId)
                .NotEmpty().WithMessage("{PropertyName} no puede estar empty.");

            RuleFor(x => x.SectorId)
                .NotEmpty().WithMessage("{PropertyName} no puede estar empty.");

            RuleFor(x => x.ReportType)
                .IsInEnum().WithMessage("{PropertyName} no es un valor válido.");

            RuleFor(x => x.ReportState)
                .IsInEnum().WithMessage("{PropertyName} no es un valor válido.");
        }
    }
}