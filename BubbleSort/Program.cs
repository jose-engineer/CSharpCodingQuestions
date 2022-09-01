using System;
using System.Collections;
using System.Collections.Generic;

namespace BubbleSort
{
    class Program
    {
        //Complexity O(n^2): Bubble sort, Selection sort and Insertion sort
        static void Main(string[] args)
        {
            int[] A = { 8, 2, 4, 1, 3 };
            //int[] A = { 8, 2, 4, 1, 3, 2 };
            //int[] A = { 8 };
            //int[] A = { };

            int[] output = BubbleSort(A);

            foreach (var item in output)
            {
                Console.WriteLine(item);
            }       
            
        }

        public static int[] BubbleSort(int[] input)
        {            
            for(int i=0; i < input.Length; i++) {
                for (int j = i+1; j < input.Length; j++)
                {                    
                    if (input[i] > input[j])
                    {
                        var temp = input[j];
                        input[j] = input[i];
                        input[i] = temp;
                    }
                }
            }
            return input;
        }
    }
}
