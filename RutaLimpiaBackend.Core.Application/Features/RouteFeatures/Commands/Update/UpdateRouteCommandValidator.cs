using FluentValidation;

namespace RutaLimpiaBackend.Core.Application.Features.RouteFeatures.Commands.Update
{
    public class UpdateRouteCommandValidator : AbstractValidator<UpdateRouteCommand>
    {
        public UpdateRouteCommandValidator()
        {
            RuleFor(x => x.SectorId)
                .NotEmpty().WithMessage("{PropertyName} no puede estar empty.");

            RuleFor(x => x.Number)
                .NotNull().WithMessage("{PropertyName} no puede ser null.")
                .NotEmpty().WithMessage("{PropertyName} no puede estar empty.");
        }
    }
}