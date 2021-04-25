using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
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
        private readonly ILogger<ProductController> _logger;

        public ProductController(ILogger<ProductController> logger)
        {
            _logger = logger;
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
        public IEnumerable<Product> Get()
        {
            return ProductContext.Products;
        }
    }
}
