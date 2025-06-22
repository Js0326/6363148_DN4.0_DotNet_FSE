using System;
using System.Linq;

namespace ECommerceSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Product[] products = new Product[]
            {
                new Product(1, "Shoes", "Footwear"),
                new Product(2, "Pencil", "Stationery"),
                new Product(3, "Headphones", "Electronics"),
                new Product(4, "Trimmer", "Electronics"),
                new Product(5, "Sunscreen", "Beauty")
            };

            Console.WriteLine("Linear Search:");
            var result1 = SearchFunctions.LinearSearch(products, "Trimmer");
            Console.WriteLine(result1 != null ? $"Found: {result1.ProductName}" : "Not Found");

            var sortedProducts = products.OrderBy(p => p.ProductName).ToArray();
            Console.WriteLine("\nBinary Search:");
            var result2 = SearchFunctions.BinarySearch(sortedProducts, "Trimmer");
            Console.WriteLine(result2 != null ? $"Found: {result2.ProductName}" : "Not Found");

            Console.ReadLine();
        }
    }
}
