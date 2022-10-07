using System;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {            
            Console.WriteLine(ReverseString2("Hello World")); //Expected: dlroW olleH
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
