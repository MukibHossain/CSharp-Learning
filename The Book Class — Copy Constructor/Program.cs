//Create a class Book with a string field Title, a string field Author, and a double field Price. Define a
//copy constructor that creates a new instance of the Book class by copying the values from another
//Book object. Write a program that creates a Book object using the parameterized constructor, then
//creates a second Book object using the copy constructor, and displays the details of both books.
using System;
class Book
{
    public string Title;
    public string Author;
    public double Price;
    // Parameterized constructor
    public Book(string title, string author, double price)
    {
        Title = title;
        Author = author;
        Price = price;
    }
    // Copy constructor
    public Book(Book other)
    {
        Title = other.Title;
        Author = other.Author;
        Price = other.Price;
    }
    public void Display(string label)
    {
        Console.WriteLine(label + ":");
        Console.WriteLine("Title: " + Title);
        Console.WriteLine("Author: " + Author);
        Console.WriteLine("Price: $" + Price);
    }
}
class Program
{
    static void Main()
    {
        Book original = new Book("The Pragmatic Programmer", "David Thomas", 39.99);
        Book copy = new Book(original);
        original.Display("Original Book");
        Console.WriteLine();
        copy.Display("Copied Book");
    }
}


