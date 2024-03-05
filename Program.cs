using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите слова (для завершения введите пустую строку):");

        List<string> words = new List<string>();

        string input;
        while (!string.IsNullOrWhiteSpace(input = Console.ReadLine()))
        {
            words.Add(input);
        }

        Console.WriteLine("\nВведенные слова:");
        foreach (var word in words)
        {
            Console.WriteLine(word);
        }

        Console.WriteLine("\nПервые буквы слов:");
        var firstLetters = words.Select(word => word.FirstOrDefault());
        foreach (var letter in firstLetters)
        {
            Console.Write(letter + " ");
        }

        Console.WriteLine("\n\nПеревернутые первые буквы слов:");
        var reversedFirstLetters = firstLetters.Reverse();
        foreach (var letter in reversedFirstLetters)
        {
            Console.Write(letter + " ");
        }
    }
}



