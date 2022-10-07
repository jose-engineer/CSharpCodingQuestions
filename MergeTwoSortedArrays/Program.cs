using System;
using System.Collections.Generic;
using System.Linq;

namespace MergeTwoSortedArrays {
    //Given 2 sorted arrays, merge them.
    //Follow up: ensure only 1 of each element is saved in the merged array, aka no duplicates.
    class Program {
        static void Main(string[] args) {
            Array.ForEach(Merge(new int[] { 1, 2, 3 }, new int[] { 2, 5, 6 }), Console.WriteLine); //Expected: [1,2,2,3,5,6]
            Console.WriteLine();
            Array.ForEach(Merge(new int[] { 10, 11, 12 }, new int[] { 1, 2, 3 }), Console.WriteLine); //Expected: [1,2,3,10,11,12]
            Console.WriteLine();
            Array.ForEach(Merge(new int[] { 0, 2 }, new int[] { 1 }), Console.WriteLine); //Expected: [0,1,2]
            Console.WriteLine();
            Array.ForEach(Merge(new int[] { 4, 5, 6 }, new int[] { 1, 2, 3 }), Console.WriteLine); //Expected: [1,2,3,4,5,6]
        }

        public static int[] Merge(int[] nums1, int[] nums2) {
            int[] result = new int[nums1.Length + nums2.Length];
            int p1 = 0, p2 = 0, i = 0, current = 0;

            while (p1 < nums1.Length && p2 < nums2.Length) {

                if (nums1[p1] < nums2[p2]) {
                    current = nums1[p1];
                    p1++;          
                } else {
                    current = nums2[p2];
                    p2++;                
                }

                if (i == 0 || result[i - 1] != current) {
                    result[i] = current;
                    i++;
                }

            }

            while (p1 < nums1.Length) {
                current = nums1[p1];
                p1++;                

                if (i == 0 || result[i - 1] != current) {
                    result[i] = current;
                    i++;
                }
            }

            while (p2 < nums2.Length) {
                current = nums2[p2];
                p2++;               

                if (i == 0 || result[i - 1] != current) {
                    result[i] = current;
                    i++;
                }
            }
            
            int[] noDup = new int[i];
            for (int j = 0; j < noDup.Length; j++) { //Array.Resize(ref result, i);
                noDup[j] = result[j];
            }

            return noDup; //return result;           
        }

        public static int[] Merge2(int[] nums1, int[] nums2) {

            List<int> lst1 = new List<int>(nums1);
            List<int> lst2 = new List<int>(nums2);

            lst1.AddRange(lst2);
            lst1.Sort();

            return lst1.Distinct().ToArray();
        }

        public static int[] Merge3(int[] nums1, int[] nums2) { //Merge without removing duplicates
            int[] result = new int[nums1.Length + nums2.Length];
            int p1 = 0, p2 = 0, i = 0;

            while(p1 < nums1.Length && p2 < nums2.Length) { //result = [1,2,2,3]
                if (nums1[p1] < nums2[p2]) {
                    result[i] = nums1[p1];
                    p1++;
                } else {
                    result[i] = nums2[p2];
                    p2++;
                }

                i++;
            }

            while (p1 < nums1.Length) { 
                result[i] = nums1[p1];
                p1++;

                i++;
            }

            while (p2 < nums2.Length) { //result = [1,2,2,3,5,6]
                result[i] = nums2[p2];
                p2++;

                i++;
            }

            return result;
        }

    }
}
