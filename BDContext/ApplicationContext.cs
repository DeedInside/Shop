using Microsoft.EntityFrameworkCore;
using Shop.Models;

namespace Shop.BDContext
{
    public class ApplicationContext : DbContext
    {
        public DbSet<PriceProduct> PriceProducts { get; set; } = null!;
        public DbSet<Product> Products { get; set; } = null!;
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
        //public const double Num = 1.1;
        //public static Product Product1 = new Product()
        //{
        //    Id = 1,
        //    Name = "apple",
        //    Price = 50,
        //    Description = "красные яблоки",
        //    PathImg = "None"
        //};
        //public static Product Product2 = new Product()
        //{
        //    Id = 2,
        //    Name = "apple",
        //    Price = 70,
        //    Description = "зеленые яблоки",
        //    PathImg = "None"
        //};
        //public static Product Product3 = new Product()
        //{
        //    Id = 3,
        //    Name = "Grape",
        //    Price = 120,
        //    Description = "сладкий",
        //    PathImg = "None"
        //};
        //public static List<PriceProduct> priceProducts { get; set; } = new List<PriceProduct>()
        //{
        //    new PriceProduct(
        //        Product1,
        //        Product1.Price * 1.1,
        //        DateOnly.ParseExact("05 03 2024","dd MM yyyy"),
        //        DateOnly.ParseExact("10 03 2024","dd MM yyyy"),
        //        300
        //        ){ Id = 1 },
        //    new PriceProduct(
        //        Product2,
        //        Product2.Price * 1.1,
        //        DateOnly.ParseExact("05 03 2024","dd MM yyyy"),
        //        DateOnly.ParseExact("08 03 2024","dd MM yyyy"),
        //        200
        //        ){ Id = 2},
        //    new PriceProduct(
        //        Product3,
        //        Product3.Price * 1.1,
        //        DateOnly.ParseExact("05 03 2024","dd MM yyyy"),
        //        DateOnly.ParseExact("12 03 2024","dd MM yyyy"),
        //        150
        //        ){ Id = 3 }
        //};
        //public static List<Product> ListProducts = new List<Product>()
        //{
        //    Product1,
        //    Product2,
        //    Product3
        //};

    }
}
