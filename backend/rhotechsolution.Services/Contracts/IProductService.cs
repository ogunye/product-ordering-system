using rhotechsolution.Application.DTOs.ProductDataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rhotechsolution.Services.Contracts
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetAllProductInfoAsync(bool trackChanges);
        Task<ProductDto> GetProductAsync(int productId, bool trackChanges);
        Task<ProductDto> GetByNameAsync(string name, bool trackChanges);
        Task<ProductDto> CreateProductAsync(ProductForCreationDto product);
        Task UpdateProductAsync(int Id, ProductForUpdateDto product, bool trackChanges);
        Task DeleteProductAsync(int Id, bool trackChanges);
    }
}
