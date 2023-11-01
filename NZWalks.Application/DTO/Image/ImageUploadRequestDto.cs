﻿using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace NZWalks.Application.DTO.Image
{
    public class ImageUploadRequestDto
    {
        [Required]
        public IFormFile File { get; set; }

        [Required]
        public string FileName { get; set; }

        public string? FileDescription { get; set; }
    }
}
