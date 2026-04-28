using RutaLimpiaBackend.Core.Application.Interfaces.CommonHandlers;

namespace RutaLimpiaBackend.Core.Application.Features.CleaningDayFeatures.Commands.Update
{
    public class UpdateCleaningDayCommand : IUpdateRequest
    {
        public Guid Id { get; set; }
        public required string Code { get; set; }
        public required string Title { get; set; }
        public required string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public required decimal Latitude { get; set; }
        public required decimal Longitude { get; set; }
        public required string SocialNetworkUrl { get; set; }
        public Guid UserId { get; set; }
        public Guid SectorId { get; set; }
    }
}