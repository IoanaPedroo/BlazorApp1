using BlazorApp1.Shared;

namespace BlazorApp1.Server.ServerServices
{
    public class CategoryService : ICategoryService
    {
        List<Category> Categories { get ; set ; } = new List<Category>
        {
                new Category
                {
                    Id = 1,
                    Name = "Books",
                    Url = "books",
                    Icon = "book"
                },
                new Category
                {
                    Id = 2,
                    Name = "Electronics",
                    Url = "electronics",
                    Icon = "camera-srl"
                },
                new Category
                {
                    Id = 3,
                    Name = "Pottery",
                    Url = "pottery",
                    Icon = "vase"
                },
        };

        public async Task<List<Category>> GetCategories()
        {
            return Categories;
        }

        public async Task<Category> GetCategoryByUrl(string url)
        {
            return Categories.FirstOrDefault(c => c.Url.Equals(url));
        }
    }
}
