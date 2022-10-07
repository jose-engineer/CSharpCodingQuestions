using System;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[] { 1, 2, 4, 5, 6, 7, 8, 9, 11 };
            int number = 6;            

            Console.WriteLine(BinarySearch(A, number, 0, A.Length - 1)); //Expected: true
        }

        public static bool BinarySearch(int[] array, int input, int left, int right)
        {
            if (left > right)
                return false;

            int mid = (left + right) / 2;
            //int mid = left + (right - left) / 2; //avoid overflow

            if (input == array[mid])
            {
                return true;
            }
            else if (input < array[mid])
            {
                return BinarySearch(array, input, left, mid - 1);
            }
            else
            {
                return BinarySearch(array, input, mid + 1, right);
            }
        }

        //public static bool BinarySearch(int[] array, int input, int left, int right)
        //{            
        //    while (left <= right)
        //    {
        //        int mid = (left + right) / 2;

        //        if (input == array[mid])
        //        {
        //            return true;
        //        }
        //        else if (input < array[mid])
        //        {
        //            right = mid - 1;
        //        }
        //        else
        //        {
        //            left = mid + 1;
        //        }
        //    }
        //    return false;         
        //}
    }
}
