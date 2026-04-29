using MediatR;
using RutaLimpiaBackend.Core.Application.Wrappers;

namespace RutaLimpiaBackend.Core.Application.Features.WeatherAlertFeatures.Commands.Create
{
    public class CreateWeatherAlertCommand : IRequest<Response<Guid>>
    {
        public required string Description { get; set; }
        public required decimal RainProbability { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Guid SectorId { get; set; }
    }
}