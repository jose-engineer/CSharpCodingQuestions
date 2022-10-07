using System;

namespace IsAnagram {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine(IsAnagram("xy", "yx")); //Expected: true
            Console.WriteLine(IsAnagram("abc", "acb")); 
            Console.WriteLine(IsAnagram("a", "a"));
            Console.WriteLine(IsAnagram("ccc", "ccc"));
            Console.WriteLine(IsAnagram("cbda", "acbd"));
            Console.WriteLine();
            Console.WriteLine(IsAnagram("abc", "cde")); //Expected: false
            Console.WriteLine(IsAnagram("aaa", "bbb"));
            Console.WriteLine(IsAnagram("a", "b"));
            Console.WriteLine(IsAnagram("ab", "c"));
            Console.WriteLine(IsAnagram("mn", "op"));            
            Console.WriteLine(IsAnagram("xaxb", "bbxx"));                        
        }

        public static bool IsAnagram(string s1, string s2) {
            char[] arr1 = s1.ToCharArray();
            char[] arr2 = s2.ToCharArray();
            Array.Sort(arr1);
            Array.Sort(arr2);

            return new string(arr1) == new string(arr2);
        }

        public static bool IsAnagram2(string str1, string str2) {

            foreach (var item in str2) {
                int index = str1.IndexOf(item);
                if (index >= 0) {
                    str1 = str1.Remove(index, 1);
                }
            }

            return str1.Length == 0;
        }

    }
}
