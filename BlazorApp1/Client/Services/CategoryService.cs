using BlazorApp1.Shared;

namespace BlazorApp1.Client.Services
{
    public class CategoryService : ICategoryService
    {
        public List<Category> Categories { get; set; } = new List<Category>();

        public void LoadCategories()
        {
            Categories = new List<Category>
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
        }
    }
}
