using System.ComponentModel.DataAnnotations;

namespace NZWalks.Application.DTO.Region
{
    public class AddOrUpdateRegionDto
    {
        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        [MaxLength(3, ErrorMessage = "Code has to be a maximum of 3 characters")]
        [MinLength(3, ErrorMessage = "Code has to be a minimum of 3 characters")]
        public string Code { get; set; } = string.Empty;

        public string? RegionImageUrl { get; set; }
    }
}
