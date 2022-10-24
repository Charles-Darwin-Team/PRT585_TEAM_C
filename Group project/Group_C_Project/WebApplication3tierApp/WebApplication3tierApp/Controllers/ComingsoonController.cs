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
    public class ComingsoonController : ControllerBase   
    {

        private readonly IComingsoonService _ComingsoonService;
        private readonly ILogger<ComingsoonController> _logger;

        public ComingsoonController(IComingsoonService ComingsoonService, ILogger<ComingsoonController> logger)
        {
            _ComingsoonService = ComingsoonService;
            _logger = logger;
        }

        [HttpGet("", Name = "GetAllComingsoons")]
        public async Task<List<ComingsoonDto>> GetAll()
        {
            var result = await _ComingsoonService.GetAll();
            return result.Select(x => x.ToComingsoonDto()).ToList();
        }

        [HttpGet("{ComingsoonId}", Name = "GetComingsoon")]
        public async Task<ComingsoonDto?> Get(int ComingsoonId)
        {
            var result = await _ComingsoonService.GetById(ComingsoonId);
            return result?.ToComingsoonDto();
        }

        [HttpPost, Route("")]
        public async Task<int> Create([FromBody] ComingsoonDto requestDto)
        {
            var ComingsoonModel = requestDto.ToComingsoonModel();
            return await _ComingsoonService.CreateComingsoon(ComingsoonModel);
        }

        [HttpPut, Route("{Id}")]
        public async Task<IActionResult> Update([FromBody] ComingsoonDto requestDto)
        {
            await _ComingsoonService.UpdateComingsoon(requestDto.ToComingsoonModel());
            return Ok();
        }

        [HttpDelete, Route("{Id}")]
        public async Task<IActionResult> Delete(int ComingsoonId)
        {
            await _ComingsoonService.DeleteComingsoon(ComingsoonId);
            return Ok();
        }
    }
}
