using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NZWalks.API.CustomActionFilters;
using NZWalks.Application.BusinessLogic;
using NZWalks.Application.DTO.Region;
using System.Text.Json;

namespace NZWalks.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class RegionsController : ControllerBase
    {
        private readonly IRegionService regionService;
        private readonly ILogger<RegionsController> logger;

        public RegionsController(IRegionService regionService, ILogger<RegionsController> logger)
        {
            this.regionService = regionService;
            this.logger = logger;
        }

        [HttpGet]
        [Authorize(Roles = "Reader,Writer")]
        public async Task<IActionResult> GetAll()
        {
            logger.LogInformation("GetAll Regions method was invoked");
            logger.LogWarning("This a Warning log");
            logger.LogError("This an Error log");

            try
            {
                //throw new Exception("Exeption was thrown!");
                var regions = await regionService.GetAllAsync();
                logger.LogInformation($"Finished GetAllRegions request with data: {JsonSerializer.Serialize(regions)}");
                return Ok(regions);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, $"Finished with some errors:", ex.Message);
                throw;
            }
        }

        [HttpGet("{id:Guid}")]
        [Authorize(Roles = "Reader")]
        public async Task<IActionResult> GetById([FromRoute] Guid id)
        {
            var region = await regionService.GetByIdAsync(id);

            if (region == null)
            {
                return NotFound();
            }

            return Ok(region);
        }

        // POST: To create new resource
        [HttpPost]
        [ValidateModel]
        [Authorize(Roles = "Writer")]
        public async Task<IActionResult> Create([FromBody] AddOrUpdateRegionDto addRegionDto)
        {
            var addedRegion = await regionService.CreateAsync(addRegionDto);

            if (addedRegion == null)
            {
                return BadRequest();
            }

            // Return 201 status for a created resource sucessfully 
            return CreatedAtAction(nameof(GetById), new { id = addedRegion.Id }, addedRegion);


        }

        [HttpPut("{id:Guid}")]
        [ValidateModel]
        [Authorize(Roles = "Writer")]
        public async Task<IActionResult> Update([FromRoute] Guid id, [FromBody] AddOrUpdateRegionDto updateRegionDto)
        {
            var updatedRegion = await regionService.UpdateAsync(id, updateRegionDto);
            
            if(updatedRegion == null)
            {
                return NotFound();
            }

            return Ok(updatedRegion);
        }

        [HttpDelete("{id:Guid}")]
        [Authorize(Roles = "Writer")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            var deletedRegion = await regionService.DeleteAsync(id);

            if(deletedRegion == null) 
            { 
                return NotFound(); 
            }

            return Ok(deletedRegion);
        }
    }
}
