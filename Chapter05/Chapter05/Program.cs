// --------------------------------------------------------------------------------
// Created by Ulysses Carlos on 2/6/2021 at 5:30 PM
//
// Program.cs
// --------------------------------------------------------------------------------
using System;

namespace Chapter05 {
    class MainClass {

        public static void nothing() {
            int val = 12;
            val *= 12;
            val /= 12;


        }

        public static void Main (string [] args) {
            int value = 0;
            Console.WriteLine("Value: " + value);
            nothing();
        }
    }
}
