using System;

namespace RetailStore
{
    class Program
    {
        static void Main(string[] args)
        {
            using var context = new AppDbContext();


            Category category = new Category()
            {
                Name = "Electronics"
            };


            Product product = new Product()
            {
                Name = "Laptop",
                Price = 60000,
                Category = category
            };


            context.Products.Add(product);

            context.SaveChanges();


            Console.WriteLine(
            "Data inserted successfully");
        }
    }
}
