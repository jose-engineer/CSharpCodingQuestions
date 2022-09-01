using System;
using System.Text;

namespace CompressRunLength {
    //Example 1:
    //Input: string = "aaaabbccc"
    //Output: "4a2b3c"

    //Example 2:
    //Input: string = "aaaabbccca"
    //Output: "4a2b3c1a"

    class Program {
        static void Main(string[] args) {
            Console.WriteLine(Encode("aaaabbccc")); //Expected: "4a2b3c"
            Console.WriteLine(Encode("aaaabbccca")); //Expected: "4a2b3c1a"
        }

        public static string Encode(string input) {
            if (string.IsNullOrEmpty(input)) {
                return string.Empty;
            }

            StringBuilder sb = new StringBuilder();
            char previous = ' ', current = ' ';
            int count = 1;

            for (int i = 1; i < input.Length; i++) {

                previous = input[i - 1];
                current = input[i];

                if (previous == current) {
                    count++;
                } else {
                    sb.Append(count).Append(previous);
                    count = 1;
                }

            }

            return sb.Append(count).Append(current).ToString();
        }

        public static string Encode2(string input) {
            if (string.IsNullOrEmpty(input)) {
                return "";
            }

            StringBuilder sb = new StringBuilder();
            int count = 0;
            char prevChar = ' ';

            foreach (var item in input) {
                if (item == prevChar) {
                    count++;
                } else {
                    if (prevChar != ' ') {
                        sb.Append(count).Append(prevChar);
                    }

                    prevChar = item;
                    count = 1;                    
                }
            }

            sb.Append(count).Append(prevChar);

            return sb.ToString();
        }        

    }
}
