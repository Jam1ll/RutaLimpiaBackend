using FluentValidation;

namespace RutaLimpiaBackend.Core.Application.Features.CollectionScheduleFeatures.Commands.Update
{
    public class UpdateCollectionScheduleCommandValidator : AbstractValidator<UpdateCollectionScheduleCommand>
    {
        public UpdateCollectionScheduleCommandValidator()
        {
            RuleFor(x => x.IdRoute)
                .NotEmpty().WithMessage("{PropertyName} no puede estar empty.");

            RuleFor(x => x.Weekday)
                .NotNull().WithMessage("{PropertyName} no puede ser null.")
                .NotEmpty().WithMessage("{PropertyName} no puede estar empty.");
        }
    }
}