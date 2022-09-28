using Core.Enums;
using Data.Files;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Service.Files.Interfaces;

namespace Service.Files
{
    public class FileService : IFileService
    {
        private readonly IHostingEnvironment environment;
        private readonly IPictureService pictureService;

        public FileService(IHostingEnvironment environment,
            IPictureService pictureService)
        {
            this.environment = environment;
            this.pictureService = pictureService;
        }
        public Task<int> SaveFileAsync(IFormFile file)
        {
            throw new NotImplementedException();
        }

        public async Task<int> SavePictureFileAsync(IFormFile file)
        {
            int fileCopy = 1;
            string tempCopy = "";
            string fileExtention = file.FileName.Split('.').Last();
            string fileName = (file.FileName.Split('.').First()).Replace(" ","_");
            string tempFileName = fileName + tempCopy + "." + fileExtention;
            while (await pictureService.IsPictureExistByFileName(tempFileName))
            {
                tempCopy = "_Copy(" + fileCopy + ")";
                fileCopy++;
                tempFileName = fileName + tempCopy + "." + fileExtention;
            }
            fileName = fileName + tempCopy + "." + fileExtention;
            var filePath = Path.Combine(environment.ContentRootPath, "wwwroot/images/uploaded", fileName);
            using var fileStream = new FileStream(filePath, FileMode.Create);
            await file.CopyToAsync(fileStream);

            // get File bytes
            await using var memoryStream = new MemoryStream();
            await file.CopyToAsync(memoryStream);

            var picture = new Picture
            {
                FileName = fileName,
                DirectoryPath = "/images/uploaded/" + fileName,
                MimeType = file.ContentType,
                BinaryData = memoryStream.ToArray()
            };
            int pictureId = await pictureService.InsertPictureAsync(picture);
            return pictureId;

        }
    }
}
