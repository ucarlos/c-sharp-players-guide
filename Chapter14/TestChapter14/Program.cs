/*
 * -----------------------------------------------------------------------------
 * Created by Ulysses Carlos on 03/08/2021 at 12:43 AM
 * 
 * Program.cs
 * A Simple test of enums in C#.
 * -----------------------------------------------------------------------------
 */

using System;

namespace Chapter14 {
    class Program {

        public enum Weekday {
            Sunday = 0,
            Monday = 1,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        };

        public static void Main(string[] args) {
            Weekday weekday = Weekday.Friday;
            Console.WriteLine("Enum Value: " + weekday);
        }
    }
}
