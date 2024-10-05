using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ZDZCode.Payments.Asaas.DTO.Accountinfo.Response;

namespace ZDZCode.Payments.Asaas.API.Controllers.Asaas
{
    [Route("api/[controller]")]
    [ApiController]
    public partial class AsaasMyAccountController : ControllerBase
    {
        private readonly AsaasService _asaasService;

        public AsaasMyAccountController(AsaasService asaasService)
        {
            _asaasService = asaasService;
        }

        [HttpGet("commercialInfo")]
        public async Task<MyAccountAccountNumberResponse> GetMyAccountAccountNumber()
        {
            return await _asaasService.GetMyAccountAccountNumber();
        }
    }
}
