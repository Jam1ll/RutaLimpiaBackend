using MapsterMapper;
using RutaLimpiaBackend.Core.Application.Features.Common.CommonCommands;
using RutaLimpiaBackend.Core.Application.Interfaces;
using RutaLimpiaBackend.Core.Domain.Entities;

namespace RutaLimpiaBackend.Core.Application.Features.CleaningDayFeatures.Commands.Update
{
    internal class UpdateCleaningDayCommandHandler : UpdateGenericCommandHandler<UpdateCleaningDayCommand, CleaningDay>
    {
        public UpdateCleaningDayCommandHandler(IRepositoryAsync<CleaningDay> repositoryAsync, IMapper mapper) : base(repositoryAsync, mapper)
        {
        }
    }
}