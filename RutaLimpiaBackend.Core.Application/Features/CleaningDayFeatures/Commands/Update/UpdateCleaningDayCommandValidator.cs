using FluentValidation;

namespace RutaLimpiaBackend.Core.Application.Features.CleaningDayFeatures.Commands.Update
{
    public class UpdateCleaningDayCommandValidator : AbstractValidator<UpdateCleaningDayCommand>
    {
        public UpdateCleaningDayCommandValidator()
        {
            RuleFor(x => x.Code)
                .NotNull().WithMessage("{PropertyName} no puede ser null.")
                .NotEmpty().WithMessage("{PropertyName} no puede estar empty.");

            RuleFor(x => x.Title)
                .NotNull().WithMessage("{PropertyName} no puede ser null.")
                .NotEmpty().WithMessage("{PropertyName} no puede estar empty.");

            RuleFor(x => x.Description)
                .NotNull().WithMessage("{PropertyName} no puede ser null.")
                .NotEmpty().WithMessage("{PropertyName} no puede estar empty.");

            RuleFor(x => x.StartDate)
                .NotEmpty().WithMessage("{PropertyName} no puede estar empty.");

            RuleFor(x => x.EndDate)
                .NotEmpty().WithMessage("{PropertyName} no puede estar empty.")
                .GreaterThanOrEqualTo(x => x.StartDate).WithMessage("{PropertyName} debe ser mayor o igual a StartDate.");

            RuleFor(x => x.Latitude)
                .InclusiveBetween(-90, 90).WithMessage("{PropertyName} debe estar entre -90 y 90.");

            RuleFor(x => x.Longitude)
                .InclusiveBetween(-180, 180).WithMessage("{PropertyName} debe estar entre -180 y 180.");

            RuleFor(x => x.SocialNetworkUrl)
                .NotNull().WithMessage("{PropertyName} no puede ser null.")
                .NotEmpty().WithMessage("{PropertyName} no puede estar empty.");

            RuleFor(x => x.UserId)
                .NotEmpty().WithMessage("{PropertyName} no puede estar empty.");

            RuleFor(x => x.SectorId)
                .NotEmpty().WithMessage("{PropertyName} no puede estar empty.");
        }
    }
}