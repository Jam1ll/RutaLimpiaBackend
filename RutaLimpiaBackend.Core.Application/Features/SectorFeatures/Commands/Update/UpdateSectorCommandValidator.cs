using FluentValidation;

namespace RutaLimpiaBackend.Core.Application.Features.SectorFeatures.Commands.Update
{
    public class UpdateSectorCommandValidator : AbstractValidator<UpdateSectorCommand>
    {
        public UpdateSectorCommandValidator()
        {
            RuleFor(x => x.Id)
               .NotEmpty().WithMessage("{PropertyName} no puede estar empty.");

            RuleFor(x => x.Name)
                .NotNull().WithMessage("{PropertyName} no puede ser null.")
                .NotEmpty().WithMessage("{PropertyName} no puede estar empty.");

            RuleFor(x => x.Municipality)
                .NotNull().WithMessage("{PropertyName} no puede ser null.")
                .NotEmpty().WithMessage("{PropertyName} no puede estar empty.");
        }
    }
}
