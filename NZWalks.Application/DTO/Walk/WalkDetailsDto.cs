using NZWalks.Application.DTO.Difficulty;
using NZWalks.Application.DTO.Region;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NZWalks.Application.DTO.Walk
{
    public class WalkDetailsDto
    {
        public Guid Id { get; set; }
        
        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;
        public double LengthInKm { get; set; }
        public string WalkImageUrl { get; set; } = string.Empty;

        public RegionDetailsDto? Region { get; set; }
        public DifficultyDetailsDto? Difficulty { get; set; }
    }
}
