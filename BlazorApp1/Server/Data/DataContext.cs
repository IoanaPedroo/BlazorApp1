using BlazorApp1.Shared;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Server.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    CategoryId = 1,
                    Title = "Radkersburg - Ceramic jugs",
                    Description = "Marcus Cyron/OgreBotCeramics/2014 July 13-16",
                    Image = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c1/20140708_Radkersburg_-_Ceramic_jugs_-_H3216.jpg/572px-20140708_Radkersburg_-_Ceramic_jugs_-_H3216.jpg",
                    Price = 9.99m,
                    OriginalPrice = 19.99m,
                },
                new Product
                {
                    Id = 2,
                    CategoryId = 1,
                    Title = "Duomo Water Filtration Pitcher",
                    Description = "INCLUDES:•Item Size: 8, L x 4.3, W x 8.75, H Country of Origin: China",
                    Image = "https://i.pinimg.com/originals/cf/b5/ac/cfb5ac2d0211309d5f645d248f63bc1e.jpg",
                    Price = 9.99m,
                    OriginalPrice = 19.99m,
                }
                );
            modelBuilder.Entity<Category>().HasData(
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
                }
                );
        }
    }

    
}
