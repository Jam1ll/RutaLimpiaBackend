using MapsterMapper;
using RutaLimpiaBackend.Core.Application.Features.Common.CommonCommands;
using RutaLimpiaBackend.Core.Application.Interfaces;
using RutaLimpiaBackend.Core.Domain.Entities;

namespace RutaLimpiaBackend.Core.Application.Features.RouteFeatures.Commands.Update
{
    internal class UpdateRouteCommandHandler : UpdateGenericCommandHandler<UpdateRouteCommand, Route>
    {
        public UpdateRouteCommandHandler(IRepositoryAsync<Route> repositoryAsync, IMapper mapper) : base(repositoryAsync, mapper)
        {
        }
    }
}