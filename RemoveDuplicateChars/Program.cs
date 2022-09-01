using System;
using System.Linq;

namespace RemoveDuplicateChars
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RemoveDuplicates("abacdeceb"));
            Console.WriteLine(RemoveDuplicates2("abacdeceb"));
        }

        public static string RemoveDuplicates(string input)
        {
            string result = string.Empty;

            char[] charArray = input.ToCharArray();

            for(int i=0; i<charArray.Length; i++)
            {
                if (!result.Contains(charArray[i]))
                {
                    result += charArray[i];
                }
            }

            return result;
        }

        public static string RemoveDuplicates2(string input) {
            char[] charArray = input.ToCharArray().Distinct().ToArray();
            return new string(charArray);
        }
    }
}
