using FluentValidation;

namespace RutaLimpiaBackend.Core.Application.Features.WeatherAlertFeatures.Commands.Update
{
    public class UpdateWeatherAlertCommandValidator : AbstractValidator<UpdateWeatherAlertCommand>
    {
        public UpdateWeatherAlertCommandValidator()
        {
            RuleFor(x => x.Description)
                .NotNull().WithMessage("{PropertyName} no puede ser null.")
                .NotEmpty().WithMessage("{PropertyName} no puede estar empty.");

            RuleFor(x => x.RainProbability)
                .InclusiveBetween(0, 100).WithMessage("{PropertyName} debe estar entre 0 y 100.");

            RuleFor(x => x.StartDate)
                .NotEmpty().WithMessage("{PropertyName} no puede estar empty.");

            RuleFor(x => x.EndDate)
                .NotEmpty().WithMessage("{PropertyName} no puede estar empty.")
                .GreaterThanOrEqualTo(x => x.StartDate).WithMessage("{PropertyName} debe ser mayor o igual a StartDate.");

            RuleFor(x => x.SectorId)
                .NotEmpty().WithMessage("{PropertyName} no puede estar empty.");
        }
    }
}