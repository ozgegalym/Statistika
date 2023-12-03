using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите текст:");
        string text = Console.ReadLine();

        Dictionary<string, int> wordCount = CountWords(text);

        Console.WriteLine("Слово\t\tКоличество");
        Console.WriteLine("-------------------------");

        foreach (var pair in wordCount)
        {
            Console.WriteLine($"{pair.Key}\t\t{pair.Value}");
        }
    }

    static Dictionary<string, int> CountWords(string text)
    {
        string[] words = text.Split(new char[] { ' ', '.', ',', '­', '\n', '\r', '­' }, StringSplitOptions.RemoveEmptyEntries);
        Dictionary<string, int> wordCount = new Dictionary<string, int>();

        foreach (string word in words)
        {
            string cleanedWord = word.ToLower(); // приводим слово к нижнему регистру
            if (wordCount.ContainsKey(cleanedWord))
            {
                wordCount[cleanedWord]++;
            }
            else
            {
                wordCount[cleanedWord] = 1;
            }
        }

        return wordCount;
    }
}
