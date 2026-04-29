using RutaLimpiaBackend.Core.Domain.Entities;

namespace RutaLimpiaBackend.Core.Application.Specifications.WeatherAlertSpecifications
{
    public class WeatherAlertSpecification : PagedGeneralSpecification<WeatherAlert>
    {
        public WeatherAlertSpecification(int pageSize, int pageNumber) : base(pageSize, pageNumber)
        {
        }
    }
}