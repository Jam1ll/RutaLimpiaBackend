using MapsterMapper;
using RutaLimpiaBackend.Core.Application.Features.Common.CommonCommands;
using RutaLimpiaBackend.Core.Application.Interfaces;
using RutaLimpiaBackend.Core.Domain.Entities;

namespace RutaLimpiaBackend.Core.Application.Features.CleaningDayFeatures.Commands.Create
{
    public class CreateCleaningDayCommandHandler : CreateGenericCommandHandler<CreateCleaningDayCommand, CleaningDay>
    {
        public CreateCleaningDayCommandHandler(IRepositoryAsync<CleaningDay> repositoryAsync, IMapper mapper) : base(repositoryAsync, mapper)
        {
        }
    }
}