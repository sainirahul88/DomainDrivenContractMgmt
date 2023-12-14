using ContractMgmt.Application.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ContractMGMT.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContractManagement : ControllerBase
    {
        private readonly IContractService _contractService;

        private readonly ILogger<ContractManagement> _logger;

        public ContractManagement(IContractService contractService, ILogger<ContractManagement> logger)
        {
            _contractService = contractService;
            _logger = logger;
        }

        [HttpGet("GetContractManagementDetailsById/{Id}")]
        public ContentResult GetContractManagementDetailsById(string Id)
        {
            var result = _contractService.GetContractsManagementResponse(Id);
            var jsonResponse = JsonConvert.SerializeObject(result);
            return Content(jsonResponse, "application/json");
        }


        [HttpGet("GetContractDetailsById/{Id}")]
        public ContentResult GetContractDetailsById(string Id)
        {
            var result = _contractService.GetContractDetailsById(Id);
            var jsonResponse = JsonConvert.SerializeObject(result);
            return Content(jsonResponse, "application/json");

        }


    }
}