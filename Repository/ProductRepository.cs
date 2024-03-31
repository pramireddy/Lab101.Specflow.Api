using Lab101.Specflow.Api.Models;

namespace Lab101.Specflow.Api.Repository
{
    public class ProductRepository : IProductRepository
    {
        public IEnumerable<Product> GetAllProducts()
        {
            return new List<Product>
            {
                new() { Id = 1, Name = "Product Name1", Description = "Product Description1", Stock = 1 },
                new() { Id = 2, Name = "Product Name2", Description = "Product Description2", Stock = 2 },
                new() { Id = 3, Name = "Product Name3", Description = "Product Description3", Stock = 3 },
                new() { Id = 4, Name = "Product Name4", Description = "Product Description4", Stock = 4 }
            };
        }
    }
}
