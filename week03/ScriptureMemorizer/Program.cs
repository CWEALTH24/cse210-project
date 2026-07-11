// Creativity:
// This program exceeds the core requirements by loading scriptures from
// an external text file instead of hardcoding them. The scriptures are
// stored in a library (List<Scripture>), and one scripture is selected
// at random each time the program starts.
// The program also displays the user's memorization progress by showing
// how many words have been hidden out of the total number of words.

using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        List<Scripture> scriptures = new List<Scripture>();

        string[] lines = File.ReadAllLines("scriptures.txt");

        foreach (string line in lines)
        {
            string[] parts = line.Split('|');

            string book = parts[0];
            int chapter = int.Parse(parts[1]);
            int startVerse = int.Parse(parts[2]);
            int endVerse = int.Parse(parts[3]);
            string text = parts[4];

            Reference reference;

            if (endVerse == 0)
            {
                reference = new Reference(book, chapter, startVerse);
            }
            else
            {
                reference = new Reference(book, chapter, startVerse, endVerse);
            }

            Scripture loadedScripture = new Scripture(reference, text);
            scriptures.Add(loadedScripture);
        }

        Random random = new Random();
        Scripture scripture = scriptures[random.Next(scriptures.Count)];

        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();

            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();

            Console.WriteLine(
                $"Progress: {scripture.GetHiddenWordCount()} of {scripture.GetTotalWordCount()} words hidden."
            );

            Console.WriteLine();
            Console.Write("Press Enter to continue or type 'quit' to exit: ");

            string input = Console.ReadLine();

            if (input != null && input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords();
        }

        Console.Clear();

        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine();
        Console.WriteLine("All words are now hidden. Program finished.");
    }
}