using MediatR;
using RutaLimpiaBackend.Core.Application.DTOs;
using RutaLimpiaBackend.Core.Application.Wrappers;

namespace RutaLimpiaBackend.Core.Application.Features.WeatherAlertFeatures.Queries.GetById
{
    public class GetWeatherAlertByIdQuery : IRequest<Response<WeatherAlertResponseDTO>>
    {
        public Guid Id { get; set; }
    }
}