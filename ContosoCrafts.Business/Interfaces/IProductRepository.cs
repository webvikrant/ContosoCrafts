using ContosoCrafts.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ContosoCrafts.Business.Interfaces
{
    public interface IProductRepository
    {
        List<Product> GetAllProducts();
    }
}
