using System;

namespace ReverseEachWord
{
    class Program
    {
        static void Main(string[] args)
        {
            // input: Welcome to Csharp corner, output: emocleW ot prahsC renroc
            Console.WriteLine(ReverseEachWord("Welcome to Csharp corner"));
        }

        public static string ReverseEachWord(string input)
        {
            string result = string.Empty;
            string[] words = input.Split(' ');
            string current;
            
            for (int i = 0; i < words.Length; i++)
            {
                current = ' ' + words[i];
                for (int j = current.Length - 1; j >= 0; j--)
                {
                    result += current[j];
                }

            }

            return result;
        }
    }
}
