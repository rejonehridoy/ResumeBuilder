using Microsoft.AspNetCore.Http;

namespace Service.Files.Interfaces
{
    public interface IFileService
    {
        Task<int> SaveFileAsync(IFormFile file);
        Task<int> SavePictureFileAsync(IFormFile file);
    }
}
