using Ardalis.Specification;
using RutaLimpiaBackend.Core.Domain.Entities;

namespace RutaLimpiaBackend.Core.Application.Specifications.ReportSpecifications
{
    public class ReportByIdSpecification : Specification<Report, ISingleResultSpecification<Report>>
    {
        public ReportByIdSpecification(Guid id)
        {
            Query.Where(x => x.Id == id);
        }
    }
}