// --------------------------------------------------------------------------------
// Created by Ulysses Carlos on 03/07/2021 at 9:33 PM
// 
// Try01.cs
// Copying an Array. Write code to create a copy of an array. First, start by
// creating an initial array. (You can use whatever type of data you want.)
// Let’s start with 10 items. Declare an array variable and assign it a new array
// with 10 items in it. Use the things we’ve discussed to put some values
// in the array.
//
// Now create a second array variable. Give it a new array with the same length
// as the first. Instead of using a number for this length, use the Length
// property to get the size of the original array. Use a loop to read values
// from the original array and place them in the new array. Also print out
// the contents of both arrays, to be sure everything copied correctly.
// --------------------------------------------------------------------------------

using System;

namespace Chapter12_Try01 {
    public class Try01 {
        private const int max_length = 10;
        public static void Main(string[] args) {
            int[] vec1 = new int[max_length];
            Console.WriteLine("Please input ten values: ");

            for (int i = 0; i < max_length; i++) {
                vec1[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            int[] vec2 = new int[vec1.Length];
            // Copy to another array:
            for (int i = 0; i < vec1.Length; i++)
                vec2[i] = vec1[i];
            
            // Now compare both arrays:
            for (int i = 0; i < vec1.Length; i++) {
                Console.WriteLine($"Vector1: {vec1[i]}\tVector2: {vec2[i]}");
                //Console.WriteLine("Vector1 : {0}\tVector2: {1}", vec1[i], vec2[i]);
            }
            
        }
        
    }
}