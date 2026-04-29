using MediatR;
using RutaLimpiaBackend.Core.Application.Wrappers;

namespace RutaLimpiaBackend.Core.Application.Features.CleaningDayParticipationFeatures.Commands.Create
{
    public class CreateCleaningDayParticipationCommand : IRequest<Response<Guid>>
    {
        public required string Comment { get; set; }
        public Guid CleaningDayId { get; set; }
        public Guid UserId { get; set; }
    }
}