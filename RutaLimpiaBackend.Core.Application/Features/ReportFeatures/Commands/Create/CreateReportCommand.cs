using MediatR;
using RutaLimpiaBackend.Core.Application.Wrappers;
using RutaLimpiaBackend.Core.Domain.Entities.Enums;

namespace RutaLimpiaBackend.Core.Application.Features.ReportFeatures.Commands.Create
{
    public class CreateReportCommand : IRequest<Response<Guid>>
    {
        public required string Title { get; set; }
        public required string Description { get; set; }
        public required string PhotoUrl { get; set; }
        public required string DirectionReference { get; set; }
        public required decimal Latitude { get; set; }
        public required decimal Longitude { get; set; }
        public ReportType ReportType { get; set; }
        public ReportState ReportState { get; set; }
        public Guid UserId { get; set; }
        public Guid RouteId { get; set; }
        public Guid SectorId { get; set; }
    }
}