using ContractMgmt.Application.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ContractMGMT.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductManagement : ControllerBase
    {
        private readonly IContractService _contractService;

        private readonly ILogger<ProductManagement> _logger;

        public ProductManagement(IContractService contractService, ILogger<ProductManagement> logger)
        {
            _contractService = contractService;
            _logger = logger;
        }


        [HttpGet("GetProductDetailsById/{Id}")]
        public ContentResult GetProductDetailsById(string Id)
        {
            var result = _contractService.GetProductDetailsById(Id);
            var jsonResponse = JsonConvert.SerializeObject(result);
            return Content(jsonResponse, "application/json");

        }


    }
}