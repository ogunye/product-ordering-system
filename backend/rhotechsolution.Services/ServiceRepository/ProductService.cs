using AutoMapper;
using rhotechsolution.Application.Contracts;
using rhotechsolution.Application.DTOs.ProductDataTransferObjects;
using rhotechsolution.Domain.Entities;
using rhotechsolution.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rhotechsolution.Services.ServiceRepository
{
    internal sealed class ProductService : IProductService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public ProductService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<ProductDto> CreateProductAsync(ProductForCreationDto product)
        {
            var productEntity = _mapper.Map<Product>(product);
            _repository.Product.CreateProduct(productEntity);
            await _repository.SaveAsync();

            var productToReturn = _mapper.Map<ProductDto>(productEntity);

            return productToReturn;
        }

        public async Task DeleteProductAsync(int Id, bool trackChanges)
        {
            var product = await _repository.Product.GetByIdAsync(Id, trackChanges);
           // if (product is null)
                //throw new ArgumentException(Id);
            _repository.Product.DeleteProduct(product);
            await _repository.SaveAsync();
        }

        public async Task<IEnumerable<ProductDto>> GetAllProductInfoAsync(bool trackChanges)
        {
            var products = await _repository.Product.GetAllProductsAsync(trackChanges);
            var productsInfo = _mapper.Map<IEnumerable<ProductDto>>(products);
            return productsInfo;
        }

        public async Task<ProductDto> GetByNameAsync(string name, bool trackChanges)
        {
            var product = await _repository.Product.GetProductByName(name, trackChanges);   
            var result = _mapper.Map<ProductDto>(product);
            return result;
        }

        public async Task<ProductDto> GetProductAsync(int productId, bool trackChanges)
        {
            var product = await _repository.Product.GetByIdAsync(productId, trackChanges);
            var productInfo = _mapper.Map<ProductDto>(product);
            return productInfo;
        }

        public async Task UpdateProductAsync(int Id, ProductForUpdateDto product, bool trackChanges)
        {
            var productEntity = await _repository.Product.GetByIdAsync(Id, trackChanges);
            if (productEntity != null)
                throw new Exception();
            _mapper.Map(product, productEntity);
            await _repository.SaveAsync();
        }
    }
}
