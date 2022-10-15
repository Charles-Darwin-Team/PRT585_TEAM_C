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
    public class VehicleController : ControllerBase   
    {

        private readonly IVehicleService _VehicleService;
        private readonly ILogger<VehicleController> _logger;

        public VehicleController(IVehicleService VehicleService, ILogger<VehicleController> logger)
        {
            _VehicleService = VehicleService;
            _logger = logger;
        }

        [HttpGet("", Name = "GetAllVehicles")]
        public async Task<List<VehicleDto>> GetAll()
        {
            var result = await _VehicleService.GetAll();
            return result.Select(x => x.ToVehicleDto()).ToList();
        }

        [HttpGet("{VehicleId}", Name = "GetVehicle")]
        public async Task<VehicleDto?> Get(int VehicleId)
        {
            var result = await _VehicleService.GetById(VehicleId);
            return result?.ToVehicleDto();
        }

        [HttpPost, Route("")]
        public async Task<int> Create([FromBody] VehicleDto requestDto)
        {
            var VehicleModel = requestDto.ToVehicleModel();
            return await _VehicleService.CreateVehicle(VehicleModel);
        }

        [HttpPut, Route("update")]
        public async Task<IActionResult> Update([FromBody] VehicleDto requestDto)
        {
            await _VehicleService.UpdateVehicle(requestDto.ToVehicleModel());
            return Ok();
        }

        [HttpDelete, Route("{VehicleId}")]
        public async Task<IActionResult> Delete(int VehicleId)
        {
            await _VehicleService.DeleteVehicle(VehicleId);
            return Ok();
        }
    }
}
