using System;

namespace QuickSort2
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] A = new int[] { 3, 2, 6, 4, 3, 5, 1 };
            //int[] A = new int[] { 4, 1, 2, -1, 24, 100, -2 };
            int[] A = new int[] { 9, 2, 6, 4, 3, 5, 1 };

            QuickSort(A, 0, A.Length -1);

            foreach (var item in A)
            {
                Console.WriteLine(item);
            }                        
        }

        public static void QuickSort(int[] array, int left, int right)
        {
            if (left >= right) // exit out of recursion
                return;

            int pivot = array[(left + right) / 2]; //pick the array value in the middle
            //int pivot = array[left];
            int index = Partition(array, left, right, pivot); //return the partition points, return the dividing point between the left and the right index
            QuickSort(array, left, index - 1); //sort the left side of the index (0 to index)
            QuickSort(array, index, right); //sort the right side of the index (index to 6)
        }

        public static int Partition(int[] array, int left, int right, int pivot)
        {
            while (left <= right)
            {
                //look for an element in the left side out of order (bigger than the pivot)
                while (array[left] < pivot) // while left value is smaller than pivot we will be ok and increment left index until we find a value to be swaped, if left value greater than pivot go to Swap it
                {
                    left++;
                }

                //look for an element in the right side out of order (smaller than the pivot)
                while (array[right] > pivot) // while right value is greater decrement right index until we find a value to be swaped, if right value is smaller than pivot go to Swap it
                {
                    right--;
                }

                if (left <= right)
                {
                    Swap(array, left, right);
                    left++;
                    right--;
                }
            }
            return left; // return the partition point (dividing poitn between the left and the right)
        }

        public static void Swap(int[] array, int left, int right)
        {
            int temp = array[left];
            array[left] = array[right];
            array[right] = temp;
        }
    }
}
