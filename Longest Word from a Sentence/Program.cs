using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a sentence: ");
        string sentence = Console.ReadLine();

        string[] words = sentence.Split(' ');

        string longest = "";

        foreach (string word in words)
        {
            if (word.Length > longest.Length)
                longest = word;
        }

        Console.WriteLine(longest);
    }
}