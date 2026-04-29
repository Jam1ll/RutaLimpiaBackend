using RutaLimpiaBackend.Core.Application.Features.Common.CommonCommands;
using RutaLimpiaBackend.Core.Application.Interfaces;
using RutaLimpiaBackend.Core.Domain.Entities;

namespace RutaLimpiaBackend.Core.Application.Features.WeatherAlertFeatures.Commands.Delete
{
    public class DeleteWeatherAlertCommandHandler : DeleteGenericCommandHandler<DeleteWeatherAlertCommand, WeatherAlert>
    {
        public DeleteWeatherAlertCommandHandler(IRepositoryAsync<WeatherAlert> repositoryAsync) : base(repositoryAsync)
        {
        }
    }
}