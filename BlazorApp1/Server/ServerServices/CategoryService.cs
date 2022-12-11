using BlazorApp1.Server.Data;
using BlazorApp1.Shared;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Server.ServerServices
{
    public class CategoryService : ICategoryService
    {
        private readonly DataContext _dataContext;

        public CategoryService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<List<Category>> GetCategories()
        {
            return await _dataContext.Categories.ToListAsync();
        }

        public async Task<Category> GetCategoryByUrl(string url)
        {
            return await _dataContext.Categories.FirstOrDefaultAsync(c => c.Url.Equals(url));
        }
    }
}
