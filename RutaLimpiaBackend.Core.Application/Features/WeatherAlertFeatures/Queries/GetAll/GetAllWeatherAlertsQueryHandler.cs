using Ardalis.Specification;
using MapsterMapper;
using RutaLimpiaBackend.Core.Application.DTOs;
using RutaLimpiaBackend.Core.Application.Features.Common.CommonQueries;
using RutaLimpiaBackend.Core.Application.Interfaces;
using RutaLimpiaBackend.Core.Application.Specifications.WeatherAlertSpecifications;
using RutaLimpiaBackend.Core.Domain.Entities;

namespace RutaLimpiaBackend.Core.Application.Features.WeatherAlertFeatures.Queries.GetAll
{
    public class GetAllWeatherAlertsQueryHandler : GetAllGenericQueryHandler<GetAllWeatherAlertsQuery, WeatherAlert, WeatherAlertResponseDTO>
    {
        public GetAllWeatherAlertsQueryHandler(IReadRepositoryAsync<WeatherAlert> repositoryAsync, IMapper mapper) : base(repositoryAsync, mapper)
        {
        }

        protected override int GetPageNumber(GetAllWeatherAlertsQuery request) => request.PageNumber;
        protected override int GetPageSize(GetAllWeatherAlertsQuery request) => request.PageSize;

        protected override ISpecification<WeatherAlert> CreateCountSpecification(GetAllWeatherAlertsQuery request)
        {
            return new WeatherAlertSpecification(-1, -1);
        }

        protected override ISpecification<WeatherAlert> CreatePagedSpecification(GetAllWeatherAlertsQuery request)
        {
            return new WeatherAlertSpecification(request.PageSize, request.PageNumber);
        }
    }
}