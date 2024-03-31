using Lab101.Specflow.Api.Models;
using Lab101.Specflow.Api.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Lab101.Specflow.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly ILogger<ProductsController> _logger;
        private readonly IProductRepository productRepository;

        public ProductsController(IProductRepository productRepository, ILogger<ProductsController> logger)
        {
            _logger = logger;
            this.productRepository = productRepository;
        }

        [HttpGet(Name = "GetProducts")]
        public IEnumerable<Product> Get()
        {
            return productRepository.GetAllProducts();
        }
    }
}
