using MediatR;
using RutaLimpiaBackend.Core.Application.DTOs;
using RutaLimpiaBackend.Core.Application.Wrappers;

namespace RutaLimpiaBackend.Core.Application.Features.CollectionScheduleFeatures.Queries.GetById
{
    public class GetCollectionScheduleByIdQuery : IRequest<Response<CollectionScheduleResponseDTO>>
    {
        public Guid Id { get; set; }
    }
}