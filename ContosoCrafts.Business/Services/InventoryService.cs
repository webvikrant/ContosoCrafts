using ContosoCrafts.Business.Interfaces;
using ContosoCrafts.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ContosoCrafts.Business.Services
{
    public class InventoryService
    {
        private readonly IProductRepository _productRepository;

        public InventoryService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public List<Product> GetAllProducts()
        {
            return _productRepository.GetAllProducts();
        }
    }
}
