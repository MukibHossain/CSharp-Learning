using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a sentence: ");
        string sentence = Console.ReadLine();
        string[] words = sentence.Split(' ');
        int maxLength = 0;
        foreach (string word in words)
        {
            if (word.Length > maxLength)
                maxLength = word.Length;
        }
        Console.WriteLine("Longest words:");
        foreach (string word in words)
        {
            if (word.Length == maxLength)
                Console.WriteLine(word);
        }
    }

}

