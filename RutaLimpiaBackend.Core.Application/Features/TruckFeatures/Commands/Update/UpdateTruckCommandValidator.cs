using FluentValidation;

namespace RutaLimpiaBackend.Core.Application.Features.TruckFeatures.Commands.Update
{
    public class UpdateTruckCommandValidator : AbstractValidator<UpdateTruckCommand>
    {
        public UpdateTruckCommandValidator()
        {
            RuleFor(x => x.RouteId)
                .NotEmpty().WithMessage("{PropertyName} no puede estar empty.");

            RuleFor(x => x.LicensePlate)
                .NotNull().WithMessage("{PropertyName} no puede ser null.")
                .NotEmpty().WithMessage("{PropertyName} no puede estar empty.");

            RuleFor(x => x.Capacity)
                .GreaterThan(0).WithMessage("{PropertyName} debe ser mayor a 0.");
        }
    }
}