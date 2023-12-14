using ContractMgmt.Application.Contract.Infrastructure.Data;

namespace ContractMgmt.Application.Contract.Infrastructure.Repositories.Interfaces
{
    public interface IContractRepository
    {
        List<Contracts> GetContractDetails();
    }
}
