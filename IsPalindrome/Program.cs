using System;

namespace IsPalindrome
{
    class Program
    {
        static void Main(string[] args)
        {                        
            Console.WriteLine(IsPalindrome("step on no pets")); //Exprected: true
            Console.WriteLine(IsPalindrome("level")); //Exprected: true
            Console.WriteLine(IsPalindrome("aaa")); //Exprected: true            
            Console.WriteLine();
            Console.WriteLine(IsPalindrome("lyevel")); //Exprected: false
            Console.WriteLine(IsPalindrome("leveyl")); //Exprected: false
            Console.WriteLine(IsPalindrome("bcbc")); //Exprected: false
            Console.WriteLine(IsPalindrome("aaab")); //Exprected: false
            Console.WriteLine(IsPalindrome("baa")); //Exprected: false            
        }        

        public static bool IsPalindrome(string input) {
            int left = 0;
            int right = input.Length - 1;

            while (left < right) {
                if (input[left] != input[right]) {
                    return false;
                }

                left++;
                right--;
            }

            return true;
        }

        public static bool IsPalindrome2(string input) {
            for (int i = 0, j = input.Length - 1; i < input.Length / 2; i++, j--) {
                if (input[i] != input[j]) {
                    return false;
                }
            }
            return true;
        }
    }
}
