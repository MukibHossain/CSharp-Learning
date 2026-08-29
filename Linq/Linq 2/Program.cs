//2. Online Shopping System - LINQ Filter & Sort
//C# Code
using System;
using System.Collections.Generic;
using System.Linq;
 
namespace OnlineShoppingSystem
{
    class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
    }
 
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>
            {
                new Product { ProductID = 1, ProductName = "Laptop",      Category = "Electronics", Price = 75000, Stock = 10 },
                new Product { ProductID = 2, ProductName = "Headphones",  Category = "Electronics", Price = 2500,  Stock = 50 },
                new Product { ProductID = 3, ProductName = "Smartwatch",  Category = "Electronics", Price = 15000, Stock = 20 },
                new Product { ProductID = 4, ProductName = "Bluetooth Speaker", Category = "Electronics", Price = 4500, Stock = 30 },
                new Product { ProductID = 5, ProductName = "T-Shirt",     Category = "Clothing",    Price = 800,   Stock = 100 },
                new Product { ProductID = 6, ProductName = "Television",  Category = "Electronics", Price = 55000, Stock = 5 }
            };
 
            var result = products
                .Where(p => p.Category == "Electronics" && p.Price < 50000)
                .OrderByDescending(p => p.Price)
                .Select(p => new { p.ProductName, p.Price });
 
            Console.WriteLine("---- Electronics Products under 50,000 (sorted by price desc) ----");
            foreach (var item in result)
            {
                Console.WriteLine($"Product: {item.ProductName}, Price: {item.Price}");
            }
        }
    }
}
 
