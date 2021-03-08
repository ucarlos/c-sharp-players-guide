/*
 * -----------------------------------------------------------------------------
 * Created by Ulysses Carlos on 03/08/2021 at 02:54 PM
 * 
 * Chapter15_Try01
 * Reversing an Array. Let’s make a program that uses methods to accomplish a
 * task. Let’s take an array and reverse the contents of it. For example,
 * if you have 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, it would become 10, 9, 8, 7, 6,
 * 5, 4, 3, 2, 1. To accomplish this, you’ll create three methods: one to
 * create the array, one to reverse the array, and one to print the array at
 * the end.
 * -----------------------------------------------------------------------------
 */

using System;

namespace Chapter15_Try01 {
    public class Program {
        public static int[] create_array(int size) {
            int[] array = new int[size];

            for (int i = 0; i < array.Length; i++) {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            return array;
        }

        public static void reverse_array(int[] array) {
            int temp;
            for (int i = 0; i < array.Length / 2; i++) {
                temp = array[i];
                array[i] = array[array.Length - 1 - i];
                array[array.Length - 1 - i] = temp;
            }
        }
        /// <summary>
        /// Print the contents of an array.
        /// </summary>
        /// <param name="array">An Array of type int.</param>
        public static void print_array(int[] array) {
            Console.WriteLine("Array Contents: ");
            foreach (int i in array) {
                Console.Write($"{i} ");
            }

            Console.WriteLine();
        }

        public static void Main(string[] args) {
            Console.WriteLine("What is the size of your array?");
            int size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Now, please enter {size} values:");
            int[] array = create_array(size);
            reverse_array(array);
            print_array(array);
        }
    }
}