using MediatR;
using MapsterMapper;
using RutaLimpiaBackend.Core.Application.Wrappers;
using RutaLimpiaBackend.Core.Application.Interfaces;
using RutaLimpiaBackend.Core.Domain.Entities;

namespace RutaLimpiaBackend.Core.Application.Features.ReportFeatures.Commands.Create
{
    public class CreateReportCommandHandler : IRequestHandler<CreateReportCommand, Response<Guid>>
    {
        private readonly IRepositoryAsync<Report> _repository;
        private readonly IMapper _mapper;
        private readonly IFileUploadService _fileUploadService;

        public CreateReportCommandHandler(
            IRepositoryAsync<Report> repository,
            IMapper mapper,
            IFileUploadService fileUploadService)
        {
            _repository = repository;
            _mapper = mapper;
            _fileUploadService = fileUploadService;
        }

        public async Task<Response<Guid>> Handle(CreateReportCommand request, CancellationToken cancellationToken)
        {
            string photoUrl = string.Empty;

            if (request.Photo != null && request.Photo.Length > 0)
            {
                photoUrl = await _fileUploadService.UploadFileAsync(request.Photo, "reports");
            }

            var newReport = _mapper.Map<Report>(request);

            newReport.PhotoUrl = photoUrl;

            await _repository.AddAsync(newReport, cancellationToken);

            return new Response<Guid>(newReport.Id, "Reporte creado exitosamente.");
        }
    }
}