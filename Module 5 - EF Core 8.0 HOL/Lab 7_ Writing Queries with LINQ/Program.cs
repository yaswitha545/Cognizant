using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace RetailStore
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using var context = new AppDbContext();


            // 1. Filter and Sort Products

            var filtered = await context.Products

                .Where(p => p.Price > 1000)

                .OrderByDescending(p => p.Price)

                .ToListAsync();


            Console.WriteLine("Filtered Products:");

            foreach(var p in filtered)
            {
                Console.WriteLine(
                $"{p.Name} - ₹{p.Price}");
            }



            // 2. Project into DTO

            var productDTOs = await context.Products

                .Select(p => new
                {
                    p.Name,
                    p.Price
                })

                .ToListAsync();



            Console.WriteLine("\nProduct DTOs:");

            foreach(var item in productDTOs)
            {
                Console.WriteLine(
                $"{item.Name} : ₹{item.Price}");
            }

        }
    }
}
