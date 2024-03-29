﻿using BlazorApp1.Shared;
using System.Net.Http.Json;

namespace BlazorApp1.Client.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly HttpClient _http;
        public List<Category> Categories { get; set; } = new List<Category>();
        public CategoryService(HttpClient http )
        {
            _http = http;
        }
        public async Task LoadCategories()
        {
            Categories = await _http.GetFromJsonAsync<List<Category>>("api/Category");    
        }
    }
}
