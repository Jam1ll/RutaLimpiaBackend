using RutaLimpiaBackend.Core.Application.Features.Common.CommonCommands;
using RutaLimpiaBackend.Core.Application.Interfaces;
using RutaLimpiaBackend.Core.Domain.Entities;

namespace RutaLimpiaBackend.Core.Application.Features.RouteFeatures.Commands.Delete
{
    public class DeleteRouteCommandHandler : DeleteGenericCommandHandler<DeleteRouteCommand, Route>
    {
        public DeleteRouteCommandHandler(IRepositoryAsync<Route> repositoryAsync) : base(repositoryAsync)
        {
        }
    }
}