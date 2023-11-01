using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using NZWalks.Application.BusinessLogic;
using NZWalks.Application.DataAccess;
using NZWalks.Application.DTO.Image;
using NZWalks.Domain;

namespace NZWalks.BusinessLogic
{
    public class ImageService : IImageService
    {
        private readonly IImageRepository imageRepository;
        private readonly IWebHostEnvironment webHostEnvironment;
        private readonly IHttpContextAccessor httpContextAccessor;

        public ImageService(IImageRepository imageRepository, IWebHostEnvironment webHostEnvironment, IHttpContextAccessor httpContextAccessor)
        {
            this.imageRepository = imageRepository;
            this.webHostEnvironment = webHostEnvironment;
            this.httpContextAccessor = httpContextAccessor;
        }

        public async Task<Image> Upload(ImageUploadRequestDto request)
        {
            var imageDomainModel = new Image
            {
                File = request.File,
                FileExtension = Path.GetExtension(request.File.FileName),
                FileSizeInBytes = request.File.Length,
                FileName = request.FileName,
                FileDescription = request.FileDescription
            };

            var localFilePath = Path.Combine(webHostEnvironment.ContentRootPath, "Images", $"{imageDomainModel.FileName}{imageDomainModel.FileExtension}");

            // Upload image to the local path
            using var stream = new FileStream(localFilePath, FileMode.Create);
            await imageDomainModel.File.CopyToAsync(stream);

            // https://localhost:1234/images/image.jpg
            var urlFilePath = $"{httpContextAccessor.HttpContext.Request.Scheme}://" +
                $"{httpContextAccessor.HttpContext.Request.Host}" +
                $"{httpContextAccessor.HttpContext.Request.PathBase}/Images/" +
                $"{imageDomainModel.FileName}{imageDomainModel.FileExtension}";

            imageDomainModel.FilePath = urlFilePath;

            // Save to Database in images Table

            var savedImage = await imageRepository.Upload(imageDomainModel);

            return savedImage;
        }
    }
}
