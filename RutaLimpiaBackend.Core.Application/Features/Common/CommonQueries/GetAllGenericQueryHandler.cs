using Ardalis.Specification;
using MapsterMapper;
using MediatR;
using RutaLimpiaBackend.Core.Application.Interfaces;
using RutaLimpiaBackend.Core.Application.Wrappers;

namespace RutaLimpiaBackend.Core.Application.Features.Common.CommonQueries
{
    public abstract class GetAllGenericQueryHandler<TQuery, TEntity, TDto> : IRequestHandler<TQuery, PagedResponse<List<TDto>>>
        where TQuery : IRequest<PagedResponse<List<TDto>>>
        where TEntity : class
    {
        protected readonly IReadRepositoryAsync<TEntity> _repositoryAsync;
        protected readonly IMapper _mapper;

        protected GetAllGenericQueryHandler(IReadRepositoryAsync<TEntity> repositoryAsync, IMapper mapper)
        {
            _repositoryAsync = repositoryAsync;
            _mapper = mapper;
        }

        protected abstract ISpecification<TEntity> CreateCountSpecification(TQuery request);
        protected abstract ISpecification<TEntity> CreatePagedSpecification(TQuery request);

        protected abstract int GetPageNumber(TQuery request);
        protected abstract int GetPageSize(TQuery request);

        public async Task<PagedResponse<List<TDto>>> Handle(TQuery request, CancellationToken cancellationToken)
        {
            var countSpec = CreateCountSpecification(request);
            var totalRecords = await _repositoryAsync.CountAsync(countSpec, cancellationToken);

            var pagedSpec = CreatePagedSpecification(request);
            var list = await _repositoryAsync.ListAsync(pagedSpec, cancellationToken);

            var dtos = _mapper.Map<List<TDto>>(list);

            return new PagedResponse<List<TDto>>(
                dtos,
                GetPageNumber(request),
                GetPageSize(request),
                totalRecords
            );
        }
    }
}