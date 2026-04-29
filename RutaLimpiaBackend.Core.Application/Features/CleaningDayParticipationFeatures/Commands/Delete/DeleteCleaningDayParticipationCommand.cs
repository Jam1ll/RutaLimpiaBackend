using RutaLimpiaBackend.Core.Application.Interfaces;
using RutaLimpiaBackend.Core.Application.Interfaces.CommonHandlers;

namespace RutaLimpiaBackend.Core.Application.Features.CleaningDayParticipationFeatures.Commands.Delete
{
    public class DeleteCleaningDayParticipationCommand : IGenericDeleteValidator, IDeleteRequest
    {
        public Guid Id { get; set; }
    }
}