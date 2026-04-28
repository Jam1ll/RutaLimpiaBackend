using FluentValidation;

namespace RutaLimpiaBackend.Core.Application.Features.CleaningDayParticipationFeatures.Commands.Delete
{
    public class DeleteCleaningDayParticipationCommandValidator : AbstractValidator<DeleteCleaningDayParticipationCommand>
    {
        public DeleteCleaningDayParticipationCommandValidator()
        {
        }
    }
}