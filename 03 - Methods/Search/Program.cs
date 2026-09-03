//Question 4: Write a C# program that:
//• Creates a string array to store the names of 5 students.
//• Accepts the names as input.
//• Searches for a name entered by the user (linear search).
//• Displays whether the name was found and at which index.

using System;
class Search
{
    static void Main()
    {
        string[] name = new string[5];
        string search;
        bool found = false;

        Console.WriteLine("Enter 5 student names:");

        for (int i = 0; i < 5; i++)
        {
            name[i] = Console.ReadLine();
        }

        Console.Write("Enter name to search: ");
        search = Console.ReadLine();

        for (int i = 0; i < 5; i++)
        {
            if (name[i] == search)
            {
                Console.WriteLine("Found at index " + i);
                found = true;
                break;
            }
        }

        if (found == false)
        {
            Console.WriteLine("Name not found");
        }
    }
}