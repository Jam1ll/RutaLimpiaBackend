using RutaLimpiaBackend.Core.Domain.Entities;

namespace RutaLimpiaBackend.Core.Application.Specifications.ReportSpecifications
{
    public class ReportSpecification : PagedGeneralSpecification<Report>
    {
        public ReportSpecification(int pageSize, int pageNumber) : base(pageSize, pageNumber)
        {
        }
    }
}