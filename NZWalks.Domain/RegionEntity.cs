using NZWalks.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NZWalks.Domain
{
    public class RegionEntity : BaseEntity
    {
        public string Code { get; set; } = string.Empty;

        public string RegionImageUrl { get; set; } = string.Empty;
    }
}
