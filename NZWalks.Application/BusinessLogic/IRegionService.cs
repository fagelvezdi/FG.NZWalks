using NZWalks.Application.DTO.Region;
using NZWalks.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NZWalks.Application.BusinessLogic
{
    public interface IRegionService
    {
        Task<List<RegionDetailsDto>> GetAllAsync();

        Task<RegionDetailsDto?> GetByIdAsync(Guid id);

        Task<RegionDetailsDto> CreateAsync(AddOrUpdateRegionDto addRegionDto);

        Task<RegionDetailsDto?> UpdateAsync(Guid id, AddOrUpdateRegionDto updateRegionDto);

        Task<RegionDetailsDto?> DeleteAsync(Guid id);
    }
}
