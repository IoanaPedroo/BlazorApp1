using BlazorApp1.Shared;

namespace BlazorApp1.Server.ServerServices
{
    public class ProductService : IProductService
    {
        private readonly ICategoryService _categoryService;
        public ProductService(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        List<Product> Products { get; set; } = new List<Product>
        {
            new Product
                {
                    Id  = 1,
                    CategoryId = 1,
                    Title = "Radkersburg - Ceramic jugs",
                    Description = "Marcus Cyron/OgreBotCeramics/2014 July 13-16",
                    Image = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c1/20140708_Radkersburg_-_Ceramic_jugs_-_H3216.jpg/572px-20140708_Radkersburg_-_Ceramic_jugs_-_H3216.jpg",
                    Price = 9.99m,
                    OriginalPrice = 19.99m,
                },
                new Product
                {
                    Id  = 2,
                    CategoryId = 1,
                    Title = "Duomo Water Filtration Pitcher",
                    Description = "INCLUDES:•Item Size: 8, L x 4.3, W x 8.75, H Country of Origin: China",
                    Image = "https://i.pinimg.com/originals/cf/b5/ac/cfb5ac2d0211309d5f645d248f63bc1e.jpg",
                    Price = 9.99m,
                    OriginalPrice = 19.99m,
                }
        };

        public async Task<List<Product>> GetAllProducts()
        {
            return Products;
        }

        public async Task<Product> GetProduct(int id)
        {
            Product product = Products.FirstOrDefault(p => p.Id == id);
            return product;
        }

        public async Task<List<Product>> GetProductsByCategory(string categoryUrl)
        {
            Category category = await _categoryService.GetCategoryByUrl(categoryUrl);
            return Products.Where(p => p.CategoryId == category.Id).ToList();
        }
    }
}
