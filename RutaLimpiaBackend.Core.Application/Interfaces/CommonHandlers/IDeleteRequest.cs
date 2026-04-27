using MediatR;
using RutaLimpiaBackend.Core.Application.Wrappers;

namespace RutaLimpiaBackend.Core.Application.Interfaces.CommonHandlers
{
    public interface IDeleteRequest : IRequest<Response<Guid>>
    {
        Guid Id { get; set; }
    }
}