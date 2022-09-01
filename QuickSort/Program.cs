using System;

namespace QuickSort
{
    class Program
    {
        ////Complexity O(NLogN): Merge sort, Quick sort, Heap sort
        static void Main(string[] args)
        {
            //int[] A = new int[] { 3, 2, 6, 4, 3, 5, 1 };
            int[] A = new int[] { 4, 1, 2, -1, 24, 100, -2 };

            int[] output = QuickSort(A, 0, A.Length);
            
            foreach (var item in output)
            {
                Console.WriteLine(item);
            }            
        }

        public static int[] QuickSort(int[] input, int left, int right)
        {
            if (left < right)
            {
                int index = Partition(input, left, right);
                QuickSort(input, left, index);
                QuickSort(input, index + 1, right);
            }
            return input;
        }

        public static int Partition(int[] array, int left, int right)
        {            
            int pivot = array[left];
            int swapIndex = left;

            for(int i = left + 1; i < right; i++)
            {
                if (array[i] < pivot)
                {
                    swapIndex++;
                    Swap(array, i, swapIndex);
                }
            }
            Swap(array, left, swapIndex);
            return swapIndex;

        }

        public static void Swap(int[] array, int left, int right)
        {
            var temp = array[left];
            array[left] = array[right];
            array[right] = temp;
        }
    }
}
