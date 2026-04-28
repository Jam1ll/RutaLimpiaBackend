using MediatR;
using RutaLimpiaBackend.Core.Application.DTOs;
using RutaLimpiaBackend.Core.Application.Wrappers;

namespace RutaLimpiaBackend.Core.Application.Features.WeatherAlertFeatures.Queries.GetAll
{
    public class GetAllWeatherAlertsQuery : IRequest<PagedResponse<List<WeatherAlertResponseDTO>>>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
    }
}