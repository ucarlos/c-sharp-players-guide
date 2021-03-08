// --------------------------------------------------------------------------------
// Created by Ulysses Carlos on 03/07/2021 at 11:56 PM
// 
// Program.cs
// I'm just implementing a minimum val and average val functions.
// --------------------------------------------------------------------------------

using System;
using System.Linq;

namespace Chapter13_Try03 {
    public class Program {

        public static int minimum_val(int[] vector1) {
            int min = vector1[0];
            foreach (var i in vector1)
                min = (i < min) ? i : min;
            

            return min;
        }

        public static double average_val(int[] vector1) {
            double total = 0;
            
            foreach (var i in vector1)
                total += i;

            return total / vector1.Length;
        }
        
        public static void Main(string[] args) {
            Console.WriteLine("Please enter ten values:");
            int[] vec = new int[10];
            for (int i = 0; i < 10; i++) {
                vec[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine($"Average Sum: {average_val(vec)}\nMinimum value: {minimum_val(vec)}");
        }
    }
}