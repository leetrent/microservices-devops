using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MongoDB.Driver;
using Shopping.API.Data;
using Shopping.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController
    {
        private readonly ProductContext _productContext;
        private readonly ILogger<ProductController> _logger;

        public ProductController(ProductContext productContext, ILogger<ProductController> logger)
        {
            _productContext = productContext ?? throw new ArgumentNullException(nameof(productContext));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        //[HttpGet]
        //public IEnumerable<Product> Get()
        //{
        //    Random random = new Random();
        //    return Enumerable.Range(1, 5).Select(index => new Product
        //    {
        //        Name = "asd"
        //    }).ToArray();
        //}

        [HttpGet]
        public async Task<IEnumerable<Product>> GetAsync()
        {
            return await _productContext.Products.Find(p => true).ToListAsync();
        }
    }
}
