using Ardalis.Specification;
using MapsterMapper;
using RutaLimpiaBackend.Core.Application.DTOs;
using RutaLimpiaBackend.Core.Application.Features.Common.CommonQueries;
using RutaLimpiaBackend.Core.Application.Interfaces;
using RutaLimpiaBackend.Core.Application.Specifications.SectorSpecification;
using RutaLimpiaBackend.Core.Domain.Entities;

namespace RutaLimpiaBackend.Core.Application.Features.SectorFeatures.Queries.GetAll
{
    public class GetAllSectorsQueryHandler : GetAllGenericQueryHandler<GetAllSectorsQuery, Sector, SectorResponseDTO>
    {
        public GetAllSectorsQueryHandler(IReadRepositoryAsync<Sector> repositoryAsync, IMapper mapper) : base(repositoryAsync, mapper)
        {
        }

        protected override int GetPageNumber(GetAllSectorsQuery request) => request.PageNumber;
        protected override int GetPageSize(GetAllSectorsQuery request) => request.PageSize;

        protected override ISpecification<Sector> CreateCountSpecification(GetAllSectorsQuery request)
        {
            return new SectorSpecification(-1, -1);
        }

        protected override ISpecification<Sector> CreatePagedSpecification(GetAllSectorsQuery request)
        {
            return new SectorSpecification(request.PageSize, request.PageNumber);
        }
    }
}