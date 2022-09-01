using System;
using System.Collections.Generic;

namespace FibonacciNumbers {
    //Write the code to generate the first 20 numers in the sequence. (As a hint, the 20th Fibonacci number is 6765.)
    class Program {
        static void Main(string[] args) {
            generateFibonacci(20);
        }

        public static void generateFibonacci(int n) {
            int[] arr = new int[n];

            arr[0] = 1;
            arr[1] = 1;

            for (int i = 2; i < n; i++) {
                arr[i] = arr[i-1] + arr[i-2];
            }
            
            foreach (var item in arr) {
                Console.WriteLine(item);
            }
        }        

        public static void generateFibonacci2(int n) {
            List<int> lst = new List<int> { 1, 1 };
            //List<int> lst = new List<int> () { 1, 1 };            

            while (lst.Count < 20) {
                int previous = lst[lst.Count - 1];
                int previous2 = lst[lst.Count - 2];

                lst.Add(previous + previous2);
            }

            foreach (var item in lst) {
                Console.WriteLine(item);
            }
        }
        
    }
}
