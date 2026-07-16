using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RetailStore
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using var context = new AppDbContext();


            // 1. Retrieve All Products

            var products = 
                await context.Products.ToListAsync();


            Console.WriteLine("All Products:");

            foreach(var p in products)
            {
                Console.WriteLine(
                $"{p.Name} - ₹{p.Price}");
            }



            // 2. Find Product by ID

            var product =
                await context.Products.FindAsync(1);


            Console.WriteLine(
            $"Found: {product?.Name}");



            // 3. FirstOrDefault Condition

            var expensive =
                await context.Products
                .FirstOrDefaultAsync(
                p => p.Price > 50000);


            Console.WriteLine(
            $"Expensive: {expensive?.Name}");
        }
    }
}
