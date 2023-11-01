using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NZWalks.Application.DataAccess;
using NZWalks.Application.DTO.Walk;
using NZWalks.Domain;
using System.Net;

namespace NZWalks.API.Controllers
{
    // /api/walks
    [Route("api/[controller]")]
    [ApiController]
    public class WalksController : ControllerBase
    {
        private readonly IMapper mapper;
        private readonly IWalkRepository walkRepository;

        public WalksController(IMapper mapper, IWalkRepository walkRepository)
        {
            this.mapper = mapper;
            this.walkRepository = walkRepository;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] AddOrUpdateWalkRequestDto addWalkRequestDto)
        {
            // Map DTO to Domain Model
            var walkModel = mapper.Map<WalkEntity>(addWalkRequestDto);
            await walkRepository.CreateAsync(walkModel);

            // Map Walk Model to a Walk details DTO
            var walkDetailsDto = mapper.Map<WalkDetailsDto>(walkModel);

            return Ok(walkDetailsDto);

        }


        // Get All Walks
        // GET /api/walks?filteron=Name&filterQuery=Track&sortBy=Name&isAsc=true&pageNumber=1&pageSize=10
        [HttpGet]
        public async Task<IActionResult> GetAll(
            [FromQuery] string? filterOn,
            [FromQuery] string? filterQuery,
            [FromQuery] string? sortBy,
            [FromQuery] bool? isAsc,
            [FromQuery] int pageNumber = 1,
            [FromQuery] int pageSize = 5)
        {

            var walksModels = await walkRepository.GetAllAsync(filterOn, filterQuery, sortBy, isAsc ?? true, pageNumber, pageSize);

            throw new Exception("This is a new exception caliing the middleware to handle the error");

            return Ok(mapper.Map<List<WalkDetailsDto>>(walksModels));

        }

        [HttpGet("{id:Guid}")]
        public async Task<IActionResult> GetById([FromRoute] Guid id)
        {
            var walkModel = await walkRepository.GetByIdAsync(id);

            if (walkModel == null)
            {
                return NotFound();
            }

            return Ok(mapper.Map<WalkDetailsDto>(walkModel));

        }

        [HttpPut("{id:Guid}")]
        public async Task<IActionResult> Update([FromRoute] Guid id, [FromBody] AddOrUpdateWalkRequestDto updateWalkRequestDto)
        {
            var walkModel = mapper.Map<WalkEntity>(updateWalkRequestDto);

            walkModel = await walkRepository.UpdateAsync(id, walkModel);

            if (walkModel == null)
            {
                return NotFound();
            }

            var walkDetialsDto = mapper.Map<WalkDetailsDto>(walkModel);

            return Ok(walkDetialsDto);
        }

        [HttpDelete("{id:Guid}")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            var deletedWalkModel = await walkRepository.DeleteAsync(id);

            if (deletedWalkModel == null)
            {
                return NotFound();
            }

            var walkDetailsDto = mapper.Map<WalkDetailsDto>(deletedWalkModel);

            return Ok(walkDetailsDto);

        }
    }
}
