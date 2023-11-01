using NZWalks.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NZWalks.DataAccess.Persistence
{
    public interface IRegionRepository
    {
        Task<List<RegionEntity>> GetAllAsync();

        Task<RegionEntity?> GetByIdAsync(Guid id);

        Task<RegionEntity> CreateAsync(RegionEntity regionEntity);

        Task<RegionEntity?> UpdateAsync(Guid id, RegionEntity regionEntity);

        Task DeleteAsync(RegionEntity regionEntity);
    }
}
