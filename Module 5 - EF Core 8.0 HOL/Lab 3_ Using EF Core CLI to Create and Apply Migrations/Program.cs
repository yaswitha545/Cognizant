using System;

namespace RetailStore
{
    class Program
    {
        static void Main(string[] args)
        {
            using var context = new AppDbContext();


            var category = new Category
            {
                Name = "Electronics"
            };


            var product = new Product
            {
                Name = "Laptop",
                Price = 55000,
                Category = category
            };


            context.Products.Add(product);

            context.SaveChanges();


            Console.WriteLine("Data Added Successfully");
        }
    }
}
