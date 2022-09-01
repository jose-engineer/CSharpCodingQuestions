using System;
using System.Collections.Generic;

namespace FibonacciNumbers {
    //Write the code to generate the first 20 numers in the sequence. (As a hint, the 20th Fibonacci number is 6765.)
    class Program {
        static void Main(string[] args) {
            generateFibonacci(20);
        }

        public static void generateFibonacci(int n) {
            int[] result = new int[n];

            result[0] = 1;
            result[1] = 1;

            for (int i = 2; i < n; i++) {
                result[i] = result[i-1] + result[i-2];
            }
            
            foreach (var item in result) {
                Console.WriteLine(item);
            }
        }        

        public static void generateFibonacci2(int n) {
            List<int> result = new List<int> { 1, 1 };
            //List<int> lst = new List<int> () { 1, 1 };            

            while (result.Count < n) {
                int previous = result[result.Count - 1];
                int previous2 = result[result.Count - 2];

                result.Add(previous + previous2);
            }

            foreach (var item in result) {
                Console.WriteLine(item);
            }
        }
        
    }
}
