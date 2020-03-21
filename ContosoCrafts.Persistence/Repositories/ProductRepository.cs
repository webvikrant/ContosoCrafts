using ContosoCrafts.Business.Interfaces;
using ContosoCrafts.Business.Models;
using ContosoCrafts.Persistence.Records;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ContosoCrafts.Persistence.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly DatabaseConfig _databaseConfig;

        public ProductRepository(IOptions<DatabaseConfig> options)
        {
            _databaseConfig = options.Value;
        }

        public List<Product> GetAllProducts()
        {
            //List<Product> products = new List<Product>();
            //products.Add(new Product { Id = 1, Name = "Product A" });
            //products.Add(new Product { Id = 1, Name = "Product B" });
            //return products;
            var products = new List<Product>();

            using (var session = (new PostgresConnectionManager(_databaseConfig)).SessionFactory.OpenSession())
            {
                products = session.Query<ProductRecord>().Select(rec => new Product { Id = rec.Id, Name = rec.Name }).ToList();
            }

            return products;
        }
    }
}
