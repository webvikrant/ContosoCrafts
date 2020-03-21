using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContosoCrafts.Business.Models;
using ContosoCrafts.Business.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace ContosoCrafts.WebSite.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly InventoryService _inventoryService;

        public List<Product> Products { get; private set; }

        public IndexModel(ILogger<IndexModel> logger, InventoryService inventoryService)
        {
            _logger = logger;
            _inventoryService = inventoryService;
        }

        public void OnGet()
        {
            Products = _inventoryService.GetAllProducts();
        }
    }
}
