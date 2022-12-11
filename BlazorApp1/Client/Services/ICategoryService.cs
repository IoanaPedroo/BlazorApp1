using BlazorApp1.Shared;

namespace BlazorApp1.Client.Services
{
    public interface ICategoryService
    {
        List<Category> Categories { get; set; }
        Task LoadCategories();
    }
}
