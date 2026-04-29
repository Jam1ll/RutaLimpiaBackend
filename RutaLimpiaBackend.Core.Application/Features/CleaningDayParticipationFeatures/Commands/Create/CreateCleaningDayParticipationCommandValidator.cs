using FluentValidation;

namespace RutaLimpiaBackend.Core.Application.Features.CleaningDayParticipationFeatures.Commands.Create
{
    public class CreateCleaningDayParticipationCommandValidator : AbstractValidator<CreateCleaningDayParticipationCommand>
    {
        public CreateCleaningDayParticipationCommandValidator()
        {
            RuleFor(x => x.Comment)
                .NotNull().WithMessage("{PropertyName} no puede ser null.")
                .NotEmpty().WithMessage("{PropertyName} no puede estar empty.");

            RuleFor(x => x.CleaningDayId)
                .NotEmpty().WithMessage("{PropertyName} no puede estar empty.");

            RuleFor(x => x.UserId)
                .NotEmpty().WithMessage("{PropertyName} no puede estar empty.");
        }
    }
}