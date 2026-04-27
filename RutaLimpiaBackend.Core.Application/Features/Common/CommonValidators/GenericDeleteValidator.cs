using FluentValidation;
using RutaLimpiaBackend.Core.Application.Interfaces;

namespace RutaLimpiaBackend.Core.Application.Features.Common.CommonValidators
{
    public class GenericDeleteValidator<T> : AbstractValidator<T> where T : class, IGenericDeleteValidator
    {
        public GenericDeleteValidator()
        {
            RuleFor(x => x.Id)
                .NotNull().WithMessage("{PropertyName} no puede ser null.")
                .NotEmpty().WithMessage("{PropertyName} no puede estar empty.");
        }
    }
}
