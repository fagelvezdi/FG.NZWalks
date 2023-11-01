using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NZWalks.Application.BusinessLogic;
using NZWalks.Application.DTO.Image;

namespace NZWalks.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImagesController : ControllerBase
    {
        private readonly IImageService imageService;

        public ImagesController(IImageService imageService)
        {
            this.imageService = imageService;
        }


        //POST: /api/Images/Upload
        [HttpPost("Upload")]
        public async Task<IActionResult> Upload([FromForm] ImageUploadRequestDto requestDto)
        {
            ValidateFileUpload(requestDto);

            if(ModelState.IsValid)
            {
               var uploadedImage = await imageService.Upload(requestDto);

                return Ok(uploadedImage);
            }

            return BadRequest(ModelState);

        }

        private void ValidateFileUpload(ImageUploadRequestDto requestDto)
        {
            // Validating file extension
            var allowedExtensions = new string[] { ".jpg", ".jpeg", ".png" };
            if(!allowedExtensions.Contains(Path.GetExtension(requestDto.File.FileName))) 
            {
                ModelState.AddModelError("file", "Unsupported file extension");
            }

            // Validate file size
            if(requestDto.File.Length > 5242880)
            {
                ModelState.AddModelError("file", "File size more that 5MB.");
            }
        }
    }
}
