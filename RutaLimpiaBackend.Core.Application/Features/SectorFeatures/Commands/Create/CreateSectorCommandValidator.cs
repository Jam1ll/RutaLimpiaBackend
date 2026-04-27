using FluentValidation;

namespace RutaLimpiaBackend.Core.Application.Features.SectorFeatures.Commands.Create
{
    public class CreateSectorCommandValidator : AbstractValidator<CreateSectorCommand>
    {
        public CreateSectorCommandValidator()
        {
            RuleFor(x => x.Name)
                .NotNull().WithMessage("{PropertyName} no puede ser null.")
                .NotEmpty().WithMessage("{PropertyName} no puede estar empty.");

            RuleFor(x => x.Municipality)
                .NotNull().WithMessage("{PropertyName} no puede ser null.")
                .NotEmpty().WithMessage("{PropertyName} no puede estar empty.");
        }
    }
}
