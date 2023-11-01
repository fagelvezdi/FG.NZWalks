using NZWalks.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NZWalks.Application.DataAccess
{
    public interface IWalkRepository
    {
        Task<WalkEntity> CreateAsync(WalkEntity walkEntity);

        Task<List<WalkEntity>> GetAllAsync(
            string? filterOn = null, 
            string? filterQuery = null, 
            string? sortBy = null, 
            bool isAsc = true,
            int pageNumber = 1,
            int pageSize = 5);

        Task<WalkEntity?> GetByIdAsync(Guid id);

        Task<WalkEntity?> UpdateAsync(Guid id, WalkEntity walkEntity);

        Task<WalkEntity?> DeleteAsync(Guid id);
    }
}
