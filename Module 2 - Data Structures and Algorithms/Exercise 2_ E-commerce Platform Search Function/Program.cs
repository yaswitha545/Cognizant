using System;

namespace EcommerceSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Product[] products =
            {
                new Product(101,"Laptop","Electronics"),
                new Product(102,"Mobile","Electronics"),
                new Product(103,"Shoes","Fashion"),
                new Product(104,"Watch","Accessories"),
                new Product(105,"Bag","Fashion")
            };

            int searchId = 104;

            Product linearResult = SearchAlgorithms.LinearSearch(products, searchId);

            if (linearResult != null)
                Console.WriteLine("Linear Search Found: " + linearResult.ProductName);
            else
                Console.WriteLine("Product Not Found");

            Product binaryResult = SearchAlgorithms.BinarySearch(products, searchId);

            if (binaryResult != null)
                Console.WriteLine("Binary Search Found: " + binaryResult.ProductName);
            else
                Console.WriteLine("Product Not Found");
        }
    }
}
