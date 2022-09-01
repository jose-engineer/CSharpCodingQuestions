using System;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            // input: hello, output: olleh
            Console.WriteLine(ReverseString2("hello"));
        }

        public static string ReverseString(string input)
        {
            string result = string.Empty;            

            for(int i=input.Length -1; i >=0; i--)
            {
                result += input[i];
            }

            return result;
        }

        public static string ReverseString2(string input) {
            if (string.IsNullOrEmpty(input)) {
                return input;
            }            

            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);            

            return new string(charArray);
        }
    }
}
