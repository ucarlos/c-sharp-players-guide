using System;
using System.Collections.Generic;

namespace Chapter26 {
    public class Program {
        public static void Main() {
            PracticeList<int> vec = new PracticeList<int>();
            for (int i = 1; i <= 10; i++) {
                vec.push_back(i);
            }

            Console.WriteLine($"Displaying output (Current size: {vec.size})");
            for (int i = 0; i < vec.size; i++)
                Console.Write($"{vec.at(i)} ");
            Console.WriteLine();

        }
    }
}