using Ardalis.Specification;

namespace RutaLimpiaBackend.Core.Application.Specifications
{
    public class PagedGeneralSpecification<T> : Specification<T>
    {
        public PagedGeneralSpecification(int pageSize, int pageNumber)
        {
            if (pageSize > 0)
            {
                Query.Skip((pageNumber - 1) * pageSize)
                .Take(pageSize);
            }

        }
    }
}
