using BlazorApp1.Shared;

namespace BlazorApp1.Client.Services
{
    public interface ICartService
    {
        event Action OnChange;
        Task AddToCart(ProductVariant productVariant);
        Task<List<CartItem>> GetCartItems();
        Task DeleteItem(CartItem item);
    }
}
