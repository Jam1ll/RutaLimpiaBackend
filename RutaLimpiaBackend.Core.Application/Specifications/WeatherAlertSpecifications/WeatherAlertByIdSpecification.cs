using Ardalis.Specification;
using RutaLimpiaBackend.Core.Domain.Entities;

namespace RutaLimpiaBackend.Core.Application.Specifications.WeatherAlertSpecifications
{
    public class WeatherAlertByIdSpecification : Specification<WeatherAlert, ISingleResultSpecification<WeatherAlert>>
    {
        public WeatherAlertByIdSpecification(Guid id)
        {
            Query.Where(x => x.Id == id);
        }
    }
}