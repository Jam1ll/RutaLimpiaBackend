using RutaLimpiaBackend.Core.Application.Interfaces.CommonHandlers;

namespace RutaLimpiaBackend.Core.Application.Features.CleaningDayParticipationFeatures.Commands.Update
{
    public class UpdateCleaningDayParticipationCommand : IUpdateRequest
    {
        public Guid Id { get; set; }
        public required string Comment { get; set; }
        public Guid CleaningDayId { get; set; }
        public Guid UserId { get; set; }
    }
}