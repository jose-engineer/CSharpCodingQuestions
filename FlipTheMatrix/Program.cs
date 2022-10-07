using System;

namespace FlipTheMatrix {
//    Given a 2D array with values of 1 or 0, do the following actions:
//Flip the matrix horizontally
//Replace 1 with 0 and replace 0 with 1
    class Program {
        static void Main(string[] args) {

            int[][] matrix = new int[][] {  new int[] { 1,1,0,0 }, 
                                            new int[] { 0,1,0,0 }, 
                                            new int[] { 0,0,1,1 } };

            Console.WriteLine("Before: ");
            displayMatrix(matrix);

            Console.WriteLine();            

            Console.WriteLine("After: ");
            displayMatrix(flipMatrix(matrix));
        }

        public static int[][] flipMatrix(int[][] matrix) {
            //Flip each row
            foreach (var row in matrix) {
                int left = 0;
                int right = row.Length - 1;

                while (left < right) {
                    int temp = row[left];
                    row[left] = row[right];
                    row[right] = temp;

                    //Invert values
                    row[left] = row[left] == 1 ? 0 : 1;
                    row[right] = row[right] == 1 ? 0 : 1;

                    left++;
                    right--;
                 }                
            }

            return matrix;
        }

        public static int[][] flipMatrix2(int[][] matrix) {
            
            foreach (var row in matrix) {
                int start = 0;
                int end = row.Length - 1;

                while (start < end) {
                    int temp = row[start];
                    row[start] = row[end];
                    row[end] = temp;

                    start++;
                    end--;
                }                

                //for (int i = 0; i < row.Length / 2; i++) {
                //    int temp = row[start];
                //    row[start] = row[end];
                //    row[end] = temp;
                //    start++;
                //    end--;
                //}
            }

            foreach (var row in matrix) {
                for (int i = 0; i < row.Length; i++) {
                    row[i] = row[i] == 1 ? 0 : 1;
                }
            }

            return matrix;
        }

        public static void displayMatrix(int[][] matrix) {
            foreach (var row in matrix) { // item = row
                foreach (var item in row) {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
