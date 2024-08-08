using Microsoft.EntityFrameworkCore;
using SportsStore.Data;

namespace SportsStore.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            StoreDbContext context = app.ApplicationServices
                .CreateScope().ServiceProvider
                .GetRequiredService<StoreDbContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product
                    {
                        ProductID = Guid.NewGuid(),
                        Name = "Nike Pegasus",
                        Description = "Men's Running Shoes",
                        Category = "Shoes",
                        Price = 139.99m
                    },
                    new Product
                    {
                        ProductID = Guid.NewGuid(),
                        Name = "Adidas Performance",
                        Description = "Men's T-shirt Official Emblem of Euro 2024",
                        Category = "Clothing",
                        Price = 23.99m
                    },
                    new Product
                    {
                        ProductID = Guid.NewGuid(),
                        Name = "Incline Bench B2.1",
                        Description = "Inclined Bench",
                        Category = "Training",
                        Price = 125
                    },
                    new Product
                    {
                        ProductID = Guid.NewGuid(),
                        Name = "Kayak",
                        Description = "BESTWAY Inflatable Kayak Ventura X2 Kayak",
                        Category = "Swimming",
                        Price = 259
                    },
                    new Product
                    {
                        ProductID = Guid.NewGuid(),
                        Name = "Pro Touch",
                        Description = "Ping Pong Table Indoor 1.1",
                        Category = "Table Tennis",
                        Price = 335
                    },
                    new Product
                    {
                        ProductID = Guid.NewGuid(),
                        Name = "Football Euro24 Pro",
                        Description = "Adidas Official Euro 2024 Ball",
                        Category = "Soccer",
                        Price = 150
                    },
                    new Product
                    {
                        ProductID = Guid.NewGuid(),
                        Name = "Mares",
                        Description = "Fins Challenge FF swimfins",
                        Category = "Scuba Diving",
                        Price = 29.95m
                    },
                    new Product
                    {
                        ProductID = Guid.NewGuid(),
                        Name = "NAKAMURA BLAZE ",
                        Description = "27,5\" - 38 Mountain Bike",
                        Category = "Cycling",
                        Price = 224
                    },
                    new Product
                    {
                        ProductID = Guid.NewGuid(),    
                        Name = "Pro Touch Spiko 100",
                        Description = "Volleyball Ball",
                        Category = "Volleyball",
                        Price = 24.99m
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
