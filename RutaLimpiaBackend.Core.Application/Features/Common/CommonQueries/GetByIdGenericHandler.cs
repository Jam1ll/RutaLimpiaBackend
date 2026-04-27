using Ardalis.Specification;
using MapsterMapper;
using MediatR;
using RutaLimpiaBackend.Core.Application.Interfaces;
using RutaLimpiaBackend.Core.Application.Wrappers;

namespace RutaLimpiaBackend.Core.Application.Features.Common.CommonQueries
{
    public abstract class GetByIdGenericQueryHandler<TQuery, TEntity, TDto> : IRequestHandler<TQuery, Response<TDto>>
        where TQuery : IRequest<Response<TDto>>
        where TEntity : class
    {
        protected readonly IReadRepositoryAsync<TEntity> _repositoryAsync;
        protected readonly IMapper _mapper;

        protected GetByIdGenericQueryHandler(IReadRepositoryAsync<TEntity> repositoryAsync, IMapper mapper)
        {
            _repositoryAsync = repositoryAsync;
            _mapper = mapper;
        }

        protected abstract ISpecification<TEntity> CreateSpecification(TQuery request);
        protected abstract Guid GetEntityId(TQuery request);

        public async Task<Response<TDto>> Handle(TQuery request, CancellationToken cancellationToken)
        {
            var specification = CreateSpecification(request);

            var entity = await _repositoryAsync.FirstOrDefaultAsync(specification, cancellationToken)
                ?? throw new KeyNotFoundException($"{typeof(TEntity).Name} with id {GetEntityId(request)} not found.");

            var dto = _mapper.Map<TDto>(entity);

            return new Response<TDto>(dto);
        }
    }
}