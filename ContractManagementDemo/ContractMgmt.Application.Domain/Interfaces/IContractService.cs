using ContractMgmt.Application.Model;

namespace ContractMgmt.Application.Domain.Interfaces
{
    public interface IContractService
    {
        Contracts GetContractsManagementResponse(string Id);
        ContractResult GetContractDetailsById(string Id);
        ProductsResult GetProductDetailsById(string Id);
    }
}
