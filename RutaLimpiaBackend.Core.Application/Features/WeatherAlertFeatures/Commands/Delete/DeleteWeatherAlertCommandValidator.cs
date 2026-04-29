using FluentValidation;

namespace RutaLimpiaBackend.Core.Application.Features.WeatherAlertFeatures.Commands.Delete
{
    public class DeleteWeatherAlertCommandValidator : AbstractValidator<DeleteWeatherAlertCommand>
    {
        public DeleteWeatherAlertCommandValidator()
        {
        }
    }
}