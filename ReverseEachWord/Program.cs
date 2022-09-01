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
            string[] strArray = input.Split(' ');
            string currentWord;
            
            for (int i = 0; i < strArray.Length; i++)
            {
                currentWord = ' ' + strArray[i];
                for (int j = currentWord.Length - 1; j >= 0; j--)
                {
                    result += currentWord[j];
                }

            }

            return result;
        }
    }
}
