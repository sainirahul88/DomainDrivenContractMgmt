using ContractMgmt.Application.Product.Infrastructure.Data;

namespace ContractMgmt.Application.Product.Infrastructure.Repositories.Interfaces
{
    public interface IProductRepository
    {
        List<Products> GetProductDetails();
    }
}
