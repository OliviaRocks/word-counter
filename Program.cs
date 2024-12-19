using System;

namespace WordCounter
{
    internal class TextStatistics
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your text: ");
            string inputText = Console.ReadLine();

            int characterCount = inputText.Length;

            string[] words = inputText.Split(new char[] { ' ', '\t', '\n', '\r' },
        StringSplitOptions.RemoveEmptyEntries);
            int wordCount = words.Length;

            Console.WriteLine();
            Console.WriteLine($"Number of characters: {characterCount}");
            Console.WriteLine($"Number of words: {wordCount}");

        }
    }
}