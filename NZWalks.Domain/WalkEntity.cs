using NZWalks.Domain.Common;

namespace NZWalks.Domain
{
    public class WalkEntity : BaseEntity
    {
        public string Description { get; set; } = string.Empty;
        public double LengthInKm { get; set; }
        public string WalkImageUrl { get; set; } = string.Empty;
        
        public Guid DifficultyId { get; set; } 
        public Guid RegionId { get; set; }

        // Navigation properties
        public DifficultyEntity? Difficulty { get; set; }
        public RegionEntity? Region { get; set; }
    }
}
