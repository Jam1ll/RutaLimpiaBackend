using RutaLimpiaBackend.Core.Application.Interfaces;

namespace RutaLimpiaBackend.Infrastructure.Shared.Services
{
    public class DateTimeService : IDateTimeService
    {
        public DateTime NowUtc => DateTime.UtcNow;
    }
}
