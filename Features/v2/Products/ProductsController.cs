using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TesteVersionamentoAPI.Context;
using TesteVersionamentoAPI.Models;

namespace TesteVersionamentoAPI.Features.v2.Products
{
    [ApiController]
    [ApiVersion("2")]
    [Route("api/v{version:apiVersion}/products")]
    public class ProductsController : ControllerBase
    {
        private readonly ApiContext _apiContext;
        public ProductsController(ApiContext apiContext)
        {
            _apiContext = apiContext;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            IEnumerable<Product> allProducts = await _apiContext.Products.ToListAsync();
            return Ok(allProducts);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            Product product = await _apiContext.Products.FindAsync(id);
            
            return Ok(product);
        }
    }
}