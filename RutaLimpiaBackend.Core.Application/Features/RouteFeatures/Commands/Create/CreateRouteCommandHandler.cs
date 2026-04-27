using MapsterMapper;
using RutaLimpiaBackend.Core.Application.Features.Common.CommonCommands;
using RutaLimpiaBackend.Core.Application.Interfaces;
using RutaLimpiaBackend.Core.Domain.Entities;

namespace RutaLimpiaBackend.Core.Application.Features.RouteFeatures.Commands.Create
{
    public class CreateRouteCommandHandler : CreateGenericCommandHandler<CreateRouteCommand, Route>
    {
        public CreateRouteCommandHandler(IRepositoryAsync<Route> repositoryAsync, IMapper mapper) : base(repositoryAsync, mapper)
        {
        }
    }
}