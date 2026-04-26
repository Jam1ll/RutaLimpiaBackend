using FluentValidation.Results;

namespace RutaLimpiaBackend.Core.Application.Exceptions
{
    public class ValidationException : Exception
    {
        public List<string> Errors { get; }

        public ValidationException() : base("One or more errors have occurred")
        {
            Errors = [];
        }

        public ValidationException(IEnumerable<ValidationFailure> failures) : this()
        {
            foreach (var failure in failures)
            {
                Errors.Add(failure.ErrorMessage);
            }
        }
    }
}
