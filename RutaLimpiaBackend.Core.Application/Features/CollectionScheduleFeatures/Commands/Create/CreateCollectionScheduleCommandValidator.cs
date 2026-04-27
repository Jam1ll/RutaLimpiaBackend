using FluentValidation;

namespace RutaLimpiaBackend.Core.Application.Features.CollectionScheduleFeatures.Commands.Create
{
    public class CreateCollectionScheduleCommandValidator : AbstractValidator<CreateCollectionScheduleCommand>
    {
        public CreateCollectionScheduleCommandValidator()
        {
            RuleFor(x => x.IdRoute)
                .NotEmpty().WithMessage("{PropertyName} no puede estar empty.");

            RuleFor(x => x.Weekday)
                .NotNull().WithMessage("{PropertyName} no puede ser null.")
                .NotEmpty().WithMessage("{PropertyName} no puede estar empty.");
        }
    }
}