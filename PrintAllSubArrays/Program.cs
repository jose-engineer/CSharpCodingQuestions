using System;

namespace PrintAllSubArrays {
    //Print all subarrays of the given array
    class Program {
        static void Main(string[] args) {
            printAllSubArrays(new int[] { 1, 2, 3, 4, 5 });
            //printSubArrays(new int[] { 1, 2, 3, 4, 5 });            
        }

        public static void printAllSubArrays(int[] arr) {

            for (int i = 0; i < arr.Length; i++) {
                for (int j = 0; j < arr.Length; j++) {
                    printArray(arr, i, j);
                }
            }

        }

        public static void printArray(int[] arr, int start, int end) {            
            for (int i = start; i <= end; i++) {
                Console.Write(arr[i].ToString() + " ");
            }
            Console.WriteLine();
        }


        public static void printSubArrays(int[] arr) {
            for (int i = 0; i < arr.Length; i++) {
                Console.WriteLine();
                for (int j = i; j < arr.Length; j++) {
                    Console.Write(arr[j].ToString() + " ");
                }

            }
        }
    }
}
