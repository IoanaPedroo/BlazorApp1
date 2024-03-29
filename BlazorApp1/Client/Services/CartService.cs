﻿using BlazorApp1.Shared;
using Blazored.LocalStorage;
using Blazored.Toast.Services;
using System.Net.Http.Json;

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

        public async Task AddToCart(CartItem item)
        {
            var cart = await _localStorage.GetItemAsync<List<CartItem>>("cart");
            if(cart == null)
            {
                cart = new List<CartItem>();
            }
            var sameItem = cart.Find(x => x.ProductId == item.ProductId && x.EditionId == item.EditionId);
            if(sameItem == null)
            {
                cart.Add(item);
            }
            else
            {
                sameItem.Quantity += item.Quantity;
            }
            


            await _localStorage.SetItemAsync("cart", cart);
            var product = await _productService.LoadProduct(item.ProductId);
            _toastService.ShowSuccess(product.Title, "Added to cart:");
            OnChange.Invoke();
        }

        public async Task<string> Checkout()
        {
            var result = await _httpClient.PostAsJsonAsync("api/payment/checkout", await GetCartItems());
            var url =  await result.Content.ReadAsStringAsync();
            return url;
        }

        public async Task DeleteItem(CartItem item)
        {
            var cart = await _localStorage.GetItemAsync<List<CartItem>>("cart");
            if(cart == null)
            {
                return;
            }
            var cartItem = cart.Find(p =>p.ProductId == item.ProductId && p.EditionId == item.EditionId);
            cart.Remove(cartItem);

            await _localStorage.SetItemAsync("cart", cart);
            OnChange.Invoke();
        }

        public async Task EmptyCart()
        {
            await _localStorage.RemoveItemAsync("cart");
            OnChange.Invoke();
        }

        public async Task<List<CartItem>> GetCartItems()
        {
            var cart = await _localStorage.GetItemAsync<List<CartItem>>("cart");
            if(cart == null)
            {
                return new List<CartItem>();
            }
            return cart;
        }
    }
}
