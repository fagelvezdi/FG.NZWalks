using AutoMapper;
using NZWalks.Application.BusinessLogic;
using NZWalks.Application.DataAccess;
using NZWalks.Application.DTO.Region;
using NZWalks.Domain;

namespace NZWalks.BusinessLogic
{
    public class RegionService : IRegionService
    {
        private readonly IRegionRepository regionRepository;
        private readonly IMapper mapper;

        public RegionService(IRegionRepository regionRepository, IMapper mapper)
        {
            this.regionRepository = regionRepository;
            this.mapper = mapper;
        }

        public async Task<RegionDetailsDto> CreateAsync(AddOrUpdateRegionDto addRegionDto)
        {
            // Map from dto model to entity model to create the resource
            var regionModel = mapper.Map<RegionEntity>(addRegionDto);

            var addedRegionEntity = await regionRepository.CreateAsync(regionModel);

            var regionDetailsDto = mapper.Map<RegionDetailsDto>(addedRegionEntity);

            //var regionDetailsDto = RegionDetailsDto.Create(addedRegionEntity);

            return regionDetailsDto;
        }

        public async Task<RegionDetailsDto?> DeleteAsync(Guid id)
        {
            var regionEntity = await regionRepository.GetByIdAsync(id);
            if (regionEntity == null)
            {
                return null;
            }

            await regionRepository.DeleteAsync(regionEntity);

            var regionDetailsDto = mapper.Map<RegionDetailsDto>(regionEntity);

            //var regionDetailsDto = RegionDetailsDto.Create(regionEntity);

            return regionDetailsDto;
        }

        public async Task<List<RegionDetailsDto>> GetAllAsync()
        {
            var regionEntities = await regionRepository.GetAllAsync();
            var regionDtos = mapper.Map<List<RegionDetailsDto>>(regionEntities);

            //var regionDtos = regionEntities.Select(RegionDetailsDto.Create).ToList();
            return regionDtos;
        }

        public async Task<RegionDetailsDto?> GetByIdAsync(Guid id)
        {
            var regionEntity = await regionRepository.GetByIdAsync(id);

            if (regionEntity == null)
            {
                return null;
            }

            var regionDetailsDto = mapper.Map<RegionDetailsDto>(regionEntity);

            //var regionDetailsDto = RegionDetailsDto.Create(regionEntity); 
            
            return regionDetailsDto;
        }

        public async Task<RegionDetailsDto?> UpdateAsync(Guid id, AddOrUpdateRegionDto updateRegionDto)
        {
            var regionEntity = mapper.Map<RegionEntity>(updateRegionDto);

            var updatedRegion = await regionRepository.UpdateAsync(id, regionEntity);

            if (updatedRegion == null)
            {
                return null;
            }

            var regionDetailsDto = mapper.Map<RegionDetailsDto>(updatedRegion);

            //var regionDetailsDto = RegionDetailsDto.Create(updatedRegion);

            return regionDetailsDto;
        }
    }
}
