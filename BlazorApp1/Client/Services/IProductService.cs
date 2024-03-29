﻿using BlazorApp1.Shared;

namespace BlazorApp1.Client.Services
{
    public interface IProductService
    {
        event Action OnChange;
        List<Product> Products { get; set; }
        Task LoadProducts(string? categoryUrl = null);

        Task<Product> LoadProduct(int id);

        Task<List<Product>> SearchProduct(string searchText);
    }
}
