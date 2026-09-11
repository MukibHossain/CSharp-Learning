//Use LINQ(write in C# class) to search the information of
//products from the table that are in category "Electronics" and have a price greater than 500.
//Given Product Table
//Product ID  Product Name    Category Price   Stock Qty
//101	Laptop Electronics	750	10
//102	Office Chair    Furniture   300	20
//103	Smartphone Electronics	600	15
//104	Pen Stationery	5	500
//105	Headphones Electronics	450	30

using System;
using System.Collections.Generic;
using System.Linq;

class Product
{
    public int ProductID { get; set; }
    public string ProductName { get; set; }
    public string Category { get; set; }
    public double Price { get; set; }
    public int StockQty { get; set; }
}

class Program
{
    static void Main()
    {
        List<Product> products = new List<Product>
        {
            new Product { ProductID = 101, ProductName = "Laptop", Category = "Electronics", Price = 750, StockQty = 10 },
            new Product { ProductID = 102, ProductName = "Office Chair", Category = "Furniture", Price = 300, StockQty = 20 },
            new Product { ProductID = 103, ProductName = "Smartphone", Category = "Electronics", Price = 600, StockQty = 15 },
            new Product { ProductID = 104, ProductName = "Pen", Category = "Stationery", Price = 5, StockQty = 500 },
            new Product { ProductID = 105, ProductName = "Headphones", Category = "Electronics", Price = 450, StockQty = 30 }
        };

        var result = products
            .Where(p => p.Category == "Electronics" && p.Price > 500);

        foreach (Product p in result)
        {
            Console.WriteLine("Product ID: " + p.ProductID);
            Console.WriteLine("Product Name: " + p.ProductName);
            Console.WriteLine("Category: " + p.Category);
            Console.WriteLine("Price: " + p.Price);
            Console.WriteLine("Stock Qty: " + p.StockQty);
            Console.WriteLine();
        }
    }
}