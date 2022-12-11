using BlazorApp1.Shared;
using Blazored.LocalStorage;
using Blazored.Toast.Services;

namespace BlazorApp1.Client.Services
{
    public class CartService : ICartService
    {
        private readonly HttpClient _httpClient;
        private readonly ILocalStorageService _localStorage;
        private readonly IToastService _toastService;
        private readonly IProductService _productService;

        public CartService(HttpClient httpClient, ILocalStorageService localStorage, IToastService toastService, IProductService productService)
        {
            _httpClient = httpClient;
            _localStorage = localStorage;
            _toastService = toastService;
            _productService = productService;
        }

        public event Action OnChange;

        public async Task AddToCart(ProductVariant productVariant)
        {
            var cart = await _localStorage.GetItemAsync<List<ProductVariant>>("cart");
            if(cart == null)
            {
                cart = new List<ProductVariant>();
            }
            cart.Add(productVariant);
            await _localStorage.SetItemAsync("cart", cart);
            var product = await _productService.LoadProduct(productVariant.ProductId);
            _toastService.ShowSuccess(product.Title, "Added to cart:");
            OnChange.Invoke();
        }

        public async Task DeleteItem(CartItem item)
        {
            var cart = await _localStorage.GetItemAsync<List<ProductVariant>>("cart");
            if(cart == null)
            {
                return;
            }
            var cartItem = cart.Find(p =>p.ProductId == item.ProductId && p.EditionId == item.EditionId);
            cart.Remove(cartItem);
            await _localStorage.SetItemAsync("cart", cart);
            OnChange.Invoke();
        }

        public async Task<List<CartItem>> GetCartItems()
        {
            var result = new List<CartItem>();
            var cart = await _localStorage.GetItemAsync<List<ProductVariant>>("cart");
            if(cart == null)
            {
                return result;
            }
            foreach(var item in cart)
            {
                var product = await _productService.LoadProduct(item.ProductId);
                var cartItem = new CartItem
                {
                    ProductId = product.Id,
                    ProductTitle = product.Title,
                    Image = product.Image,
                    EditionId = item.EditionId,
                };
                var variant = product.ProductVariants.Find(x => x.EditionId == item.EditionId);
                if(variant != null)
                {
                    cartItem.EditionName = variant.Edition.Name;
                    cartItem.Price = variant.Price;
                }
                result.Add(cartItem);

            }
            return result;
        }
    }
}
