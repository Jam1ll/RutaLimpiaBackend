using Ardalis.Specification;
using MapsterMapper;
using RutaLimpiaBackend.Core.Application.DTOs;
using RutaLimpiaBackend.Core.Application.Features.Common.CommonQueries;
using RutaLimpiaBackend.Core.Application.Interfaces;
using RutaLimpiaBackend.Core.Application.Specifications.ReportSpecifications;
using RutaLimpiaBackend.Core.Domain.Entities;

namespace RutaLimpiaBackend.Core.Application.Features.ReportFeatures.Queries.GetById
{
    public class GetReportByIdQueryHandler : GetByIdGenericQueryHandler<GetReportByIdQuery, Report, ReportResponseDTO>
    {
        public GetReportByIdQueryHandler(IReadRepositoryAsync<Report> repositoryAsync, IMapper mapper) : base(repositoryAsync, mapper)
        {
        }

        protected override Guid GetEntityId(GetReportByIdQuery request) => request.Id;

        protected override ISpecification<Report> CreateSpecification(GetReportByIdQuery request)
        {
            return new ReportByIdSpecification(request.Id);
        }
    }
}