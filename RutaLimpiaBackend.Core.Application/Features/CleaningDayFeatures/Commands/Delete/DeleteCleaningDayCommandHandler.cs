using RutaLimpiaBackend.Core.Application.Features.Common.CommonCommands;
using RutaLimpiaBackend.Core.Application.Interfaces;
using RutaLimpiaBackend.Core.Domain.Entities;

namespace RutaLimpiaBackend.Core.Application.Features.CleaningDayFeatures.Commands.Delete
{
    public class DeleteCleaningDayCommandHandler : DeleteGenericCommandHandler<DeleteCleaningDayCommand, CleaningDay>
    {
        public DeleteCleaningDayCommandHandler(IRepositoryAsync<CleaningDay> repositoryAsync) : base(repositoryAsync)
        {
        }
    }
}