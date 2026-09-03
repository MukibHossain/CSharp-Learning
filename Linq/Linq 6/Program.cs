//Write a C# LINQ query to find and display all the scores greater than 80 from the following array:
//int[] scores = { 97, 92, 81, 60 };
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Specify the data source
        int[] scores = { 97, 92, 81, 60 };

        // Define the LINQ query
        var scoreQuery =
            from i in scores
            where i > 80
            select i;

        // Execute the query
        Console.WriteLine("Scores greater than 80:");

        foreach (var i in scoreQuery)
        {
            Console.Write(i + " ");
        }

        Console.ReadLine();
    }
}