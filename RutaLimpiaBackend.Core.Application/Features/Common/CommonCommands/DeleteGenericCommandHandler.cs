using MediatR;
using Microsoft.EntityFrameworkCore;
using RutaLimpiaBackend.Core.Application.Exceptions;
using RutaLimpiaBackend.Core.Application.Interfaces;
using RutaLimpiaBackend.Core.Application.Interfaces.CommonHandlers;
using RutaLimpiaBackend.Core.Application.Wrappers;
using RutaLimpiaBackend.Core.Domain.Entities.Common;

namespace RutaLimpiaBackend.Core.Application.Features.Common.CommonCommands
{
    public class DeleteGenericCommandHandler<TRequest, TEntity> : IRequestHandler<TRequest, Response<Guid>>
        where TRequest : IDeleteRequest
        where TEntity : class, IEntity
    {
        private readonly IRepositoryAsync<TEntity> _repositoryAsync;

        public DeleteGenericCommandHandler(IRepositoryAsync<TEntity> repositoryAsync)
        {
            _repositoryAsync = repositoryAsync ?? throw new ArgumentNullException(nameof(repositoryAsync));
        }

        public async Task<Response<Guid>> Handle(TRequest request, CancellationToken cancellationToken)
        {
            var entity = await _repositoryAsync.GetByIdAsync(request.Id)
                ?? throw new KeyNotFoundException($"No se encontró el registro de '{typeof(TEntity).Name}' con el id '{request.Id}'");

            try
            {
                await _repositoryAsync.DeleteAsync(entity, cancellationToken);
                await _repositoryAsync.SaveChangesAsync(cancellationToken);
                return new Response<Guid>(entity.Id);
            }
            catch (DbUpdateException ex) when (ex.InnerException != null && ex.InnerException.Message.Contains("REFERENCE constraint"))
            {
                throw new ApiException("No se puede eliminar este registro porque tiene otros datos asociados que dependen de él.");
            }
        }
    }
}
