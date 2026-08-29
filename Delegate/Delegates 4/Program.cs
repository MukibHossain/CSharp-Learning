
//4.Imagine you're developing a for a local library. In this system, you need to model various
//entities such as Library, Book, and Author.
//• Each book has the following properties: Title, ISBN, Genre, and Price.

//• Each author has the properties: Name, Bio, and DateOfBirth.
//• The library has a collection of books. Each book is part of the library's collection.
//• The library also needs to have a method to display all the books along with their authors.
//• Additionally, the library should have a method to calculate the total cost of all books in its
//collection.
//• Create a Library that has multiple Book objects.
//• Each Book can have one or more Author objects associated with it.
//• Implement a method in the Library class to display all books along with their authors.
//• Implement a method in the Library class to calculate the total price of all the books in the
//library.
using System;
using System.Collections.Generic;

class Author
{
    public string Name { get; set; }
}

class Book
{
    public string Title { get; set; }
    public string ISBN { get; set; }
    public string Genre { get; set; }
    public double Price { get; set; }

    public List<Author> Authors { get; set; } = new List<Author>();
}

class Library
{
    public List<Book> Books { get; set; } = new List<Book>();

    public void DisplayBooks()
    {
        foreach (Book b in Books)
        {
            Console.WriteLine(b.Title);

            foreach (Author a in b.Authors)
                Console.WriteLine(a.Name);
        }
    }

    public double TotalPrice()
    {
        double total = 0;

        foreach (Book b in Books)
            total += b.Price;

        return total;
    }
}

class Program
{
    static void Main()
    {
        Author a = new Author();
        a.Name = "J.K. Rowling";

        Book b = new Book();
        b.Title = "Harry Potter";
        b.ISBN = "12345";
        b.Genre = "Fantasy";
        b.Price = 20;

        b.Authors.Add(a);

        Library l = new Library();

        l.Books.Add(b);

        l.DisplayBooks();

        Console.WriteLine("Total Price: " + l.TotalPrice());
    }
}

