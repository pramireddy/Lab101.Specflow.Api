using Lab101.Specflow.Api.Models;

namespace Lab101.Specflow.Api.Repository
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAllProducts();
    }
}
