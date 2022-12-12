using BlazorApp1.Shared;

namespace BlazorApp1.Server.ServerServices
{
    public interface IProductService
    {
        Task<List<Product>> GetAllProducts();
        Task<List<Product>> GetProductsByCategory(string categoryUrl);
        Task<Product> GetProduct(int id);
        Task<List<Product>> SearchProduct(string searchText);
    }
}
