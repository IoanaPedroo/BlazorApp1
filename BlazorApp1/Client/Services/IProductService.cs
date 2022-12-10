using BlazorApp1.Shared;

namespace BlazorApp1.Client.Services
{
    public interface IProductService
    {
        List<Product> Products { get; set; }
        void LoadProducts(); 
    }
}
