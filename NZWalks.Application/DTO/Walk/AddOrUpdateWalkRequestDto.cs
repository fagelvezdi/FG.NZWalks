using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NZWalks.Application.DTO.Walk
{
    public class AddOrUpdateWalkRequestDto
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public double LengthInKm { get; set; }
        public string WalkImageUrl { get; set; } = string.Empty;

        public Guid DifficultyId { get; set; }
        public Guid RegionId { get; set; }
    }
}
