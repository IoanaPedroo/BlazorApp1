﻿using BlazorApp1.Server.Data;
using BlazorApp1.Shared;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Server.ServerServices
{
    public class ProductService : IProductService
    {
        private readonly ICategoryService _categoryService;
        private readonly DataContext _dataContext;
        public ProductService(ICategoryService categoryService, DataContext context)
        {
            _categoryService = categoryService;
            _dataContext = context;
        }

        public async Task<List<Product>> GetAllProducts()
        {
            return await _dataContext.Products.ToListAsync();
        }

        public async Task<Product> GetProduct(int id)
        {
            Product product = await _dataContext.Products.FirstOrDefaultAsync(p => p.Id == id);
            return product;
        }

        public async Task<List<Product>> GetProductsByCategory(string categoryUrl)
        {
            Category category = await _categoryService.GetCategoryByUrl(categoryUrl);
            return await _dataContext.Products.Where(p => p.CategoryId == category.Id).ToListAsync();
        }
    }
}
