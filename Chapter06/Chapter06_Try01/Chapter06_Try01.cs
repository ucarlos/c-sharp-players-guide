// --------------------------------------------------------------------------------
// Created by Ulysses Carlos on 02/13/2021 at 12:10 AM
// 
// Chapter06_Try01.cs
// --------------------------------------------------------------------------------

using System;

namespace Chapter06_Try01
{
    class Chapter06_Try01 {
        public static void Main(string[] args) {
            char ch = 'H' ;
            byte byt = 255;

            short s = (1 << 15) - 1;
            ushort us = 65535;
            int i = -1 * (1 << 30);
            uint ui = 1 << 30;
            long l = -1 * (1 << 60);
            ulong ul = 1 << 60;

            //float fl = 0x7F_FF_FF_FF;
            int va = 0x7f800000;
            float fl = (float)va;
            double dou = 2021.0212;

            decimal decm = 1E20M;
            string str = "Hello World!";

            Console.WriteLine("Hello World!");

            Console.WriteLine("ch: " + ch);
            Console.WriteLine("byte: " + byt);
            Console.WriteLine("short: " + s);
            Console.WriteLine("Unsigned Short: " + us);
            Console.WriteLine("Long: " + l);
            Console.WriteLine("Unsigned Long: " + ul);
            Console.WriteLine("Float: " + fl);
            Console.WriteLine("Double: " + dou);
            Console.WriteLine("Decimal: " + decm);
            Console.WriteLine("String: " + str);

        }
    }
}