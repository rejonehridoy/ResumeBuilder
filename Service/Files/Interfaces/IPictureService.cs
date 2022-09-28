using Data.Files;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Files.Interfaces
{
    public interface IPictureService
    {
        Task<int> InsertPictureAsync(Picture picture);
        Task<bool> IsPictureExistByFileName(string fileName);
    }
}
