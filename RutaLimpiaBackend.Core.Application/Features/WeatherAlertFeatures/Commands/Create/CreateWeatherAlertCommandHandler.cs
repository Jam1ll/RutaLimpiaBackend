using MapsterMapper;
using RutaLimpiaBackend.Core.Application.Features.Common.CommonCommands;
using RutaLimpiaBackend.Core.Application.Interfaces;
using RutaLimpiaBackend.Core.Domain.Entities;

namespace RutaLimpiaBackend.Core.Application.Features.WeatherAlertFeatures.Commands.Create
{
    public class CreateWeatherAlertCommandHandler : CreateGenericCommandHandler<CreateWeatherAlertCommand, WeatherAlert>
    {
        public CreateWeatherAlertCommandHandler(IRepositoryAsync<WeatherAlert> repositoryAsync, IMapper mapper) : base(repositoryAsync, mapper)
        {
        }
    }
}