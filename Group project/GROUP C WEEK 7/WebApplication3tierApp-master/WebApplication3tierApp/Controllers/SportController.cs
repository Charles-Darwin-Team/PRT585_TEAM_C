using _2DataAccessLayer.Services;
using _3BusinessLogicLayer.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication3tierApp.Models;

namespace WebApplication3tierApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class SportController : ControllerBase   
    {

        private readonly ISportService _SportService;
        private readonly ILogger<SportController> _logger;

        public SportController(ISportService SportService, ILogger<SportController> logger)
        {
            _SportService = SportService;
            _logger = logger;
        }

        [HttpGet("", Name = "GetAllSports")]
        public async Task<List<SportDto>> GetAll()
        {
            var result = await _SportService.GetAll();
            return result.Select(x => x.ToSportDto()).ToList();
        }

        [HttpGet("{SportId}", Name = "GetSport")]
        public async Task<SportDto?> Get(int SportId)
        {
            var result = await _SportService.GetById(SportId);
            return result?.ToSportDto();
        }

        [HttpPost, Route("")]
        public async Task<int> Create([FromBody] SportDto requestDto)
        {
            var SportModel = requestDto.ToSportModel();
            return await _SportService.CreateSport(SportModel);
        }

        [HttpPut, Route("update")]
        public async Task<IActionResult> Update([FromBody] SportDto requestDto)
        {
            await _SportService.UpdateSport(requestDto.ToSportModel());
            return Ok();
        }

        [HttpDelete, Route("{SportId}")]
        public async Task<IActionResult> Delete(int SportId)
        {
            await _SportService.DeleteSport(SportId);
            return Ok();
        }
    }
}
