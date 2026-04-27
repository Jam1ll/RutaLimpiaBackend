using FluentValidation;

namespace RutaLimpiaBackend.Core.Application.Features.SectorFeatures.Commands.Delete
{
    public class DeleteSectorCommandValidator : AbstractValidator<DeleteSectorCommand>
    {
        public DeleteSectorCommandValidator()
        {
        }
    }
}
