using FluentValidation;

namespace RutaLimpiaBackend.Core.Application.Features.RouteFeatures.Commands.Delete
{
    public class DeleteRouteCommandValidator : AbstractValidator<DeleteRouteCommand>
    {
        public DeleteRouteCommandValidator()
        {
        }
    }
}