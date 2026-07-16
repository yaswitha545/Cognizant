using System;
using System.Linq;

namespace RetailInventory
{
    class Program
    {
        static void Main(string[] args)
        {
            using var context = new InventoryContext();


            var category = new Category()
            {
                CategoryName = "Electronics"
            };


            var product = new Product()
            {
                ProductName = "Laptop",
                Stock = 10,
                Category = category
            };


            context.Products.Add(product);

            context.SaveChanges();


            Console.WriteLine("Product Added Successfully");


            var products = context.Products.ToList();


            foreach(var p in products)
            {
                Console.WriteLine(
                $"{p.ProductId} {p.ProductName} {p.Stock}");
            }
        }
    }
}
