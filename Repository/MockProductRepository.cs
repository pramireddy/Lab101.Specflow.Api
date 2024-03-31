using Lab101.Specflow.Api.Models;

namespace Lab101.Specflow.Api.Repository
{
    public class MockProductRepository : IProductRepository
    {
        private readonly IEnumerable<Product> products;
        public MockProductRepository(IEnumerable<Product> products)
        {
            this.products = products;
        }
        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }
    }
}
