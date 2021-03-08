// --------------------------------------------------------------------------------
// Created by Ulysses Carlos on 03/05/2021 at 12:16 AM
// 
// Pyramid.cs
// --------------------------------------------------------------------------------

using System;
namespace Chapter12 {
    class Program {
        public static void Main(string[] args) {
            int rows;
            Console.WriteLine("Please enter the number of lines: ");
            rows = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= rows; i++) {
                int characters = (2 * i) - 1;
                int spaces = rows - i;
                // Each line has a specific number of spaces left and right
                // usually rows - i  
                for (int s = 0; s < spaces; s++)
                    Console.Write(" ");
                for (int j = 0; j < characters; j++)
                    Console.Write("*");
                for (int s = 0; s < spaces; s++)
                    Console.Write(" ");
                Console.WriteLine();
            }
        }
    }
}