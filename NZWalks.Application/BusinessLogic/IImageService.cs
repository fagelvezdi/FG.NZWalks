using NZWalks.Application.DTO.Image;
using NZWalks.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NZWalks.Application.BusinessLogic
{
    public interface IImageService
    {
        Task<Image> Upload(ImageUploadRequestDto request);
    }
}
