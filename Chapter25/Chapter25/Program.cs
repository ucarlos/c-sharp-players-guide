using System;
using System.Collections.Generic;
using System.Linq;

namespace Chapter25 {
    public class Program {
        public static void Main(string[] args) {
            List<int> vec = new List<int>();
            for (int i = 0; i < 10; i++) {
                vec.Add((1 << (i + 1)));
                
            }

            int val = vec.ElementAt(0);
            // This should cause an out of bounds exception:
            //int val2 = vec[100];
            Console.WriteLine("Displaying all values in vector:");
            foreach (int item in vec)
                Console.Write($"{item} ");
            Console.WriteLine();
        }
    }
}