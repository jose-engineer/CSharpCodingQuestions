using System;
using System.Collections.Generic;
using System.Linq;

namespace SquareSum {
    //Implement a method squareSum(double num1, double num2, double num3) in a class SquareSum which takes three numbers, square them and returns their sum.
    class Program {
        static void Main(string[] args) {
            
            //IEnumerable<int> list = Enumerable.Range(1, 9);            

            Console.WriteLine(squareSum(2, 3, 4)); //Expected: 29

            Console.ReadLine();
        }

        public static double squareSum(double num1, double num2, double num3) {

            List<double> lst = new List<double>() { num1, num2, num3 };

            return lst.Select(x => x * x).Sum();
        }
    }
}
