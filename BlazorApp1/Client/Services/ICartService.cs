using BlazorApp1.Shared;

namespace BlazorApp1.Client.Services
{
    public interface ICartService
    {
        event Action OnChange;
        Task AddToCart(CartItem item);
        Task<List<CartItem>> GetCartItems();
        Task DeleteItem(CartItem item);
        Task EmptyCart();
        Task<string> Checkout();

    }
}
