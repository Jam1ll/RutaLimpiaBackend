using MediatR;
using RutaLimpiaBackend.Core.Application.Wrappers;

namespace RutaLimpiaBackend.Core.Application.Features.CollectionScheduleFeatures.Commands.Create
{
    public class CreateCollectionScheduleCommand : IRequest<Response<Guid>>
    {
        public Guid RouteId { get; set; }
        public required string Weekday { get; set; }
        public TimeOnly StartTime { get; set; }
        public TimeOnly EndTime { get; set; }
        public bool IsActive { get; set; }
    }
}