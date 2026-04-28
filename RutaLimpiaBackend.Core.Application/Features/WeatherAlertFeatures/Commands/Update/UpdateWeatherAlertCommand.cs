using RutaLimpiaBackend.Core.Application.Interfaces.CommonHandlers;

namespace RutaLimpiaBackend.Core.Application.Features.WeatherAlertFeatures.Commands.Update
{
    public class UpdateWeatherAlertCommand : IUpdateRequest
    {
        public Guid Id { get; set; }
        public required string Description { get; set; }
        public required decimal RainProbability { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Guid SectorId { get; set; }
    }
}