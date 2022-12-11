using BlazorApp1.Shared;

namespace BlazorApp1.Server.ServerServices
{
    public interface ICategoryService
    {
        Task<List<Category>> GetCategories();
        Task<Category> GetCategoryByUrl(string url);
    }
}
