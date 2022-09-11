using System;

namespace PositionSameLetter {
    //You are given an array S consisting of N strings. Every string is of the same length M. Your task is to find a pair of strings in array S,
    //such that there exists a position in which both of the strings have the same letter. Both the index in array S and the positions in the strings
    //are numbered from zero.

    //For example, given S = ["abc", "bca", "dbe"), string 0 ("abc") and string 2 ("dbe") have the same letter 'b' in position 1. On the other hand,
    //for strings "abc" and "bca" there does not exist a position in which they have the same letter.

    //Write a function:
    //      class Solution { public int[] solution(string[] S); }

    //that, given a zero-indexed array S of N strings, returns an array describing a pair of strings from S which share a common letter at some index.
    //If there is no such pair, the function should return an empty array. If there is more than one correct answer, the function can return any of them.

    //The result should be represented as an array containing three integers. The first two integers are the indexes in S of the strings belonging to
    //the pair. The third integer is the position of the common letter.

    //For S = ["abc", "bca", "dbe"), as above, the result array should be represented as [0, 2, 1). Another correct answer is [2, 0, 1), as the order
    //of indexes of strings does not matter.

    //Examples:
    //1. Given: S=["abc", "bca", "dbe"], your function may return [0,2,1] as described above.

    //2. Given: S=["zzzz", "ferz", "zdsr", "fgtd"], your function may return [0,1,3]. Both "zzzz" and "ferz" have 'z' in position 3. The fucntion may
    //also return [1,3,0], which would reflect strings "ferz", "fgdt" and letter 'f'.

    //3. Given A=["gr", "sd", "rg"], your function should return []. There is no pair of strings that fulfils the criteria.

    //4. Given A=["bdafg", "ceagi"], your function may return [0,1,2].

    class Program {
        static void Main(string[] args) {
            Array.ForEach(solution(new string[] { "abc", "bca", "dbe" }), Console.WriteLine); //Expected:  [0,2,1]
            Console.WriteLine();
            Array.ForEach(solution(new string[] { "zzzz", "ferz", "zdsr", "fgtd" }), Console.WriteLine); //Expected:  [0,1,3]
            Console.WriteLine();
            Array.ForEach(solution(new string[] { "gr", "sd", "rg" }), Console.WriteLine); //Expected:  []
            Console.WriteLine();
            Array.ForEach(solution(new string[] { "bdafg", "ceagi" }), Console.WriteLine); //Expected:  [0,1,2]
        }

        public static int[] solution(string[] S) {
            int[] result = new int[3];
            bool isFound = false;

            for (int i = 0; i < S.Length; i++) {
                string currentString = S[i];

                for (int j = i + 1; j < S.Length; j++) {
                    string chkString = S[j];

                    for (int p = 0; p < currentString.Length; p++) {

                        if (currentString[p] == chkString[p]) {                            
                            result[0] = i;
                            result[1] = j;
                            result[2] = p;
                            isFound = true;
                            break;
                        }

                    }
                    if (isFound) break;
                }
                if (isFound) break;
                return new int[0];
            }

            return result;
        }
    }
}
