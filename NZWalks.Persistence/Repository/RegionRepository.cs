using Microsoft.EntityFrameworkCore;
using NZWalks.Application.DataAccess;
using NZWalks.Domain;
using NZWalks.Persistence.DatabaseContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NZWalks.Persistence.Repository
{
    public class RegionRepository : IRegionRepository
    {
        private readonly NZWalksDbContext dbContext;

        public RegionRepository(NZWalksDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<RegionEntity> CreateAsync(RegionEntity regionEntity)
        {
            await dbContext.Regions.AddAsync(regionEntity);
            await dbContext.SaveChangesAsync();
            return regionEntity;
        }

        public async Task DeleteAsync(RegionEntity regionEntity)
        {
            dbContext.Regions.Remove(regionEntity);
            await dbContext.SaveChangesAsync();
        }

        public async Task<List<RegionEntity>> GetAllAsync()
        {
            var regions = await dbContext.Regions.ToListAsync();

            return regions;
        }

        public async Task<RegionEntity?> GetByIdAsync(Guid id)
        {
            var region = await dbContext.Regions.FirstOrDefaultAsync(r => r.Id == id);
            
            return region ?? null;
        }

        public async Task<RegionEntity?> UpdateAsync(Guid id, RegionEntity regionEntity)
        {
            var region = await dbContext.Regions.FirstOrDefaultAsync(r =>r.Id == id);

            if (region == null) 
            { 
                return null; 
            }

            region.RegionImageUrl = regionEntity.RegionImageUrl;
            region.Name = regionEntity.Name;
            region.Code = regionEntity.Code;

            await dbContext.SaveChangesAsync();
            return region;

        }
    }
}
