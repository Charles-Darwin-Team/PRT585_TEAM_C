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
    public class PlayerController : ControllerBase   
    {

        private readonly IPlayerService _PlayerService;
        private readonly ILogger<PlayerController> _logger;

        public PlayerController(IPlayerService PlayerService, ILogger<PlayerController> logger)
        {
            _PlayerService = PlayerService;
            _logger = logger;
        }

        [HttpGet("", Name = "GetAllPlayers")]
        public async Task<List<PlayerDto>> GetAll()
        {
            var result = await _PlayerService.GetAll();
            return result.Select(x => x.ToPlayerDto()).ToList();
        }

        [HttpGet("{PlayerId}", Name = "GetPlayer")]
        public async Task<PlayerDto?> Get(int PlayerId)
        {
            var result = await _PlayerService.GetById(PlayerId);
            return result?.ToPlayerDto();
        }

        [HttpPost, Route("")]
        public async Task<int> Create([FromBody] PlayerDto requestDto)
        {
            var PlayerModel = requestDto.ToPlayerModel();
            return await _PlayerService.CreatePlayer(PlayerModel);
        }

        [HttpPut, Route("update")]
        public async Task<IActionResult> Update([FromBody] PlayerDto requestDto)
        {
            await _PlayerService.UpdatePlayer(requestDto.ToPlayerModel());
            return Ok();
        }

        [HttpDelete, Route("{PlayerId}")]
        public async Task<IActionResult> Delete(int PlayerId)
        {
            await _PlayerService.DeletePlayer(PlayerId);
            return Ok();
        }
    }
}
