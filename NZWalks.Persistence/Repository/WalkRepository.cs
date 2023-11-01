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
    public class WalkRepository : IWalkRepository
    {
        private readonly NZWalksDbContext dbContext;

        public WalkRepository(NZWalksDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<WalkEntity> CreateAsync(WalkEntity walkEntity)
        {
            await dbContext.AddAsync(walkEntity);
            await dbContext.SaveChangesAsync();

            return walkEntity;
        }

        public async Task<WalkEntity?> DeleteAsync(Guid id)
        {
            var existingWalk = await dbContext.Walks
                .Include("Difficulty")
                .Include("Region")
                .FirstOrDefaultAsync(x => x.Id == id);

            if(existingWalk == null) 
            {
                return null;
            }

            dbContext.Walks.Remove(existingWalk);
            await dbContext.SaveChangesAsync();
        
            return existingWalk;
        }

        public async Task<List<WalkEntity>> GetAllAsync(
            string? filterOn = null,
            string? filterQuery = null,
            string? sortBy = null,
            bool isAsc = true,
            int pageNumber = 1,
            int pageSize = 5)
        {
            var walksDetails = dbContext.Walks.Include("Difficulty").Include("Region").AsQueryable();

            // Filtering
            if(!string.IsNullOrWhiteSpace(filterOn) && !string.IsNullOrWhiteSpace(filterQuery))
            {
                if(filterOn.Equals("Name", StringComparison.OrdinalIgnoreCase))
                {
                    walksDetails = walksDetails.Where(x => x.Name.Contains(filterQuery));
                }
            }

            // Sorting
            if(!string.IsNullOrWhiteSpace(sortBy))
            {
                if(sortBy.Equals("Name", StringComparison.OrdinalIgnoreCase))
                {
                    walksDetails = isAsc ? walksDetails.OrderBy(x => x.Name) : walksDetails.OrderByDescending(x => x.Name);
                }
                else if(sortBy.Equals("Length", StringComparison.OrdinalIgnoreCase))
                {
                    walksDetails = isAsc ? walksDetails.OrderBy(x => x.LengthInKm) : walksDetails.OrderByDescending(x => x.LengthInKm);
                }
            }

            // Pagination
            var skipResults = (pageNumber - 1) * pageSize;

            //var walksDetails = 
            //    await dbContext.Walks
            //    .Include("Difficulty")
            //    .Include("Region")
            //    .ToListAsync();

            return await walksDetails.Skip(skipResults).Take(pageSize).ToListAsync();
        }

        public async Task<WalkEntity?> GetByIdAsync(Guid id)
        {
            var walkDetails = 
                await dbContext.Walks
                .Include("Difficulty")
                .Include("Region")
                .FirstOrDefaultAsync(x => x.Id == id);

            return walkDetails;
        }

        public async Task<WalkEntity?> UpdateAsync(Guid id, WalkEntity walkEntity)
        {
            var existingWalkEntity = await dbContext.Walks
                .Include("Difficulty")
                .Include("Region")
                .FirstOrDefaultAsync(x => x.Id == id);
            if(existingWalkEntity == null) 
            {
                return null;
            }

            existingWalkEntity.Name = walkEntity.Name;
            existingWalkEntity.Description = walkEntity.Description;
            existingWalkEntity.LengthInKm = walkEntity.LengthInKm;
            existingWalkEntity.WalkImageUrl = walkEntity.WalkImageUrl;
            existingWalkEntity.DifficultyId = walkEntity.DifficultyId;
            existingWalkEntity.RegionId = walkEntity.RegionId;

            await dbContext.SaveChangesAsync();

            return existingWalkEntity;
        }
    }
}
