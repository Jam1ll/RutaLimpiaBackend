using Microsoft.AspNetCore.SignalR;
using RutaLimpiaBackend.Core.Application.DTOs;

namespace WebAPI.Hubs
{
    public class TrackingHub : Hub
    {
        //CITIZEN 
        public async Task JoinRouteGroup(string routeId)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, routeId);
        }

        public async Task LeaveRouteGroup(string routeId)
        {
            await Groups.RemoveFromGroupAsync(Context.ConnectionId, routeId);
        }

        // COLLECTOR
        public async Task SendLocationUpdate(LocationUpdateDTO location)
        {
            await Clients.Group(location.RouteId).SendAsync("ReceiveLocation", location);
        }
    }
}