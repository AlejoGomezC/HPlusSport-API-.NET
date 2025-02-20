using Microsoft.EntityFrameworkCore;

namespace HPlusSport.API.Models
{
    public static class ModelBuilderExtensions
    {

        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "Running"
                },
                new Category
                {
                    Id = 2,
                    Name = "Basketball"
                },
                new Category
                {
                    Id = 3,
                    Name = "Tennis"
                }
            );
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Name = "Running Shoes",
                    Sku = "1001",
                    Description = "Shoes for running",
                    Price = 79.99m,
                    IsAvailable = true,
                    CategoryId = 1
                },
                new Product
                {
                    Id = 2,
                    Name = "Running Shorts",
                    Sku = "1002",
                    Description = "Shorts for running",
                    Price = 29.99m,
                    IsAvailable = true,
                    CategoryId = 1
                },
                new Product
                {
                    Id = 3,
                    Name = "Basketball Shoes",
                    Sku = "1003",
                    Description = "Shoes for basketball",
                    Price = 109.99m,
                    IsAvailable = true,
                    CategoryId = 2
                },
                new Product
                {
                    Id = 4,
                    Name = "Tennis Shoes",
                    Sku = "1004",
                    Description = "Shoes for tennis",
                    Price = 89.99m,
                    IsAvailable = true,
                    CategoryId = 3
                },
                new Product
                {
                    Id = 5,
                    Name = "Tennis Balls",
                    Sku = "1005",
                    Description = "Balls for tennis",
                    Price = 4.99m,
                    IsAvailable = true,
                    CategoryId = 3
                },
                new Product
                {
                    Id = 6,
                    Name = "Basketball",
                    Sku = "1006",
                    Description = "Ball for basketball",
                    Price = 9.99m,
                    IsAvailable = true,
                    CategoryId = 2
                }
            );
        }
    }
}
