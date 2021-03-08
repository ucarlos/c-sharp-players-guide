/*
 * -----------------------------------------------------------------------------
 * Created by Ulysses Carlos on 03/08/2021 at 03:19 PM
 * 
 * Chapter15_Try02.cs
 * Your mission, should you choose to accept it, is to create a method called
 * Fibonacci, which takes in a number and returns that number of the Fibonacci
 * sequence. So if someone calls Fibonacci(3), it would return the 3rd number
 * in the Fibonacci sequence, which is 2. If someone calls Fibonacci(8), it
 * would return 21.
 * -----------------------------------------------------------------------------
 */
using System;
namespace Chapter15_Try02 {
    public class Program {

        public static ulong fibonacci(uint val) {
            if (val == 0) return 0;
            else if (val == 1) return 1;
            else return fibonacci(val - 1) + fibonacci(val - 2);
            
        }
        
        public static void Main(string[] args) {
            Console.WriteLine("Please enter the desired Fibonacci Number: ");
            uint val = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine($"Result : {fibonacci(val)}");
        }
    }
}