using RutaLimpiaBackend.Core.Application.Interfaces;
using RutaLimpiaBackend.Core.Application.Interfaces.CommonHandlers;

namespace RutaLimpiaBackend.Core.Application.Features.WeatherAlertFeatures.Commands.Delete
{
    public class DeleteWeatherAlertCommand : IGenericDeleteValidator, IDeleteRequest
    {
        public Guid Id { get; set; }
    }
}