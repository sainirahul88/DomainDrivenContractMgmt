using ContractMgmt.Application.Domain.Interfaces;
using ContractMgmt.Application.Contract.Infrastructure.Repositories.Interfaces;
using ContractMgmt.Application.Model;
using ContractMgmt.Application.Product.Infrastructure.Repositories.Interfaces;
using Microsoft.Extensions.Logging;
using ContractMgmt.Application.Contract.Infrastructure.Data;

namespace ContractMgmt.Application.Domain.Services
{
    public class ContractService : IContractService
    {
        private IContractRepository _contractRepository;
        private IProductRepository _productRepository;
        private readonly ILogger<ContractService> _logger;

        public ContractService(IContractRepository contractRepository, IProductRepository productRepository, ILogger<ContractService> logger)
        {
            _contractRepository = contractRepository;
            _productRepository = productRepository;
            _logger = logger;
        }

        public ContractMgmt.Application.Model.Contracts GetContractsManagementResponse(string Id)
        {
            try
            {
                ResponseContracts responseContracts = new ResponseContracts();
                List<ContractMgmt.Application.Contract.Infrastructure.Data.Contracts> contracts = _contractRepository.GetContractDetails();
                List<ContractMgmt.Application.Product.Infrastructure.Data.Products> products = _productRepository.GetProductDetails();
                var contractById = contracts.Where(a => a.id == Id).FirstOrDefault();

                ContractMgmt.Application.Model.Contracts obj = new ContractMgmt.Application.Model.Contracts
                {
                    CountryId = contractById.CountryId,
                    Name = contractById.Name,
                    id = contractById.id,
                    Products = new HashSet<ContractMgmt.Application.Model.Product>(
                        products.Select(p => new ContractMgmt.Application.Model.Product
                        {
                            id = p.id,
                            Elements = new HashSet<ContractMgmt.Application.Model.Element>(
                                p.Elements.Select(e => new ContractMgmt.Application.Model.Element
                                {
                                    Fee = e.Fee,
                                    Price = e.Price,
                                    t = e.t
                                })
                            ).ToHashSet()
                        })
                    ).ToHashSet()
                };
                return obj;

            }
            catch (Exception ex)
            {
                _logger.LogError($" Contract Service -- > Get Complete Response Results :: {ex.Message}");
                throw new Exception(ex.Message);
            }
        }

        public ContractResult GetContractDetailsById(string Id)
        {
            try
            {
                ResponseContracts responseContracts = new ResponseContracts();
                List<ContractMgmt.Application.Contract.Infrastructure.Data.Contracts> contracts = _contractRepository.GetContractDetails();
                var contractById = contracts.Where(a => a.id == Id).FirstOrDefault();

                ContractResult obj = new ContractResult
                {
                    CountryId = contractById.CountryId,
                    Name = contractById.Name,
                    id = contractById.id
                };
                return obj;

            }
            catch (Exception ex)
            {
                _logger.LogError($" Contract Service -- > Get Contract Details Results :: {ex.Message}");
                throw new Exception(ex.Message);
            }
        }
        public ProductsResult GetProductDetailsById(string Id)
        {
            try
            {
                ResponseContracts responseContracts = new ResponseContracts();
                List<ContractMgmt.Application.Product.Infrastructure.Data.Products> products = _productRepository.GetProductDetails();
                var productById = products.Where(a => a.id == Id).FirstOrDefault();

                ProductsResult obj = new ProductsResult
                {
                    id = productById.id,
                    Elements = new HashSet<ContractMgmt.Application.Model.Elements>(
                                productById.Elements.Select(e => new ContractMgmt.Application.Model.Elements
                                {
                                    Fee = e.Fee,
                                    Price = e.Price,
                                    t = e.t
                                })
                            ).ToHashSet()

                };
                return obj;

            }
            catch (Exception ex)
            {
                _logger.LogError($" Contract Service -- > Get Complete Response Results :: {ex.Message}");
                throw new Exception(ex.Message);
            }
        }

    }
}
