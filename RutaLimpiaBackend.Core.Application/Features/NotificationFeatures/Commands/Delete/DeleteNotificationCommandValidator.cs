using FluentValidation;

namespace RutaLimpiaBackend.Core.Application.Features.NotificationFeatures.Commands.Delete
{
    public class DeleteNotificationCommandValidator : AbstractValidator<DeleteNotificationCommand>
    {
        public DeleteNotificationCommandValidator()
        {
        }
    }
}