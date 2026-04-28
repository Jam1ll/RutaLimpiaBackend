using Ardalis.Specification;
using MapsterMapper;
using RutaLimpiaBackend.Core.Application.DTOs;
using RutaLimpiaBackend.Core.Application.Features.Common.CommonQueries;
using RutaLimpiaBackend.Core.Application.Interfaces;
using RutaLimpiaBackend.Core.Application.Specifications.WeatherAlertSpecifications;
using RutaLimpiaBackend.Core.Domain.Entities;

namespace RutaLimpiaBackend.Core.Application.Features.WeatherAlertFeatures.Queries.GetById
{
    public class GetWeatherAlertByIdQueryHandler : GetByIdGenericQueryHandler<GetWeatherAlertByIdQuery, WeatherAlert, WeatherAlertResponseDTO>
    {
        public GetWeatherAlertByIdQueryHandler(IReadRepositoryAsync<WeatherAlert> repositoryAsync, IMapper mapper) : base(repositoryAsync, mapper)
        {
        }

        protected override Guid GetEntityId(GetWeatherAlertByIdQuery request) => request.Id;

        protected override ISpecification<WeatherAlert> CreateSpecification(GetWeatherAlertByIdQuery request)
        {
            return new WeatherAlertByIdSpecification(request.Id);
        }
    }
}