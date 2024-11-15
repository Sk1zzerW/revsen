using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("ваше предложение");
        string input = Console.ReadLine();

        string[] words = input.Split(' ');

        string result = "";

        for (int i = 0; i < words.Length; i++)
        {
            string reversedWord = "";
            for (int j = words[i].Length - 1; j >= 0; j--)
            {
                reversedWord += words[i][j];
            }
            result += reversedWord + " ";
        }

        Console.WriteLine("результат -  " + result.Trim());

        Console.ReadKey();
    }
}
