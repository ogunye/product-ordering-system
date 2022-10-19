using Microsoft.EntityFrameworkCore;
using rhotechsolution.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rhotechsolution.PersistenceData.ApplicationDbContext
{
    public class RepositoryContext : DbContext
    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public RepositoryContext(DbContextOptions options) : base(options)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
        }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Payment_Method> Payment_Methods { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Product_Price> Product_Prices { get; set; }
        public DbSet<Product_Shipment> Product_Shipments { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<SalesOrder> SalesOrders { get; set; }
        public DbSet<SalesPerson> SalesPeople { get; set; }

    }
}
