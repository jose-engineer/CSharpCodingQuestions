using System;
using System.Collections.Generic;

namespace FizzBuzzTokens {
    internal class Program {
        static void Main(string[] args) {
            Dictionary<int, string> divisorTokens = new Dictionary<int, string>();            

            Console.WriteLine("Type the min value: ");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Type the max value: ");
            int max = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many Tokens/Divisors do you want?");
            int numberInputs = Convert.ToInt32(Console.ReadLine());

            while (numberInputs > 0) {
                Console.WriteLine("Type the divisor: ");
                int divisor = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Type the Token: ");
                string token = Console.ReadLine();

                divisorTokens.Add(divisor, token);

                numberInputs--;
            }

            Console.WriteLine();

            List<string> lst = FizzBuzzTokens(min, max, divisorTokens);
            lst.ForEach(Console.WriteLine);            
        }

        public static List<string> FizzBuzzTokens(int min, int max, Dictionary<int, string> pairs) {
            List<string> lst = new List<string>();

            for (int i = min; i <= max; i++) {
                string token = string.Empty;

                foreach (var item in pairs) {
                    if (i % item.Key == 0)
                        token += item.Value;
                }

                if (string.IsNullOrEmpty(token))
                    lst.Add(i.ToString());
                else
                    lst.Add(token);
            }

            return lst;
        }

        public static  List<string> FizzBuzzTokens2(int min, int max, Dictionary<int, string> keyValues) {
            List<string> lst = new List<string>();            

            for (int i = min; i <= max; i++) {
                string palabra = "";
                bool esFactor = false;

                foreach (KeyValuePair<int, string> item in keyValues) {
                    if (i % item.Key == 0) {
                        palabra += item.Value;
                        esFactor = true;
                    }
                }

                if (esFactor)
                    lst.Add(palabra);
                else
                    lst.Add(i.ToString());
            }

            return lst;
        }
        
    }
}
