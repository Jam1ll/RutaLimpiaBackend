using MapsterMapper;
using RutaLimpiaBackend.Core.Application.Features.Common.CommonCommands;
using RutaLimpiaBackend.Core.Application.Interfaces;
using RutaLimpiaBackend.Core.Domain.Entities;

namespace RutaLimpiaBackend.Core.Application.Features.WeatherAlertFeatures.Commands.Update
{
    internal class UpdateWeatherAlertCommandHandler : UpdateGenericCommandHandler<UpdateWeatherAlertCommand, WeatherAlert>
    {
        public UpdateWeatherAlertCommandHandler(IRepositoryAsync<WeatherAlert> repositoryAsync, IMapper mapper) : base(repositoryAsync, mapper)
        {
        }
    }
}