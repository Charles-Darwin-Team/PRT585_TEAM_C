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
    public class PhoneController : ControllerBase   
    {

        private readonly IPhoneService _PhoneService;
        private readonly ILogger<PhoneController> _logger;

        public PhoneController(IPhoneService PhoneService, ILogger<PhoneController> logger)
        {
            _PhoneService = PhoneService;
            _logger = logger;
        }

        [HttpGet("", Name = "GetAllPhones")]
        public async Task<List<PhoneDto>> GetAll()
        {
            var result = await _PhoneService.GetAll();
            return result.Select(x => x.ToPhoneDto()).ToList();
        }

        [HttpGet("{PhoneId}", Name = "GetPhone")]
        public async Task<PhoneDto?> Get(int PhoneId)
        {
            var result = await _PhoneService.GetById(PhoneId);
            return result?.ToPhoneDto();
        }

        [HttpPost, Route("")]
        public async Task<int> Create([FromBody] PhoneDto requestDto)
        {
            var PhoneModel = requestDto.ToPhoneModel();
            return await _PhoneService.CreatePhone(PhoneModel);
        }

        [HttpPut, Route("update")]
        public async Task<IActionResult> Update([FromBody] PhoneDto requestDto)
        {
            await _PhoneService.UpdatePhone(requestDto.ToPhoneModel());
            return Ok();
        }

        [HttpDelete, Route("{PhoneId}")]
        public async Task<IActionResult> Delete(int PhoneId)
        {
            await _PhoneService.DeletePhone(PhoneId);
            return Ok();
        }
    }
}
