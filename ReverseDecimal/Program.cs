using System;

namespace ReverseDecimal {
    //You are given an implementation of a function solution that, given a positive integer N, prints to standard output another integer, which was
    //formed by reversing a decimal representation of N. The leading zeros of the resulting intger should not be printed by the function.

    //Examples:
    //1. Given N = 54321, the function should print 12345.
    //2. Given N = 10011, the function should print 11001.
    //3. Given N = 1, the function should print 1.

    //The attached code is still incorrect for some inputs. Despite the error(s), the code may produce a correct answer for the example test cases.
    //The goal of the exercise is to find and fix the bug(s) in the implementation. You can modify at most three lines.

    //Assume that:
    //N is an integer within the range [1.. 1,000,000,000]

    class Program {
        static void Main(string[] args) {
            Fixed_solution(12345); //Expected: 54321
            Console.WriteLine();
            Fixed_solution(54321); //Expected: 12345
            Console.WriteLine();
            Fixed_solution(10011); //Expected: 11001
            Console.WriteLine();
            Fixed_solution(1); //Expected: 1
            Console.WriteLine();
            Fixed_solution(110); //Expected: 11
            Console.WriteLine();
            Fixed_solution(123); //Expected: 321
            Console.WriteLine();
            Fixed_solution(120); //Expected: 21
        }

        public static void solution(int N) {
            int enable_print = N % 10;

            while (N > 0) {
                if (enable_print == 0 && N % 10 != 0) { //Fix: (enable_print == 0) {
                    enable_print = 1;
                } else if(enable_print == 1) { //Fix:  else if(enable_print > 0) {
                    Console.WriteLine(N % 10);
                }
                N = N / 10;
            }

        }

        public static void Fixed_solution(int N) { //321
            int enable_print = N % 10; //enable_print = 1

            while (N > 0) {
                if (enable_print == 0) { //if(remainder is 0)
                    enable_print = 1;   //enable_print = 1 only when there is one number on N (remainder will be 0) so you can print that number
                } else if (enable_print > 0) { //otherwise keep printing with enable_print = remainder, reamider will be greather than 0.
                    Console.WriteLine(N % 10); //print: 1
                }
                N = N / 10; // N = 32
            }

        }
    }
}
