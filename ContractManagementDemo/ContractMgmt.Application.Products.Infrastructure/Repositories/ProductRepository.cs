using ContractMgmt.Application.Product.Infrastructure.Data;
using ContractMgmt.Application.Product.Infrastructure.Repositories.Interfaces;
using Newtonsoft.Json;

namespace ContractMgmt.Application.Product.Infrastructure.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public List<Products> GetProductDetails()
        {

            List<Products> obj = new List<Products>();
            var jsonProducts = File.ReadAllText(@"./JSONfiles/Products.json");
            obj = JsonConvert.DeserializeObject<List<Products>>(jsonProducts);
            return obj;
        }

    }
}
