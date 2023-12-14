using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContractMgmt.Application.Contract.Infrastructure.Data
{
   
    public class Contracts
    {
        public string id { get; set; }
        public string Name { get; set; }
        public int CountryId { get; set; }
    }
}
