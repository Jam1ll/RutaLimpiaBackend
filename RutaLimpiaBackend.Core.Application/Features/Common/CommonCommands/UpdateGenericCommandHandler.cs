using MapsterMapper;
using MediatR;
using RutaLimpiaBackend.Core.Application.Interfaces;
using RutaLimpiaBackend.Core.Application.Interfaces.CommonHandlers;
using RutaLimpiaBackend.Core.Application.Wrappers;
using RutaLimpiaBackend.Core.Domain.Entities.Common;

namespace RutaLimpiaBackend.Core.Application.Features.Common.CommonCommands
{
    public class UpdateGenericCommandHandler<TRequest, TEntity> : IRequestHandler<TRequest, Response<Guid>>
        where TRequest : IUpdateRequest
        where TEntity : class, IEntity
    {
        private readonly IRepositoryAsync<TEntity> _repositoryAsync;
        private readonly IMapper _mapper;

        public UpdateGenericCommandHandler(IRepositoryAsync<TEntity> repositoryAsync, IMapper mapper)
        {
            _repositoryAsync = repositoryAsync ?? throw new ArgumentNullException(nameof(repositoryAsync));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<Response<Guid>> Handle(TRequest request, CancellationToken cancellationToken)
        {
            var entity = await _repositoryAsync.GetByIdAsync(request.Id)
                ?? throw new KeyNotFoundException($"No se encontró el registro de '{typeof(TEntity).Name}' con el id '{request.Id}'");

            _mapper.Map(request, entity);

            await _repositoryAsync.UpdateAsync(entity, cancellationToken);
            await _repositoryAsync.SaveChangesAsync(cancellationToken);

            return new Response<Guid>(entity.Id);
        }
    }
}
