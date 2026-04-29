using RutaLimpiaBackend.Core.Application.Interfaces;
using RutaLimpiaBackend.Core.Application.Interfaces.CommonHandlers;

namespace RutaLimpiaBackend.Core.Application.Features.CleaningDayFeatures.Commands.Delete
{
    public class DeleteCleaningDayCommand : IGenericDeleteValidator, IDeleteRequest
    {
        public Guid Id { get; set; }
    }
}