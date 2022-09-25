using Data.Files;
using OA.Repo;
using Service.Files.Interfaces;

namespace Service.Files
{
    public class PictureService : IPictureService
    {
        private readonly IRepository<Picture> pictureRepository;

        public PictureService(IRepository<Picture> pictureRepository)
        {
            this.pictureRepository = pictureRepository;
        }
        public async Task<int> InsertPictureAsync(Picture picture)
        {
            await pictureRepository.InsertAsync(picture);
            return picture.Id;
        }
    }
}
