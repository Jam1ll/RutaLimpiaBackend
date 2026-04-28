using RutaLimpiaBackend.Core.Application.Interfaces.CommonHandlers;

namespace RutaLimpiaBackend.Core.Application.Features.CollectionScheduleFeatures.Commands.Update
{
    public class UpdateCollectionScheduleCommand : IUpdateRequest
    {
        public Guid Id { get; set; }
        public Guid RouteId { get; set; }
        public required string Weekday { get; set; }
        public TimeOnly StartTime { get; set; }
        public TimeOnly EndTime { get; set; }
        public bool IsActive { get; set; }
    }
}