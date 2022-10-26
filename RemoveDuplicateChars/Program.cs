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

        public static string RemoveDuplicates(string input) {
            string result = string.Empty;            

            for (int i = 0; i < input.Length; i++) {
                if (!result.Contains(input[i])) { // string has a Contains function, very handy in this case
                    result += input[i];
                }
            }

            return result;
        }        

        public static string RemoveDuplicates2(string input) {
            char[] charArray = input.ToCharArray().Distinct().ToArray();
            return new string(charArray);
        }

        public static string RemoveDuplicates3(string input) {
            string result = string.Empty;

            char[] charArray = input.ToCharArray();

            for (int i = 0; i < charArray.Length; i++) {
                if (!result.Contains(charArray[i])) {
                    result += charArray[i];
                }
            }

            return result;
        }
    }
}
