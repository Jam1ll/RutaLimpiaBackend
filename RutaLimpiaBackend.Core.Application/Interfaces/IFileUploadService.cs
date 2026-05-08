using Microsoft.AspNetCore.Http;

namespace RutaLimpiaBackend.Core.Application.Interfaces
{
    public interface IFileUploadService
    {
        Task<string> UploadFileAsync(IFormFile file, string folderName);
    }
}