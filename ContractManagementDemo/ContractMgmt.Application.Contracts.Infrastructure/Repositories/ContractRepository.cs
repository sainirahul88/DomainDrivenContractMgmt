using ContractMgmt.Application.Contract.Infrastructure.Data;
using ContractMgmt.Application.Contract.Infrastructure.Repositories.Interfaces;
using Newtonsoft.Json;

namespace ContractMgmt.Application.Contract.Infrastructure.Repositories
{
    public class ContractRepository : IContractRepository
    {
        public List<Contracts> GetContractDetails()
        {

            List<Contracts> obj = new List<Contracts>();
            var jsonContracts = File.ReadAllText(@"./JSONfiles/Contracts.json");
            obj = JsonConvert.DeserializeObject<List<Contracts>>(jsonContracts);
            return obj;
        }

    }
}
