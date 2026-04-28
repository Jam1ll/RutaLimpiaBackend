using Ardalis.Specification;
using MapsterMapper;
using RutaLimpiaBackend.Core.Application.DTOs;
using RutaLimpiaBackend.Core.Application.Features.Common.CommonQueries;
using RutaLimpiaBackend.Core.Application.Interfaces;
using RutaLimpiaBackend.Core.Application.Specifications.ReportSpecifications;
using RutaLimpiaBackend.Core.Domain.Entities;

namespace RutaLimpiaBackend.Core.Application.Features.ReportFeatures.Queries.GetAll
{
    public class GetAllReportsQueryHandler : GetAllGenericQueryHandler<GetAllReportsQuery, Report, ReportResponseDTO>
    {
        public GetAllReportsQueryHandler(IReadRepositoryAsync<Report> repositoryAsync, IMapper mapper) : base(repositoryAsync, mapper)
        {
        }

        protected override int GetPageNumber(GetAllReportsQuery request) => request.PageNumber;
        protected override int GetPageSize(GetAllReportsQuery request) => request.PageSize;

        protected override ISpecification<Report> CreateCountSpecification(GetAllReportsQuery request)
        {
            return new ReportSpecification(-1, -1);
        }

        protected override ISpecification<Report> CreatePagedSpecification(GetAllReportsQuery request)
        {
            return new ReportSpecification(request.PageSize, request.PageNumber);
        }
    }
}