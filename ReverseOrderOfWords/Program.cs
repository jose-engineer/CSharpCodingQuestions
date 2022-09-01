using System;

namespace ReverseOrderOfWords
{
    class Program
    {
        static void Main(string[] args)
        {
            // input: Welcome to Csharp corner, output: corner Csharp to Welcome
            Console.WriteLine(ReverseOrderOfWords("Welcome to Csharp corner"));
        }

        public static string ReverseOrderOfWords(string input)
        {
            string result = string.Empty;
            string[] stringArray = input.Split(' ');

            for (int i = stringArray.Length - 1; i >= 0; i--)
            {
                result += stringArray[i] + ' ';
            }

            return result;
        }
    }
}
