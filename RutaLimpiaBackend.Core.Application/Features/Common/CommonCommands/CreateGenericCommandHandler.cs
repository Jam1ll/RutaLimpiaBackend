using MapsterMapper;
using MediatR;
using RutaLimpiaBackend.Core.Application.Interfaces;
using RutaLimpiaBackend.Core.Application.Wrappers;
using RutaLimpiaBackend.Core.Domain.Entities.Common;

namespace RutaLimpiaBackend.Core.Application.Features.Common.CommonCommands
{
    public class CreateGenericCommandHandler<TRequest, TEntity> : IRequestHandler<TRequest, Response<Guid>>
        where TRequest : IRequest<Response<Guid>>
        where TEntity : class, IEntity
    {
        private readonly IRepositoryAsync<TEntity> _repositoryAsync;
        private readonly IMapper _mapper;

        public CreateGenericCommandHandler(IRepositoryAsync<TEntity> repositoryAsync, IMapper mapper)
        {
            _repositoryAsync = repositoryAsync ?? throw new ArgumentNullException(nameof(repositoryAsync));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<Response<Guid>> Handle(TRequest request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<TEntity>(request);

            await _repositoryAsync.AddAsync(entity, cancellationToken);
            await _repositoryAsync.SaveChangesAsync(cancellationToken);

            return new Response<Guid>(entity.Id);
        }
    }
}
