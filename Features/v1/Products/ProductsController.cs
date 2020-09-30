using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TesteVersionamentoAPI.Context;
using TesteVersionamentoAPI.Models;

namespace TesteVersionamentoAPI.Features.v1.Products
{
    [ApiController]
    [ApiVersion("1", Deprecated = true)]
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
    }
}