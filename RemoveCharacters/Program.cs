using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PresentButNotPresent 
    {
    class Program
    {
        //Write a program which take two strings as input from the user (str1 and str2). This program should print two strings as output (op1 and op2)
        //op1 should contain all the characters which are present in str1 but NOT present in str2
        //op2 should contain all the characters which are present in str2 but NOT present in str1
        // str1 = "ABC" and str2 = "BC"         then op1 "A" and op2 = "null"
        // str1 = "BC" and str2 = "BANGALORE"   then op1 "C" and op2 = "ANGALORE"
        static void Main(string[] args)
        {
            string str1 = "BC";
            string str2 = "BANGALORE";
            //string str1 = "ABC";
            //string str2 = "BC";
            List<string> result = GetNewStrings(str1, str2);

            foreach (var item in result)
            {
                Console.WriteLine(item == null ? "null" : item);
            }            
        }

        public static List<string> GetNewStrings(string str1, string str2)
        {
            List<string> result = new List<string>();            
            string op1 = null;
            string op2 = null;

            for (int i = 0; i < str2.Length; i++)
            {
                if (!str1.Contains(str2[i]))
                {
                    op2 += str2[i];
                }                
            }

            for (int i = 0; i < str1.Length; i++)
            {
                if (!str2.Contains(str1[i]))
                {
                    op1 += str1[i];
                }                
            }

            result.Add(op1);
            result.Add(op2);

            return result;
        }

        public static List<string> GetNewStringsLinq(string str1, string str2)
        {
            List<string> result = new List<string>();            
            var op1 = String.Join("", str1.ToCharArray().Where(x => !str2.Contains(x)));
            var op2 = String.Join("", str2.ToCharArray().Where(x => !str1.Contains(x)));

            result.Add(op1);
            result.Add(op2);

            return result;
        }

        //public static List<string> GetNewStrings_StringBuilder(string str1, string str2)
        //{
        //    List<string> result = new List<string>();
        //    StringBuilder op1 = new StringBuilder();
        //    StringBuilder op2 = new StringBuilder();

        //    for (int i = 0; i < str2.Length; i++)
        //    {
        //        if (!str1.Contains(str2[i]))
        //        {
        //            op2.Append(str2[i]);
        //        }
        //    }

        //    for (int i = 0; i < str1.Length; i++)
        //    {
        //        if (!str2.Contains(str1[i]))
        //        {
        //            op1.Append(str1[i]);
        //        }
        //    }

        //    result.Add(op1.ToString());
        //    result.Add(op2.ToString());

        //    return result;
        //}
    }
}
