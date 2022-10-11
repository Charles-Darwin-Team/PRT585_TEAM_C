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
    public class LaptopController : ControllerBase   
    {

        private readonly ILaptopService _LaptopService;
        private readonly ILogger<LaptopController> _logger;

        public LaptopController(ILaptopService LaptopService, ILogger<LaptopController> logger)
        {
            _LaptopService = LaptopService;
            _logger = logger;
        }

        [HttpGet("", Name = "GetAllLaptops")]
        public async Task<List<LaptopDto>> GetAll()
        {
            var result = await _LaptopService.GetAll();
            return result.Select(x => x.ToLaptopDto()).ToList();
        }

        [HttpGet("{LaptopId}", Name = "GetLaptop")]
        public async Task<LaptopDto?> Get(int LaptopId)
        {
            var result = await _LaptopService.GetById(LaptopId);
            return result?.ToLaptopDto();
        }

        [HttpPost, Route("")]
        public async Task<int> Create([FromBody] LaptopDto requestDto)
        {
            var LaptopModel = requestDto.ToLaptopModel();
            return await _LaptopService.CreateLaptop(LaptopModel);
        }

        [HttpPut, Route("update")]
        public async Task<IActionResult> Update([FromBody] LaptopDto requestDto)
        {
            await _LaptopService.UpdateLaptop(requestDto.ToLaptopModel());
            return Ok();
        }

        [HttpDelete, Route("{LaptopId}")]
        public async Task<IActionResult> Delete(int LaptopId)
        {
            await _LaptopService.DeleteLaptop(LaptopId);
            return Ok();
        }
    }
}
