using System;

namespace ReverseOrderOfWords
{
    class Program
    {
        static void Main(string[] args)
        {
            // input: Welcome to Csharp corner, 
            Console.WriteLine(ReverseOrderOfWords("Welcome to Csharp corner")); //output: corner Csharp to Welcome
        }

        public static string ReverseOrderOfWords(string input)
        {
            string result = string.Empty;
            string[] words = input.Split(' ');

            for (int i = words.Length - 1; i >= 0; i--)
            {
                result += words[i] + ' ';
            }

            return result;
        }
    }
}
