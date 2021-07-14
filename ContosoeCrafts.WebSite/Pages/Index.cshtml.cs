using ContosoeCrafts.WebSite.Models;
using ContosoeCrafts.WebSite.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ContosoeCrafts.WebSite.Pages
{
    public class IndexModel : PageModel
    {
       // private readonly ILogger<IndexModel> _logger;
        //public JsonFileProductsService ProductsService;
        //public IEnumerable<Product> Products { get; private set; }
        private readonly ConnectionDbClass _db;

        //public IndexModel(ILogger<IndexModel> logger,JsonFileProductsService productsService)
        //{
        //    _logger = logger;
        //    //ProductsService = productsService;
           

        //}
        public IndexModel(ConnectionDbClass db)
        {
            //_logger = logger;
            //ProductsService = productsService;
            _db = db;


        }
        public IEnumerable<Product> getRecords { get; set; }


        public async Task OnGet()
        {
            //Products = ProductsService.GetProducts();
            getRecords = await _db.Product.ToListAsync();
        }
    }
}
