using MediatR;
using RutaLimpiaBackend.Core.Application.Wrappers;

namespace RutaLimpiaBackend.Core.Application.Features.CleaningDayFeatures.Commands.Create
{
    public class CreateCleaningDayCommand : IRequest<Response<Guid>>
    {
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