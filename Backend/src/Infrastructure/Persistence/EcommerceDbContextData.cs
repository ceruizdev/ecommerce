using Ecommerce.Application.Models.Authorization;
using Ecommerce.Domain;
using Ecommerce.Domain.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace Ecommerce.Infrastructure.Persistence;
public class EcommerceDbContextData
{
    public static async Task LoadDataAsync(
        EcommerceDbContext context,
        UserManager<User> userManager,
        RoleManager<IdentityRole> roleManager,
        ILoggerFactory loggerFactory)
    {
        try
        {
            if (!roleManager.Roles.Any())
            {
                await roleManager.CreateAsync(new IdentityRole(Role.ADMIN));
                await roleManager.CreateAsync(new IdentityRole(Role.USER));
            }
            if (!userManager.Users.Any())
            {
                var userAdmin = new User
                {
                    Name = "Carlos",
                    LastName = "Ruiz",
                    Email = "carlos@gmail.com",
                    UserName = "carlos93",
                    Phone = "3167518239",
                    AvatarURL = "http://test.com"
                };
                await userManager.CreateAsync(userAdmin, "Password123Col23$");
                await userManager.AddToRoleAsync(userAdmin, Role.ADMIN);

                var userRegular = new User
                {
                    Name = "Ana",
                    LastName = "Rodriguez",
                    Email = "ana@gmail.com",
                    UserName = "ana93",
                    Phone = "3167518239",
                    AvatarURL = "http://test.com"
                };
                await userManager.CreateAsync(userRegular, "Password123Col23$");
                await userManager.AddToRoleAsync(userRegular, Role.USER);
            }
            if (!context.Categories!.Any())
            {
                var categoryData = File.ReadAllText("../Infrastructure/Data/category.json");
                var categories = JsonConvert.DeserializeObject<List<Category>>(categoryData);
                await context.Categories!.AddRangeAsync(categories!);
                await context.SaveChangesAsync();
            }
            if (!context.Products!.Any())
            {
                var productData = File.ReadAllText("../Infrastructure/Data/product.json");
                var products = JsonConvert.DeserializeObject<List<Product>>(productData);
                await context.Products!.AddRangeAsync(products!);
                await context.SaveChangesAsync();
            }
            if (!context.ProductImages!.Any())
            {
                var productImageData = File.ReadAllText("../Infrastructure/Data/productImage.json");
                var productImages = JsonConvert.DeserializeObject<List<ProductImage>>(productImageData);
                await context.ProductImages!.AddRangeAsync(productImages!);
                await context.SaveChangesAsync();
            }
            if (!context.Countries!.Any())
            {
                var countryData = File.ReadAllText("../Infrastructure/Data/countries.json");
                var countries = JsonConvert.DeserializeObject<List<Country>>(countryData);
                await context.Countries!.AddRangeAsync(countries!);
                await context.SaveChangesAsync();
            }
            if (!context.Reviews!.Any())
            {
                var reviewData = File.ReadAllText("../Infrastructure/Data/review.json");
                var reviews = JsonConvert.DeserializeObject<List<Review>>(reviewData);
                await context.Reviews!.AddRangeAsync(reviews!);
                await context.SaveChangesAsync();
            }
        }
        catch (Exception ex)
        {
            var logger = loggerFactory.CreateLogger<EcommerceDbContextData>();
            logger.LogError(ex.Message);
        }
    }
}