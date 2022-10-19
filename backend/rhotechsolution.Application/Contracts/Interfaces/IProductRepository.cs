using rhotechsolution.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rhotechsolution.Application.Contracts.Interfaces
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAllProductsAsync(bool trackChanges);
        Task<Product> GetByIdAsync(int id, bool trackChanges);
        void CreateProduct(Product product);
        void UpdateProduct(Product product);
        Task<Product> GetProductBarCode(string productBarCode, bool trackChanges);
    }
}
