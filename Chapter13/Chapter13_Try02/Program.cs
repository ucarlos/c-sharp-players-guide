// --------------------------------------------------------------------------------
// Created by Ulysses Carlos on 03/07/2021 at 9:58 PM
// 
// Program.cs
// This is just a simple test with multi-dimensional arrays in C#.
// --------------------------------------------------------------------------------

using System;

namespace Chapter13_Try02 {
    public class Program {
        private const int max_column = 12;
        private const int max_rows = 10;
        public static void Main(string[] args) {
            int[,] vec1 = new int[max_rows, max_column];
            for (int i = 0; i < vec1.GetLength(0); i++) {
                for (int j = 0; j < vec1.GetLength(1); j++) {
                    vec1[i, j] = (i + 1) * (j + 1);
                }
            }
            
            // Now list them:
            for (int i = 0; i < vec1.GetLength(0); i++) {
                for (int j = 0; j < vec1.GetLength(1); j++) {
                    string temp = Convert.ToString(vec1[i, j]);
                    Console.Write(temp.PadRight(4));
                }
                Console.WriteLine();
            }
        }
    }
}