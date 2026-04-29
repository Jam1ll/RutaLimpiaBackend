using FluentValidation;

namespace RutaLimpiaBackend.Core.Application.Features.CleaningDayFeatures.Commands.Delete
{
    public class DeleteCleaningDayCommandValidator : AbstractValidator<DeleteCleaningDayCommand>
    {
        public DeleteCleaningDayCommandValidator()
        {
        }
    }
}