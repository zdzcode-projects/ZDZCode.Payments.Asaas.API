using Microsoft.AspNetCore.Mvc;
using ZDZCode.Payments.Asaas.DTO.Accountinfo.Response;

namespace ZDZCode.Payments.Asaas.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        private readonly AsaasService _asaasService;


        public WeatherForecastController(ILogger<WeatherForecastController> logger, AsaasService asaasService)
        {
            _logger = logger;
            _asaasService = asaasService;
        }

        [HttpGet(Name = "GetMyAccountAccountNumber")]
        public async Task<MyAccountAccountNumberResponse> Get()
        {
            return await _asaasService.GetMyAccountAccountNumber();
        }
    }
}
