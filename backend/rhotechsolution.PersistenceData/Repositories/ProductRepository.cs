using Microsoft.EntityFrameworkCore;
using rhotechsolution.Application.Contracts.Interfaces;
using rhotechsolution.Domain.Entities;
using rhotechsolution.PersistenceData.ApplicationDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rhotechsolution.PersistenceData.Repositories
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(RepositoryContext context) : base(context)
        {
            
        }

        public void CreateProduct(Product product) => Create(product);

        public void DeleteProduct(Product product) => Delete(product);  

        public async Task<IEnumerable<Product>> GetAllProductsAsync(bool trackChanges)
        {
            return await FindAll(trackChanges)
                .OrderBy(x => x.Id)
                .ToListAsync();
        }

        public async Task<Product> GetByIdAsync(int id, bool trackChanges) =>
#pragma warning disable CS8603 // Possible null reference return.
            await FindByCondition(c => c.Id.Equals(id), trackChanges)
                 .SingleOrDefaultAsync();

       
#pragma warning restore CS8603 // Possible null reference return.


        public async Task<Product> GetProductByName(string productName, bool trackChanges)
        {
#pragma warning disable CS8603 // Possible null reference return.
            return await FindByCondition(c => c.product_name == productName, trackChanges)
                .OrderBy(x => x.product_name)
                .FirstOrDefaultAsync();
#pragma warning restore CS8603 // Possible null reference return.
        }        
        
    }
}
